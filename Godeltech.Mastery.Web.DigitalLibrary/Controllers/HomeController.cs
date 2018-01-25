using System;
using System.Collections.Generic;
using System.Web.Hosting;
using System.Web.Mvc;
using Godeltech.Mastery.Web.DigitalLibrary.Models;
using Godeltech.Mastery.Web.DigitalLibrary.Models.ViewModels;

namespace Godeltech.Mastery.Web.DigitalLibrary.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Slider()
        {
            Slider slider = new Slider();
            String path = HostingEnvironment.MapPath("~/Content/Images/Home/Slider");
            List<SliderImageViewModel> images = slider.GetImages(path);
            return PartialView("~/Views/Slider/Slider.cshtml", images);
        }
    }
}