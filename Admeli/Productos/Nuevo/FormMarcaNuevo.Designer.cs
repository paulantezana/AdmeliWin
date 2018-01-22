namespace Admeli.Productos.Nuevo
{
    partial class FormMarcaNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarcaNuevo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textDescripcionMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.chkActivoMarca = new Bunifu.Framework.UI.BunifuCheckbox();
            this.textWebMarca = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textNombreMarca = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filder_icon.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textDescripcionMarca
            // 
            this.textDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcionMarca.Location = new System.Drawing.Point(19, 229);
            this.textDescripcionMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDescripcionMarca.Multiline = true;
            this.textDescripcionMarca.Name = "textDescripcionMarca";
            this.textDescripcionMarca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescripcionMarca.Size = new System.Drawing.Size(522, 115);
            this.textDescripcionMarca.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Si esta Desmarcado, no se mostrara esta marca en la página.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnAceptar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 428);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 70);
            this.panel5.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(309, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(137, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 45);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textDescripcionMarca);
            this.panel3.Controls.Add(this.chkActivoMarca);
            this.panel3.Controls.Add(this.textWebMarca);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textNombreMarca);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 498);
            this.panel3.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(44, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Activo";
            // 
            // chkActivoMarca
            // 
            this.chkActivoMarca.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoMarca.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivoMarca.Checked = true;
            this.chkActivoMarca.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoMarca.ForeColor = System.Drawing.Color.White;
            this.chkActivoMarca.Location = new System.Drawing.Point(19, 360);
            this.chkActivoMarca.Name = "chkActivoMarca";
            this.chkActivoMarca.Size = new System.Drawing.Size(20, 20);
            this.chkActivoMarca.TabIndex = 15;
            // 
            // textWebMarca
            // 
            this.textWebMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textWebMarca.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textWebMarca.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textWebMarca.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textWebMarca.BorderThickness = 1;
            this.textWebMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textWebMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWebMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textWebMarca.isPassword = false;
            this.textWebMarca.Location = new System.Drawing.Point(19, 153);
            this.textWebMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textWebMarca.Name = "textWebMarca";
            this.textWebMarca.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textWebMarca.Size = new System.Drawing.Size(522, 35);
            this.textWebMarca.TabIndex = 1;
            this.textWebMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label21.Location = new System.Drawing.Point(16, 135);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Sitio Web:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 42);
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
            this.label8.Size = new System.Drawing.Size(167, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mantenimiento de marca";
            // 
            // textNombreMarca
            // 
            this.textNombreMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNombreMarca.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreMarca.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNombreMarca.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNombreMarca.BorderThickness = 1;
            this.textNombreMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombreMarca.isPassword = false;
            this.textNombreMarca.Location = new System.Drawing.Point(19, 80);
            this.textNombreMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreMarca.Name = "textNombreMarca";
            this.textNombreMarca.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNombreMarca.Size = new System.Drawing.Size(522, 35);
            this.textNombreMarca.TabIndex = 0;
            this.textNombreMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label22.Location = new System.Drawing.Point(16, 62);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Nombre Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(16, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descripción:";
            // 
            // FormMarcaNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(558, 498);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMarcaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMarcaNuevo";
            this.Load += new System.EventHandler(this.FormMarcaNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescripcionMarca;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoMarca;
        private Bunifu.Framework.UI.BunifuMetroTextbox textWebMarca;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreMarca;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
    }
}