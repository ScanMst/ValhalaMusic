using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla_Music.Entities
{
    public class Cliente
    {
        public Cliente()
        {
        }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        //public virtual ICollection<Venta> Ventas { get; set; }
    }
}