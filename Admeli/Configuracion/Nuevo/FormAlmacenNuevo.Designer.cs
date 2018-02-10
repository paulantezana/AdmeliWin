﻿namespace Admeli.Configuracion.Nuevo
{
    partial class FormAlmacenNuevo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacenNuevo));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSucursalNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivoAlmacen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkPrincipalAlmacen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivel4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivel3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nivel1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLevel3 = new System.Windows.Forms.Panel();
            this.cbxNivel3 = new System.Windows.Forms.ComboBox();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.panelLevel2 = new System.Windows.Forms.Panel();
            this.cbxNivel2 = new System.Windows.Forms.ComboBox();
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.textDirecionAlmacen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelLevel1 = new System.Windows.Forms.Panel();
            this.cbxNivel1 = new System.Windows.Forms.ComboBox();
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.panelLevelPais = new System.Windows.Forms.Panel();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombreAlmacen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelLevel3.SuspendLayout();
            this.panelLevel2.SuspendLayout();
            this.panelLevel1.SuspendLayout();
            this.panelLevelPais.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 313);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelFooter.Size = new System.Drawing.Size(720, 49);
            this.panelFooter.TabIndex = 31;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(159, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 48);
            this.panel1.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(16, 9);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 30);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Location = new System.Drawing.Point(188, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSucursalNuevo
            // 
            this.btnSucursalNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(202)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatAppearance.BorderSize = 0;
            this.btnSucursalNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursalNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursalNuevo.ForeColor = System.Drawing.Color.White;
            this.btnSucursalNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnSucursalNuevo.Image")));
            this.btnSucursalNuevo.Location = new System.Drawing.Point(322, 48);
            this.btnSucursalNuevo.Name = "btnSucursalNuevo";
            this.btnSucursalNuevo.Size = new System.Drawing.Size(28, 40);
            this.btnSucursalNuevo.TabIndex = 104;
            this.btnSucursalNuevo.UseVisualStyleBackColor = false;
            this.btnSucursalNuevo.Click += new System.EventHandler(this.btnSucursalNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(174, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Activo *";
            // 
            // chkActivoAlmacen
            // 
            this.chkActivoAlmacen.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoAlmacen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivoAlmacen.Checked = true;
            this.chkActivoAlmacen.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoAlmacen.ForeColor = System.Drawing.Color.White;
            this.chkActivoAlmacen.Location = new System.Drawing.Point(149, 156);
            this.chkActivoAlmacen.Name = "chkActivoAlmacen";
            this.chkActivoAlmacen.Size = new System.Drawing.Size(20, 20);
            this.chkActivoAlmacen.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label16.Location = new System.Drawing.Point(47, 156);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 101;
            this.label16.Text = "Principal";
            // 
            // chkPrincipalAlmacen
            // 
            this.chkPrincipalAlmacen.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkPrincipalAlmacen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkPrincipalAlmacen.Checked = true;
            this.chkPrincipalAlmacen.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkPrincipalAlmacen.ForeColor = System.Drawing.Color.White;
            this.chkPrincipalAlmacen.Location = new System.Drawing.Point(22, 154);
            this.chkPrincipalAlmacen.Name = "chkPrincipalAlmacen";
            this.chkPrincipalAlmacen.Size = new System.Drawing.Size(20, 20);
            this.chkPrincipalAlmacen.TabIndex = 100;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Entidad.Sucursal);
            // 
            // nivel4BindingSource
            // 
            this.nivel4BindingSource.DataSource = typeof(Entidad.Location.Nivel4);
            // 
            // nivel3BindingSource
            // 
            this.nivel3BindingSource.DataSource = typeof(Entidad.Location.Nivel3);
            // 
            // nivel2BindingSource
            // 
            this.nivel2BindingSource.DataSource = typeof(Entidad.Location.Nivel2);
            // 
            // nivel1BindingSource
            // 
            this.nivel1BindingSource.DataSource = typeof(Entidad.Location.Nivel1);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(Entidad.Location.Pais);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBarApp
            // 
            this.progressBarApp.BackColor = System.Drawing.Color.White;
            this.progressBarApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarApp.Location = new System.Drawing.Point(0, 0);
            this.progressBarApp.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarApp.MarqueeAnimationSpeed = 10;
            this.progressBarApp.Maximum = 200;
            this.progressBarApp.Name = "progressBarApp";
            this.progressBarApp.RightToLeftLayout = true;
            this.progressBarApp.Size = new System.Drawing.Size(720, 5);
            this.progressBarApp.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(372, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 121;
            this.label4.Text = "Dirección *";
            // 
            // panelLevel3
            // 
            this.panelLevel3.Controls.Add(this.cbxNivel3);
            this.panelLevel3.Controls.Add(this.lblNivel3);
            this.panelLevel3.Location = new System.Drawing.Point(369, 195);
            this.panelLevel3.Name = "panelLevel3";
            this.panelLevel3.Size = new System.Drawing.Size(328, 40);
            this.panelLevel3.TabIndex = 120;
            this.panelLevel3.Visible = false;
            // 
            // cbxNivel3
            // 
            this.cbxNivel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNivel3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNivel3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNivel3.DataSource = this.nivel3BindingSource;
            this.cbxNivel3.DisplayMember = "nombre";
            this.cbxNivel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel3.FormattingEnabled = true;
            this.cbxNivel3.Location = new System.Drawing.Point(3, 14);
            this.cbxNivel3.Name = "cbxNivel3";
            this.cbxNivel3.Size = new System.Drawing.Size(321, 24);
            this.cbxNivel3.TabIndex = 1;
            this.cbxNivel3.ValueMember = "idNivel3";
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel3.ForeColor = System.Drawing.Color.DimGray;
            this.lblNivel3.Location = new System.Drawing.Point(2, 1);
            this.lblNivel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(35, 14);
            this.lblNivel3.TabIndex = 0;
            this.lblNivel3.Text = "nivel3";
            // 
            // panelLevel2
            // 
            this.panelLevel2.Controls.Add(this.cbxNivel2);
            this.panelLevel2.Controls.Add(this.lblNivel2);
            this.panelLevel2.Location = new System.Drawing.Point(369, 146);
            this.panelLevel2.Name = "panelLevel2";
            this.panelLevel2.Size = new System.Drawing.Size(328, 40);
            this.panelLevel2.TabIndex = 119;
            this.panelLevel2.Visible = false;
            // 
            // cbxNivel2
            // 
            this.cbxNivel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNivel2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNivel2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNivel2.DataSource = this.nivel2BindingSource;
            this.cbxNivel2.DisplayMember = "nombre";
            this.cbxNivel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel2.FormattingEnabled = true;
            this.cbxNivel2.Location = new System.Drawing.Point(3, 14);
            this.cbxNivel2.Name = "cbxNivel2";
            this.cbxNivel2.Size = new System.Drawing.Size(321, 24);
            this.cbxNivel2.TabIndex = 1;
            this.cbxNivel2.ValueMember = "idNivel2";
            this.cbxNivel2.SelectedIndexChanged += new System.EventHandler(this.cbxNivel2_SelectedIndexChanged);
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel2.ForeColor = System.Drawing.Color.DimGray;
            this.lblNivel2.Location = new System.Drawing.Point(2, 1);
            this.lblNivel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(35, 14);
            this.lblNivel2.TabIndex = 0;
            this.lblNivel2.Text = "nivel2";
            // 
            // textDirecionAlmacen
            // 
            this.textDirecionAlmacen.BackColor = System.Drawing.Color.White;
            this.textDirecionAlmacen.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textDirecionAlmacen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textDirecionAlmacen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textDirecionAlmacen.BorderThickness = 1;
            this.textDirecionAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDirecionAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDirecionAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconPadding(this.textDirecionAlmacen, -30);
            this.textDirecionAlmacen.isPassword = false;
            this.textDirecionAlmacen.Location = new System.Drawing.Point(368, 244);
            this.textDirecionAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.textDirecionAlmacen.Name = "textDirecionAlmacen";
            this.textDirecionAlmacen.Padding = new System.Windows.Forms.Padding(2, 18, 5, 2);
            this.textDirecionAlmacen.Size = new System.Drawing.Size(329, 40);
            this.textDirecionAlmacen.TabIndex = 122;
            this.textDirecionAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelLevel1
            // 
            this.panelLevel1.Controls.Add(this.cbxNivel1);
            this.panelLevel1.Controls.Add(this.lblNivel1);
            this.panelLevel1.Location = new System.Drawing.Point(369, 98);
            this.panelLevel1.Name = "panelLevel1";
            this.panelLevel1.Size = new System.Drawing.Size(328, 40);
            this.panelLevel1.TabIndex = 118;
            this.panelLevel1.Visible = false;
            // 
            // cbxNivel1
            // 
            this.cbxNivel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNivel1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNivel1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNivel1.DataSource = this.nivel1BindingSource;
            this.cbxNivel1.DisplayMember = "nombre";
            this.cbxNivel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel1.FormattingEnabled = true;
            this.cbxNivel1.Location = new System.Drawing.Point(3, 14);
            this.cbxNivel1.Name = "cbxNivel1";
            this.cbxNivel1.Size = new System.Drawing.Size(321, 24);
            this.cbxNivel1.TabIndex = 1;
            this.cbxNivel1.ValueMember = "idNivel1";
            this.cbxNivel1.SelectedIndexChanged += new System.EventHandler(this.cbxNivel1_SelectedIndexChanged);
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel1.ForeColor = System.Drawing.Color.DimGray;
            this.lblNivel1.Location = new System.Drawing.Point(2, 1);
            this.lblNivel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(35, 14);
            this.lblNivel1.TabIndex = 0;
            this.lblNivel1.Text = "nivel1";
            // 
            // panelLevelPais
            // 
            this.panelLevelPais.Controls.Add(this.cbxPaises);
            this.panelLevelPais.Controls.Add(this.label11);
            this.panelLevelPais.Location = new System.Drawing.Point(369, 50);
            this.panelLevelPais.Name = "panelLevelPais";
            this.panelLevelPais.Size = new System.Drawing.Size(328, 40);
            this.panelLevelPais.TabIndex = 117;
            // 
            // cbxPaises
            // 
            this.cbxPaises.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPaises.DataSource = this.paisBindingSource;
            this.cbxPaises.DisplayMember = "nombre";
            this.cbxPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Location = new System.Drawing.Point(3, 14);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(321, 24);
            this.cbxPaises.TabIndex = 1;
            this.cbxPaises.ValueMember = "idPais";
            this.cbxPaises.SelectedIndexChanged += new System.EventHandler(this.cbxPaises_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(2, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 123;
            this.label5.Text = "Nombres*";
            // 
            // textNombreAlmacen
            // 
            this.textNombreAlmacen.BackColor = System.Drawing.Color.White;
            this.textNombreAlmacen.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreAlmacen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textNombreAlmacen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textNombreAlmacen.BorderThickness = 1;
            this.textNombreAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconPadding(this.textNombreAlmacen, -30);
            this.textNombreAlmacen.isPassword = false;
            this.textNombreAlmacen.Location = new System.Drawing.Point(21, 99);
            this.textNombreAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreAlmacen.Name = "textNombreAlmacen";
            this.textNombreAlmacen.Padding = new System.Windows.Forms.Padding(2, 18, 5, 2);
            this.textNombreAlmacen.Size = new System.Drawing.Size(329, 40);
            this.textNombreAlmacen.TabIndex = 124;
            this.textNombreAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxSucursal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 125;
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSucursal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxSucursal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSucursal.DataSource = this.nivel2BindingSource;
            this.cbxSucursal.DisplayMember = "nombre";
            this.cbxSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(3, 14);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(293, 24);
            this.cbxSucursal.TabIndex = 1;
            this.cbxSucursal.ValueMember = "idNivel2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "nivel2";
            // 
            // FormAlmacenNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNombreAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLevel3);
            this.Controls.Add(this.panelLevel2);
            this.Controls.Add(this.textDirecionAlmacen);
            this.Controls.Add(this.panelLevel1);
            this.Controls.Add(this.panelLevelPais);
            this.Controls.Add(this.progressBarApp);
            this.Controls.Add(this.btnSucursalNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkActivoAlmacen);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkPrincipalAlmacen);
            this.Controls.Add(this.panelFooter);
            this.Name = "FormAlmacenNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Almacén";
            this.Load += new System.EventHandler(this.FormAlmacenNuevo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAlmacenNuevo_Paint);
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelLevel3.ResumeLayout(false);
            this.panelLevel3.PerformLayout();
            this.panelLevel2.ResumeLayout(false);
            this.panelLevel2.PerformLayout();
            this.panelLevel1.ResumeLayout(false);
            this.panelLevel1.PerformLayout();
            this.panelLevelPais.ResumeLayout(false);
            this.panelLevelPais.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSucursalNuevo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoAlmacen;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuCheckbox chkPrincipalAlmacen;
        private System.Windows.Forms.BindingSource nivel4BindingSource;
        private System.Windows.Forms.BindingSource nivel3BindingSource;
        private System.Windows.Forms.BindingSource nivel2BindingSource;
        private System.Windows.Forms.BindingSource nivel1BindingSource;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        protected System.Windows.Forms.ProgressBar progressBarApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLevel3;
        private System.Windows.Forms.ComboBox cbxNivel3;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.Panel panelLevel2;
        private System.Windows.Forms.ComboBox cbxNivel2;
        private System.Windows.Forms.Label lblNivel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textDirecionAlmacen;
        private System.Windows.Forms.Panel panelLevel1;
        private System.Windows.Forms.ComboBox cbxNivel1;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Panel panelLevelPais;
        private System.Windows.Forms.ComboBox cbxPaises;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreAlmacen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.Label label2;
    }
}