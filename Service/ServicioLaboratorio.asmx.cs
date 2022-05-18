using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//Para poder usar el SHA 256 dentro del aplicativo
using System.Security.Cryptography;

namespace Service
{
    /// <summary>
    /// Descripción breve de ServicioLaboratorio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioLaboratorio : System.Web.Services.WebService
    {
        BDServiceEntities context = new BDServiceEntities();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod(Description = "Logueo de usuario enviando Usuario y Contraseña")]
        public List<spValidarUsuario_Result> Logueo(string usuario, string contra)
        {
            return context.spValidarUsuario(usuario, contra).ToList();
        }

        [WebMethod(Description = "Envio de insercion de usuario")]
        public string Insert(string user, string contra)
        {
            context.spInsertarUsuario(user, contra);
            return "Success";
        }
    }
}
