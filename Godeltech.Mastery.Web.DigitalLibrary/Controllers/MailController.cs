using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Godeltech.Mastery.Web.DigitalLibrary.Models;
using Godeltech.Mastery.Web.DigitalLibrary.Models.View;

namespace Godeltech.Mastery.Web.DigitalLibrary.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientMail()
        {
            return PartialView();
        }

        public async Task<ActionResult> SendClientMail(ClientMailViewModel client, bool isAttach)
        {
            //var adress = "white.orchid.st@gmail.com";
            //var mailTo = new string[] { adress };
            //return await SendMail(customer, isAttach, GetGmailClient, adress, mailTo);
            return View();
        }
    } 
}