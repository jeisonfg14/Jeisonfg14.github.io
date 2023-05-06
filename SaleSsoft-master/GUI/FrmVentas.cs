using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmVentas : Form
    {
        TiendaService tiendaService;
        public FrmVentas()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            CargarFacturas();
        }
        static List<Factura> facturas = new List<Factura>();
        static List<DetalleFactura> detalles = new List<DetalleFactura>();


        public void CargarFacturas()
        {
            facturas = tiendaService.ConsultarFacturas();
            if (facturas is null)
            {
                MessageBox.Show("No existen Facturas o Error al leer Datos");
            }
            else
            {
                //ConfigurarGrid();
                DtgFactura.Rows.Clear();
                DtgFactura.AutoResizeColumnHeadersHeight();
                DtgFactura.ColumnCount = 6;
                foreach (Factura item in facturas)
                {
                    //Aquí recuperas los datos de cada item
                    DtgFactura.Rows.Add(item.NoFactura, item.FechaFactura, item.IdCliente, item.SubTotal, item.Impuesto, item.Total);

                }
            }




        }

        private void BtnBuscarAlternativo_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.TextLength.Equals(0))
            {
                CargarFacturas();
                dtgDetalle.Rows.Clear();
                dtgDetalle.AutoResizeColumnHeadersHeight();
                dtgDetalle.ColumnCount = 5;
            }
            else
            {
                foreach (Factura item in facturas)
                {
                    if (TxtBuscar.Text.Equals(item.NoFactura))
                    {
                        DtgFactura.Rows.Clear();
                        DtgFactura.AutoResizeColumnHeadersHeight();
                        DtgFactura.ColumnCount = 6;
                        DtgFactura.Rows.Add(item.NoFactura, item.FechaFactura, item.IdCliente, item.SubTotal, item.Impuesto, item.Total);
                        CargarDetalles(TxtBuscar.Text);
                    }
                }

            }
            
        }

        private void DtgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
               

            }
        }
        public void CargarDetalles(string id)
        {
            detalles = tiendaService.ConsultarDetalles();
            if (facturas is null)
            {
                MessageBox.Show("No existen Detalles o Error al leer Datos");
            }
            else
            {
                //ConfigurarGrid();
                dtgDetalle.Rows.Clear();
                dtgDetalle.AutoResizeColumnHeadersHeight();
                dtgDetalle.ColumnCount = 5;
                foreach (DetalleFactura item in detalles)
                {
                    if (id.Equals(item.NoFactura))
                    {
                        dtgDetalle.Rows.Add(item.IdProducto, item.Descripcion, item.Cantidad, item.PrecioUnitario, item.Importe);

                    }
                }
            }
        }

        private void BtnFiltroFecha_Click(object sender, EventArgs e)
        {
            
                foreach (Factura item in facturas)
                {
                    if (dttfecha.Value.Equals(item.FechaFactura))
                    {
                        DtgFactura.Rows.Clear();
                        DtgFactura.AutoResizeColumnHeadersHeight();
                        DtgFactura.ColumnCount = 6;
                        DtgFactura.Rows.Add(item.NoFactura, item.FechaFactura, item.IdCliente, item.SubTotal, item.Impuesto, item.Total);

                    }
                }

            
        }
    }
}
