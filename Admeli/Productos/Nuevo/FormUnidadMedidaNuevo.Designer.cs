namespace Admeli.Productos.Nuevo
{
    partial class FormUnidadMedidaNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidadMedidaNuevo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.chkActivoUM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.textSimboloUM = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textNombreUM = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label22 = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Si está desmarcado, no se podrá hacer operaciones con esta Unidad de Medida.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Siglas únicas de la Unidad.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnAceptar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 462);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(576, 70);
            this.panel5.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(318, 13);
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
            this.btnAceptar.Location = new System.Drawing.Point(146, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 45);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.chkActivoUM);
            this.panel3.Controls.Add(this.textSimboloUM);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textNombreUM);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 532);
            this.panel3.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(44, 212);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Activo";
            // 
            // chkActivoUM
            // 
            this.chkActivoUM.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoUM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivoUM.Checked = true;
            this.chkActivoUM.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoUM.ForeColor = System.Drawing.Color.White;
            this.chkActivoUM.Location = new System.Drawing.Point(19, 210);
            this.chkActivoUM.Name = "chkActivoUM";
            this.chkActivoUM.Size = new System.Drawing.Size(20, 20);
            this.chkActivoUM.TabIndex = 2;
            // 
            // textSimboloUM
            // 
            this.textSimboloUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textSimboloUM.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textSimboloUM.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textSimboloUM.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textSimboloUM.BorderThickness = 1;
            this.textSimboloUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSimboloUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSimboloUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSimboloUM.isPassword = false;
            this.textSimboloUM.Location = new System.Drawing.Point(19, 153);
            this.textSimboloUM.Margin = new System.Windows.Forms.Padding(4);
            this.textSimboloUM.Name = "textSimboloUM";
            this.textSimboloUM.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textSimboloUM.Size = new System.Drawing.Size(125, 35);
            this.textSimboloUM.TabIndex = 1;
            this.textSimboloUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label21.Location = new System.Drawing.Point(16, 135);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Símbolo:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 42);
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
            this.label8.Size = new System.Drawing.Size(257, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mantenimiento de unidades de medida";
            // 
            // textNombreUM
            // 
            this.textNombreUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNombreUM.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreUM.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNombreUM.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNombreUM.BorderThickness = 1;
            this.textNombreUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombreUM.isPassword = false;
            this.textNombreUM.Location = new System.Drawing.Point(19, 80);
            this.textNombreUM.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreUM.Name = "textNombreUM";
            this.textNombreUM.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNombreUM.Size = new System.Drawing.Size(522, 35);
            this.textNombreUM.TabIndex = 0;
            this.textNombreUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label22.Location = new System.Drawing.Point(16, 62);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Nombre Unidad:";
            // 
            // FormUnidadMedidaNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(576, 532);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUnidadMedidaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUnidadMedidaNuevo";
            this.Load += new System.EventHandler(this.FormUnidadMedidaNuevo_Load);
            this.Click += new System.EventHandler(this.FormUnidadMedidaNuevo_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoUM;
        private Bunifu.Framework.UI.BunifuMetroTextbox textSimboloUM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreUM;
        private System.Windows.Forms.Label label22;
    }
}