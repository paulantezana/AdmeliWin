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
using Admeli.AlmacenBox;

namespace Admeli.Navegacion
{
    public partial class UCAlmacenNav : UserControl
    {
        private UCGuiaRemision uCGuiaRemision;
        private UCNotaEntrada uCNotaEntrada;
        private UCNotaSalida uCNotaSalida;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado

        private FormPrincipal formPrincipal;

        public UCAlmacenNav()
        {
            InitializeComponent();
        }

        public UCAlmacenNav(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
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
            this.limpiarControles();
            btnColor();
            switch (panelName)
            {
                case "guiaRemision":
                    if (uCGuiaRemision == null)
                    {
                        this.uCGuiaRemision = new Admeli.AlmacenBox.UCGuiaRemision(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCGuiaRemision);
                        this.uCGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCGuiaRemision.Location = new System.Drawing.Point(0, 0);
                        this.uCGuiaRemision.Name = "uCGuiaRemision";
                        this.uCGuiaRemision.Size = new System.Drawing.Size(250, 776);
                        this.uCGuiaRemision.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCGuiaRemision);
                        this.uCGuiaRemision.reLoad();
                    }
                    break;
                case "notaSalida":
                    if (uCNotaSalida == null)
                    {
                        this.uCNotaSalida = new Admeli.AlmacenBox.UCNotaSalida(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCNotaSalida);
                        this.uCNotaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCNotaSalida.Location = new System.Drawing.Point(0, 0);
                        this.uCNotaSalida.Name = "uCVentasNav";
                        this.uCNotaSalida.Size = new System.Drawing.Size(250, 776);
                        this.uCNotaSalida.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCNotaSalida);
                        this.uCNotaSalida.reLoad();
                    }
                    break;
                case "notaEntrada":
                    if (uCNotaEntrada == null)
                    {
                        this.uCNotaEntrada = new Admeli.AlmacenBox.UCNotaEntrada(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCNotaEntrada);
                        this.uCNotaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCNotaEntrada.Location = new System.Drawing.Point(0, 0);
                        this.uCNotaEntrada.Name = "uCNotaEntrada";
                        this.uCNotaEntrada.Size = new System.Drawing.Size(250, 776);
                        this.uCNotaEntrada.TabIndex = 0;

                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCNotaEntrada);
                        this.uCNotaEntrada.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            if (uCGuiaRemision != null) uCGuiaRemision.lisenerKeyEvents = false;
            if (uCNotaEntrada != null) uCNotaEntrada.lisenerKeyEvents = false;
            if (uCNotaEntrada != null) uCNotaEntrada.lisenerKeyEvents = false;
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
