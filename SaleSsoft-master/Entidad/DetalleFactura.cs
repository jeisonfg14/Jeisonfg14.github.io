using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class DetalleFactura
    {
        public string NoFactura { get; set; }
        public string IdDetalleFactura { get; set; }
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Importe { get; set; }
        public void CalcularImporte()
        {
            Importe = PrecioUnitario * Cantidad;
        }
    }
}
