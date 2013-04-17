using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownCascada.Models
{
    public class Fabricante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class ModeloAuto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}