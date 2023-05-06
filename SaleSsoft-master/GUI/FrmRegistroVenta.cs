using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmRegistroVenta : Form
    {
        TiendaService tiendaService;
        Factura factura = new Factura();

        public FrmRegistroVenta()
        {
            InitializeComponent();
            tiendaService = new TiendaService(ConfigConnection.connectionString);
            LlenarComboCliente();
            LlenarComboProducto();
            NumeroFactura();
            factura.iniciarListDetalles();
            NumeroDetalleFactura();
        }
        static int numeroDetalle =0;
        public void NumeroDetalleFactura()
        {
            numeroDetalle = Convert.ToInt32(tiendaService.NumeroDetalleFactura());
            
        }

        static List<Cliente> clientes = new List<Cliente>();
        static List<Producto> productos = new List<Producto>();
        public void LlenarComboCliente()
        {

            
            clientes = tiendaService.ConsultarClientes();
            if (clientes is null)
            {
                MessageBox.Show("Debe crear un Cliente primero");
            }
            else
            {
                foreach (Cliente item in clientes)
                {
                    //Aquí recuperas los datos de cada item

                    CmbCliente.Items.Add(item.IdCliente);

                }
            }

        }
        public void LlenarComboProducto()
        {

            CmbProductos.Items.Clear();
            productos = tiendaService.ConsultarProductos();
            if (productos is null)
            {
                MessageBox.Show("Debe agregar un producto primero");
            }
            else
            {
                foreach (Producto item in productos)
                {
                    //Aquí recuperas los datos de cada item

                    CmbProductos.Items.Add(item.IdProducto);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CmbCliente.SelectedItem == null)
            {
                foreach (Cliente item in clientes)
                {
                    if (CmbCliente.Text.Equals(item.IdCliente))
                    {
                        factura.IdCliente = item.IdCliente;
                        (txtPrimerNombre.Text) = item.PrimerNombre;
                        (txtPrimerApellido.Text) = item.PrimerApellido;

                        (TxtEdad.Text) = item.edad.ToString();

                        (txtEmail.Text) = item.Email;

                        (txtTelefono.Text) = item.Telefono;
                    }
                }
                    
            }
            else
            {
                foreach (Cliente item in clientes)
                {
                    if (CmbCliente.SelectedItem.ToString().Equals(item.IdCliente))
                    {
                        factura.IdCliente = item.IdCliente;
                        (txtPrimerNombre.Text) = item.PrimerNombre;
                        (txtPrimerApellido.Text) = item.PrimerApellido;

                        (TxtEdad.Text) = item.edad.ToString();

                        (txtEmail.Text) = item.Email;

                        (txtTelefono.Text)= item.Telefono;

                    }
                    

                }
            }
            
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (CmbProductos.SelectedItem == null)
            {
                foreach (Producto item in productos)
                {
                    if (CmbProductos.Text.Equals(item.IdProducto))
                    {
                        (TxtNombreProducto.Text) = item.Nombre;
                        (TxtCantidadDiponible.Text) = item.CantidadDísponible.ToString();       
                    }
                }

            }
            else
            {
                foreach (Producto item in productos)
                {
                    if (CmbProductos.SelectedItem.ToString().Equals(item.IdProducto))
                    {

                        (TxtNombreProducto.Text) = item.Nombre;
                        (TxtCantidadDiponible.Text) = item.CantidadDísponible.ToString();

                    }


                }
            }
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFactura detalle = new DetalleFactura();
            detalle.NoFactura = factura.NoFactura;
            if (CmbProductos.SelectedItem == null)
            {
            }
            else
            {
                if (Convert.ToInt32(TxtCantidadDiponible.Text)>= Convert.ToInt32(TxtCantidad.Text))
                {
                    

                    
                    foreach (Producto item in productos)
                    {
                        if (CmbProductos.SelectedItem.ToString().Equals(item.IdProducto))
                        {
                            item.CantidadDísponible = Convert.ToInt32(TxtCantidadDiponible.Text) - Convert.ToInt32(TxtCantidad.Text);
                            TxtCantidadDiponible.Text = item.CantidadDísponible.ToString();

                            detalle.IdDetalleFactura = (numeroDetalle += 1).ToString();
                            detalle.IdProducto = item.IdProducto;
                            detalle.Descripcion = item.Nombre;
                            detalle.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                            detalle.PrecioUnitario = item.PrecioUnitario;
                            detalle.CalcularImporte();

                           
                            dtgDetalle.AutoResizeColumnHeadersHeight();
                            dtgDetalle.ColumnCount = 5;
                            dtgDetalle.Rows.Add(detalle.IdProducto, detalle.Descripcion, detalle.Cantidad, detalle.PrecioUnitario, detalle.Importe);

                            factura.agregarDetalles(detalle);
                            

                            factura.CalcularSubtotal();
                            TxtSubtotal.Text = factura.SubTotal.ToString();
                            factura.CalcularImpuesto();
                            TxtImpuesto.Text = factura.Impuesto.ToString();
                            factura.CalcularTotal();
                            TxtTotal.Text = factura.Total.ToString();

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Cantidad disponible sobrepasada");
                }
            }
        }

        public void NumeroFactura()
        {
            string mensaje = tiendaService.NumeroFactura();

            if (mensaje != null)
            {
                int numero = Convert.ToInt32(mensaje);
                numero += 1;
                factura.NoFactura = (numero.ToString());
                TxtNoFactura.Text = factura.NoFactura;
            }

        }
        

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDetalle.SelectedCells != null)
            {
                string id = (string)dtgDetalle.SelectedCells[0].Value.ToString();
                int fila = dtgDetalle.CurrentRow.Index;
                foreach (Producto item in productos)
                {
                    if (id.ToString().Equals(item.IdProducto))
                    {
                        item.CantidadDísponible = Convert.ToInt32(dtgDetalle.Rows[fila].Cells[2].Value) + item.CantidadDísponible;
                        if (CmbProductos.SelectedItem.ToString().Equals(item.IdProducto)) 
                        {
                            TxtCantidadDiponible.Text = item.CantidadDísponible.ToString();
                        } 
                    }
                }
                factura.removerDetalle(fila);
                dtgDetalle.Rows.RemoveAt(fila);
                factura.CalcularSubtotal();
                TxtSubtotal.Text = factura.SubTotal.ToString();
                factura.CalcularImpuesto();
                TxtImpuesto.Text = factura.Impuesto.ToString();
                factura.CalcularTotal();
                TxtTotal.Text = factura.Total.ToString();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            factura.FechaFactura = DttFechaFactura.Value.Date;
            factura.Impuesto = Convert.ToDouble(TxtImpuesto.Text);
            factura.SubTotal = Convert.ToDouble(TxtSubtotal.Text);
            factura.Total = Convert.ToDouble(TxtTotal.Text);
            string respuesta = tiendaService.GuardarFactura(factura);
            foreach (DetalleFactura item in factura.DetallesFactura)
            {
                respuesta = tiendaService.GuardarDetalleFactura(item);
                //MessageBox.Show(item.IdProducto+ " "+item.PrecioUnitario+ " " + item.Cantidad+ " " + item.Descripcion+ " " + item.Importe);
            }
            MessageBox.Show(respuesta);
            LlenarComboProducto();
            NumeroFactura();
            factura.DetallesFactura.Clear();
            dtgDetalle.Rows.Clear();
            numeroDetalle = 0;
            factura.CalcularSubtotal();
            TxtSubtotal.Text = factura.SubTotal.ToString();
            factura.CalcularImpuesto();
            TxtImpuesto.Text = factura.Impuesto.ToString();
            factura.CalcularTotal();
            TxtTotal.Text = factura.Total.ToString();

            


        }
    }
}
