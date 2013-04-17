using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownCascada.Models;

namespace DropDownCascada.Controllers
{
    public class HomeController : Controller
    {
        private IAutoRepositorio autoRepositorio = new AutoRepositorio();
        
        public ActionResult Index()
        {
            ViewBag.Message = "DropDowns en Cascada";
            var modelo = new IndexViewModel();

            modelo.FabricantesDisponibles = new SelectList(autoRepositorio.GetFabricantes(), "Id", "Nombre");
            modelo.ModelosDisponibles = new SelectList(autoRepositorio.GetModelos(1), "Id", "Nombre");

            return View(modelo);
        }
    }
}
