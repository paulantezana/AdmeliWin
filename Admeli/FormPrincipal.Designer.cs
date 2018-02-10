namespace Admeli
{
    partial class FormPrincipal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelAside = new System.Windows.Forms.Panel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombrePersonal2 = new System.Windows.Forms.Label();
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeaderApp = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMaximizedApp = new System.Windows.Forms.Button();
            this.btnMinimizedApp = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelAsideMain = new System.Windows.Forms.Panel();
            this.panelAside.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelHeaderApp.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(209)))), ((int)(((byte)(79)))));
            this.transition1.SetDecoration(this.panelFooter, BunifuAnimatorNS.DecorationType.None);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 354);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(907, 10);
            this.panelFooter.TabIndex = 3;
            this.panelFooter.Visible = false;
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(237)))));
            this.panelAside.Controls.Add(this.panelAsideMain);
            this.panelAside.Controls.Add(this.panel2);
            this.transition1.SetDecoration(this.panelAside, BunifuAnimatorNS.DecorationType.None);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAside.Location = new System.Drawing.Point(0, 0);
            this.panelAside.Margin = new System.Windows.Forms.Padding(2);
            this.panelAside.Name = "panelAside";
            this.panelAside.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelAside.Size = new System.Drawing.Size(907, 150);
            this.panelAside.TabIndex = 4;
            this.panelAside.Visible = false;
            this.panelAside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAside_Paint);
            // 
            // btnCompras
            // 
            this.transition1.SetDecoration(this.btnCompras, BunifuAnimatorNS.DecorationType.None);
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(0, 5);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(87, 30);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnCompras, "Compra");
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.transition1.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(522, 5);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(87, 30);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnVentas, "Venta");
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCaja
            // 
            this.transition1.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Location = new System.Drawing.Point(435, 5);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(87, 30);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnCaja, "Caja");
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlmacen
            // 
            this.transition1.SetDecoration(this.btnAlmacen, BunifuAnimatorNS.DecorationType.None);
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.Location = new System.Drawing.Point(348, 5);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(87, 30);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAlmacen, "Almacen");
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnProducto
            // 
            this.transition1.SetDecoration(this.btnProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(261, 5);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(87, 30);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnProducto, "Producto");
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnConfiguracion
            // 
            this.transition1.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Location = new System.Drawing.Point(174, 5);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(87, 30);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnConfiguracion, "Configuracion");
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnHerramientas
            // 
            this.transition1.SetDecoration(this.btnHerramientas, BunifuAnimatorNS.DecorationType.None);
            this.btnHerramientas.FlatAppearance.BorderSize = 0;
            this.btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerramientas.ForeColor = System.Drawing.Color.White;
            this.btnHerramientas.Location = new System.Drawing.Point(87, 5);
            this.btnHerramientas.Margin = new System.Windows.Forms.Padding(0);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(87, 30);
            this.btnHerramientas.TabIndex = 7;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnHerramientas, "Herramientas");
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Controls.Add(this.panelMain);
            this.panelMainContainer.Controls.Add(this.progressBarApp);
            this.transition1.SetDecoration(this.panelMainContainer, BunifuAnimatorNS.DecorationType.None);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 150);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(907, 204);
            this.panelMainContainer.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.transition1.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(907, 201);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(252, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 210);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "punto de venta y tienda en linea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(58, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "admeli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back_icon.png");
            this.imageList1.Images.SetKeyName(1, "next_icon.png");
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(28, 0);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(27, 28);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrarSesion, "Cerrar sesión");
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Foto Usuario");
            // 
            // lblNombrePersonal2
            // 
            this.lblNombrePersonal2.AutoSize = true;
            this.transition1.SetDecoration(this.lblNombrePersonal2, BunifuAnimatorNS.DecorationType.None);
            this.lblNombrePersonal2.ForeColor = System.Drawing.Color.White;
            this.lblNombrePersonal2.Location = new System.Drawing.Point(94, 9);
            this.lblNombrePersonal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombrePersonal2.Name = "lblNombrePersonal2";
            this.lblNombrePersonal2.Size = new System.Drawing.Size(35, 13);
            this.lblNombrePersonal2.TabIndex = 0;
            this.lblNombrePersonal2.Text = "label9";
            this.toolTip1.SetToolTip(this.lblNombrePersonal2, "Nombre usuario");
            // 
            // progressBarApp
            // 
            this.progressBarApp.BackColor = System.Drawing.Color.White;
            this.transition1.SetDecoration(this.progressBarApp, BunifuAnimatorNS.DecorationType.None);
            this.progressBarApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarApp.Location = new System.Drawing.Point(0, 201);
            this.progressBarApp.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarApp.MarqueeAnimationSpeed = 10;
            this.progressBarApp.Maximum = 200;
            this.progressBarApp.Name = "progressBarApp";
            this.progressBarApp.RightToLeftLayout = true;
            this.progressBarApp.Size = new System.Drawing.Size(907, 3);
            this.progressBarApp.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarApp.TabIndex = 0;
            // 
            // transition1
            // 
            this.transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition1.DefaultAnimation = animation1;
            this.transition1.TimeStep = 0.03F;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Admeli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panelHeaderApp);
            this.panel2.Controls.Add(this.panel4);
            this.transition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 65);
            this.panel2.TabIndex = 0;
            // 
            // panelHeaderApp
            // 
            this.panelHeaderApp.Controls.Add(this.btnMinimizedApp);
            this.panelHeaderApp.Controls.Add(this.btnMaximizedApp);
            this.panelHeaderApp.Controls.Add(this.btnCloseApp);
            this.transition1.SetDecoration(this.panelHeaderApp, BunifuAnimatorNS.DecorationType.None);
            this.panelHeaderApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderApp.Location = new System.Drawing.Point(59, 0);
            this.panelHeaderApp.Name = "panelHeaderApp";
            this.panelHeaderApp.Size = new System.Drawing.Size(848, 30);
            this.panelHeaderApp.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHome);
            this.transition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(59, 65);
            this.panel4.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition1.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 65);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHome, "Menu Principal");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblNombrePersonal2);
            this.panel6.Controls.Add(this.btnCerrarSesion);
            this.panel6.Controls.Add(this.pictureBox2);
            this.transition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(745, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 35);
            this.panel6.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCompras);
            this.flowLayoutPanel2.Controls.Add(this.btnHerramientas);
            this.flowLayoutPanel2.Controls.Add(this.btnConfiguracion);
            this.flowLayoutPanel2.Controls.Add(this.btnProducto);
            this.flowLayoutPanel2.Controls.Add(this.btnAlmacen);
            this.flowLayoutPanel2.Controls.Add(this.btnCaja);
            this.flowLayoutPanel2.Controls.Add(this.btnVentas);
            this.transition1.SetDecoration(this.flowLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(59, 30);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(686, 35);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // btnCloseApp
            // 
            this.transition1.SetDecoration(this.btnCloseApp, BunifuAnimatorNS.DecorationType.None);
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(812, 0);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(36, 30);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnMaximizedApp
            // 
            this.transition1.SetDecoration(this.btnMaximizedApp, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizedApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizedApp.FlatAppearance.BorderSize = 0;
            this.btnMaximizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizedApp.ForeColor = System.Drawing.Color.White;
            this.btnMaximizedApp.Location = new System.Drawing.Point(776, 0);
            this.btnMaximizedApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizedApp.Name = "btnMaximizedApp";
            this.btnMaximizedApp.Size = new System.Drawing.Size(36, 30);
            this.btnMaximizedApp.TabIndex = 3;
            this.btnMaximizedApp.Text = "O";
            this.btnMaximizedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaximizedApp.UseVisualStyleBackColor = true;
            this.btnMaximizedApp.Click += new System.EventHandler(this.btnMaximizedApp_Click);
            // 
            // btnMinimizedApp
            // 
            this.transition1.SetDecoration(this.btnMinimizedApp, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizedApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizedApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizedApp.ForeColor = System.Drawing.Color.White;
            this.btnMinimizedApp.Location = new System.Drawing.Point(740, 0);
            this.btnMinimizedApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizedApp.Name = "btnMinimizedApp";
            this.btnMinimizedApp.Size = new System.Drawing.Size(36, 30);
            this.btnMinimizedApp.TabIndex = 4;
            this.btnMinimizedApp.Text = "-";
            this.btnMinimizedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimizedApp.UseVisualStyleBackColor = true;
            this.btnMinimizedApp.Click += new System.EventHandler(this.btnMinimizedApp_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeaderApp;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelAsideMain
            // 
            this.panelAsideMain.BackColor = System.Drawing.Color.White;
            this.transition1.SetDecoration(this.panelAsideMain, BunifuAnimatorNS.DecorationType.None);
            this.panelAsideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAsideMain.Location = new System.Drawing.Point(0, 65);
            this.panelAsideMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelAsideMain.Name = "panelAsideMain";
            this.panelAsideMain.Size = new System.Drawing.Size(907, 84);
            this.panelAsideMain.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(907, 364);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.panelFooter);
            this.transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admeli 0.0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelAside.ResumeLayout(false);
            this.panelMainContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelHeaderApp.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelMainContainer;
        public System.Windows.Forms.Panel panelMain;
        protected System.Windows.Forms.ProgressBar progressBarApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombrePersonal2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.ImageList imageList1;
        private BunifuAnimatorNS.BunifuTransition transition1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelHeaderApp;
        private System.Windows.Forms.Button btnMinimizedApp;
        private System.Windows.Forms.Button btnMaximizedApp;
        private System.Windows.Forms.Button btnCloseApp;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        internal System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelAsideMain;
    }
}