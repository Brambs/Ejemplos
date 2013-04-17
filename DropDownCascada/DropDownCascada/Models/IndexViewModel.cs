using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownCascada.Models
{
    public class IndexViewModel
    {
        public string Fabricante { get; set; }
        public int Modelo { get; set; }

        public SelectList FabricantesDisponibles { get; set; }
        public SelectList ModelosDisponibles { get; set; }

        public IndexViewModel()
        {
            FabricantesDisponibles = new SelectList(Enumerable.Empty<Fabricante>(), "Id", "Nombre");
            ModelosDisponibles = new SelectList(Enumerable.Empty<ModeloAuto>(), "Id", "Nombre");
        }
    }
}