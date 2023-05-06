using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioCompra { get; set; }
        public int CantidadDísponible { get; set; }
        public string IdProveedor { get; set; }

    }
}
