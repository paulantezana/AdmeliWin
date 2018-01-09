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
using Admeli.Almacen;

namespace Admeli.Navegacion
{
    public partial class UCAlmacenNav : UserControl
    {
        private UCGuiaRemision uCGuiaRemision;
        private UCNotaEntrada uCNotaEntrada;
        private UCNotaSalida uCNotaSalida;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado

        private Panel panelMain;

        public UCAlmacenNav()
        {
            InitializeComponent();
        }

        public UCAlmacenNav(Panel panelMain)
        {
            InitializeComponent();
            this.panelMain = panelMain;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader, 220, 220, 220);
        }

        private void UCAlmacenNav_Load(object sender, EventArgs e)
        {
            //
        }
        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            btnColor();
            switch (panelName)
            {
                case "guiaRemision":
                    this.uCGuiaRemision = new Admeli.Almacen.UCGuiaRemision();
                    this.panelMain.Controls.Add(uCGuiaRemision);
                    this.uCGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCGuiaRemision.Location = new System.Drawing.Point(0, 0);
                    this.uCGuiaRemision.Name = "uCGuiaRemision";
                    this.uCGuiaRemision.Size = new System.Drawing.Size(250, 776);
                    this.uCGuiaRemision.TabIndex = 0;
                    break;
                case "notaSalida":
                    this.uCNotaSalida = new Admeli.Almacen.UCNotaSalida();
                    this.panelMain.Controls.Add(uCNotaSalida);
                    this.uCNotaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCNotaSalida.Location = new System.Drawing.Point(0, 0);
                    this.uCNotaSalida.Name = "uCVentasNav";
                    this.uCNotaSalida.Size = new System.Drawing.Size(250, 776);
                    this.uCNotaSalida.TabIndex = 0;
                    break;
                case "notaEntrada":
                    this.uCNotaEntrada = new Admeli.Almacen.UCNotaEntrada();
                    this.panelMain.Controls.Add(uCNotaEntrada);
                    this.uCNotaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCNotaEntrada.Location = new System.Drawing.Point(0, 0);
                    this.uCNotaEntrada.Name = "uCNotaEntrada";
                    this.uCNotaEntrada.Size = new System.Drawing.Size(250, 776);
                    this.uCNotaEntrada.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void btnColor()
        {
            btnGuiaRemision.BackColor = this.BackColor;
            btnNotaEntrada.BackColor = this.BackColor;
            btnNotaSalida.BackColor = this.BackColor;
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            togglePanelMain("notaSalida");
            btnNotaSalida.BackColor = colorActive;
        }

        private void btnNotaEntrada_Click(object sender, EventArgs e)
        {
            togglePanelMain("notaEntrada");
            btnNotaEntrada.BackColor = colorActive;
        }

        private void btnGuiaRemision_Click(object sender, EventArgs e)
        {
            togglePanelMain("guiaRemision");
            btnGuiaRemision.BackColor = colorActive;
        }
    }
}
