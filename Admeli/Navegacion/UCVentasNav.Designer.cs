namespace Admeli.Navegacion
{
    partial class UCVentasNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVentasNav));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCotizacionCliente = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCuentasPorCobrar = new System.Windows.Forms.Button();
            this.btnVentaTouch = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(250, 60);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administración de ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCotizacionCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnVentas);
            this.flowLayoutPanel1.Controls.Add(this.btnClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnCuentasPorCobrar);
            this.flowLayoutPanel1.Controls.Add(this.btnVentaTouch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 606);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnCotizacionCliente
            // 
            this.btnCotizacionCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizacionCliente.FlatAppearance.BorderSize = 0;
            this.btnCotizacionCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCotizacionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCotizacionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacionCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizacionCliente.Image")));
            this.btnCotizacionCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacionCliente.Location = new System.Drawing.Point(0, 10);
            this.btnCotizacionCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCotizacionCliente.Name = "btnCotizacionCliente";
            this.btnCotizacionCliente.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCotizacionCliente.Size = new System.Drawing.Size(247, 50);
            this.btnCotizacionCliente.TabIndex = 2;
            this.btnCotizacionCliente.Text = " Cotizaciones de cliente";
            this.btnCotizacionCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacionCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCotizacionCliente.UseVisualStyleBackColor = true;
            this.btnCotizacionCliente.Click += new System.EventHandler(this.btnCotizacionCliente_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 60);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(247, 50);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = " Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 110);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(247, 50);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = " Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCuentasPorCobrar
            // 
            this.btnCuentasPorCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentasPorCobrar.FlatAppearance.BorderSize = 0;
            this.btnCuentasPorCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCuentasPorCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCuentasPorCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentasPorCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentasPorCobrar.Image")));
            this.btnCuentasPorCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentasPorCobrar.Location = new System.Drawing.Point(0, 160);
            this.btnCuentasPorCobrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuentasPorCobrar.Name = "btnCuentasPorCobrar";
            this.btnCuentasPorCobrar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCuentasPorCobrar.Size = new System.Drawing.Size(247, 50);
            this.btnCuentasPorCobrar.TabIndex = 5;
            this.btnCuentasPorCobrar.Text = " Cuentas por cobrar";
            this.btnCuentasPorCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentasPorCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentasPorCobrar.UseVisualStyleBackColor = true;
            this.btnCuentasPorCobrar.Click += new System.EventHandler(this.btnCuentasPorCobrar_Click);
            // 
            // btnVentaTouch
            // 
            this.btnVentaTouch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaTouch.FlatAppearance.BorderSize = 0;
            this.btnVentaTouch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnVentaTouch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnVentaTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaTouch.Image = ((System.Drawing.Image)(resources.GetObject("btnVentaTouch.Image")));
            this.btnVentaTouch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaTouch.Location = new System.Drawing.Point(0, 210);
            this.btnVentaTouch.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentaTouch.Name = "btnVentaTouch";
            this.btnVentaTouch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnVentaTouch.Size = new System.Drawing.Size(247, 50);
            this.btnVentaTouch.TabIndex = 6;
            this.btnVentaTouch.Text = " Venta Touch";
            this.btnVentaTouch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaTouch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaTouch.UseVisualStyleBackColor = true;
            this.btnVentaTouch.Click += new System.EventHandler(this.btnVentaTouch_Click);
            // 
            // UCVentasNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "UCVentasNav";
            this.Size = new System.Drawing.Size(250, 666);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCotizacionCliente;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCuentasPorCobrar;
        private System.Windows.Forms.Button btnVentaTouch;
    }
}
