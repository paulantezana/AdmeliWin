﻿namespace Admeli.Configuracion.Nuevo
{
    partial class FormPuntoVentaNuevo
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
            this.label6 = new System.Windows.Forms.Label();
            this.chkActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textPuntoVenta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbxSucursalPV = new System.Windows.Forms.ComboBox();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.progressBarApp = new System.Windows.Forms.ProgressBar();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 338);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelFooter.Size = new System.Drawing.Size(355, 49);
            this.panelFooter.TabIndex = 31;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(24, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 48);
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
            this.btnAceptar.Location = new System.Drawing.Point(10, 9);
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
            this.btnClose.Location = new System.Drawing.Point(182, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(39, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(14, 121);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(20, 20);
            this.chkActivo.TabIndex = 108;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Entidad.Sucursal);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textPuntoVenta
            // 
            this.textPuntoVenta.BackColor = System.Drawing.Color.White;
            this.textPuntoVenta.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.textPuntoVenta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textPuntoVenta.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.textPuntoVenta.BorderThickness = 1;
            this.textPuntoVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuntoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconPadding(this.textPuntoVenta, -30);
            this.textPuntoVenta.isPassword = false;
            this.textPuntoVenta.Location = new System.Drawing.Point(13, 70);
            this.textPuntoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.textPuntoVenta.Name = "textPuntoVenta";
            this.textPuntoVenta.Padding = new System.Windows.Forms.Padding(2, 18, 5, 2);
            this.textPuntoVenta.Size = new System.Drawing.Size(329, 40);
            this.textPuntoVenta.TabIndex = 114;
            this.textPuntoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPuntoVenta.Validated += new System.EventHandler(this.textPuntoVenta_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 113;
            this.label1.Text = "Punto venta";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cbxSucursalPV);
            this.panel12.Controls.Add(this.lblNivel3);
            this.panel12.Location = new System.Drawing.Point(14, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(328, 40);
            this.panel12.TabIndex = 112;
            // 
            // cbxSucursalPV
            // 
            this.cbxSucursalPV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSucursalPV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxSucursalPV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSucursalPV.DataSource = this.sucursalBindingSource;
            this.cbxSucursalPV.DisplayMember = "nombre";
            this.cbxSucursalPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSucursalPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursalPV.FormattingEnabled = true;
            this.cbxSucursalPV.Location = new System.Drawing.Point(3, 14);
            this.cbxSucursalPV.Name = "cbxSucursalPV";
            this.cbxSucursalPV.Size = new System.Drawing.Size(321, 24);
            this.cbxSucursalPV.TabIndex = 1;
            this.cbxSucursalPV.ValueMember = "idSucursal";
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel3.ForeColor = System.Drawing.Color.DimGray;
            this.lblNivel3.Location = new System.Drawing.Point(2, 1);
            this.lblNivel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(56, 14);
            this.lblNivel3.TabIndex = 0;
            this.lblNivel3.Text = "Sucursal :";
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
            this.progressBarApp.Size = new System.Drawing.Size(355, 5);
            this.progressBarApp.TabIndex = 115;
            // 
            // FormPuntoVentaNuevo
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(355, 387);
            this.Controls.Add(this.progressBarApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.textPuntoVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPuntoVentaNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNAR PUNTO VENTA";
            this.Load += new System.EventHandler(this.FormPuntoVentaNuevo_Load);
            this.Shown += new System.EventHandler(this.FormPuntoVentaNuevo_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPuntoVentaNuevo_Paint);
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbxSucursalPV;
        private System.Windows.Forms.Label lblNivel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox textPuntoVenta;
        protected System.Windows.Forms.ProgressBar progressBarApp;
    }
}