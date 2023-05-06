
namespace PresentacionGUI
{
    partial class FrmAdministrarClientes
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
            this.label11 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.ClmIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
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
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.pnlDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(30, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Clientes";
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
            this.BtnBuscar.Location = new System.Drawing.Point(850, 32);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(70, 30);
            this.BtnBuscar.TabIndex = 17;
            this.BtnBuscar.Text = "Buscar :";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(923, 35);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(128, 25);
            this.TxtBuscar.TabIndex = 18;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCliente.BackgroundImage = global::PresentacionGUI.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(1057, 35);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(26, 27);
            this.BtnBuscarCliente.TabIndex = 19;
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToOrderColumns = true;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIdCliente,
            this.ClmPrimerNombre,
            this.ClmSegundoNombre,
            this.ClmPrimerApellido,
            this.ClmSegundoApellido,
            this.ClmEdad,
            this.ClmSexo,
            this.ClmTelefono,
            this.ClmEmail});
            this.dtgClientes.Location = new System.Drawing.Point(30, 84);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowTemplate.Height = 25;
            this.dtgClientes.Size = new System.Drawing.Size(1053, 208);
            this.dtgClientes.TabIndex = 21;
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
            // 
            // ClmIdCliente
            // 
            this.ClmIdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmIdCliente.HeaderText = "ID Cliente";
            this.ClmIdCliente.Name = "ClmIdCliente";
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
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosCliente.Controls.Add(this.CmbSexo);
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
            this.pnlDatosCliente.Controls.Add(this.TxtEdad);
            this.pnlDatosCliente.Controls.Add(this.txtTelefono);
            this.pnlDatosCliente.Controls.Add(this.label7);
            this.pnlDatosCliente.Controls.Add(this.label1);
            this.pnlDatosCliente.Controls.Add(this.label4);
            this.pnlDatosCliente.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosCliente.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosCliente.Controls.Add(this.label3);
            this.pnlDatosCliente.Location = new System.Drawing.Point(30, 312);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(1053, 268);
            this.pnlDatosCliente.TabIndex = 22;
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(861, 67);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(159, 25);
            this.CmbSexo.TabIndex = 20;
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
            this.BtnModificar.Location = new System.Drawing.Point(536, 216);
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
            this.label2.Location = new System.Drawing.Point(104, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Edad :";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundoApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSegundoApellido.Location = new System.Drawing.Point(513, 68);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(122, 25);
            this.txtSegundoApellido.TabIndex = 16;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerApellido.Location = new System.Drawing.Point(172, 67);
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
            this.label10.Location = new System.Drawing.Point(369, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Segundo Apellido :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(42, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Primer Apellido :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(861, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 25);
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
            this.label6.Location = new System.Drawing.Point(792, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email :";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEdad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtEdad.Location = new System.Drawing.Point(172, 116);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(122, 25);
            this.TxtEdad.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTelefono.Location = new System.Drawing.Point(513, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 25);
            this.txtTelefono.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(425, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(716, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Segundo Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(382, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Primer Nombre :";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundoNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSegundoNombre.Location = new System.Drawing.Point(861, 20);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(159, 25);
            this.txtSegundoNombre.TabIndex = 2;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrimerNombre.Location = new System.Drawing.Point(513, 20);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(122, 25);
            this.txtPrimerNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(796, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo :";
            // 
            // FrmAdministrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1095, 610);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrarClientes";
            this.Text = "FrmAdministrarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.DataGridView dtgClientes;
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
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEmail;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox CmbSexo;
    }
}