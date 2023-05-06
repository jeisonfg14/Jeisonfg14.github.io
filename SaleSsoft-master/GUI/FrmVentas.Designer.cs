
namespace PresentacionGUI
{
    partial class FrmVentas
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
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.ClmNFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmToral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBuscarAlternativo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dttfecha = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltroFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgFactura
            // 
            this.DtgFactura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNFactura,
            this.ClmFecha,
            this.ClmCliente,
            this.ClmSubtotal,
            this.ClmImpuesto,
            this.ClmToral});
            this.DtgFactura.Location = new System.Drawing.Point(12, 73);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.RowTemplate.Height = 25;
            this.DtgFactura.Size = new System.Drawing.Size(1070, 247);
            this.DtgFactura.TabIndex = 3;
            this.DtgFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgFactura_CellClick);
            // 
            // ClmNFactura
            // 
            this.ClmNFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmNFactura.HeaderText = "N°Factura";
            this.ClmNFactura.Name = "ClmNFactura";
            // 
            // ClmFecha
            // 
            this.ClmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmFecha.HeaderText = "Fecha";
            this.ClmFecha.Name = "ClmFecha";
            // 
            // ClmCliente
            // 
            this.ClmCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmCliente.HeaderText = "Cliente";
            this.ClmCliente.Name = "ClmCliente";
            // 
            // ClmSubtotal
            // 
            this.ClmSubtotal.HeaderText = "Sub-Total";
            this.ClmSubtotal.Name = "ClmSubtotal";
            // 
            // ClmImpuesto
            // 
            this.ClmImpuesto.HeaderText = "Impuesto";
            this.ClmImpuesto.Name = "ClmImpuesto";
            // 
            // ClmToral
            // 
            this.ClmToral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmToral.HeaderText = "Total";
            this.ClmToral.Name = "ClmToral";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 23);
            this.textBox2.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(27, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 15);
            this.label26.TabIndex = 16;
            this.label26.Text = "Nombre del Prodcuto :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(74, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 15);
            this.label27.TabIndex = 15;
            this.label27.Text = "% Descuento :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(82, 134);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 15);
            this.label28.TabIndex = 14;
            this.label28.Text = "Descripcion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ventas";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(922, 38);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(128, 25);
            this.TxtBuscar.TabIndex = 29;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(782, 35);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(137, 30);
            this.BtnBuscar.TabIndex = 28;
            this.BtnBuscar.Text = "Buscar N° Factura :";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscarAlternativo
            // 
            this.BtnBuscarAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarAlternativo.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnBuscarAlternativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarAlternativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAlternativo.Location = new System.Drawing.Point(1056, 38);
            this.BtnBuscarAlternativo.Name = "BtnBuscarAlternativo";
            this.BtnBuscarAlternativo.Size = new System.Drawing.Size(26, 27);
            this.BtnBuscarAlternativo.TabIndex = 30;
            this.BtnBuscarAlternativo.UseVisualStyleBackColor = false;
            this.BtnBuscarAlternativo.Click += new System.EventHandler(this.BtnBuscarAlternativo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-99, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Filtro Fecha :";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToOrderColumns = true;
            this.dtgDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.ClmProducto,
            this.ClmCantidad,
            this.ClmPrecioVenta,
            this.ClmImporte});
            this.dtgDetalle.Location = new System.Drawing.Point(12, 326);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.RowTemplate.Height = 25;
            this.dtgDetalle.Size = new System.Drawing.Size(1070, 225);
            this.dtgDetalle.TabIndex = 33;
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmCodigo.HeaderText = "IdProducto";
            this.ClmCodigo.Name = "ClmCodigo";
            // 
            // ClmProducto
            // 
            this.ClmProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmProducto.HeaderText = "Descripcion";
            this.ClmProducto.Name = "ClmProducto";
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmCantidad.HeaderText = "Cantidad";
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.Width = 80;
            // 
            // ClmPrecioVenta
            // 
            this.ClmPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmPrecioVenta.HeaderText = "Precio Unitario";
            this.ClmPrecioVenta.Name = "ClmPrecioVenta";
            // 
            // ClmImporte
            // 
            this.ClmImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmImporte.HeaderText = "Importe";
            this.ClmImporte.Name = "ClmImporte";
            // 
            // dttfecha
            // 
            this.dttfecha.Location = new System.Drawing.Point(410, 37);
            this.dttfecha.Name = "dttfecha";
            this.dttfecha.Size = new System.Drawing.Size(200, 23);
            this.dttfecha.TabIndex = 34;
            // 
            // BtnFiltroFecha
            // 
            this.BtnFiltroFecha.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltroFecha.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnFiltroFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFiltroFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltroFecha.Location = new System.Drawing.Point(630, 35);
            this.BtnFiltroFecha.Name = "BtnFiltroFecha";
            this.BtnFiltroFecha.Size = new System.Drawing.Size(26, 27);
            this.BtnFiltroFecha.TabIndex = 30;
            this.BtnFiltroFecha.UseVisualStyleBackColor = false;
            this.BtnFiltroFecha.Click += new System.EventHandler(this.BtnFiltroFecha_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1094, 607);
            this.Controls.Add(this.dttfecha);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnFiltroFecha);
            this.Controls.Add(this.BtnBuscarAlternativo);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmAdministrarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBuscarAlternativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmToral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmImporte;
        private System.Windows.Forms.DateTimePicker dttfecha;
        private System.Windows.Forms.Button BtnFiltroFecha;
    }
}