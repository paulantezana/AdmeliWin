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

        private Panel panelMain;
        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado

        public UCVentasNav()
        {
            InitializeComponent();
        }

        public UCVentasNav(Panel panelMain)
        {
            InitializeComponent();
            this.panelMain = panelMain;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            btnColor();
            switch (panelName)
            {
                case "clientes":
                    this.uCClientes = new Admeli.Ventas.UCClientes();
                    this.panelMain.Controls.Add(uCClientes);
                    this.uCClientes.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCClientes.Location = new System.Drawing.Point(0, 0);
                    this.uCClientes.Name = "uCClientes";
                    this.uCClientes.Size = new System.Drawing.Size(250, 776);
                    this.uCClientes.TabIndex = 0;
                    break;
                case "contizacionCliente":
                    this.uCCotizacionCliente = new Admeli.Ventas.UCCotizacionCliente();
                    this.panelMain.Controls.Add(uCCotizacionCliente);
                    this.uCCotizacionCliente.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCotizacionCliente.Location = new System.Drawing.Point(0, 0);
                    this.uCCotizacionCliente.Name = "uCCotizacionCliente";
                    this.uCCotizacionCliente.Size = new System.Drawing.Size(250, 776);
                    this.uCCotizacionCliente.TabIndex = 0;
                    break;
                case "cuentaCobrar":
                    this.uCCuentaCobrar = new Admeli.Ventas.UCCuentaCobrar();
                    this.panelMain.Controls.Add(uCCuentaCobrar);
                    this.uCCuentaCobrar.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCuentaCobrar.Location = new System.Drawing.Point(0, 0);
                    this.uCCuentaCobrar.Name = "uCCuentaCobrar";
                    this.uCCuentaCobrar.Size = new System.Drawing.Size(250, 776);
                    this.uCCuentaCobrar.TabIndex = 0;
                    break;
                case "ventas":
                    this.uCVentas = new Admeli.Ventas.UCVentas();
                    this.panelMain.Controls.Add(uCVentas);
                    this.uCVentas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVentas.Location = new System.Drawing.Point(0, 0);
                    this.uCVentas.Name = "uCVentas";
                    this.uCVentas.Size = new System.Drawing.Size(250, 776);
                    this.uCVentas.TabIndex = 0;
                    break;
                case "ventaTouch":
                    FormVentaTouch ventaTouch = new FormVentaTouch();
                    ventaTouch.ShowDialog();
                    break;
                default:
                    break;
            }
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
