using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDownCascada.Models
{
    public class AutoRepositorio : IAutoRepositorio
    {
        public IQueryable<Fabricante> GetFabricantes()
        {
            return new List<Fabricante>
            {
                new Fabricante { Id = 1, Nombre = "Mazda" },
                new Fabricante { Id = 2, Nombre = "Ford" },
                new Fabricante { Id = 3, Nombre = "Nissan" }
            }.AsQueryable();
        }

        public IQueryable<ModeloAuto> GetModelos(int id)
        {
            var modelos = new List<ModeloAuto>();

            if (id == 1) {
                modelos.AddRange(new List<ModeloAuto> { 
                    new ModeloAuto { Id = 1, Nombre = "Mazda3" },
                    new ModeloAuto { Id = 2, Nombre = "Mazda5" },
                    new ModeloAuto { Id = 3, Nombre = "Mazda CX-5" }
                });
            } else if (id == 2) {
                modelos.AddRange(new List<ModeloAuto> {
                    new ModeloAuto { Id = 1, Nombre = "Fiesta" },
                    new ModeloAuto { Id = 2, Nombre = "Focus" },
                    new ModeloAuto { Id = 3, Nombre = "Fusion" }
                });
            } else if (id == 3) {
                modelos.AddRange(new List<ModeloAuto> {
                    new ModeloAuto { Id = 1, Nombre = "March" },
                    new ModeloAuto { Id = 2, Nombre = "Sentra" },
                    new ModeloAuto { Id = 3, Nombre = "Tida" }
                });
            }

            return modelos.AsQueryable();
        }
    }

    public interface IAutoRepositorio 
    {
        IQueryable<Fabricante> GetFabricantes();
        IQueryable<ModeloAuto> GetModelos(int idFabricante);
    }
}