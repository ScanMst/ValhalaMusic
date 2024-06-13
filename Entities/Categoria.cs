using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla_Music.Entities
{
    public class Categoria
    {
        public Categoria()
        {
        }

    public int CategoriaId { get; set; }
    public string Nombre { get; set; }

    //public virtual ICollection<Subcategoria> Subcategorias { get; set; }   
    }
}