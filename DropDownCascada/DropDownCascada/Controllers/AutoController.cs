using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownCascada.Models;

namespace DropDownCascada.Controllers
{
    public class AutoController : Controller
    {
        private IAutoRepositorio autoRepositorio = new AutoRepositorio();

        /*[HttpPost]
        public ActionResult Fabricantes()
        {
            var fabricantes = autoRepositorio.GetFabricantes();

            return Json(new SelectList(fabricantes, "Id", "Nombre"));
        }*/

        [HttpPost]
        public ActionResult Modelos(int id)
        {
            var modelos = autoRepositorio.GetModelos(id);

            return Json(new SelectList(modelos, "Id", "Nombre"));
        }
    }
}
