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
using Admeli.Ventas;

namespace Admeli.Navegacion
{
    public partial class UCVentasNav : UserControl
    {
        private UCClientes uCClientes;
        private UCCotizacionCliente uCCotizacionCliente;
        private UCCuentaCobrar uCCuentaCobrar;
        private UCVentas uCVentas;

        private Color colorActive = Color.FromArgb(243, 243, 243);  // Color que se muestra del ultimo voton clikeado
        private FormPrincipal formPrincipal;

        public UCVentasNav()
        {
            InitializeComponent();
        }

        public UCVentasNav(FormPrincipal formPrincipal)
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
                case "clientes":
                    if (uCClientes == null)
                    {
                        this.uCClientes = new Admeli.Ventas.UCClientes(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCClientes);
                        this.uCClientes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCClientes.Location = new System.Drawing.Point(0, 0);
                        this.uCClientes.Name = "uCClientes";
                        this.uCClientes.Size = new System.Drawing.Size(250, 776);
                        this.uCClientes.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCClientes);
                        this.uCClientes.reLoad();
                    }

                    break;
                case "contizacionCliente":
                    if (uCCotizacionCliente == null)
                    {
                        this.uCCotizacionCliente = new Admeli.Ventas.UCCotizacionCliente(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCotizacionCliente);
                        this.uCCotizacionCliente.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCotizacionCliente.Location = new System.Drawing.Point(0, 0);
                        this.uCCotizacionCliente.Name = "uCCotizacionCliente";
                        this.uCCotizacionCliente.Size = new System.Drawing.Size(250, 776);
                        this.uCCotizacionCliente.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCotizacionCliente);
                        this.uCCotizacionCliente.reLoad();
                    }

                    break;
                case "cuentaCobrar":
                    if (uCCuentaCobrar == null)
                    {
                        this.uCCuentaCobrar = new Admeli.Ventas.UCCuentaCobrar(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCuentaCobrar);
                        this.uCCuentaCobrar.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCuentaCobrar.Location = new System.Drawing.Point(0, 0);
                        this.uCCuentaCobrar.Name = "uCCuentaCobrar";
                        this.uCCuentaCobrar.Size = new System.Drawing.Size(250, 776);
                        this.uCCuentaCobrar.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCuentaCobrar);
                        this.uCCuentaCobrar.reLoad();
                    }

                    break;
                case "ventas":
                    if (uCVentas == null)
                    {
                        this.uCVentas = new Admeli.Ventas.UCVentas(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCVentas);
                        this.uCVentas.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentas.Location = new System.Drawing.Point(0, 0);
                        this.uCVentas.Name = "uCVentas";
                        this.uCVentas.Size = new System.Drawing.Size(250, 776);
                        this.uCVentas.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCVentas);
                        this.uCVentas.reLoad();
                    }
                    break;
                case "ventaTouch":
                    FormVentaTouch ventaTouch = new FormVentaTouch();
                    ventaTouch.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            if (uCClientes != null) uCClientes.lisenerKeyEvents = false;
            if (uCCotizacionCliente != null) uCCotizacionCliente.lisenerKeyEvents = false;
            if (uCCuentaCobrar != null) uCCuentaCobrar.lisenerKeyEvents = false;
            if (uCVentas != null) uCVentas.lisenerKeyEvents = false;
        }

        // Limpi la decoracion de colores
        private void btnColor()
        {
            btnClientes.BackColor = this.BackColor;
            btnCotizacionCliente.BackColor = this.BackColor;
            btnCuentasPorCobrar.BackColor = this.BackColor;
            btnVentas.BackColor = this.BackColor;
            btnVentaTouch.BackColor = this.BackColor;
        }

        private void btnCotizacionCliente_Click(object sender, EventArgs e)
        {
            togglePanelMain("contizacionCliente");
            btnCotizacionCliente.BackColor = this.colorActive;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            togglePanelMain("ventas");
            btnVentas.BackColor = this.colorActive;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            togglePanelMain("clientes");
            btnClientes.BackColor = this.colorActive;
        }

        private void btnCuentasPorCobrar_Click(object sender, EventArgs e)
        {
            togglePanelMain("cuentaCobrar");
            btnCuentasPorCobrar.BackColor = this.colorActive;
        }

        private void btnVentaTouch_Click(object sender, EventArgs e)
        {
            togglePanelMain("ventaTouch");
            btnVentaTouch.BackColor = this.colorActive;
        }
    }
}
