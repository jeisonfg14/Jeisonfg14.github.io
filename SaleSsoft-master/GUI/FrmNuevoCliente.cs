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
    public partial class FrmNuevoCliente : Form
    {
        TiendaService tiendaService;
        public FrmNuevoCliente()
        {
            InitializeComponent();

            tiendaService = new TiendaService(ConfigConnection.connectionString);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = (txtIdentificacion.Text);
            cliente.PrimerNombre = (txtPrimerNombre.Text);
            cliente.SegundoNombre = (txtSegundoNombre.Text);
            cliente.PrimerApellido = (txtPrimerApellido.Text);
            cliente.SegundoApellido = (txtSegundoApellido.Text);
            cliente.edad = Convert.ToInt32(txtEdad.Text);
            cliente.sexo = (CmbSexo.SelectedItem.ToString());
            cliente.Email = (txtEmail.Text);
            cliente.Telefono = (txtTelefono.Text);
            string respuesta = tiendaService.GuardarCliente(cliente);
            MessageBox.Show(respuesta);
        }
    }
}
