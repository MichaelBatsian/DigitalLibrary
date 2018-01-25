using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Godeltech.Mastery.Web.DigitalLibrary.Controllers
{
    public class BookCartController : Controller
    {
        // GET: BookCart
        public ActionResult Index()
        {
            return View();
        }
    }
}