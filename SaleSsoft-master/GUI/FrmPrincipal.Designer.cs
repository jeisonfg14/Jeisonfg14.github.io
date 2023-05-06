
namespace GUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlBarra = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPanel = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.PnlBordeVentas = new System.Windows.Forms.Panel();
            this.PnlBordeProveedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlProductos = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnAdministrarProducto = new System.Windows.Forms.Button();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlCliente = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnAdministrarClientes = new System.Windows.Forms.Button();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.PnlBordeProducto = new System.Windows.Forms.Panel();
            this.PnlProveedor = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.BtnAdministrarProveedores = new System.Windows.Forms.Button();
            this.BtnNuevoProveedor = new System.Windows.Forms.Button();
            this.PnlVentas = new System.Windows.Forms.Panel();
            this.BtnInformeVentas = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlProductos.SuspendLayout();
            this.PnlCliente.SuspendLayout();
            this.PnlProveedor.SuspendLayout();
            this.PnlVentas.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBarra
            // 
            this.PnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.PnlBarra.Controls.Add(this.BtnMinimizar);
            this.PnlBarra.Controls.Add(this.button1);
            this.PnlBarra.Controls.Add(this.BtnCerrar);
            resources.ApplyResources(this.PnlBarra, "PnlBarra");
            this.PnlBarra.Name = "PnlBarra";
            this.PnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseDown);
            this.PnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseMove);
            this.PnlBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseUp);
            // 
            // BtnMinimizar
            // 
            resources.ApplyResources(this.BtnMinimizar, "BtnMinimizar");
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PnlContenedor, "PnlContenedor");
            this.PnlContenedor.Name = "PnlContenedor";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BtnPanel
            // 
            this.BtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnPanel.FlatAppearance.BorderSize = 0;
            this.BtnPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnPanel, "BtnPanel");
            this.BtnPanel.ForeColor = System.Drawing.Color.White;
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.UseVisualStyleBackColor = false;
            this.BtnPanel.Click += new System.EventHandler(this.BtnPanel_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnCliente, "BtnCliente");
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnProveedor, "BtnProveedor");
            this.BtnProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnProductos, "BtnProductos");
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnVentas, "BtnVentas");
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // PnlBordeVentas
            // 
            this.PnlBordeVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.PnlBordeVentas, "PnlBordeVentas");
            this.PnlBordeVentas.Name = "PnlBordeVentas";
            // 
            // PnlBordeProveedor
            // 
            this.PnlBordeProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.PnlBordeProveedor, "PnlBordeProveedor");
            this.PnlBordeProveedor.Name = "PnlBordeProveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PnlProductos
            // 
            this.PnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlProductos.Controls.Add(this.panel5);
            this.PnlProductos.Controls.Add(this.panel6);
            this.PnlProductos.Controls.Add(this.BtnAdministrarProducto);
            this.PnlProductos.Controls.Add(this.BtnRegistrarProducto);
            resources.ApplyResources(this.PnlProductos, "PnlProductos");
            this.PnlProductos.Name = "PnlProductos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // BtnAdministrarProducto
            // 
            this.BtnAdministrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnAdministrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnAdministrarProducto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnAdministrarProducto, "BtnAdministrarProducto");
            this.BtnAdministrarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarProducto.Name = "BtnAdministrarProducto";
            this.BtnAdministrarProducto.UseVisualStyleBackColor = false;
            this.BtnAdministrarProducto.Click += new System.EventHandler(this.BtnAdministrarProducto_Click);
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnRegistrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnRegistrarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnRegistrarProducto, "BtnRegistrarProducto");
            this.BtnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // PnlCliente
            // 
            this.PnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlCliente.Controls.Add(this.panel8);
            this.PnlCliente.Controls.Add(this.panel9);
            this.PnlCliente.Controls.Add(this.BtnAdministrarClientes);
            this.PnlCliente.Controls.Add(this.BtnNuevoCliente);
            resources.ApplyResources(this.PnlCliente, "PnlCliente");
            this.PnlCliente.Name = "PnlCliente";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // BtnAdministrarClientes
            // 
            this.BtnAdministrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnAdministrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnAdministrarClientes.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnAdministrarClientes, "BtnAdministrarClientes");
            this.BtnAdministrarClientes.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarClientes.Name = "BtnAdministrarClientes";
            this.BtnAdministrarClientes.UseVisualStyleBackColor = false;
            this.BtnAdministrarClientes.Click += new System.EventHandler(this.BtnAdministrarClientes_Click);
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.BtnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnNuevoCliente, "BtnNuevoCliente");
            this.BtnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.UseVisualStyleBackColor = false;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // PnlBordeProducto
            // 
            this.PnlBordeProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.PnlBordeProducto, "PnlBordeProducto");
            this.PnlBordeProducto.Name = "PnlBordeProducto";
            // 
            // PnlProveedor
            // 
            this.PnlProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlProveedor.Controls.Add(this.panel13);
            this.PnlProveedor.Controls.Add(this.panel14);
            this.PnlProveedor.Controls.Add(this.BtnAdministrarProveedores);
            this.PnlProveedor.Controls.Add(this.BtnNuevoProveedor);
            resources.ApplyResources(this.PnlProveedor, "PnlProveedor");
            this.PnlProveedor.Name = "PnlProveedor";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // BtnAdministrarProveedores
            // 
            this.BtnAdministrarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnAdministrarProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnAdministrarProveedores.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnAdministrarProveedores, "BtnAdministrarProveedores");
            this.BtnAdministrarProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarProveedores.Name = "BtnAdministrarProveedores";
            this.BtnAdministrarProveedores.UseVisualStyleBackColor = false;
            this.BtnAdministrarProveedores.Click += new System.EventHandler(this.BtnAdministrarProveedores_Click);
            // 
            // BtnNuevoProveedor
            // 
            this.BtnNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnNuevoProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevoProveedor.FlatAppearance.BorderSize = 0;
            this.BtnNuevoProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevoProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnNuevoProveedor, "BtnNuevoProveedor");
            this.BtnNuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnNuevoProveedor.Name = "BtnNuevoProveedor";
            this.BtnNuevoProveedor.UseVisualStyleBackColor = false;
            this.BtnNuevoProveedor.Click += new System.EventHandler(this.BtnNuevoProveedor_Click);
            // 
            // PnlVentas
            // 
            this.PnlVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlVentas.Controls.Add(this.BtnInformeVentas);
            this.PnlVentas.Controls.Add(this.panel12);
            this.PnlVentas.Controls.Add(this.panel11);
            this.PnlVentas.Controls.Add(this.BtnRegistrarVenta);
            resources.ApplyResources(this.PnlVentas, "PnlVentas");
            this.PnlVentas.Name = "PnlVentas";
            // 
            // BtnInformeVentas
            // 
            this.BtnInformeVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnInformeVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnInformeVentas.FlatAppearance.BorderSize = 0;
            this.BtnInformeVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnInformeVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnInformeVentas, "BtnInformeVentas");
            this.BtnInformeVentas.ForeColor = System.Drawing.Color.White;
            this.BtnInformeVentas.Name = "BtnInformeVentas";
            this.BtnInformeVentas.UseVisualStyleBackColor = false;
            this.BtnInformeVentas.Click += new System.EventHandler(this.BtnAdministarVenta_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.BtnRegistrarVenta, "BtnRegistrarVenta");
            this.BtnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.UseVisualStyleBackColor = false;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlMenu.Controls.Add(this.PnlVentas);
            this.PnlMenu.Controls.Add(this.PnlProveedor);
            this.PnlMenu.Controls.Add(this.PnlBordeProducto);
            this.PnlMenu.Controls.Add(this.PnlCliente);
            this.PnlMenu.Controls.Add(this.panel2);
            this.PnlMenu.Controls.Add(this.PnlProductos);
            this.PnlMenu.Controls.Add(this.panel1);
            this.PnlMenu.Controls.Add(this.PnlBordeProveedor);
            this.PnlMenu.Controls.Add(this.PnlBordeVentas);
            this.PnlMenu.Controls.Add(this.BtnVentas);
            this.PnlMenu.Controls.Add(this.BtnProductos);
            this.PnlMenu.Controls.Add(this.BtnProveedor);
            this.PnlMenu.Controls.Add(this.BtnCliente);
            this.PnlMenu.Controls.Add(this.BtnPanel);
            this.PnlMenu.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.PnlMenu, "PnlMenu");
            this.PnlMenu.Name = "PnlMenu";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlProductos.ResumeLayout(false);
            this.PnlCliente.ResumeLayout(false);
            this.PnlProveedor.ResumeLayout(false);
            this.PnlVentas.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBarra;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPanel;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Panel PnlBordeVentas;
        private System.Windows.Forms.Panel PnlBordeProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnAdministrarProducto;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlCliente;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnAdministrarClientes;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.Panel PnlBordeProducto;
        private System.Windows.Forms.Panel PnlProveedor;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button BtnAdministrarProveedores;
        private System.Windows.Forms.Button BtnNuevoProveedor;
        private System.Windows.Forms.Panel PnlVentas;
        private System.Windows.Forms.Button BtnInformeVentas;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BtnRegistrarVenta;
        private System.Windows.Forms.Panel PnlMenu;
    }
}

