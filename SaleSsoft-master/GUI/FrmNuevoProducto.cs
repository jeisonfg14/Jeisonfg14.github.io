using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace PresentacionGUI
{
    public partial class FrmNuevoProducto : Form
    {
        TiendaService tiendaService;
        public FrmNuevoProducto()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            LlenarCombo();
        }

        public  void LlenarCombo()
        {
            
            List<Proveedor> Proveedores = new List<Proveedor>();
            Proveedores=tiendaService.ConsultarProveedores();
            if(Proveedores is null)
            {
                MessageBox.Show("Debe crear un proveedor primero");
            }
            else
            {
                foreach (Proveedor item in Proveedores)
                {
                    //Aquí recuperas los datos de cada item

                    CmbProveedor.Items.Add(item.IdProveedor);

                }
            }
            
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdProducto = (TxtCodigoProducto.Text);
            producto.CantidadDísponible = Convert.ToInt32(TxtCantidad.Text);
            producto.PrecioCompra = Convert.ToDouble(TxtPrecioCompra.Text);
            producto.PrecioUnitario = Convert.ToDouble(TxtPrecioVenta.Text);
            producto.Nombre = (TxtNombreProducto.Text);
            producto.IdProveedor = (CmbProveedor.SelectedItem.ToString()); 
            string respuesta = tiendaService.GuardarProducto(producto);
            MessageBox.Show(respuesta);
        }
    }
}
