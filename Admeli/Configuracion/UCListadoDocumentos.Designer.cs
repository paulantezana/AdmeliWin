﻿namespace Admeli.Configuracion
{
    partial class UCListadoDocumentos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelHeaderItem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelHeaderItem1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(888, 554);
            this.panelContainer.TabIndex = 7;
            // 
            // panelHeaderItem1
            // 
            this.panelHeaderItem1.Controls.Add(this.label1);
            this.panelHeaderItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderItem1.Location = new System.Drawing.Point(1, 1);
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(886, 41);
            this.panelHeaderItem1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DOCUMENTOS COMERCIALES";
            // 
            // UCListadoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCListadoDocumentos";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(904, 570);
            this.panelContainer.ResumeLayout(false);
            this.panelHeaderItem1.ResumeLayout(false);
            this.panelHeaderItem1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeaderItem1;
        private System.Windows.Forms.Label label1;
    }
}
