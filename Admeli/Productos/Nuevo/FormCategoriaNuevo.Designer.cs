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
            this.chkActivoCat = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbxCatPadre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMostrarEn = new System.Windows.Forms.ComboBox();
            this.cbxOrdenVisual = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNombreCat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumeroColumna = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.textTituloCat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.textUrlCat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTagCat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textCabeceraTag = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.textOrden = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.textPieCat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkMostrarWeb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filder_icon.png");
            // 
            // chkActivoCat
            // 
            this.chkActivoCat.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoCat.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivoCat.Checked = true;
            this.chkActivoCat.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoCat.ForeColor = System.Drawing.Color.White;
            this.chkActivoCat.Location = new System.Drawing.Point(380, 98);
            this.chkActivoCat.Name = "chkActivoCat";
            this.chkActivoCat.Size = new System.Drawing.Size(20, 20);
            this.chkActivoCat.TabIndex = 2;
            // 
            // cbxCatPadre
            // 
            this.cbxCatPadre.DropDownHeight = 107;
            this.cbxCatPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCatPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatPadre.FormattingEnabled = true;
            this.cbxCatPadre.IntegralHeight = false;
            this.cbxCatPadre.Location = new System.Drawing.Point(20, 159);
            this.cbxCatPadre.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCatPadre.Name = "cbxCatPadre";
            this.cbxCatPadre.Size = new System.Drawing.Size(328, 23);
            this.cbxCatPadre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Categoría *";
            // 
            // cbxMostrarEn
            // 
            this.cbxMostrarEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMostrarEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMostrarEn.FormattingEnabled = true;
            this.cbxMostrarEn.Location = new System.Drawing.Point(380, 371);
            this.cbxMostrarEn.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMostrarEn.Name = "cbxMostrarEn";
            this.cbxMostrarEn.Size = new System.Drawing.Size(328, 23);
            this.cbxMostrarEn.TabIndex = 20;
            // 
            // cbxOrdenVisual
            // 
            this.cbxOrdenVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrdenVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrdenVisual.FormattingEnabled = true;
            this.cbxOrdenVisual.Location = new System.Drawing.Point(19, 371);
            this.cbxOrdenVisual.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrdenVisual.Name = "cbxOrdenVisual";
            this.cbxOrdenVisual.Size = new System.Drawing.Size(328, 23);
            this.cbxOrdenVisual.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cbxCatPadre);
            this.panel1.Controls.Add(this.chkActivoCat);
            this.panel1.Controls.Add(this.textNombreCat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 216);
            this.panel1.TabIndex = 2;
            // 
            // textNombreCat
            // 
            this.textNombreCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNombreCat.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreCat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNombreCat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNombreCat.BorderThickness = 1;
            this.textNombreCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombreCat.isPassword = false;
            this.textNombreCat.Location = new System.Drawing.Point(19, 92);
            this.textNombreCat.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreCat.Name = "textNombreCat";
            this.textNombreCat.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNombreCat.Size = new System.Drawing.Size(328, 35);
            this.textNombreCat.TabIndex = 1;
            this.textNombreCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label19.Location = new System.Drawing.Point(17, 141);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Categoría Padre *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(405, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Activo *";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 42);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mantenimiento Categoría";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.chkMostrarWeb);
            this.panel3.Controls.Add(this.cbxMostrarEn);
            this.panel3.Controls.Add(this.textOrden);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textPieCat);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbxOrdenVisual);
            this.panel3.Controls.Add(this.textCabeceraTag);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textTagCat);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textUrlCat);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.textTituloCat);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textNumeroColumna);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 495);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 42);
            this.panel4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mantenimiento Categoría (Opcionales)";
            // 
            // textNumeroColumna
            // 
            this.textNumeroColumna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNumeroColumna.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNumeroColumna.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNumeroColumna.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNumeroColumna.BorderThickness = 1;
            this.textNumeroColumna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNumeroColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroColumna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNumeroColumna.isPassword = false;
            this.textNumeroColumna.Location = new System.Drawing.Point(19, 80);
            this.textNumeroColumna.Margin = new System.Windows.Forms.Padding(4);
            this.textNumeroColumna.Name = "textNumeroColumna";
            this.textNumeroColumna.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNumeroColumna.Size = new System.Drawing.Size(328, 35);
            this.textNumeroColumna.TabIndex = 1;
            this.textNumeroColumna.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textNumeroColumna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumeroColumna_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label22.Location = new System.Drawing.Point(16, 62);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Número Columnas";
            // 
            // textTituloCat
            // 
            this.textTituloCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textTituloCat.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textTituloCat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textTituloCat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textTituloCat.BorderThickness = 1;
            this.textTituloCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTituloCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textTituloCat.isPassword = false;
            this.textTituloCat.Location = new System.Drawing.Point(380, 80);
            this.textTituloCat.Margin = new System.Windows.Forms.Padding(4);
            this.textTituloCat.Name = "textTituloCat";
            this.textTituloCat.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textTituloCat.Size = new System.Drawing.Size(328, 35);
            this.textTituloCat.TabIndex = 3;
            this.textTituloCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label20.Location = new System.Drawing.Point(377, 62);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Título Categoría Seo";
            // 
            // textUrlCat
            // 
            this.textUrlCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textUrlCat.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textUrlCat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textUrlCat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textUrlCat.BorderThickness = 1;
            this.textUrlCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUrlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrlCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUrlCat.isPassword = false;
            this.textUrlCat.Location = new System.Drawing.Point(19, 153);
            this.textUrlCat.Margin = new System.Windows.Forms.Padding(4);
            this.textUrlCat.Name = "textUrlCat";
            this.textUrlCat.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textUrlCat.Size = new System.Drawing.Size(328, 35);
            this.textUrlCat.TabIndex = 5;
            this.textUrlCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label21.Location = new System.Drawing.Point(16, 135);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Url Categoría Seo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(377, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Meta Tags Seo:";
            // 
            // textTagCat
            // 
            this.textTagCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textTagCat.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textTagCat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textTagCat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textTagCat.BorderThickness = 1;
            this.textTagCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTagCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTagCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textTagCat.isPassword = false;
            this.textTagCat.Location = new System.Drawing.Point(380, 153);
            this.textTagCat.Margin = new System.Windows.Forms.Padding(4);
            this.textTagCat.Name = "textTagCat";
            this.textTagCat.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textTagCat.Size = new System.Drawing.Size(328, 35);
            this.textTagCat.TabIndex = 8;
            this.textTagCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textCabeceraTag
            // 
            this.textCabeceraTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textCabeceraTag.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textCabeceraTag.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textCabeceraTag.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textCabeceraTag.BorderThickness = 1;
            this.textCabeceraTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCabeceraTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCabeceraTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCabeceraTag.isPassword = false;
            this.textCabeceraTag.Location = new System.Drawing.Point(19, 232);
            this.textCabeceraTag.Margin = new System.Windows.Forms.Padding(4);
            this.textCabeceraTag.Name = "textCabeceraTag";
            this.textCabeceraTag.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textCabeceraTag.Size = new System.Drawing.Size(328, 35);
            this.textCabeceraTag.TabIndex = 10;
            this.textCabeceraTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(16, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cabecera Página";
            // 
            // textOrden
            // 
            this.textOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textOrden.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textOrden.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textOrden.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textOrden.BorderThickness = 1;
            this.textOrden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textOrden.isPassword = false;
            this.textOrden.Location = new System.Drawing.Point(19, 304);
            this.textOrden.Margin = new System.Windows.Forms.Padding(4);
            this.textOrden.Name = "textOrden";
            this.textOrden.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textOrden.Size = new System.Drawing.Size(328, 35);
            this.textOrden.TabIndex = 14;
            this.textOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textOrden_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(16, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Orden:";
            // 
            // textPieCat
            // 
            this.textPieCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textPieCat.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textPieCat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textPieCat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textPieCat.BorderThickness = 1;
            this.textPieCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPieCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPieCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPieCat.isPassword = false;
            this.textPieCat.Location = new System.Drawing.Point(380, 232);
            this.textPieCat.Margin = new System.Windows.Forms.Padding(4);
            this.textPieCat.Name = "textPieCat";
            this.textPieCat.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textPieCat.Size = new System.Drawing.Size(328, 35);
            this.textPieCat.TabIndex = 12;
            this.textPieCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label10.Location = new System.Drawing.Point(377, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pie Página";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(405, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mostrar web";
            // 
            // chkMostrarWeb
            // 
            this.chkMostrarWeb.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkMostrarWeb.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMostrarWeb.Checked = true;
            this.chkMostrarWeb.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkMostrarWeb.ForeColor = System.Drawing.Color.White;
            this.chkMostrarWeb.Location = new System.Drawing.Point(380, 312);
            this.chkMostrarWeb.Name = "chkMostrarWeb";
            this.chkMostrarWeb.Size = new System.Drawing.Size(20, 20);
            this.chkMostrarWeb.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label15.Location = new System.Drawing.Point(17, 350);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Orden Visualización Productos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label16.Location = new System.Drawing.Point(377, 353);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Mostrar Productos En:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnAceptar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 641);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 70);
            this.panel5.TabIndex = 4;
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
            this.btnAceptar.Location = new System.Drawing.Point(223, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 45);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Location = new System.Drawing.Point(395, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCategoriaNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(730, 711);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategoriaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoriaNuevo";
            this.Load += new System.EventHandler(this.FormCategoriaNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbxCatPadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMostrarEn;
        private System.Windows.Forms.ComboBox cbxOrdenVisual;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoCat;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreCat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNumeroColumna;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuMetroTextbox textUrlCat;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTituloCat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textTagCat;
        private Bunifu.Framework.UI.BunifuMetroTextbox textCabeceraTag;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox textOrden;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox textPieCat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox chkMostrarWeb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
    }
}