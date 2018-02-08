namespace Admeli.CajaBox
{
    partial class UCIniciarCaja
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCajaEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textObservacion = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dtpFechaInicio);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.dtpFechaIngreso);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.lblCajaEstado);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textObservacion);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(927, 445);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(303, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Fecha inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaInicio.BorderRadius = 0;
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.FormatCustom = null;
            this.dtpFechaInicio.Location = new System.Drawing.Point(298, 71);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.dtpFechaInicio.Size = new System.Drawing.Size(252, 50);
            this.dtpFechaInicio.TabIndex = 105;
            this.dtpFechaInicio.Value = new System.DateTime(2018, 2, 6, 19, 19, 41, 715);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(23, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Fecha inicio";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaIngreso.BorderRadius = 0;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.FormatCustom = null;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(18, 71);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.dtpFechaIngreso.Size = new System.Drawing.Size(252, 50);
            this.dtpFechaIngreso.TabIndex = 103;
            this.dtpFechaIngreso.Value = new System.DateTime(2018, 2, 6, 19, 19, 41, 715);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 62);
            this.panel1.TabIndex = 101;
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
            this.btnAceptar.Location = new System.Drawing.Point(17, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(389, 33);
            this.btnAceptar.TabIndex = 98;
            this.btnAceptar.Text = "Iniciar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCajaEstado
            // 
            this.lblCajaEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lblCajaEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblCajaEstado.Location = new System.Drawing.Point(16, 18);
            this.lblCajaEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCajaEstado.Name = "lblCajaEstado";
            this.lblCajaEstado.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblCajaEstado.Size = new System.Drawing.Size(893, 38);
            this.lblCajaEstado.TabIndex = 94;
            this.lblCajaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(16, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Observación";
            // 
            // textObservacion
            // 
            this.textObservacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObservacion.Location = new System.Drawing.Point(18, 157);
            this.textObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.textObservacion.Multiline = true;
            this.textObservacion.Name = "textObservacion";
            this.textObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textObservacion.Size = new System.Drawing.Size(389, 76);
            this.textObservacion.TabIndex = 94;
            // 
            // UCIniciarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCIniciarCaja";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(943, 461);
            this.Load += new System.EventHandler(this.UCIniciarCaja_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textObservacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCajaEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaIngreso;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaInicio;
    }
}
