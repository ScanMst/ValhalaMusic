using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valhalla_Music.Entities
{
    public class Venta
    {
    public Venta()
    {
    }

    public int VentaId { get; set; }
    public int ClienteId { get; set; }
    public DateTime FechaVenta { get; set; }
    public decimal PrecioTotal { get; set; }

    //public virtual Cliente Cliente { get; set; }
    //public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}