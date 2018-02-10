namespace Admeli.Navegacion
{
    partial class UCAlmacenNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAlmacenNav));
            this.btnNotaSalida = new System.Windows.Forms.Button();
            this.btnNotaEntrada = new System.Windows.Forms.Button();
            this.btnGuiaRemision = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotaSalida
            // 
            this.btnNotaSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotaSalida.FlatAppearance.BorderSize = 0;
            this.btnNotaSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnNotaSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaSalida.Image")));
            this.btnNotaSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaSalida.Location = new System.Drawing.Point(0, 8);
            this.btnNotaSalida.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotaSalida.Name = "btnNotaSalida";
            this.btnNotaSalida.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnNotaSalida.Size = new System.Drawing.Size(188, 41);
            this.btnNotaSalida.TabIndex = 2;
            this.btnNotaSalida.Text = " Notas de salida";
            this.btnNotaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaSalida.UseVisualStyleBackColor = true;
            this.btnNotaSalida.Click += new System.EventHandler(this.btnNotaSalida_Click);
            // 
            // btnNotaEntrada
            // 
            this.btnNotaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotaEntrada.FlatAppearance.BorderSize = 0;
            this.btnNotaEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnNotaEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnNotaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaEntrada.Image")));
            this.btnNotaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaEntrada.Location = new System.Drawing.Point(188, 8);
            this.btnNotaEntrada.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotaEntrada.Name = "btnNotaEntrada";
            this.btnNotaEntrada.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnNotaEntrada.Size = new System.Drawing.Size(188, 41);
            this.btnNotaEntrada.TabIndex = 3;
            this.btnNotaEntrada.Text = " Notas de entrada";
            this.btnNotaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaEntrada.UseVisualStyleBackColor = true;
            this.btnNotaEntrada.Click += new System.EventHandler(this.btnNotaEntrada_Click);
            // 
            // btnGuiaRemision
            // 
            this.btnGuiaRemision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiaRemision.FlatAppearance.BorderSize = 0;
            this.btnGuiaRemision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnGuiaRemision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnGuiaRemision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiaRemision.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiaRemision.Image")));
            this.btnGuiaRemision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuiaRemision.Location = new System.Drawing.Point(376, 8);
            this.btnGuiaRemision.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuiaRemision.Name = "btnGuiaRemision";
            this.btnGuiaRemision.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGuiaRemision.Size = new System.Drawing.Size(188, 41);
            this.btnGuiaRemision.TabIndex = 4;
            this.btnGuiaRemision.Text = " Guías de remisión";
            this.btnGuiaRemision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuiaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuiaRemision.UseVisualStyleBackColor = true;
            this.btnGuiaRemision.Click += new System.EventHandler(this.btnGuiaRemision_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNotaSalida);
            this.flowLayoutPanel1.Controls.Add(this.btnNotaEntrada);
            this.flowLayoutPanel1.Controls.Add(this.btnGuiaRemision);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 118);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // UCAlmacenNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCAlmacenNav";
            this.Size = new System.Drawing.Size(597, 118);
            this.Load += new System.EventHandler(this.UCAlmacenNav_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNotaSalida;
        private System.Windows.Forms.Button btnNotaEntrada;
        private System.Windows.Forms.Button btnGuiaRemision;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
