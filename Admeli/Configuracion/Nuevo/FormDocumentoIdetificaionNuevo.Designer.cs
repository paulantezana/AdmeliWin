﻿namespace Admeli.Configuracion.Nuevo
{
    partial class FormDocumentoIdetificaionNuevo
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
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivoDI = new Bunifu.Framework.UI.BunifuCheckbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textDigitosDocumentoIdenti = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textNombreDocumentoIdenti = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 293);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelFooter.Size = new System.Drawing.Size(365, 49);
            this.panelFooter.TabIndex = 31;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(28, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 48);
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
            this.btnAceptar.Location = new System.Drawing.Point(11, 9);
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
            this.btnClose.Location = new System.Drawing.Point(183, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(43, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Activo *";
            // 
            // chkActivoDI
            // 
            this.chkActivoDI.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoDI.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivoDI.Checked = true;
            this.chkActivoDI.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivoDI.ForeColor = System.Drawing.Color.White;
            this.chkActivoDI.Location = new System.Drawing.Point(18, 234);
            this.chkActivoDI.Name = "chkActivoDI";
            this.chkActivoDI.Size = new System.Drawing.Size(20, 20);
            this.chkActivoDI.TabIndex = 86;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textDigitosDocumentoIdenti
            // 
            this.textDigitosDocumentoIdenti.BackColor = System.Drawing.Color.White;
            this.textDigitosDocumentoIdenti.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textDigitosDocumentoIdenti.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textDigitosDocumentoIdenti.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textDigitosDocumentoIdenti.BorderThickness = 1;
            this.textDigitosDocumentoIdenti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDigitosDocumentoIdenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDigitosDocumentoIdenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconPadding(this.textDigitosDocumentoIdenti, -30);
            this.textDigitosDocumentoIdenti.isPassword = false;
            this.textDigitosDocumentoIdenti.Location = new System.Drawing.Point(15, 75);
            this.textDigitosDocumentoIdenti.Margin = new System.Windows.Forms.Padding(4);
            this.textDigitosDocumentoIdenti.Name = "textDigitosDocumentoIdenti";
            this.textDigitosDocumentoIdenti.Padding = new System.Windows.Forms.Padding(2, 18, 5, 2);
            this.textDigitosDocumentoIdenti.Size = new System.Drawing.Size(329, 40);
            this.textDigitosDocumentoIdenti.TabIndex = 119;
            this.textDigitosDocumentoIdenti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textDigitosDocumentoIdenti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDigitosDocumentoIdenti_KeyPress);
            this.textDigitosDocumentoIdenti.Validated += new System.EventHandler(this.textDigitosDocumentoIdenti_Validated);
            // 
            // textNombreDocumentoIdenti
            // 
            this.textNombreDocumentoIdenti.BackColor = System.Drawing.Color.White;
            this.textNombreDocumentoIdenti.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textNombreDocumentoIdenti.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textNombreDocumentoIdenti.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textNombreDocumentoIdenti.BorderThickness = 1;
            this.textNombreDocumentoIdenti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombreDocumentoIdenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreDocumentoIdenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconPadding(this.textNombreDocumentoIdenti, -30);
            this.textNombreDocumentoIdenti.isPassword = false;
            this.textNombreDocumentoIdenti.Location = new System.Drawing.Point(16, 27);
            this.textNombreDocumentoIdenti.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreDocumentoIdenti.Name = "textNombreDocumentoIdenti";
            this.textNombreDocumentoIdenti.Padding = new System.Windows.Forms.Padding(2, 18, 5, 2);
            this.textNombreDocumentoIdenti.Size = new System.Drawing.Size(329, 40);
            this.textNombreDocumentoIdenti.TabIndex = 121;
            this.textNombreDocumentoIdenti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textNombreDocumentoIdenti.Validating += new System.ComponentModel.CancelEventHandler(this.textNombreDocumentoIdenti_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 118;
            this.label4.Text = "Número de Dígitos";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cbxTipoDocumento);
            this.panel12.Controls.Add(this.lblNivel3);
            this.panel12.Location = new System.Drawing.Point(16, 146);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(328, 40);
            this.panel12.TabIndex = 117;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(3, 14);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(321, 24);
            this.cbxTipoDocumento.TabIndex = 1;
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel3.ForeColor = System.Drawing.Color.DimGray;
            this.lblNivel3.Location = new System.Drawing.Point(2, 1);
            this.lblNivel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(90, 14);
            this.lblNivel3.TabIndex = 0;
            this.lblNivel3.Text = "Tipo Documento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 120;
            this.label5.Text = "Nombres*";
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
            this.progressBarApp.Size = new System.Drawing.Size(365, 5);
            this.progressBarApp.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 14);
            this.label1.TabIndex = 123;
            this.label1.Text = "Número de dígitos que tendrá el documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 14);
            this.label2.TabIndex = 124;
            this.label2.Text = "Natural: para persona común.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(15, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 14);
            this.label6.TabIndex = 125;
            this.label6.Text = "Jurídico: para empresas.";
            // 
            // FormDocumentoIdetificaionNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(365, 342);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNombreDocumentoIdenti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.textDigitosDocumentoIdenti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkActivoDI);
            this.Controls.Add(this.panelFooter);
            this.Name = "FormDocumentoIdetificaionNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOCUMENTOS DE IDENTIFICACIÓN";
            this.Load += new System.EventHandler(this.FormDocumentoIdetificaionNuevo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDocumentoIdetificaionNuevo_Paint);
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivoDI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label lblNivel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox textDigitosDocumentoIdenti;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textNombreDocumentoIdenti;
        protected System.Windows.Forms.ProgressBar progressBarApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}