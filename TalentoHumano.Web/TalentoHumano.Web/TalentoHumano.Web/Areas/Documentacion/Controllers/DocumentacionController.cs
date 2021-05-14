using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TalentoHumano.Web.Areas.Documentacion.Controllers
{
    public class DocumentacionController : Controller
    {
        // GET: Documentacion/Documentacion
        public ActionResult DocumentacionIndex()
        {
            return PartialView();
        }
    }
}