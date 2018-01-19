namespace Admeli.Productos.Nuevo
{
    partial class FormCategoriaNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaNuevo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripCrud = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreCat = new System.Windows.Forms.TextBox();
            this.cbxCatPadre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActivoCat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMostrarEn = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkMostrarWeb = new System.Windows.Forms.CheckBox();
            this.textPieCat = new System.Windows.Forms.TextBox();
            this.textCabeceraTag = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textOrden = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textTagCat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textUrlCat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTituloCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxOrdenVisual = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNumeroColumna = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripCrud.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filder_icon.png");
            // 
            // toolStripCrud
            // 
            this.toolStripCrud.AutoSize = false;
            this.toolStripCrud.BackColor = System.Drawing.Color.White;
            this.toolStripCrud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripCrud.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripCrud.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCrud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnClose});
            this.toolStripCrud.Location = new System.Drawing.Point(0, 532);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripCrud.Size = new System.Drawing.Size(1263, 55);
            this.toolStripCrud.TabIndex = 0;
            this.toolStripCrud.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnGuardar.Text = "Guardar y salir";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.ToolTipText = "Guardar registro (Enter)";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 37);
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.ToolTipText = "Cerrar ventan";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 532);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textNombreCat);
            this.tabPage1.Controls.Add(this.cbxCatPadre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkActivoCat);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1255, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento Categoría";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Si está desmarcado, no se podrá hacer operaciones con esta categoría.";
            // 
            // textNombreCat
            // 
            this.textNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreCat.Location = new System.Drawing.Point(157, 23);
            this.textNombreCat.Name = "textNombreCat";
            this.textNombreCat.Size = new System.Drawing.Size(248, 24);
            this.textNombreCat.TabIndex = 1;
            // 
            // cbxCatPadre
            // 
            this.cbxCatPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatPadre.FormattingEnabled = true;
            this.cbxCatPadre.Location = new System.Drawing.Point(158, 89);
            this.cbxCatPadre.Name = "cbxCatPadre";
            this.cbxCatPadre.Size = new System.Drawing.Size(247, 26);
            this.cbxCatPadre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Categoría:";
            // 
            // chkActivoCat
            // 
            this.chkActivoCat.AutoSize = true;
            this.chkActivoCat.Location = new System.Drawing.Point(157, 59);
            this.chkActivoCat.Name = "chkActivoCat";
            this.chkActivoCat.Size = new System.Drawing.Size(68, 21);
            this.chkActivoCat.TabIndex = 2;
            this.chkActivoCat.Text = "Activo";
            this.chkActivoCat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría Padre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbxMostrarEn);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.chkMostrarWeb);
            this.tabPage2.Controls.Add(this.textPieCat);
            this.tabPage2.Controls.Add(this.textCabeceraTag);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textOrden);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textTagCat);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textUrlCat);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textTituloCat);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbxOrdenVisual);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textNumeroColumna);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1255, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos para mostrar en Web";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(788, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(375, 35);
            this.label18.TabIndex = 24;
            this.label18.Text = "Texto que aparecerá en el final de la página";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(158, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(375, 35);
            this.label17.TabIndex = 23;
            this.label17.Text = "Texto que aparecerá en la cabecera de la página";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(157, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(375, 35);
            this.label16.TabIndex = 22;
            this.label16.Text = "Texto que contiene los keywords y otras descripciones(Opcional).";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(162, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(375, 35);
            this.label15.TabIndex = 21;
            this.label15.Text = "Url de la Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mostrar Productos En:";
            // 
            // cbxMostrarEn
            // 
            this.cbxMostrarEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMostrarEn.FormattingEnabled = true;
            this.cbxMostrarEn.Location = new System.Drawing.Point(791, 322);
            this.cbxMostrarEn.Name = "cbxMostrarEn";
            this.cbxMostrarEn.Size = new System.Drawing.Size(210, 26);
            this.cbxMostrarEn.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(789, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(398, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Si está desmarcado, esta categoría no se mostrara en la web.";
            // 
            // chkMostrarWeb
            // 
            this.chkMostrarWeb.AutoSize = true;
            this.chkMostrarWeb.Location = new System.Drawing.Point(791, 219);
            this.chkMostrarWeb.Name = "chkMostrarWeb";
            this.chkMostrarWeb.Size = new System.Drawing.Size(111, 21);
            this.chkMostrarWeb.TabIndex = 14;
            this.chkMostrarWeb.Text = "Mostrar Web";
            this.chkMostrarWeb.UseVisualStyleBackColor = true;
            // 
            // textPieCat
            // 
            this.textPieCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPieCat.Location = new System.Drawing.Point(792, 36);
            this.textPieCat.Multiline = true;
            this.textPieCat.Name = "textPieCat";
            this.textPieCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPieCat.Size = new System.Drawing.Size(395, 78);
            this.textPieCat.TabIndex = 11;
            // 
            // textCabeceraTag
            // 
            this.textCabeceraTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCabeceraTag.Location = new System.Drawing.Point(161, 349);
            this.textCabeceraTag.Multiline = true;
            this.textCabeceraTag.Name = "textCabeceraTag";
            this.textCabeceraTag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCabeceraTag.Size = new System.Drawing.Size(369, 78);
            this.textCabeceraTag.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(724, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Orden:";
            // 
            // textOrden
            // 
            this.textOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrden.Location = new System.Drawing.Point(792, 179);
            this.textOrden.Name = "textOrden";
            this.textOrden.Size = new System.Drawing.Size(209, 24);
            this.textOrden.TabIndex = 13;
            this.textOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOrden_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(696, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Pie Página:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cabecera Página:";
            // 
            // textTagCat
            // 
            this.textTagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTagCat.Location = new System.Drawing.Point(161, 206);
            this.textTagCat.Multiline = true;
            this.textTagCat.Name = "textTagCat";
            this.textTagCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTagCat.Size = new System.Drawing.Size(369, 78);
            this.textTagCat.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Meta Tags Seo:";
            // 
            // textUrlCat
            // 
            this.textUrlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrlCat.Location = new System.Drawing.Point(160, 141);
            this.textUrlCat.Name = "textUrlCat";
            this.textUrlCat.Size = new System.Drawing.Size(369, 24);
            this.textUrlCat.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Url Categoría Seo:";
            // 
            // textTituloCat
            // 
            this.textTituloCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloCat.Location = new System.Drawing.Point(161, 76);
            this.textTituloCat.Name = "textTituloCat";
            this.textTituloCat.Size = new System.Drawing.Size(369, 24);
            this.textTituloCat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textTituloCat, "Título de la página de la Categoría");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Título Categoría Seo:";
            // 
            // cbxOrdenVisual
            // 
            this.cbxOrdenVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrdenVisual.FormattingEnabled = true;
            this.cbxOrdenVisual.Location = new System.Drawing.Point(791, 280);
            this.cbxOrdenVisual.Name = "cbxOrdenVisual";
            this.cbxOrdenVisual.Size = new System.Drawing.Size(210, 26);
            this.cbxOrdenVisual.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Orden Visualización Productos:";
            // 
            // textNumeroColumna
            // 
            this.textNumeroColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroColumna.Location = new System.Drawing.Point(160, 36);
            this.textNumeroColumna.Name = "textNumeroColumna";
            this.textNumeroColumna.Size = new System.Drawing.Size(147, 24);
            this.textNumeroColumna.TabIndex = 1;
            this.textNumeroColumna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroColumna_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número Columnas:";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCategoriaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripCrud);
            this.Name = "FormCategoriaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoriaNuevo";
            this.toolTip1.SetToolTip(this, "Título de la página de la Categoría");
            this.Load += new System.EventHandler(this.FormCategoriaNuevo_Load);
            this.toolStripCrud.ResumeLayout(false);
            this.toolStripCrud.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStripCrud;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreCat;
        private System.Windows.Forms.ComboBox cbxCatPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActivoCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxMostrarEn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkMostrarWeb;
        private System.Windows.Forms.TextBox textPieCat;
        private System.Windows.Forms.TextBox textCabeceraTag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textOrden;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTagCat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textUrlCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTituloCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxOrdenVisual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNumeroColumna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}