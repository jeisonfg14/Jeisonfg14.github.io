
namespace PresentacionGUI
{
    partial class FrmAdministrarProductos
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
            this.PnlAdministrarProductos = new System.Windows.Forms.Panel();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleProdcutos = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.PnlAdministrarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.DetalleProdcutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAdministrarProductos
            // 
            this.PnlAdministrarProductos.BackColor = System.Drawing.Color.Azure;
            this.PnlAdministrarProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlAdministrarProductos.Controls.Add(this.BtnBuscarProducto);
            this.PnlAdministrarProductos.Controls.Add(this.TxtBuscar);
            this.PnlAdministrarProductos.Controls.Add(this.BtnBuscar);
            this.PnlAdministrarProductos.Controls.Add(this.label1);
            this.PnlAdministrarProductos.Controls.Add(this.dtgProducto);
            this.PnlAdministrarProductos.Controls.Add(this.DetalleProdcutos);
            this.PnlAdministrarProductos.Location = new System.Drawing.Point(0, 0);
            this.PnlAdministrarProductos.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAdministrarProductos.Name = "PnlAdministrarProductos";
            this.PnlAdministrarProductos.Size = new System.Drawing.Size(1094, 607);
            this.PnlAdministrarProductos.TabIndex = 0;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProducto.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(1044, 34);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(26, 27);
            this.BtnBuscarProducto.TabIndex = 28;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(910, 34);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(128, 25);
            this.TxtBuscar.TabIndex = 27;
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
            this.BtnBuscar.Location = new System.Drawing.Point(770, 31);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(137, 30);
            this.BtnBuscar.TabIndex = 26;
            this.BtnBuscar.Text = "Buscar Por Codigo:";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Productos";
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToOrderColumns = true;
            this.dtgProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.ClmProducto,
            this.ClmCantidad,
            this.ClmPrecioVenta,
            this.ClmPrecioCompra,
            this.ClmProveedor});
            this.dtgProducto.Location = new System.Drawing.Point(17, 82);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.RowTemplate.Height = 25;
            this.dtgProducto.Size = new System.Drawing.Size(1053, 237);
            this.dtgProducto.TabIndex = 20;
            this.dtgProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducto_CellClick);
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmCodigo.HeaderText = "Codigo";
            this.ClmCodigo.Name = "ClmCodigo";
            // 
            // ClmProducto
            // 
            this.ClmProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmProducto.HeaderText = "Producto";
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
            this.ClmPrecioVenta.HeaderText = "Precio de Venta";
            this.ClmPrecioVenta.Name = "ClmPrecioVenta";
            // 
            // ClmPrecioCompra
            // 
            this.ClmPrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmPrecioCompra.HeaderText = "Precio Compra";
            this.ClmPrecioCompra.Name = "ClmPrecioCompra";
            // 
            // ClmProveedor
            // 
            this.ClmProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmProveedor.HeaderText = "ID Provedor";
            this.ClmProveedor.Name = "ClmProveedor";
            // 
            // DetalleProdcutos
            // 
            this.DetalleProdcutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetalleProdcutos.Controls.Add(this.BtnModificar);
            this.DetalleProdcutos.Controls.Add(this.label14);
            this.DetalleProdcutos.Controls.Add(this.label13);
            this.DetalleProdcutos.Controls.Add(this.TxtPrecioCompra);
            this.DetalleProdcutos.Controls.Add(this.TxtCantidad);
            this.DetalleProdcutos.Controls.Add(this.label18);
            this.DetalleProdcutos.Controls.Add(this.TxtNombreProducto);
            this.DetalleProdcutos.Controls.Add(this.label15);
            this.DetalleProdcutos.Controls.Add(this.TxtPrecioVenta);
            this.DetalleProdcutos.Controls.Add(this.label12);
            this.DetalleProdcutos.Controls.Add(this.TxtCodigo);
            this.DetalleProdcutos.Location = new System.Drawing.Point(17, 346);
            this.DetalleProdcutos.Margin = new System.Windows.Forms.Padding(0);
            this.DetalleProdcutos.Name = "DetalleProdcutos";
            this.DetalleProdcutos.Size = new System.Drawing.Size(1053, 200);
            this.DetalleProdcutos.TabIndex = 9;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.Location = new System.Drawing.Point(524, 151);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(82, 30);
            this.BtnModificar.TabIndex = 20;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Precio de Compra :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(808, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cantidad :";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioCompra.Location = new System.Drawing.Point(147, 77);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(151, 25);
            this.TxtPrecioCompra.TabIndex = 12;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidad.Location = new System.Drawing.Point(888, 17);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(151, 26);
            this.TxtCantidad.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(407, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "Nombre del Prodcuto :";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreProducto.Location = new System.Drawing.Point(561, 20);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(151, 25);
            this.TxtNombreProducto.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(438, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "Precio de Venta :";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioVenta.Location = new System.Drawing.Point(561, 79);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(151, 25);
            this.TxtPrecioVenta.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(4, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Codigo de Producto :";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodigo.Location = new System.Drawing.Point(147, 22);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(151, 25);
            this.TxtCodigo.TabIndex = 4;
            // 
            // FrmAdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1095, 610);
            this.Controls.Add(this.PnlAdministrarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarProductos";
            this.Text = "FrmAdministrarProductos";
            this.PnlAdministrarProductos.ResumeLayout(false);
            this.PnlAdministrarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.DetalleProdcutos.ResumeLayout(false);
            this.DetalleProdcutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAdministrarProductos;
        private System.Windows.Forms.Panel DetalleProdcutos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtPrecioCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProveedor;
    }
}