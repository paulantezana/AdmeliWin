namespace Admeli.Productos.Nuevo
{
    partial class FormProductoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductoNuevo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGenerales = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textSimboloUM = new System.Windows.Forms.TextBox();
            this.textNombreUM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActivoUM = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripCrud = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabAdicionales = new System.Windows.Forms.TabPage();
            this.tabImpuestos = new System.Windows.Forms.TabPage();
            this.tabDescuentos = new System.Windows.Forms.TabPage();
            this.tabTiendaOnline = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCatPadre = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabGenerales.SuspendLayout();
            this.toolStripCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenerales);
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabAdicionales);
            this.tabControl1.Controls.Add(this.tabImpuestos);
            this.tabControl1.Controls.Add(this.tabDescuentos);
            this.tabControl1.Controls.Add(this.tabTiendaOnline);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 557);
            this.tabControl1.TabIndex = 5;
            // 
            // tabGenerales
            // 
            this.tabGenerales.Controls.Add(this.button1);
            this.tabGenerales.Controls.Add(this.comboBox1);
            this.tabGenerales.Controls.Add(this.cbxCatPadre);
            this.tabGenerales.Controls.Add(this.textBox3);
            this.tabGenerales.Controls.Add(this.label7);
            this.tabGenerales.Controls.Add(this.textBox2);
            this.tabGenerales.Controls.Add(this.label6);
            this.tabGenerales.Controls.Add(this.textBox1);
            this.tabGenerales.Controls.Add(this.label5);
            this.tabGenerales.Controls.Add(this.label4);
            this.tabGenerales.Controls.Add(this.textSimboloUM);
            this.tabGenerales.Controls.Add(this.textNombreUM);
            this.tabGenerales.Controls.Add(this.label2);
            this.tabGenerales.Controls.Add(this.chkActivoUM);
            this.tabGenerales.Controls.Add(this.label3);
            this.tabGenerales.ImageIndex = 0;
            this.tabGenerales.Location = new System.Drawing.Point(4, 39);
            this.tabGenerales.Name = "tabGenerales";
            this.tabGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerales.Size = new System.Drawing.Size(890, 514);
            this.tabGenerales.TabIndex = 0;
            this.tabGenerales.Text = "Datos Generales";
            this.tabGenerales.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Si está desmarcado, no se podrá hacer operaciones con esta Unidad de Medida.";
            // 
            // textSimboloUM
            // 
            this.textSimboloUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSimboloUM.Location = new System.Drawing.Point(155, 321);
            this.textSimboloUM.Name = "textSimboloUM";
            this.textSimboloUM.Size = new System.Drawing.Size(172, 24);
            this.textSimboloUM.TabIndex = 3;
            // 
            // textNombreUM
            // 
            this.textNombreUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreUM.Location = new System.Drawing.Point(155, 27);
            this.textNombreUM.Name = "textNombreUM";
            this.textNombreUM.Size = new System.Drawing.Size(595, 24);
            this.textNombreUM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Unidad:";
            // 
            // chkActivoUM
            // 
            this.chkActivoUM.AutoSize = true;
            this.chkActivoUM.Location = new System.Drawing.Point(155, 363);
            this.chkActivoUM.Name = "chkActivoUM";
            this.chkActivoUM.Size = new System.Drawing.Size(68, 21);
            this.chkActivoUM.TabIndex = 5;
            this.chkActivoUM.Text = "Activo";
            this.chkActivoUM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Símbolo:";
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
            this.toolStripCrud.Location = new System.Drawing.Point(0, 557);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripCrud.Size = new System.Drawing.Size(898, 55);
            this.toolStripCrud.TabIndex = 4;
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
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filder_icon.png");
            // 
            // tabStock
            // 
            this.tabStock.ImageIndex = 0;
            this.tabStock.Location = new System.Drawing.Point(4, 39);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(1216, 514);
            this.tabStock.TabIndex = 1;
            this.tabStock.Text = "Precio-Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // tabAdicionales
            // 
            this.tabAdicionales.ImageIndex = 0;
            this.tabAdicionales.Location = new System.Drawing.Point(4, 39);
            this.tabAdicionales.Name = "tabAdicionales";
            this.tabAdicionales.Size = new System.Drawing.Size(1216, 514);
            this.tabAdicionales.TabIndex = 2;
            this.tabAdicionales.Text = "Adicionales";
            this.tabAdicionales.UseVisualStyleBackColor = true;
            // 
            // tabImpuestos
            // 
            this.tabImpuestos.ImageIndex = 0;
            this.tabImpuestos.Location = new System.Drawing.Point(4, 39);
            this.tabImpuestos.Name = "tabImpuestos";
            this.tabImpuestos.Size = new System.Drawing.Size(1216, 514);
            this.tabImpuestos.TabIndex = 3;
            this.tabImpuestos.Text = "Impuestos";
            this.tabImpuestos.UseVisualStyleBackColor = true;
            // 
            // tabDescuentos
            // 
            this.tabDescuentos.ImageIndex = 0;
            this.tabDescuentos.Location = new System.Drawing.Point(4, 39);
            this.tabDescuentos.Name = "tabDescuentos";
            this.tabDescuentos.Size = new System.Drawing.Size(1216, 514);
            this.tabDescuentos.TabIndex = 4;
            this.tabDescuentos.Text = "Descuentos y Ofertas";
            this.tabDescuentos.UseVisualStyleBackColor = true;
            // 
            // tabTiendaOnline
            // 
            this.tabTiendaOnline.ImageIndex = 0;
            this.tabTiendaOnline.Location = new System.Drawing.Point(4, 39);
            this.tabTiendaOnline.Name = "tabTiendaOnline";
            this.tabTiendaOnline.Size = new System.Drawing.Size(1216, 514);
            this.tabTiendaOnline.TabIndex = 5;
            this.tabTiendaOnline.Text = "Tienda online";
            this.tabTiendaOnline.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 24);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre Unidad:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(155, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(595, 24);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre Unidad:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(155, 147);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(595, 157);
            this.textBox3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre Unidad:";
            // 
            // cbxCatPadre
            // 
            this.cbxCatPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatPadre.FormattingEnabled = true;
            this.cbxCatPadre.Location = new System.Drawing.Point(155, 399);
            this.cbxCatPadre.Name = "cbxCatPadre";
            this.cbxCatPadre.Size = new System.Drawing.Size(247, 26);
            this.cbxCatPadre.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 446);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormProductoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripCrud);
            this.Name = "FormProductoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductoNuevo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabGenerales.ResumeLayout(false);
            this.tabGenerales.PerformLayout();
            this.toolStripCrud.ResumeLayout(false);
            this.toolStripCrud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGenerales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSimboloUM;
        private System.Windows.Forms.TextBox textNombreUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActivoUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStripCrud;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabAdicionales;
        private System.Windows.Forms.TabPage tabImpuestos;
        private System.Windows.Forms.TabPage tabDescuentos;
        private System.Windows.Forms.TabPage tabTiendaOnline;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCatPadre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}