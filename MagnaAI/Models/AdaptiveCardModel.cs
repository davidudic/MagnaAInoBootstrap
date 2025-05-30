namespace MagnaAI.Models
{
    public class AdaptiveCardModel : LayoutViewModel
    {
        public string AdaptiveCardJson { get; set; }
        public List<string> AdaptiveCardJsonList { get; set; }

        public AdaptiveCardModel()
        {
            AdaptiveCardJson = string.Empty;
            AdaptiveCardJsonList = new List<string>();
        }
    }
}
