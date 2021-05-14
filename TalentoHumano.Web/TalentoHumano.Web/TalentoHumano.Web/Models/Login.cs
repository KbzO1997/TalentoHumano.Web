using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentoHumano.Web.Models
{
    public class Login
    {
        class LoginRequest
        {
            public string email_login { get; set; }
            public string password_login { get; set; }
            public string email_contrasenia { get; set; }
            public string name_user { get; set; }
            public string email_user { get; set; }
            public string password_user { get; set; }
        }
    }
}