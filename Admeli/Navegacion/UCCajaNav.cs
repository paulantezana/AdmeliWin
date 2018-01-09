using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;
using Admeli.Caja;

namespace Admeli.Navegacion
{
    public partial class UCCajaNav : UserControl
    {

        private UCCierreCaja uCCierreCaja;
        private UCEgresos uCEgresos;
        private UCIngresos uCIngresos;
        private UCIniciarCaja uCIniciarCaja;

        private Panel panelMain;
        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado

        public UCCajaNav()
        {
            InitializeComponent();
        }

        public UCCajaNav(Panel panelMain)
        {
            InitializeComponent();
            this.panelMain = panelMain;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader, 220, 220, 220);
        }

        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            btnColor();
            switch (panelName)
            {
                case "cierreCaja":
                    this.uCCierreCaja = new Admeli.Caja.UCCierreCaja();
                    this.panelMain.Controls.Add(uCCierreCaja);
                    this.uCCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCierreCaja.Location = new System.Drawing.Point(0, 0);
                    this.uCCierreCaja.Name = "uCCierreCaja";
                    this.uCCierreCaja.Size = new System.Drawing.Size(250, 776);
                    this.uCCierreCaja.TabIndex = 0;
                    break;
                case "egresos":
                    this.uCEgresos = new Admeli.Caja.UCEgresos();
                    this.panelMain.Controls.Add(uCEgresos);
                    this.uCEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCEgresos.Location = new System.Drawing.Point(0, 0);
                    this.uCEgresos.Name = "uCEgresos";
                    this.uCEgresos.Size = new System.Drawing.Size(250, 776);
                    this.uCEgresos.TabIndex = 0;
                    break;
                case "ingresos":
                    this.uCIngresos = new Admeli.Caja.UCIngresos();
                    this.panelMain.Controls.Add(uCIngresos);
                    this.uCIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCIngresos.Location = new System.Drawing.Point(0, 0);
                    this.uCIngresos.Name = "uCIngresos";
                    this.uCIngresos.Size = new System.Drawing.Size(250, 776);
                    this.uCIngresos.TabIndex = 0;
                    break;
                case "iniciarCaja":
                    this.uCIniciarCaja = new Admeli.Caja.UCIniciarCaja();
                    this.panelMain.Controls.Add(uCIniciarCaja);
                    this.uCIniciarCaja.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCIniciarCaja.Location = new System.Drawing.Point(0, 0);
                    this.uCIniciarCaja.Name = "uCIniciarCaja";
                    this.uCIniciarCaja.Size = new System.Drawing.Size(250, 776);
                    this.uCIniciarCaja.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void btnColor()
        {
            btnCierreCaja.BackColor = this.BackColor;
            btnEgresos.BackColor = this.BackColor;
            btnIngresos.BackColor = this.BackColor;
            btnIniciarCaja.BackColor = this.BackColor;
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            togglePanelMain("egresos");
            btnEgresos.BackColor = this.colorActive;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            togglePanelMain("ingresos");
            btnIngresos.BackColor = this.colorActive;
        }

        private void btnIniciarCaja_Click(object sender, EventArgs e)
        {
            togglePanelMain("iniciarCaja");
            btnIniciarCaja.BackColor = this.colorActive;
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            togglePanelMain("cierreCaja");
            btnCierreCaja.BackColor = this.colorActive;
        }
    }
}
