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
    public partial class FrmPanel : Form
    {
        TiendaService tiendaService;

        public FrmPanel()
        {
            tiendaService = new TiendaService(ConfigConnection.connectionString);

            InitializeComponent();
            NumeroCliente();
            NumeroProveedor();
            NumeroFactura();
            NumeroProducto();

        }
        public void NumeroCliente()
        {
            LblNumeroClientes.Text = tiendaService.NumeroCliente().ToString();
        }
        public void NumeroProveedor()
        {
            LbNumeroProveedores.Text = tiendaService.NumeroProveedor().ToString();
        }
        public void NumeroFactura()
        {
            LblNumeroVentas.Text = tiendaService.NumeroFactura().ToString();
        }
        public void NumeroProducto()
        {
            LblNumeroProducto.Text = tiendaService.NumeroProducto().ToString();
        }


    }
}
