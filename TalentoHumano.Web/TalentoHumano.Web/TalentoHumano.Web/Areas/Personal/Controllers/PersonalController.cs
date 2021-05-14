using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TalentoHumano.Web.Areas.Personal.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal/Personal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CmbIntegrantesEquipos()
        {
            return PartialView();
        }
        public ActionResult TablaPullNotification()
        {
            return PartialView();
        }
    }
}