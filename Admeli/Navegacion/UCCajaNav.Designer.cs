namespace Admeli.Navegacion
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnIniciarCaja = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
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
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(188, 49);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administración de la caja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEgresos);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresos);
            this.flowLayoutPanel1.Controls.Add(this.btnIniciarCaja);
            this.flowLayoutPanel1.Controls.Add(this.btnCierreCaja);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 495);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnEgresos
            // 
            this.btnEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEgresos.FlatAppearance.BorderSize = 0;
            this.btnEgresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnEgresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresos.Image = ((System.Drawing.Image)(resources.GetObject("btnEgresos.Image")));
            this.btnEgresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgresos.Location = new System.Drawing.Point(0, 8);
            this.btnEgresos.Margin = new System.Windows.Forms.Padding(0);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEgresos.Size = new System.Drawing.Size(185, 41);
            this.btnEgresos.TabIndex = 2;
            this.btnEgresos.Text = " Egresos";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEgresos.UseVisualStyleBackColor = true;
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnIngresos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresos.Image")));
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(0, 49);
            this.btnIngresos.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnIngresos.Size = new System.Drawing.Size(185, 41);
            this.btnIngresos.TabIndex = 3;
            this.btnIngresos.Text = " Ingresos";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnIniciarCaja
            // 
            this.btnIniciarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarCaja.FlatAppearance.BorderSize = 0;
            this.btnIniciarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnIniciarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnIniciarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarCaja.Image")));
            this.btnIniciarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarCaja.Location = new System.Drawing.Point(0, 90);
            this.btnIniciarCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciarCaja.Name = "btnIniciarCaja";
            this.btnIniciarCaja.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnIniciarCaja.Size = new System.Drawing.Size(185, 41);
            this.btnIniciarCaja.TabIndex = 4;
            this.btnIniciarCaja.Text = " Iniciar caja";
            this.btnIniciarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarCaja.UseVisualStyleBackColor = true;
            this.btnIniciarCaja.Click += new System.EventHandler(this.btnIniciarCaja_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCierreCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreCaja.Image")));
            this.btnCierreCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreCaja.Location = new System.Drawing.Point(0, 131);
            this.btnCierreCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCierreCaja.Size = new System.Drawing.Size(185, 41);
            this.btnCierreCaja.TabIndex = 5;
            this.btnCierreCaja.Text = " Cierres de caja";
            this.btnCierreCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // UCCajaNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCCajaNav";
            this.Size = new System.Drawing.Size(188, 544);
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
        private System.Windows.Forms.Button btnEgresos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnIniciarCaja;
        private System.Windows.Forms.Button btnCierreCaja;
    }
}
