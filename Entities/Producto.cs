using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla_Music.Entities
{
    public class Producto
    {
        public Guid Id { get; set;}

        public string Name { get; set;}

        public decimal Price { get; set;}   

        public int Stock{ get; set;}

        public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }


        
    }
}