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
    public partial class FrmNuevoProveedor : Form
    {
        TiendaService tiendaService;
        public FrmNuevoProveedor()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
           
        }
        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = (txtIdentificacion.Text);
            proveedor.NombreEmpresa = TxtNombreComercial.Text;
            proveedor.PrimerNombre = (txtPrimerNombre.Text);
            proveedor.SegundoNombre = (txtSegundoNombre.Text);
            proveedor.PrimerApellido = (txtPrimerApellido.Text);
            proveedor.SegundoApellido = (txtSegundoApellido.Text);
            proveedor.edad = Convert.ToInt32(txtEdad.Text);
            proveedor.sexo = (CmbSexo.SelectedItem.ToString());
            proveedor.Email = (txtEmail.Text);
            proveedor.Telefono = (txtTelefono.Text);
            string respuesta = tiendaService.GuardarProveedor(proveedor);
            MessageBox.Show(respuesta);
        }
    }
}
