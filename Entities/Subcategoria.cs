using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla_Music.Entities
{
    public class Subcategoria
    {
        public Subcategoria()
        {
        }
        public int SubcategoriaId { get; set; }
        public string Nombre { get; set; }

        //public virtual ICollection<Producto> Productos { get; set; }
    }
}