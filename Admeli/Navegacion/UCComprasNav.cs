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
using Admeli.Compras;

namespace Admeli.Navegacion
{
    public partial class UCComprasNav : UserControl
    {

        private UCCompras uCCompras;
        private UCCuentaPagar uCCuentaPagar;
        private UCOrdenCompraProveedor uCOrdenCompraProveedor;
        private UCProveedores uCProveedores;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado

        private Panel panelMain;

        public UCComprasNav()
        {
            InitializeComponent();
        }

        public UCComprasNav(Panel panelMain)
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
                case "compras":
                    this.uCCompras = new Admeli.Compras.UCCompras();
                    this.panelMain.Controls.Add(uCCompras);
                    this.uCCompras.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCompras.Location = new System.Drawing.Point(0, 0);
                    this.uCCompras.Name = "uCCompras";
                    this.uCCompras.Size = new System.Drawing.Size(250, 776);
                    this.uCCompras.TabIndex = 0;
                    break;
                case "cuentaPagar":
                    this.uCCuentaPagar = new Admeli.Compras.UCCuentaPagar();
                    this.panelMain.Controls.Add(uCCuentaPagar);
                    this.uCCuentaPagar.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCuentaPagar.Location = new System.Drawing.Point(0, 0);
                    this.uCCuentaPagar.Name = "uCCuentaPagar";
                    this.uCCuentaPagar.Size = new System.Drawing.Size(250, 776);
                    this.uCCuentaPagar.TabIndex = 0;
                    break;
                case "ordenCompraProveedor":
                    this.uCOrdenCompraProveedor = new Admeli.Compras.UCOrdenCompraProveedor();
                    this.panelMain.Controls.Add(uCOrdenCompraProveedor);
                    this.uCOrdenCompraProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCOrdenCompraProveedor.Location = new System.Drawing.Point(0, 0);
                    this.uCOrdenCompraProveedor.Name = "uCOrdenCompraProveedor";
                    this.uCOrdenCompraProveedor.Size = new System.Drawing.Size(250, 776);
                    this.uCOrdenCompraProveedor.TabIndex = 0;
                    break;
                case "proveedores":
                    this.uCProveedores = new Admeli.Compras.UCProveedores();
                    this.panelMain.Controls.Add(uCProveedores);
                    this.uCProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCProveedores.Location = new System.Drawing.Point(0, 0);
                    this.uCProveedores.Name = "uCProveedores";
                    this.uCProveedores.Size = new System.Drawing.Size(250, 776);
                    this.uCProveedores.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void btnColor()
        {
            btnOredenCompra.BackColor = this.BackColor;
            btnCompras.BackColor = this.BackColor;
            btnProveedores.BackColor = this.BackColor;
            btnCuentaPagar.BackColor = this.BackColor;
        }

        private void btnOredenCompra_Click(object sender, EventArgs e)
        {
            togglePanelMain("ordenCompraProveedor");
            btnOredenCompra.BackColor = colorActive;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            togglePanelMain("compras");
            btnCompras.BackColor = colorActive;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            togglePanelMain("proveedores");
            btnProveedores.BackColor = colorActive;
        }

        private void btnCuentaPagar_Click(object sender, EventArgs e)
        {
            togglePanelMain("cuentaPagar");
            btnCuentaPagar.BackColor = colorActive;
        }
    }
}
