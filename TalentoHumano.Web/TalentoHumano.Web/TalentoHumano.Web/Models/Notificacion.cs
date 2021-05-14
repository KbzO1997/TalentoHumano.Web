using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalentoHumano.Web.Models
{
    
   public class NotificacionRequest
    {
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
        public string nombreIntegrante { get; set; }
    }

    public class NotificacionResponse
    {
        public string fechaNotificacion { get; set; }
        public string descripcion { get; set; }
        public string hora { get; set; }
        public string integranteEquipo { get; set; }
    }
}
