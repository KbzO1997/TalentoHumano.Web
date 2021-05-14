using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TalentoHumano.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly string _ViewDocumentacionIndex = "~/Areas/Documentacion/Views/Documentacion/DocumentacionIndex.cshtml";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View(_ViewDocumentacionIndex);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult LoginIndex()
        {
            return View();
        }
        public ActionResult NotificationPush()
        {
            return PartialView();
        }
        public ActionResult AllNotification()
        {
            return PartialView();
        }
    }
}