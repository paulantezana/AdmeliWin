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
using Admeli.CajaBox;

namespace Admeli.Navegacion
{
    public partial class UCCajaNav : UserControl
    {

        private UCCierreCaja uCCierreCaja;
        private UCEgresos uCEgresos;
        private UCIngresos uCIngresos;
        private UCIniciarCaja uCIniciarCaja;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado
        private FormPrincipal formPrincipal;

        public UCCajaNav()
        {
            InitializeComponent();
        }

        public UCCajaNav(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void togglePanelMain(string panelName)
        {
            limpiarControles();
            btnColor();
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
            if (uCCierreCaja != null) uCCierreCaja.lisenerKeyEvents = false;
            if (uCEgresos != null) uCEgresos.lisenerKeyEvents = false;
            if (uCIngresos != null) uCIngresos.lisenerKeyEvents = false;
            if (uCIniciarCaja != null) uCIniciarCaja.lisenerKeyEvents = false;
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
