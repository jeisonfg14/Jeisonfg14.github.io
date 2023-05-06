using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidad
{
    public class Factura
    {
        

        public string NoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public string IdCliente { get; set; }

        public void iniciarListDetalles()
        {

            DetallesFactura = new List<DetalleFactura>();
            
        }

        public void agregarDetalles(DetalleFactura detalle)
        {
            
            DetallesFactura.Add(detalle);
        }
        public void removerDetalle(int indice)
        {
            DetallesFactura.RemoveAt(indice);
        }

        public void CalcularSubtotal()
        {
            SubTotal = DetallesFactura.Sum(X=> X.Importe);
        }
        public void CalcularImpuesto()
        {
            Impuesto = SubTotal * 0.19;
        }
        public void CalcularTotal()
        {
            Total = SubTotal + Impuesto;
        }

    }
}
