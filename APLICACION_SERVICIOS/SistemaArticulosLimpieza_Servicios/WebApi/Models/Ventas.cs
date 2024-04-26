using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Ventas
    {
        public int IDVentas { get; set; }
        public Productos IDProductos { get; set; }
        public string Descripcion { get; set; }
        public double CantidadVendida { get; set; }
        public DateTime Fecha { get; set; }
}
}