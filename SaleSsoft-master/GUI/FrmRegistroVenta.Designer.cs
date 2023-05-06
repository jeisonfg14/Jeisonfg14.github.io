
namespace PresentacionGUI
{
    partial class FrmRegistroVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtNoFactura = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DttFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.PnlFacturaCompra = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidadDiponible = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProdcuto = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatosCliente.SuspendLayout();
            this.PnlFacturaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos del Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(784, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Nombre del Producto :";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(923, 50);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(151, 23);
            this.txtDescuento.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(923, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(151, 23);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(839, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "Descripcion :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(831, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "% Descuento :";
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosCliente.Controls.Add(this.button1);
            this.pnlDatosCliente.Controls.Add(this.CmbCliente);
            this.pnlDatosCliente.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosCliente.Controls.Add(this.label9);
            this.pnlDatosCliente.Controls.Add(this.txtEmail);
            this.pnlDatosCliente.Controls.Add(this.label5);
            this.pnlDatosCliente.Controls.Add(this.label8);
            this.pnlDatosCliente.Controls.Add(this.label6);
            this.pnlDatosCliente.Controls.Add(this.txtTelefono);
            this.pnlDatosCliente.Controls.Add(this.TxtEdad);
            this.pnlDatosCliente.Controls.Add(this.label7);
            this.pnlDatosCliente.Controls.Add(this.label27);
            this.pnlDatosCliente.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosCliente.Location = new System.Drawing.Point(20, 46);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(1053, 86);
            this.pnlDatosCliente.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(314, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbCliente
            // 
            this.CmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(159, 10);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(151, 25);
            this.CmbCliente.TabIndex = 18;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerApellido.Location = new System.Drawing.Point(858, 6);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(155, 25);
            this.txtPrimerApellido.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(728, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Primer Apellido :";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(858, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Edad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(90, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cliente :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(789, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefono.Location = new System.Drawing.Point(530, 52);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 25);
            this.txtTelefono.TabIndex = 10;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Enabled = false;
            this.TxtEdad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEdad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtEdad.Location = new System.Drawing.Point(159, 53);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(151, 25);
            this.TxtEdad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(454, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(411, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 19);
            this.label27.TabIndex = 4;
            this.label27.Text = "Primer Nombre :";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerNombre.Location = new System.Drawing.Point(530, 10);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(149, 25);
            this.txtPrimerNombre.TabIndex = 2;
            // 
            // TxtNoFactura
            // 
            this.TxtNoFactura.Enabled = false;
            this.TxtNoFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNoFactura.Location = new System.Drawing.Point(159, 17);
            this.TxtNoFactura.Name = "TxtNoFactura";
            this.TxtNoFactura.Size = new System.Drawing.Size(151, 25);
            this.TxtNoFactura.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(72, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "N°Factura :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(402, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 19);
            this.label25.TabIndex = 3;
            this.label25.Text = "Fecha de Factura :";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSubtotal.Location = new System.Drawing.Point(530, 344);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(150, 25);
            this.TxtSubtotal.TabIndex = 2;
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Enabled = false;
            this.TxtImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtImpuesto.Location = new System.Drawing.Point(694, 344);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(150, 25);
            this.TxtImpuesto.TabIndex = 2;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTotal.Location = new System.Drawing.Point(858, 344);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(150, 25);
            this.TxtTotal.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(728, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Lista de Productos :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(530, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "Sub-Total :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(694, 326);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 15);
            this.label23.TabIndex = 9;
            this.label23.Text = "Impuesto :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(858, 326);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 15);
            this.label24.TabIndex = 9;
            this.label24.Text = "Total :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(3, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 1);
            this.panel1.TabIndex = 11;
            // 
            // DttFechaFactura
            // 
            this.DttFechaFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DttFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DttFechaFactura.Location = new System.Drawing.Point(528, 17);
            this.DttFechaFactura.Name = "DttFechaFactura";
            this.DttFechaFactura.Size = new System.Drawing.Size(151, 25);
            this.DttFechaFactura.TabIndex = 12;
            // 
            // CmbProductos
            // 
            this.CmbProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(863, 13);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(150, 25);
            this.CmbProductos.TabIndex = 13;
            // 
            // PnlFacturaCompra
            // 
            this.PnlFacturaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFacturaCompra.Controls.Add(this.BtnAgregar);
            this.PnlFacturaCompra.Controls.Add(this.BtnGuardar);
            this.PnlFacturaCompra.Controls.Add(this.dtgDetalle);
            this.PnlFacturaCompra.Controls.Add(this.label14);
            this.PnlFacturaCompra.Controls.Add(this.label1);
            this.PnlFacturaCompra.Controls.Add(this.TxtCantidadDiponible);
            this.PnlFacturaCompra.Controls.Add(this.TxtCantidad);
            this.PnlFacturaCompra.Controls.Add(this.label12);
            this.PnlFacturaCompra.Controls.Add(this.TxtNombreProducto);
            this.PnlFacturaCompra.Controls.Add(this.BtnBuscarProdcuto);
            this.PnlFacturaCompra.Controls.Add(this.CmbProductos);
            this.PnlFacturaCompra.Controls.Add(this.DttFechaFactura);
            this.PnlFacturaCompra.Controls.Add(this.panel1);
            this.PnlFacturaCompra.Controls.Add(this.BtnEliminar);
            this.PnlFacturaCompra.Controls.Add(this.label24);
            this.PnlFacturaCompra.Controls.Add(this.label23);
            this.PnlFacturaCompra.Controls.Add(this.label16);
            this.PnlFacturaCompra.Controls.Add(this.label13);
            this.PnlFacturaCompra.Controls.Add(this.TxtTotal);
            this.PnlFacturaCompra.Controls.Add(this.TxtImpuesto);
            this.PnlFacturaCompra.Controls.Add(this.TxtSubtotal);
            this.PnlFacturaCompra.Controls.Add(this.label25);
            this.PnlFacturaCompra.Controls.Add(this.label26);
            this.PnlFacturaCompra.Controls.Add(this.TxtNoFactura);
            this.PnlFacturaCompra.Location = new System.Drawing.Point(20, 166);
            this.PnlFacturaCompra.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFacturaCompra.Name = "PnlFacturaCompra";
            this.PnlFacturaCompra.Size = new System.Drawing.Size(1053, 424);
            this.PnlFacturaCompra.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.Location = new System.Drawing.Point(474, 103);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(82, 30);
            this.BtnAgregar.TabIndex = 28;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(474, 383);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 30);
            this.BtnGuardar.TabIndex = 27;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.AllowUserToOrderColumns = true;
            this.dtgDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.ClmProducto,
            this.ClmCantidad,
            this.ClmPrecioVenta,
            this.ClmImporte});
            this.dtgDetalle.Location = new System.Drawing.Point(3, 165);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.RowTemplate.Height = 25;
            this.dtgDetalle.Size = new System.Drawing.Size(1005, 145);
            this.dtgDetalle.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(382, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cantidad Disponible :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(786, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cantidad :";
            // 
            // TxtCantidadDiponible
            // 
            this.TxtCantidadDiponible.Enabled = false;
            this.TxtCantidadDiponible.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidadDiponible.Location = new System.Drawing.Point(528, 62);
            this.TxtCantidadDiponible.Name = "TxtCantidadDiponible";
            this.TxtCantidadDiponible.Size = new System.Drawing.Size(151, 26);
            this.TxtCantidadDiponible.TabIndex = 23;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidad.Location = new System.Drawing.Point(866, 60);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(147, 26);
            this.TxtCantidad.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(5, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nombre del Prodcuto :";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Enabled = false;
            this.TxtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreProducto.Location = new System.Drawing.Point(159, 65);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(151, 25);
            this.TxtNombreProducto.TabIndex = 21;
            // 
            // BtnBuscarProdcuto
            // 
            this.BtnBuscarProdcuto.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProdcuto.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnBuscarProdcuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarProdcuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProdcuto.Location = new System.Drawing.Point(1019, 13);
            this.BtnBuscarProdcuto.Name = "BtnBuscarProdcuto";
            this.BtnBuscarProdcuto.Size = new System.Drawing.Size(26, 27);
            this.BtnBuscarProdcuto.TabIndex = 20;
            this.BtnBuscarProdcuto.UseVisualStyleBackColor = false;
            this.BtnBuscarProdcuto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.BackgroundImage = global::PresentacionGUI.Properties.Resources.circle_x_close_icon_143475;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(1013, 165);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(33, 30);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(31, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Datos de la Factura";
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmCodigo.HeaderText = "IdProducto";
            this.ClmCodigo.Name = "ClmCodigo";
            this.ClmCodigo.ReadOnly = true;
            // 
            // ClmProducto
            // 
            this.ClmProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmProducto.HeaderText = "Descripcion";
            this.ClmProducto.Name = "ClmProducto";
            this.ClmProducto.ReadOnly = true;
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmCantidad.HeaderText = "Cantidad";
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.ReadOnly = true;
            this.ClmCantidad.Width = 80;
            // 
            // ClmPrecioVenta
            // 
            this.ClmPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmPrecioVenta.HeaderText = "Precio Unitario";
            this.ClmPrecioVenta.Name = "ClmPrecioVenta";
            this.ClmPrecioVenta.ReadOnly = true;
            // 
            // ClmImporte
            // 
            this.ClmImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmImporte.HeaderText = "Importe";
            this.ClmImporte.Name = "ClmImporte";
            this.ClmImporte.ReadOnly = true;
            // 
            // FrmRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1095, 610);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.PnlFacturaCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroVenta";
            this.Text = "FrmRegistrarVenta";
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.PnlFacturaCompra.ResumeLayout(false);
            this.PnlFacturaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox TxtNoFactura;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DttFechaFactura;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.Panel PnlFacturaCompra;
        private System.Windows.Forms.Button BtnBuscarProdcuto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidadDiponible;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmImporte;
    }
}