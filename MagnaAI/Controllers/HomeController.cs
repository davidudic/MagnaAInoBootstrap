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
            // TODO: Budouc� integrace s SharePoint/Teams p�es Microsoft Graph API
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
        // Toto bude v budoucnu nahrazeno skute�n�m vol�n�m na NewsService
        [HttpGet]
        [Route("api/news")]
        public async Task<IActionResult> GetNewsData()
        {
            try
            {
                // Placeholder pro budouc� integraci s NewsService
                // string newsServiceUrl = _configuration.GetValue<string>("ConnectedServices:NewsService");
                // var newsData = await CallNewsService(newsServiceUrl, channelId: 5); // Produk�n� kan�l

                // Pro testov�n� vr�t�me statick� data
                var testData = GetTestNewsData();
                return Ok(testData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Chyba p�i na��t�n� news dat");
                return StatusCode(500, "Chyba p�i na��t�n� aktualit");
            }
        }

        private object[] GetTestNewsData()
        {
            // Simulace dat z NewsService - structure based on ev�dejky system
            return new object[]
            {
                new {
                    Id = 1,
                    Title = "Aktu�ln� informace",
                    Message = "Nov� �kolen� AI jsou nyn� dostupn� pro v�echny zam�stnance. Registrace prob�h� p�es intern� port�l.",
                    Date = DateTime.Now.ToString("dd.MM.yyyy"),
                    Category = "�kolen�",
                    ActionUrl = "https://portal.magna.com/training",
                    Type = "info"
                },
                new {
                    Id = 2,
                    Title = "Syst�mov� �dr�ba",
                    Message = "Pl�novan� �dr�ba AI syst�m� prob�hne tento v�kend. O�ek�van� v�padky: 2-4 hodiny.",
                    Date = "31.05.2025",
                    Time = "02:00 - 06:00",
                    Category = "Syst�m",
                    Type = "warning"
                }
            };
        }

        // TODO: Budouc� metoda pro integraci s NewsService
        /*
        private async Task<string> CallNewsService(string serviceUrl, int channelId)
        {
            using var client = new HttpClient();
            // Implementace vol�n� na NewsService
            // Nap��klad: GET /NewsService/GetACMessages?channelId=5&includeClosed=false&language=cs
            var response = await client.GetStringAsync($"{serviceUrl}/GetACMessages?channelId={channelId}&includeClosed=false&language=cs");
            return response;
        }
        */

        // TODO: Budouc� metoda pro SharePoint integraci
        /*
        private async Task<List<ArticleModel>> GetArticlesFromSharePoint()
        {
            // Microsoft Graph API integrace
            // 1. Autentifikace p�es Azure AD
            // 2. P��stup k SharePoint site
            // 3. Na�ten� dokument� z ur�en� knihovny
            // 4. Filtrace podle typu (PDF, Word dokumenty)
            // 5. Vr�cen� seznamu s metadata
            
            // P��klad vol�n�:
            // var graphClient = GetGraphServiceClient();
            // var site = await graphClient.Sites["root"].Request().GetAsync();
            // var drive = await graphClient.Sites[site.Id].Drives["Documents"].Request().GetAsync();
            // var items = await graphClient.Sites[site.Id].Drives[drive.Id].Root.Children.Request().GetAsync();
            
            return new List<ArticleModel>();
        }
        */
    }

    // TODO: Model pro �l�nky ze SharePoint
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