
namespace PresentacionGUI
{
    partial class FrmAdministrarProveedor
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
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreComercial = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.ClmIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosCliente.Controls.Add(this.CmbSexo);
            this.pnlDatosCliente.Controls.Add(this.TxtEdad);
            this.pnlDatosCliente.Controls.Add(this.BtnModificar);
            this.pnlDatosCliente.Controls.Add(this.label2);
            this.pnlDatosCliente.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosCliente.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosCliente.Controls.Add(this.TxtIdentificacion);
            this.pnlDatosCliente.Controls.Add(this.label10);
            this.pnlDatosCliente.Controls.Add(this.label9);
            this.pnlDatosCliente.Controls.Add(this.txtEmail);
            this.pnlDatosCliente.Controls.Add(this.label8);
            this.pnlDatosCliente.Controls.Add(this.label6);
            this.pnlDatosCliente.Controls.Add(this.txtTelefono);
            this.pnlDatosCliente.Controls.Add(this.label7);
            this.pnlDatosCliente.Controls.Add(this.label1);
            this.pnlDatosCliente.Controls.Add(this.label12);
            this.pnlDatosCliente.Controls.Add(this.label4);
            this.pnlDatosCliente.Controls.Add(this.TxtNombreComercial);
            this.pnlDatosCliente.Controls.Add(this.TxtSegundoNombre);
            this.pnlDatosCliente.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosCliente.Controls.Add(this.label3);
            this.pnlDatosCliente.Location = new System.Drawing.Point(21, 312);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(1053, 268);
            this.pnlDatosCliente.TabIndex = 28;
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(171, 118);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(123, 25);
            this.CmbSexo.TabIndex = 21;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEdad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtEdad.Location = new System.Drawing.Point(513, 114);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(122, 25);
            this.TxtEdad.TabIndex = 19;
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
            this.BtnModificar.Location = new System.Drawing.Point(532, 220);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(82, 30);
            this.BtnModificar.TabIndex = 18;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(446, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Edad :";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundoApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSegundoApellido.Location = new System.Drawing.Point(861, 68);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(122, 25);
            this.txtSegundoApellido.TabIndex = 16;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerApellido.Location = new System.Drawing.Point(513, 67);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(122, 25);
            this.txtPrimerApellido.TabIndex = 15;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Enabled = false;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdentificacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtIdentificacion.Location = new System.Drawing.Point(171, 20);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(122, 25);
            this.TxtIdentificacion.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(717, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Segundo Apellido :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(383, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Primer Apellido :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(171, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Identificacion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(102, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefono.Location = new System.Drawing.Point(861, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 25);
            this.txtTelefono.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(773, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Segundo Nombre :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(362, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre Comercial :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(730, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Primer Nombre :";
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombreComercial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNombreComercial.Location = new System.Drawing.Point(513, 20);
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.Size = new System.Drawing.Size(122, 25);
            this.TxtNombreComercial.TabIndex = 2;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSegundoNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtSegundoNombre.Location = new System.Drawing.Point(172, 67);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(122, 25);
            this.TxtSegundoNombre.TabIndex = 2;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerNombre.Location = new System.Drawing.Point(861, 20);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(122, 25);
            this.txtPrimerNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo :";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToOrderColumns = true;
            this.dtgProveedor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIdCliente,
            this.ClmNombreComercial,
            this.ClmPrimerNombre,
            this.ClmSegundoNombre,
            this.ClmPrimerApellido,
            this.ClmSegundoApellido,
            this.ClmEdad,
            this.ClmSexo,
            this.ClmTelefono,
            this.ClmEmail});
            this.dtgProveedor.Location = new System.Drawing.Point(21, 84);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.RowTemplate.Height = 25;
            this.dtgProveedor.Size = new System.Drawing.Size(1053, 208);
            this.dtgProveedor.TabIndex = 27;
            this.dtgProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellClick);
            // 
            // ClmIdCliente
            // 
            this.ClmIdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmIdCliente.HeaderText = "ID Cliente";
            this.ClmIdCliente.Name = "ClmIdCliente";
            // 
            // ClmNombreComercial
            // 
            this.ClmNombreComercial.HeaderText = "Nombre Comercial";
            this.ClmNombreComercial.Name = "ClmNombreComercial";
            // 
            // ClmPrimerNombre
            // 
            this.ClmPrimerNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmPrimerNombre.HeaderText = "Primer Nombre";
            this.ClmPrimerNombre.Name = "ClmPrimerNombre";
            // 
            // ClmSegundoNombre
            // 
            this.ClmSegundoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmSegundoNombre.HeaderText = "Segundo Nombre";
            this.ClmSegundoNombre.Name = "ClmSegundoNombre";
            // 
            // ClmPrimerApellido
            // 
            this.ClmPrimerApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmPrimerApellido.HeaderText = "Primer Apellido";
            this.ClmPrimerApellido.Name = "ClmPrimerApellido";
            // 
            // ClmSegundoApellido
            // 
            this.ClmSegundoApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmSegundoApellido.HeaderText = "Segundo Apellido";
            this.ClmSegundoApellido.Name = "ClmSegundoApellido";
            // 
            // ClmEdad
            // 
            this.ClmEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmEdad.HeaderText = "Edad";
            this.ClmEdad.Name = "ClmEdad";
            this.ClmEdad.Width = 58;
            // 
            // ClmSexo
            // 
            this.ClmSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmSexo.HeaderText = "Sexo";
            this.ClmSexo.Name = "ClmSexo";
            this.ClmSexo.Width = 56;
            // 
            // ClmTelefono
            // 
            this.ClmTelefono.HeaderText = "Telefono";
            this.ClmTelefono.Name = "ClmTelefono";
            // 
            // ClmEmail
            // 
            this.ClmEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmEmail.HeaderText = "Email";
            this.ClmEmail.Name = "ClmEmail";
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProveedor.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(1048, 35);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(26, 27);
            this.BtnBuscarProveedor.TabIndex = 26;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarAlternativo_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(914, 35);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(128, 25);
            this.TxtBuscar.TabIndex = 25;
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
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(841, 32);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(70, 30);
            this.BtnBuscar.TabIndex = 24;
            this.BtnBuscar.Text = "Buscar :";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(21, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "Proveedores";
            // 
            // FrmAdministrarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1095, 610);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.BtnBuscarProveedor);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarProveedor";
            this.Text = "FrmAdministrarProveedor";
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEmail;
        private System.Windows.Forms.TextBox TxtEdad;
    }
}