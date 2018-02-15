namespace Admeli.NavDarck
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotaSalida = new System.Windows.Forms.Button();
            this.btnNotaEntrada = new System.Windows.Forms.Button();
            this.btnGuiaRemision = new System.Windows.Forms.Button();
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
            this.panelContainer.Location = new System.Drawing.Point(80, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(621, 447);
            this.panelContainer.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNotaSalida);
            this.flowLayoutPanel1.Controls.Add(this.btnNotaEntrada);
            this.flowLayoutPanel1.Controls.Add(this.btnGuiaRemision);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 351);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNotaSalida
            // 
            this.btnNotaSalida.FlatAppearance.BorderSize = 0;
            this.btnNotaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaSalida.ForeColor = System.Drawing.Color.DimGray;
            this.btnNotaSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaSalida.Image")));
            this.btnNotaSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotaSalida.Location = new System.Drawing.Point(10, 10);
            this.btnNotaSalida.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnNotaSalida.Name = "btnNotaSalida";
            this.btnNotaSalida.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNotaSalida.Size = new System.Drawing.Size(95, 90);
            this.btnNotaSalida.TabIndex = 1;
            this.btnNotaSalida.Text = "Notas de Salida";
            this.btnNotaSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotaSalida.UseVisualStyleBackColor = true;
            // 
            // btnNotaEntrada
            // 
            this.btnNotaEntrada.FlatAppearance.BorderSize = 0;
            this.btnNotaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.btnNotaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaEntrada.Image")));
            this.btnNotaEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotaEntrada.Location = new System.Drawing.Point(134, 10);
            this.btnNotaEntrada.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnNotaEntrada.Name = "btnNotaEntrada";
            this.btnNotaEntrada.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNotaEntrada.Size = new System.Drawing.Size(95, 90);
            this.btnNotaEntrada.TabIndex = 2;
            this.btnNotaEntrada.Text = "Notas de Entrada";
            this.btnNotaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotaEntrada.UseVisualStyleBackColor = true;
            // 
            // btnGuiaRemision
            // 
            this.btnGuiaRemision.FlatAppearance.BorderSize = 0;
            this.btnGuiaRemision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiaRemision.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuiaRemision.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiaRemision.Image")));
            this.btnGuiaRemision.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuiaRemision.Location = new System.Drawing.Point(258, 10);
            this.btnGuiaRemision.Margin = new System.Windows.Forms.Padding(10, 10, 19, 10);
            this.btnGuiaRemision.Name = "btnGuiaRemision";
            this.btnGuiaRemision.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnGuiaRemision.Size = new System.Drawing.Size(95, 90);
            this.btnGuiaRemision.TabIndex = 3;
            this.btnGuiaRemision.Text = "Guías de Remisión";
            this.btnGuiaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuiaRemision.UseVisualStyleBackColor = true;
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
            this.label1.Text = "ALMACEN";
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
            // UCAlmacenNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "UCAlmacenNav";
            this.Size = new System.Drawing.Size(775, 490);
            this.panelContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotaSalida;
        private System.Windows.Forms.Button btnNotaEntrada;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuiaRemision;
    }
}
