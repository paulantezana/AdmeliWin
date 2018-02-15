namespace Admeli.NavDarck
{
    partial class UCProductosNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductosNav));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnUnidadMedida = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelContainer.Controls.Add(this.flowLayoutPanel1);
            this.panelContainer.Controls.Add(this.panelContent);
            this.panelContainer.Location = new System.Drawing.Point(78, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(621, 447);
            this.panelContainer.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnProductos);
            this.flowLayoutPanel1.Controls.Add(this.btnMarcas);
            this.flowLayoutPanel1.Controls.Add(this.btnUnidadMedida);
            this.flowLayoutPanel1.Controls.Add(this.btnCategorias);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 351);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.DimGray;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(10, 10);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(95, 90);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Listado Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.ForeColor = System.Drawing.Color.DimGray;
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcas.Location = new System.Drawing.Point(134, 10);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(95, 90);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnUnidadMedida
            // 
            this.btnUnidadMedida.FlatAppearance.BorderSize = 0;
            this.btnUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadMedida.ForeColor = System.Drawing.Color.DimGray;
            this.btnUnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidadMedida.Image")));
            this.btnUnidadMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnidadMedida.Location = new System.Drawing.Point(258, 10);
            this.btnUnidadMedida.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnUnidadMedida.Name = "btnUnidadMedida";
            this.btnUnidadMedida.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUnidadMedida.Size = new System.Drawing.Size(95, 90);
            this.btnUnidadMedida.TabIndex = 3;
            this.btnUnidadMedida.Text = "Unidades de Medida";
            this.btnUnidadMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnidadMedida.UseVisualStyleBackColor = true;
            this.btnUnidadMedida.Click += new System.EventHandler(this.btnUnidadMedida_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategorias.Location = new System.Drawing.Point(382, 10);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(95, 90);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.bunifuSeparator1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(621, 96);
            this.panelContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(209, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "administración";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 64);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(621, 32);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // UCProductosNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCProductosNav";
            this.Size = new System.Drawing.Size(776, 540);
            this.panelContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnUnidadMedida;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnCategorias;
    }
}
