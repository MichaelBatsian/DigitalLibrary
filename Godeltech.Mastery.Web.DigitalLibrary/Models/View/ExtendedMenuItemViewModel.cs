using System.Collections.Generic;
using System.Web.Mvc;
using Godeltech.Mastery.Web.DigitalLibrary.Models.View.Account;

namespace Godeltech.Mastery.Web.DigitalLibrary.Models.View
{
    public class ExtendedMenuItemViewModel
    {
        public ExtendedMenuItemViewModel()
        {
            MenuItems = new List<MenuItemViewModel>();
            Login = new LoginViewModel();
            Genres = new List<string>();
        }

        public List<MenuItemViewModel> MenuItems { get; }
        public List<string> Genres { get; }
        public LoginViewModel Login { get; set; }
        public ViewDataDictionary Data { get; set; }
    }
}