// Controllers/HomeController.cs
using MagnaAI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Nodes;
using NewsService;

namespace MagnaAI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<IActionResult> IndexAsync()
        {
            string NewsServiceAddress = _configuration.GetValue<string>("ConnectedServices:NewsService") ?? string.Empty;
            int newsServiceChannel = _configuration.GetValue<int>("ConnectedServices:NewsServiceChannels:Production");

            NewsServiceClient client = new(NewsServiceClient.EndpointConfiguration.BasicHttpBinding_INewsService, NewsServiceAddress);
            await client.OpenAsync();

            var clientGetMsg = client.GetACMessagesAsync(newsServiceChannel, false, "cs");
            var data = await clientGetMsg;
            var clientClose = client.CloseAsync();

            var json = JsonObject.Parse(data);
            JsonArray jArray = json!.AsArray();

            var vm = new AdaptiveCardModel() 
            { 
                Menu = [], 
                UserLogin = new UserInfo(), 
                AdaptiveCardJsonList = [.. jArray.Select(s => s?.ToJsonString() ?? string.Empty)]
            };

            ViewData["Model"] = vm;

            return View();
        }

        public IActionResult Models()
        {
            return View();
        }

        public IActionResult Articles()
        {
            // TODO: Budoucí integrace s SharePoint/Teams pøes Microsoft Graph API
            // var articles = await GetArticlesFromSharePoint();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // TODO: API endpoint pro Adaptive Cards data
        // Toto bude v budoucnu nahrazeno skuteèným voláním na NewsService
        [HttpGet]
        [Route("api/news")]
        public async Task<IActionResult> GetNewsData()
        {
            try
            {
                // Placeholder pro budoucí integraci s NewsService
                // string newsServiceUrl = _configuration.GetValue<string>("ConnectedServices:NewsService");
                // var newsData = await CallNewsService(newsServiceUrl, channelId: 5); // Produkèní kanál

                // Pro testování vrátíme statická data
                var testData = GetTestNewsData();
                return Ok(testData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba pøi naèítání news dat");
                return StatusCode(500, "Chyba pøi naèítání aktualit");
            }
        }

        private object[] GetTestNewsData()
        {
            // Simulace dat z NewsService - structure based on evýdejky system
            return new object[]
            {
                new {
                    Id = 1,
                    Title = "Aktuální informace",
                    Message = "Nová školení AI jsou nyní dostupná pro všechny zamìstnance. Registrace probíhá pøes interní portál.",
                    Date = DateTime.Now.ToString("dd.MM.yyyy"),
                    Category = "Školení",
                    ActionUrl = "https://portal.magna.com/training",
                    Type = "info"
                },
                new {
                    Id = 2,
                    Title = "Systémová údržba",
                    Message = "Plánovaná údržba AI systémù probìhne tento víkend. Oèekávané výpadky: 2-4 hodiny.",
                    Date = "31.05.2025",
                    Time = "02:00 - 06:00",
                    Category = "Systém",
                    Type = "warning"
                }
            };
        }

        // TODO: Budoucí metoda pro integraci s NewsService
        /*
        private async Task<string> CallNewsService(string serviceUrl, int channelId)
        {
            using var client = new HttpClient();
            // Implementace volání na NewsService
            // Napøíklad: GET /NewsService/GetACMessages?channelId=5&includeClosed=false&language=cs
            var response = await client.GetStringAsync($"{serviceUrl}/GetACMessages?channelId={channelId}&includeClosed=false&language=cs");
            return response;
        }
        */

        // TODO: Budoucí metoda pro SharePoint integraci
        /*
        private async Task<List<ArticleModel>> GetArticlesFromSharePoint()
        {
            // Microsoft Graph API integrace
            // 1. Autentifikace pøes Azure AD
            // 2. Pøístup k SharePoint site
            // 3. Naètení dokumentù z urèené knihovny
            // 4. Filtrace podle typu (PDF, Word dokumenty)
            // 5. Vrácení seznamu s metadata
            
            // Pøíklad volání:
            // var graphClient = GetGraphServiceClient();
            // var site = await graphClient.Sites["root"].Request().GetAsync();
            // var drive = await graphClient.Sites[site.Id].Drives["Documents"].Request().GetAsync();
            // var items = await graphClient.Sites[site.Id].Drives[drive.Id].Root.Children.Request().GetAsync();
            
            return new List<ArticleModel>();
        }
        */
    }

    // TODO: Model pro èlánky ze SharePoint
    /*
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DownloadUrl { get; set; }
        public DateTime LastModified { get; set; }
        public string FileSize { get; set; }
        public string FileType { get; set; }
    }
    */
}