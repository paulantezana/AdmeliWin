namespace Admeli.Navegacion
{
    partial class UCComprasNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCComprasNav));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOredenCompra = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCuentaPagar = new System.Windows.Forms.Button();
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
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administración de las compras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOredenCompra);
            this.flowLayoutPanel1.Controls.Add(this.btnCompras);
            this.flowLayoutPanel1.Controls.Add(this.btnProveedores);
            this.flowLayoutPanel1.Controls.Add(this.btnCuentaPagar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 597);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnOredenCompra
            // 
            this.btnOredenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOredenCompra.FlatAppearance.BorderSize = 0;
            this.btnOredenCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnOredenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnOredenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOredenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnOredenCompra.Image")));
            this.btnOredenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOredenCompra.Location = new System.Drawing.Point(0, 10);
            this.btnOredenCompra.Margin = new System.Windows.Forms.Padding(0);
            this.btnOredenCompra.Name = "btnOredenCompra";
            this.btnOredenCompra.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnOredenCompra.Size = new System.Drawing.Size(247, 50);
            this.btnOredenCompra.TabIndex = 2;
            this.btnOredenCompra.Text = " Orden de compra proveedor";
            this.btnOredenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOredenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOredenCompra.UseVisualStyleBackColor = true;
            this.btnOredenCompra.Click += new System.EventHandler(this.btnOredenCompra_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 60);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(247, 50);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = " Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 110);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(247, 50);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = " Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCuentaPagar
            // 
            this.btnCuentaPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentaPagar.FlatAppearance.BorderSize = 0;
            this.btnCuentaPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCuentaPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCuentaPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentaPagar.Image")));
            this.btnCuentaPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentaPagar.Location = new System.Drawing.Point(0, 160);
            this.btnCuentaPagar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuentaPagar.Name = "btnCuentaPagar";
            this.btnCuentaPagar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCuentaPagar.Size = new System.Drawing.Size(247, 50);
            this.btnCuentaPagar.TabIndex = 5;
            this.btnCuentaPagar.Text = " Cuentas por pagar";
            this.btnCuentaPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentaPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentaPagar.UseVisualStyleBackColor = true;
            this.btnCuentaPagar.Click += new System.EventHandler(this.btnCuentaPagar_Click);
            // 
            // UCComprasNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "UCComprasNav";
            this.Size = new System.Drawing.Size(250, 657);
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
        private System.Windows.Forms.Button btnOredenCompra;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCuentaPagar;
    }
}
