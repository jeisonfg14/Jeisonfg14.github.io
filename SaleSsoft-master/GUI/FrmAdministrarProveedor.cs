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
    public partial class FrmAdministrarProveedor : Form
    {
        TiendaService tiendaService;
        public FrmAdministrarProveedor()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            CargarProveedor();
        }
        static List<Proveedor> proveedores = new List<Proveedor>();
        public void CargarProveedor()
        {
            proveedores = tiendaService.ConsultarProveedores();
            if (proveedores is null)
            {
                MessageBox.Show("No existen Proveedores");
            }
            else
            {
                //ConfigurarGrid();
                dtgProveedor.Rows.Clear();
                dtgProveedor.AutoResizeColumnHeadersHeight();
                dtgProveedor.ColumnCount = 10;
                foreach (Proveedor item in proveedores)
                {
                    //Aquí recuperas los datos de cada item
                    dtgProveedor.Rows.Add(item.IdProveedor, item.NombreEmpresa, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.edad, item.sexo, item.Telefono, item.Email);

                }
            }
        }

        private void BtnBuscarAlternativo_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.TextLength.Equals(0))
            {
                CargarProveedor();
            }
            else
            {
                foreach (Proveedor item in proveedores)
                {
                    if (TxtBuscar.Text.Equals(item.IdProveedor))
                    {
                        dtgProveedor.Rows.Clear();
                        dtgProveedor.AutoResizeColumnHeadersHeight();
                        dtgProveedor.ColumnCount = 10;
                        dtgProveedor.Rows.Add(item.IdProveedor, item.NombreEmpresa, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.edad, item.sexo, item.Telefono, item.Email);

                    }
                }

            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = (TxtIdentificacion.Text);
            proveedor.NombreEmpresa = (TxtNombreComercial.Text);
            proveedor.PrimerNombre = (txtPrimerNombre.Text);
            proveedor.SegundoNombre = (TxtSegundoNombre.Text);
            proveedor.PrimerApellido = (txtPrimerApellido.Text);
            proveedor.SegundoApellido = (txtSegundoApellido.Text);
            proveedor.edad = Convert.ToInt32(TxtEdad.Text);
            proveedor.sexo = (CmbSexo.SelectedItem.ToString());
            proveedor.Email = (txtEmail.Text);
            proveedor.Telefono = (txtTelefono.Text);
            string respuesta = tiendaService.ModificarProveedor(proveedor);
            CargarProveedor();
            MessageBox.Show(respuesta);
        }

        private void dtgProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                TxtIdentificacion.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[0].Value;
                TxtNombreComercial.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[1].Value;
                txtPrimerNombre.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[2].Value;
                TxtSegundoNombre.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[3].Value;
                txtPrimerApellido.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[4].Value;
                txtSegundoApellido.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[5].Value;
                TxtEdad.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[6].Value.ToString();
                CmbSexo.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[7].Value;
                txtTelefono.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[8].Value;
                txtEmail.Text = (string)dtgProveedor.Rows[e.RowIndex].Cells[9].Value;
            }
        }
    }
}
