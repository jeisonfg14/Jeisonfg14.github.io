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
    public partial class FrmAdministrarProductos : Form
    {
        TiendaService tiendaService;
        public FrmAdministrarProductos()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            CargarProducto();
        }
        static List<Producto> productos = new List<Producto>();

        public void CargarProducto()
        {
            productos = tiendaService.ConsultarProductos();
            if (productos is null)
            {
                MessageBox.Show("No existen Productos");
            }
            else
            {
                //ConfigurarGrid();
                dtgProducto.Rows.Clear();
                dtgProducto.AutoResizeColumnHeadersHeight();
                dtgProducto.ColumnCount = 9;
                foreach (Producto item in productos)
                {
                    //Aquí recuperas los datos de cada item
                    dtgProducto.Rows.Add(item.IdProducto, item.Nombre, item.CantidadDísponible, item.PrecioUnitario, item.PrecioCompra, item.IdProveedor);

                }
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.TextLength.Equals(0))
            {
                CargarProducto();
            }
            else
            {
                foreach (Producto item in productos)
                {
                    if (TxtBuscar.Text.Equals(item.IdProducto))
                    {
                        dtgProducto.Rows.Clear();
                        dtgProducto.AutoResizeColumnHeadersHeight();
                        dtgProducto.ColumnCount = 9;
                        dtgProducto.Rows.Add(item.IdProducto, item.Nombre, item.CantidadDísponible, item.PrecioUnitario, item.PrecioCompra, item.IdProveedor);

                    }
                }

            }
        }

        private void dtgProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                TxtCodigo.Text = (string)dtgProducto.Rows[e.RowIndex].Cells[0].Value;
                TxtNombreProducto.Text = (string)dtgProducto.Rows[e.RowIndex].Cells[1].Value;
                TxtCantidad.Text = (string)dtgProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtPrecioVenta.Text = (string)dtgProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtPrecioCompra.Text = (string)dtgProducto.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdProducto = (TxtCodigo.Text);
            producto.CantidadDísponible = Convert.ToInt32(TxtCantidad.Text);
            producto.PrecioCompra = Convert.ToDouble(TxtPrecioCompra.Text);
            producto.PrecioUnitario = Convert.ToDouble(TxtPrecioVenta.Text);
            producto.Nombre = (TxtNombreProducto.Text);
            string respuesta = tiendaService.ModificarProducto(producto);
            CargarProducto();
            MessageBox.Show(respuesta);
        }
    }
}
