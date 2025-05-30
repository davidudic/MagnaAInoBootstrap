namespace MagnaAI.Models
{
    public class LayoutViewModel
    {
        public List<MenuItem> Menu { get; set; }
        public UserInfo UserLogin { get; set; }
    }

    public class MenuItem { }
    public class UserInfo { }


    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
