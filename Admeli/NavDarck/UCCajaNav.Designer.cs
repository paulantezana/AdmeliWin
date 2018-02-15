namespace Admeli.NavDarck
{
    partial class UCCajaNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCajaNav));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnPorCobrar = new System.Windows.Forms.Button();
            this.btnCuentaPagar = new System.Windows.Forms.Button();
            this.btnIniciarCaja = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
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
            this.panelContainer.Location = new System.Drawing.Point(74, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(621, 447);
            this.panelContainer.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEgreso);
            this.flowLayoutPanel1.Controls.Add(this.btnIngreso);
            this.flowLayoutPanel1.Controls.Add(this.btnPorCobrar);
            this.flowLayoutPanel1.Controls.Add(this.btnCuentaPagar);
            this.flowLayoutPanel1.Controls.Add(this.btnIniciarCaja);
            this.flowLayoutPanel1.Controls.Add(this.btnCierreCaja);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 351);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnEgreso
            // 
            this.btnEgreso.FlatAppearance.BorderSize = 0;
            this.btnEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgreso.ForeColor = System.Drawing.Color.DimGray;
            this.btnEgreso.Image = ((System.Drawing.Image)(resources.GetObject("btnEgreso.Image")));
            this.btnEgreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEgreso.Location = new System.Drawing.Point(10, 10);
            this.btnEgreso.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnEgreso.Size = new System.Drawing.Size(95, 90);
            this.btnEgreso.TabIndex = 1;
            this.btnEgreso.Text = "Egresos";
            this.btnEgreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.ForeColor = System.Drawing.Color.DimGray;
            this.btnIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreso.Image")));
            this.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngreso.Location = new System.Drawing.Point(134, 10);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnIngreso.Size = new System.Drawing.Size(95, 90);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresos";
            this.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnPorCobrar
            // 
            this.btnPorCobrar.FlatAppearance.BorderSize = 0;
            this.btnPorCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorCobrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnPorCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnPorCobrar.Image")));
            this.btnPorCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPorCobrar.Location = new System.Drawing.Point(258, 10);
            this.btnPorCobrar.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnPorCobrar.Name = "btnPorCobrar";
            this.btnPorCobrar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnPorCobrar.Size = new System.Drawing.Size(95, 90);
            this.btnPorCobrar.TabIndex = 3;
            this.btnPorCobrar.Text = "Cuentas por Cobrar";
            this.btnPorCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPorCobrar.UseVisualStyleBackColor = true;
            this.btnPorCobrar.Click += new System.EventHandler(this.btnPorCobrar_Click);
            // 
            // btnCuentaPagar
            // 
            this.btnCuentaPagar.FlatAppearance.BorderSize = 0;
            this.btnCuentaPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaPagar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCuentaPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentaPagar.Image")));
            this.btnCuentaPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuentaPagar.Location = new System.Drawing.Point(382, 10);
            this.btnCuentaPagar.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnCuentaPagar.Name = "btnCuentaPagar";
            this.btnCuentaPagar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCuentaPagar.Size = new System.Drawing.Size(95, 90);
            this.btnCuentaPagar.TabIndex = 4;
            this.btnCuentaPagar.Text = "Cuentas por Pagar";
            this.btnCuentaPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCuentaPagar.UseVisualStyleBackColor = true;
            this.btnCuentaPagar.Click += new System.EventHandler(this.btnCuentaPagar_Click);
            // 
            // btnIniciarCaja
            // 
            this.btnIniciarCaja.FlatAppearance.BorderSize = 0;
            this.btnIniciarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarCaja.ForeColor = System.Drawing.Color.DimGray;
            this.btnIniciarCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarCaja.Image")));
            this.btnIniciarCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciarCaja.Location = new System.Drawing.Point(506, 10);
            this.btnIniciarCaja.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnIniciarCaja.Name = "btnIniciarCaja";
            this.btnIniciarCaja.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnIniciarCaja.Size = new System.Drawing.Size(95, 90);
            this.btnIniciarCaja.TabIndex = 5;
            this.btnIniciarCaja.Text = "Iniciar Caja";
            this.btnIniciarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIniciarCaja.UseVisualStyleBackColor = true;
            this.btnIniciarCaja.Click += new System.EventHandler(this.btnIniciarCaja_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.ForeColor = System.Drawing.Color.DimGray;
            this.btnCierreCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreCaja.Image")));
            this.btnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCierreCaja.Location = new System.Drawing.Point(10, 120);
            this.btnCierreCaja.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCierreCaja.Size = new System.Drawing.Size(95, 90);
            this.btnCierreCaja.TabIndex = 6;
            this.btnCierreCaja.Text = "Cierres de Caja";
            this.btnCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
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
            this.label1.Text = "CAJA";
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
            // UCCajaNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCCajaNav";
            this.Size = new System.Drawing.Size(768, 516);
            this.panelContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnPorCobrar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnCuentaPagar;
        private System.Windows.Forms.Button btnIniciarCaja;
        private System.Windows.Forms.Button btnCierreCaja;
    }
}
