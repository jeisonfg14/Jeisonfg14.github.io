using PresentacionGUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        

        private Form FormularioActivo = null;
        private void AbrirFormulario(Form FormularioHijo)
        {
            if (FormularioActivo != null)
            {
                if(FormularioActivo.GetType() != FormularioHijo.GetType())
                {
                    FormularioActivo.Close();
                    FormularioActivo = FormularioHijo;
                    FormularioHijo.TopLevel = false;
                    FormularioHijo.Dock = DockStyle.Fill;
                    PnlContenedor.Controls.Add(FormularioHijo);
                    PnlContenedor.Tag = FormularioHijo;
                    FormularioHijo.BringToFront();
                    FormularioHijo.Show();
                }
            }
            else
            {
                FormularioActivo = FormularioHijo;
                FormularioHijo.TopLevel = false;
                FormularioHijo.Dock = DockStyle.Fill;
                PnlContenedor.Controls.Add(FormularioHijo);
                PnlContenedor.Tag = FormularioHijo;
                FormularioHijo.BringToFront();
                FormularioHijo.Show();
            }
            
        }
        /*
        public void IncluirFormulario(Form form)
        {
            if (this.PnlContenedor.Controls.Count > 0)
            {
                this.PnlContenedor.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(form);
            form.Show();
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            OrdenInicial();
        }
        private void OrdenInicial()
        {
            BtnCliente.Location = new Point(8, 177);
            BtnProveedor.Location = new Point(8, 221);
            PnlBordeProveedor.Location = new Point(1, 221);
            BtnProductos.Location = new Point(8, 265);
            PnlBordeProducto.Location = new Point(1, 265);
            BtnVentas.Location = new Point(8, 309);
            PnlBordeVentas.Location = new Point(1, 309);
            PnlProductos.Hide();
            PnlVentas.Hide();
            PnlCliente.Hide();
            PnlProveedor.Hide();
            AbrirFormulario(new FrmPanel());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (PnlProductos.Visible == true)
            {
                PnlProductos.Visible = false;
            }
            else
            {
                PnlProductos.Visible = true;
                PnlVentas.Hide();
                PnlCliente.Hide();
                PnlProveedor.Hide();
            }
            BtnCliente.Location = new Point(8, 177);
            BtnProveedor.Location = new Point(8, 221);
            PnlBordeProveedor.Location = new Point(1, 221);
            BtnProductos.Location = new Point(8, 265);
            PnlBordeProducto.Location = new Point(1, 265);
            PnlProductos.Location = new Point(1, 309);
            BtnVentas.Location = new Point(8, 385);
            PnlBordeVentas.Location = new Point(1, 385);

            if (PnlProductos.Visible == false)
            {
                OrdenInicial();

            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (PnlVentas.Visible == true)
            {
                PnlVentas.Visible = false;
            }
            else
            {
                PnlVentas.Visible = true;
                PnlProductos.Hide();
                PnlCliente.Hide();
                PnlProveedor.Hide();
            }
            BtnCliente.Location = new Point(8, 177);
            BtnProveedor.Location = new Point(8, 221);
            PnlBordeProveedor.Location = new Point(1, 221);
            BtnProductos.Location = new Point(8, 265);
            PnlBordeProducto.Location = new Point(1, 265);
            BtnVentas.Location = new Point(8, 309);
            PnlBordeVentas.Location = new Point(1, 309);
            PnlVentas.Location = new Point(0, 353);
            

            if (PnlVentas.Visible == false)
            {
                OrdenInicial();



            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            if (PnlCliente.Visible == true)
            {
                PnlCliente.Visible = false;
            }
            else
            {
                PnlCliente.Visible = true;
                PnlProductos.Hide();
                PnlVentas.Hide();
                PnlProveedor.Hide();
            }
            PnlCliente.Location = new Point(8, 221);
            
            BtnProveedor.Location = new Point(8, 297);
            PnlBordeProveedor.Location = new Point(1, 297);
            BtnProductos.Location = new Point(8, 341);
            PnlBordeProducto.Location = new Point(1, 341);
            BtnVentas.Location = new Point(8, 385);
            PnlBordeVentas.Location = new Point(1, 385);



            if (PnlCliente.Visible == false)
            {
                OrdenInicial();

            }
        }

        private void BtnPanel_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPanel());
            OrdenInicial();

        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmNuevoCliente());

        }
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            if (PnlProveedor.Visible == true)
            {
                PnlProveedor.Visible = false;
            }
            else
            {
                PnlProveedor.Visible = true;
                PnlCliente.Hide();
                PnlProductos.Hide();
                PnlVentas.Hide();
            }
            BtnProveedor.Location = new Point(8, 221);
            PnlBordeProveedor.Location = new Point(1, 221);
            PnlProveedor.Location = new Point(8, 265);
            BtnProductos.Location = new Point(8, 341);
            PnlBordeProducto.Location = new Point(1, 341);
            BtnVentas.Location = new Point(8, 385);
            PnlBordeVentas.Location = new Point(1, 385);




            if (PnlProveedor.Visible == false)
            {
                OrdenInicial();

            }

        }
        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmNuevoProducto());
        }

        private void BtnAdministrarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAdministrarProductos());
        }

        int eventoActivo, ubicacionMausex, ubicacionMausey;
        private void PnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            eventoActivo = 1;
            ubicacionMausex = e.X;
            ubicacionMausey = e.Y;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistroVenta());
        }

        private void BtnAdministarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVentas());
        }

        private void BtnAdministrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAdministrarClientes());
        }

        private void BtnNuevoProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmNuevoProveedor());
        }

        private void BtnAdministrarProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAdministrarProveedor());
        }

        private void PnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (eventoActivo == 1)
            {
                this.SetDesktopLocation(MousePosition.X - ubicacionMausex, MousePosition.Y - ubicacionMausey);
            }
        }

        private void PnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            eventoActivo = 0;
        }
    }
}
