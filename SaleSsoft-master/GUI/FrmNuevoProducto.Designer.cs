
namespace PresentacionGUI
{
    partial class FrmNuevoProducto
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
            this.label18 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.DetalleProdcutos = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.DetalleProdcutos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(100, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 19);
            this.label18.TabIndex = 8;
            this.label18.Text = "Nombre del Prodcuto :";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreProducto.Location = new System.Drawing.Point(254, 70);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(151, 25);
            this.TxtNombreProducto.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(109, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Codigo de Producto :";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodigoProducto.Location = new System.Drawing.Point(254, 30);
            this.TxtCodigoProducto.Margin = new System.Windows.Forms.Padding(0);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(151, 25);
            this.TxtCodigoProducto.TabIndex = 7;
            // 
            // DetalleProdcutos
            // 
            this.DetalleProdcutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetalleProdcutos.Controls.Add(this.BtnGuardar);
            this.DetalleProdcutos.Controls.Add(this.CmbProveedor);
            this.DetalleProdcutos.Controls.Add(this.label14);
            this.DetalleProdcutos.Controls.Add(this.label18);
            this.DetalleProdcutos.Controls.Add(this.label27);
            this.DetalleProdcutos.Controls.Add(this.TxtNombreProducto);
            this.DetalleProdcutos.Controls.Add(this.label12);
            this.DetalleProdcutos.Controls.Add(this.TxtCodigoProducto);
            this.DetalleProdcutos.Controls.Add(this.TxtPrecioCompra);
            this.DetalleProdcutos.Controls.Add(this.TxtCantidad);
            this.DetalleProdcutos.Controls.Add(this.label1);
            this.DetalleProdcutos.Controls.Add(this.label15);
            this.DetalleProdcutos.Controls.Add(this.TxtPrecioVenta);
            this.DetalleProdcutos.Location = new System.Drawing.Point(330, 60);
            this.DetalleProdcutos.Margin = new System.Windows.Forms.Padding(0);
            this.DetalleProdcutos.Name = "DetalleProdcutos";
            this.DetalleProdcutos.Size = new System.Drawing.Size(508, 356);
            this.DetalleProdcutos.TabIndex = 13;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(222, 291);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 30);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(253, 230);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(152, 25);
            this.CmbProveedor.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(123, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Precio de Compra :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(177, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 19);
            this.label27.TabIndex = 17;
            this.label27.Text = "Cantidad :";
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioCompra.Location = new System.Drawing.Point(254, 150);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(151, 25);
            this.TxtPrecioCompra.TabIndex = 12;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCantidad.Location = new System.Drawing.Point(254, 110);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(151, 25);
            this.TxtCantidad.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proveedor :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(137, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "Precio de Venta :";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrecioVenta.Location = new System.Drawing.Point(254, 190);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(151, 25);
            this.TxtPrecioVenta.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(330, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 31);
            this.panel1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(14, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Registrar de Producto";
            // 
            // FrmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1095, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetalleProdcutos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoProducto";
            this.Text = "FrmProductos";
            this.DetalleProdcutos.ResumeLayout(false);
            this.DetalleProdcutos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Panel DetalleProdcutos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TxtPrecioCompra;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnGuardar;
    }
}