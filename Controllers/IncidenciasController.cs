using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_Incidencias.Controllers
{
    public class IncidenciasController : Controller
    {
        // GET: Incidencias
        public ActionResult Index()
        {
           
            
                return View();
            
                
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        private class IncidenciasContex
        {
            public object Incidencias { get; internal set; }
        }
    }

    internal class IncidenciasContext
    {
        public IncidenciasContext()
        {
        }

        public object Incidencias { get; internal set; }
    }
}