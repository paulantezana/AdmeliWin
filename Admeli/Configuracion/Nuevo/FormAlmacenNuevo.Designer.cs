namespace Admeli.Configuracion.Nuevo
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.btnSucursalNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivoAlmacen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkPrincipalAlmacen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNivel4 = new System.Windows.Forms.ComboBox();
            this.nivel4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNivel4 = new System.Windows.Forms.Label();
            this.cbxNivel3 = new System.Windows.Forms.ComboBox();
            this.nivel3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.cbxNivel2 = new System.Windows.Forms.ComboBox();
            this.nivel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.cbxNivel1 = new System.Windows.Forms.ComboBox();
            this.nivel1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreAlmacen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textDirecionAlmacen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivel4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 357);
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
            this.panel1.Size = new System.Drawing.Size(402, 48);
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
            this.btnAceptar.Location = new System.Drawing.Point(58, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 36);
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
            this.btnClose.Location = new System.Drawing.Point(230, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(720, 42);
            this.panelHeader.TabIndex = 30;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mantenimiento Almacén";
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
            this.progressBarApp.Size = new System.Drawing.Size(720, 3);
            this.progressBarApp.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarApp.TabIndex = 83;
            // 
            // btnSucursalNuevo
            // 
            this.btnSucursalNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSucursalNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatAppearance.BorderSize = 0;
            this.btnSucursalNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(59)))));
            this.btnSucursalNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursalNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursalNuevo.ForeColor = System.Drawing.Color.White;
            this.btnSucursalNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnSucursalNuevo.Image")));
            this.btnSucursalNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSucursalNuevo.Location = new System.Drawing.Point(236, 80);
            this.btnSucursalNuevo.Name = "btnSucursalNuevo";
            this.btnSucursalNuevo.Size = new System.Drawing.Size(40, 24);
            this.btnSucursalNuevo.TabIndex = 104;
            this.btnSucursalNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSucursalNuevo.UseVisualStyleBackColor = false;
            this.btnSucursalNuevo.Click += new System.EventHandler(this.btnSucursalNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(171, 194);
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
            this.chkActivoAlmacen.Location = new System.Drawing.Point(146, 192);
            this.chkActivoAlmacen.Name = "chkActivoAlmacen";
            this.chkActivoAlmacen.Size = new System.Drawing.Size(20, 20);
            this.chkActivoAlmacen.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label16.Location = new System.Drawing.Point(44, 192);
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
            this.chkPrincipalAlmacen.Location = new System.Drawing.Point(19, 190);
            this.chkPrincipalAlmacen.Name = "chkPrincipalAlmacen";
            this.chkPrincipalAlmacen.Size = new System.Drawing.Size(20, 20);
            this.chkPrincipalAlmacen.TabIndex = 100;
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.DataSource = this.sucursalBindingSource;
            this.cbxSucursal.DisplayMember = "nombre";
            this.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(19, 80);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(217, 24);
            this.cbxSucursal.TabIndex = 99;
            this.cbxSucursal.ValueMember = "idSucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Sucursal :";
            // 
            // cbxNivel4
            // 
            this.cbxNivel4.DataSource = this.nivel4BindingSource;
            this.cbxNivel4.DisplayMember = "nombre";
            this.cbxNivel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel4.FormattingEnabled = true;
            this.cbxNivel4.Location = new System.Drawing.Point(541, 309);
            this.cbxNivel4.Name = "cbxNivel4";
            this.cbxNivel4.Size = new System.Drawing.Size(154, 24);
            this.cbxNivel4.TabIndex = 97;
            this.cbxNivel4.ValueMember = "idNivel4";
            this.cbxNivel4.Visible = false;
            // 
            // nivel4BindingSource
            // 
            this.nivel4BindingSource.DataSource = typeof(Entidad.Location.Nivel4);
            // 
            // lblNivel4
            // 
            this.lblNivel4.AutoSize = true;
            this.lblNivel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblNivel4.Location = new System.Drawing.Point(538, 290);
            this.lblNivel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel4.Name = "lblNivel4";
            this.lblNivel4.Size = new System.Drawing.Size(40, 16);
            this.lblNivel4.TabIndex = 96;
            this.lblNivel4.Text = "nivel4";
            this.lblNivel4.Visible = false;
            // 
            // cbxNivel3
            // 
            this.cbxNivel3.DataSource = this.nivel3BindingSource;
            this.cbxNivel3.DisplayMember = "nombre";
            this.cbxNivel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel3.FormattingEnabled = true;
            this.cbxNivel3.Location = new System.Drawing.Point(365, 309);
            this.cbxNivel3.Name = "cbxNivel3";
            this.cbxNivel3.Size = new System.Drawing.Size(160, 24);
            this.cbxNivel3.TabIndex = 95;
            this.cbxNivel3.ValueMember = "idNivel3";
            this.cbxNivel3.Visible = false;
            this.cbxNivel3.SelectedIndexChanged += new System.EventHandler(this.cbxNivel3_SelectedIndexChanged);
            // 
            // nivel3BindingSource
            // 
            this.nivel3BindingSource.DataSource = typeof(Entidad.Location.Nivel3);
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblNivel3.Location = new System.Drawing.Point(362, 290);
            this.lblNivel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(40, 16);
            this.lblNivel3.TabIndex = 94;
            this.lblNivel3.Text = "nivel3";
            this.lblNivel3.Visible = false;
            // 
            // cbxNivel2
            // 
            this.cbxNivel2.DataSource = this.nivel2BindingSource;
            this.cbxNivel2.DisplayMember = "nombre";
            this.cbxNivel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel2.FormattingEnabled = true;
            this.cbxNivel2.Location = new System.Drawing.Point(189, 309);
            this.cbxNivel2.Name = "cbxNivel2";
            this.cbxNivel2.Size = new System.Drawing.Size(160, 24);
            this.cbxNivel2.TabIndex = 93;
            this.cbxNivel2.ValueMember = "idNivel2";
            this.cbxNivel2.Visible = false;
            this.cbxNivel2.SelectedIndexChanged += new System.EventHandler(this.cbxNivel2_SelectedIndexChanged);
            // 
            // nivel2BindingSource
            // 
            this.nivel2BindingSource.DataSource = typeof(Entidad.Location.Nivel2);
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblNivel2.Location = new System.Drawing.Point(186, 290);
            this.lblNivel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(40, 16);
            this.lblNivel2.TabIndex = 92;
            this.lblNivel2.Text = "nivel2";
            this.lblNivel2.Visible = false;
            // 
            // cbxNivel1
            // 
            this.cbxNivel1.DataSource = this.nivel1BindingSource;
            this.cbxNivel1.DisplayMember = "nombre";
            this.cbxNivel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNivel1.FormattingEnabled = true;
            this.cbxNivel1.Location = new System.Drawing.Point(19, 309);
            this.cbxNivel1.Name = "cbxNivel1";
            this.cbxNivel1.Size = new System.Drawing.Size(154, 24);
            this.cbxNivel1.TabIndex = 91;
            this.cbxNivel1.ValueMember = "idNivel1";
            this.cbxNivel1.Visible = false;
            this.cbxNivel1.SelectedIndexChanged += new System.EventHandler(this.cbxNivel1_SelectedIndexChanged);
            // 
            // nivel1BindingSource
            // 
            this.nivel1BindingSource.DataSource = typeof(Entidad.Location.Nivel1);
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblNivel1.Location = new System.Drawing.Point(16, 290);
            this.lblNivel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(40, 16);
            this.lblNivel1.TabIndex = 90;
            this.lblNivel1.Text = "nivel1";
            this.lblNivel1.Visible = false;
            // 
            // cbxPaises
            // 
            this.cbxPaises.DataSource = this.paisBindingSource;
            this.cbxPaises.DisplayMember = "nombre";
            this.cbxPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Location = new System.Drawing.Point(19, 250);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(330, 24);
            this.cbxPaises.TabIndex = 89;
            this.cbxPaises.ValueMember = "idPais";
            this.cbxPaises.SelectedIndexChanged += new System.EventHandler(this.cbxPaises_SelectedIndexChanged);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(Entidad.Location.Pais);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nombres*";
            // 
            // textNombreAlmacen
            // 
            this.textNombreAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNombreAlmacen.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreAlmacen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNombreAlmacen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNombreAlmacen.BorderThickness = 1;
            this.textNombreAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombreAlmacen.isPassword = false;
            this.textNombreAlmacen.Location = new System.Drawing.Point(19, 135);
            this.textNombreAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreAlmacen.Name = "textNombreAlmacen";
            this.textNombreAlmacen.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNombreAlmacen.Size = new System.Drawing.Size(330, 35);
            this.textNombreAlmacen.TabIndex = 85;
            this.textNombreAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(16, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 86;
            this.label11.Text = "País";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label15.Location = new System.Drawing.Point(362, 115);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 88;
            this.label15.Text = "Dirección";
            // 
            // textDirecionAlmacen
            // 
            this.textDirecionAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textDirecionAlmacen.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textDirecionAlmacen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textDirecionAlmacen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textDirecionAlmacen.BorderThickness = 1;
            this.textDirecionAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDirecionAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDirecionAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDirecionAlmacen.isPassword = false;
            this.textDirecionAlmacen.Location = new System.Drawing.Point(365, 135);
            this.textDirecionAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.textDirecionAlmacen.Name = "textDirecionAlmacen";
            this.textDirecionAlmacen.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textDirecionAlmacen.Size = new System.Drawing.Size(330, 35);
            this.textDirecionAlmacen.TabIndex = 87;
            this.textDirecionAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Entidad.Sucursal);
            // 
            // FormAlmacenNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 406);
            this.Controls.Add(this.btnSucursalNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkActivoAlmacen);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkPrincipalAlmacen);
            this.Controls.Add(this.cbxSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNivel4);
            this.Controls.Add(this.lblNivel4);
            this.Controls.Add(this.cbxNivel3);
            this.Controls.Add(this.lblNivel3);
            this.Controls.Add(this.cbxNivel2);
            this.Controls.Add(this.lblNivel2);
            this.Controls.Add(this.cbxNivel1);
            this.Controls.Add(this.lblNivel1);
            this.Controls.Add(this.cbxPaises);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreAlmacen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textDirecionAlmacen);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.progressBarApp);
            this.Name = "FormAlmacenNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlmacenNuevo";
            this.Load += new System.EventHandler(this.FormAlmacenNuevo_Load);
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivel4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ProgressBar progressBarApp;
        private System.Windows.Forms.Button btnSucursalNuevo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoAlmacen;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuCheckbox chkPrincipalAlmacen;
        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNivel4;
        private System.Windows.Forms.Label lblNivel4;
        private System.Windows.Forms.ComboBox cbxNivel3;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.ComboBox cbxNivel2;
        private System.Windows.Forms.Label lblNivel2;
        private System.Windows.Forms.ComboBox cbxNivel1;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.ComboBox cbxPaises;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreAlmacen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox textDirecionAlmacen;
        private System.Windows.Forms.BindingSource nivel4BindingSource;
        private System.Windows.Forms.BindingSource nivel3BindingSource;
        private System.Windows.Forms.BindingSource nivel2BindingSource;
        private System.Windows.Forms.BindingSource nivel1BindingSource;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
    }
}