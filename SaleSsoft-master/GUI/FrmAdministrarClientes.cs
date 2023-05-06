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
    public partial class FrmAdministrarClientes : Form
    {
        TiendaService tiendaService;
        public FrmAdministrarClientes()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            CargarClientes();
        }
        static List<Cliente> clientes = new List<Cliente>();
        public void CargarClientes()
        {
            clientes = tiendaService.ConsultarClientes();
            if (clientes is null)
            {
                MessageBox.Show("No existen Clientes");
            }
            else
            {
                //ConfigurarGrid();
                dtgClientes.Rows.Clear();
                dtgClientes.AutoResizeColumnHeadersHeight();
                dtgClientes.ColumnCount = 9;
                foreach (Cliente item in clientes)
                {
                    //Aquí recuperas los datos de cada item
                    dtgClientes.Rows.Add(item.IdCliente, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.edad, item.sexo, item.Telefono, item.Email);
                    
                }
            }

        }
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.TextLength.Equals(0))
            {
                CargarClientes();
            }
            else
            {
                foreach (Cliente item in clientes)
                {
                    if (TxtBuscar.Text.Equals(item.IdCliente))
                    {
                        dtgClientes.Rows.Clear();
                        dtgClientes.AutoResizeColumnHeadersHeight();
                        dtgClientes.ColumnCount = 9;
                        dtgClientes.Rows.Add(item.IdCliente, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.edad, item.sexo, item.Telefono, item.Email);

                    }
                }

            }
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                TxtIdentificacion.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[0].Value;
                txtPrimerNombre.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[1].Value;
                txtSegundoNombre.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[2].Value;
                txtPrimerApellido.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[3].Value;
                txtSegundoApellido.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[4].Value;
                TxtEdad.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                CmbSexo.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[6].Value;
                txtTelefono.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[7].Value;
                txtEmail.Text = (string)dtgClientes.Rows[e.RowIndex].Cells[8].Value;
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = (TxtIdentificacion.Text);
            cliente.PrimerNombre = (txtPrimerNombre.Text);
            cliente.SegundoNombre = (txtSegundoNombre.Text);
            cliente.PrimerApellido = (txtPrimerApellido.Text);
            cliente.SegundoApellido = (txtSegundoApellido.Text);
            cliente.edad = Convert.ToInt32(TxtEdad.Text);
            cliente.sexo = (CmbSexo.SelectedItem.ToString());
            cliente.Email = (txtEmail.Text);
            cliente.Telefono = (txtTelefono.Text);
            string respuesta = tiendaService.ModificarCliente(cliente);
            CargarClientes();

            MessageBox.Show(respuesta);
        }
    }
}
