using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.CajaBox;

namespace Admeli.Navigation
{
    public partial class UCCajaN : UserControl
    {
        private UCCierreCaja uCCierreCaja;
        private UCEgresos uCEgresos;
        private UCIngresos uCIngresos;
        private UCIniciarCaja uCIniciarCaja;

        private FormPrincipal formPrincipal;

        public UCCajaN()
        {
            InitializeComponent();
        }

        public UCCajaN(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void togglePanelMain(string panelName)
        {
            limpiarControles();
            switch (panelName)
            {
                case "cierreCaja":
                    if (uCCierreCaja == null)
                    {
                        this.uCCierreCaja = new Admeli.CajaBox.UCCierreCaja(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCierreCaja);
                        this.uCCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCierreCaja.Location = new System.Drawing.Point(0, 0);
                        this.uCCierreCaja.Name = "uCCierreCaja";
                        this.uCCierreCaja.Size = new System.Drawing.Size(250, 776);
                        this.uCCierreCaja.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCierreCaja);
                        this.uCCierreCaja.reLoad();
                    }
                    break;
                case "egresos":
                    if (uCEgresos == null)
                    {
                        this.uCEgresos = new Admeli.CajaBox.UCEgresos(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCEgresos);
                        this.uCEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCEgresos.Location = new System.Drawing.Point(0, 0);
                        this.uCEgresos.Name = "uCEgresos";
                        this.uCEgresos.Size = new System.Drawing.Size(250, 776);
                        this.uCEgresos.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCEgresos);
                        this.uCEgresos.reLoad();
                    }
                    break;
                case "ingresos":
                    if (uCIngresos == null)
                    {
                        this.uCIngresos = new Admeli.CajaBox.UCIngresos(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCIngresos);
                        this.uCIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCIngresos.Location = new System.Drawing.Point(0, 0);
                        this.uCIngresos.Name = "uCIngresos";
                        this.uCIngresos.Size = new System.Drawing.Size(250, 776);
                        this.uCIngresos.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCIngresos);
                        this.uCIngresos.reLoad();
                    }
                    break;
                case "iniciarCaja":
                    if (uCIniciarCaja == null)
                    {
                        this.uCIniciarCaja = new Admeli.CajaBox.UCIniciarCaja(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCIniciarCaja);
                        this.uCIniciarCaja.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCIniciarCaja.Location = new System.Drawing.Point(0, 0);
                        this.uCIniciarCaja.Name = "uCIniciarCaja";
                        this.uCIniciarCaja.Size = new System.Drawing.Size(250, 776);
                        this.uCIniciarCaja.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCIniciarCaja);
                        this.uCIniciarCaja.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            this.formPrincipal.panelMenuRight.Size = new Size(0, this.formPrincipal.panelMenuRight.Size.Height);
            if (uCCierreCaja != null) uCCierreCaja.lisenerKeyEvents = false;
            if (uCEgresos != null) uCEgresos.lisenerKeyEvents = false;
            if (uCIngresos != null) uCIngresos.lisenerKeyEvents = false;
            if (uCIniciarCaja != null) uCIniciarCaja.lisenerKeyEvents = false;
        }

        private void btnColor()
        {
            /// Reset Color buttons
            btnEgreso.Textcolor = Color.FromArgb(139, 138, 141);
            btnIngreso.Textcolor = Color.FromArgb(139, 138, 141);
            btnIniciarCaja.Textcolor = Color.FromArgb(139, 138, 141);
            btnCierreCaja.Textcolor = Color.FromArgb(139, 138, 141);
            btnPorCobrar.Textcolor = Color.FromArgb(139, 138, 141);
            btnCuentaPagar.Textcolor = Color.FromArgb(139, 138, 141);
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("egresos");
            btnEgreso.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("ingresos");
            btnIngreso.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }

        private void btnPorCobrar_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("cuentaPorCobrar");
            btnPorCobrar.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }

        private void btnCuentaPagar_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("cuentaPorPagar");
            btnCuentaPagar.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }

        private void btnIniciarCaja_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("iniciarCaja");
            btnIniciarCaja.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            btnColor(); /// Reset
            togglePanelMain("cierreCaja");
            btnCierreCaja.Textcolor = Color.FromArgb(23, 203, 34); // Color
        }
    }
}
