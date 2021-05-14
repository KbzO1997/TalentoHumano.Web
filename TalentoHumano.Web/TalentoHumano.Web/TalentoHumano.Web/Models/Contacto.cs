using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalentoHumano.Web.Models
{
    public class Contacto
    {
        class ContactoRequest
        {
            public string telefonoPersona { get; set; }
            public string correoPersona { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string mensaje { get; set; }
        }

        class ContactoResponse
        {
            public string correoInstitucion { get; set; }
            public string telefonoInstitucion { get; set; }
        }
    }
}
