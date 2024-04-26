using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class VentaPorArticulo
    {
        public int IDProducto { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int TotalVendido { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalVentas { get; set; }

    }
}