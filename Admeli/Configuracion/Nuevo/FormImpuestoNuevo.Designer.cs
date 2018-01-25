﻿namespace Admeli.Configuracion.Nuevo
{
    partial class FormImpuestoNuevo
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreImpuesto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSiglasImpuesto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textValorImpuesto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelfc = new System.Windows.Forms.Label();
            this.chkDefaultImpuesto = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkPorcentualImpuesto = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 388);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelFooter.Size = new System.Drawing.Size(379, 49);
            this.panelFooter.TabIndex = 31;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-12, 1);
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
            this.btnAceptar.TabIndex = 0;
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
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 42);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mantenimiento Impuesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Impuesto";
            // 
            // textNombreImpuesto
            // 
            this.textNombreImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textNombreImpuesto.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreImpuesto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textNombreImpuesto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textNombreImpuesto.BorderThickness = 1;
            this.textNombreImpuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombreImpuesto.isPassword = false;
            this.textNombreImpuesto.Location = new System.Drawing.Point(19, 78);
            this.textNombreImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreImpuesto.Name = "textNombreImpuesto";
            this.textNombreImpuesto.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textNombreImpuesto.Size = new System.Drawing.Size(330, 35);
            this.textNombreImpuesto.TabIndex = 1;
            this.textNombreImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siglas Impuesto";
            // 
            // textSiglasImpuesto
            // 
            this.textSiglasImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textSiglasImpuesto.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textSiglasImpuesto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textSiglasImpuesto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textSiglasImpuesto.BorderThickness = 1;
            this.textSiglasImpuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSiglasImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSiglasImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSiglasImpuesto.isPassword = false;
            this.textSiglasImpuesto.Location = new System.Drawing.Point(19, 144);
            this.textSiglasImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.textSiglasImpuesto.Name = "textSiglasImpuesto";
            this.textSiglasImpuesto.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textSiglasImpuesto.Size = new System.Drawing.Size(330, 35);
            this.textSiglasImpuesto.TabIndex = 3;
            this.textSiglasImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(16, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Impuesto";
            // 
            // textValorImpuesto
            // 
            this.textValorImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.textValorImpuesto.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textValorImpuesto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textValorImpuesto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textValorImpuesto.BorderThickness = 1;
            this.textValorImpuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textValorImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textValorImpuesto.isPassword = false;
            this.textValorImpuesto.Location = new System.Drawing.Point(19, 242);
            this.textValorImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.textValorImpuesto.Name = "textValorImpuesto";
            this.textValorImpuesto.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textValorImpuesto.Size = new System.Drawing.Size(330, 35);
            this.textValorImpuesto.TabIndex = 7;
            this.textValorImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textValorImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValorImpuesto_KeyPress);
            // 
            // labelfc
            // 
            this.labelfc.AutoSize = true;
            this.labelfc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.labelfc.Location = new System.Drawing.Point(44, 300);
            this.labelfc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfc.Name = "labelfc";
            this.labelfc.Size = new System.Drawing.Size(76, 16);
            this.labelfc.TabIndex = 9;
            this.labelfc.Text = "Por Defecto";
            // 
            // chkDefaultImpuesto
            // 
            this.chkDefaultImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkDefaultImpuesto.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkDefaultImpuesto.Checked = false;
            this.chkDefaultImpuesto.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkDefaultImpuesto.ForeColor = System.Drawing.Color.White;
            this.chkDefaultImpuesto.Location = new System.Drawing.Point(19, 298);
            this.chkDefaultImpuesto.Name = "chkDefaultImpuesto";
            this.chkDefaultImpuesto.Size = new System.Drawing.Size(20, 20);
            this.chkDefaultImpuesto.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label16.Location = new System.Drawing.Point(44, 192);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Porcentual";
            // 
            // chkPorcentualImpuesto
            // 
            this.chkPorcentualImpuesto.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkPorcentualImpuesto.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkPorcentualImpuesto.Checked = true;
            this.chkPorcentualImpuesto.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkPorcentualImpuesto.ForeColor = System.Drawing.Color.White;
            this.chkPorcentualImpuesto.Location = new System.Drawing.Point(19, 190);
            this.chkPorcentualImpuesto.Name = "chkPorcentualImpuesto";
            this.chkPorcentualImpuesto.Size = new System.Drawing.Size(20, 20);
            this.chkPorcentualImpuesto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(44, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(19, 333);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(20, 20);
            this.chkActivo.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormImpuestoNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(379, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.labelfc);
            this.Controls.Add(this.chkDefaultImpuesto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkPorcentualImpuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textValorImpuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSiglasImpuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombreImpuesto);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel2);
            this.Name = "FormImpuestoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImpuestoNuevo";
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreImpuesto;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textSiglasImpuesto;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox textValorImpuesto;
        private System.Windows.Forms.Label labelfc;
        private Bunifu.Framework.UI.BunifuCheckbox chkDefaultImpuesto;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuCheckbox chkPorcentualImpuesto;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}