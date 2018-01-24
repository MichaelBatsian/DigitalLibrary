namespace Godeltech.Mastery.Web.DigitalLibrary.Models.View
{
    public class MenuItemViewModel
    {
        public string Name { set; get; }        
        public string Controller { set; get; } 
        public string Action { set; get; }     
        public string Active { set; get; }
        public string Icon { get; set; }
    }
}