using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Compras;

namespace Admeli.Navigation
{
    public partial class UCComprasN : UserControl
    {
        private UCCompras uCCompras;
        private UCCuentaPagar uCCuentaPagar;
        private UCOrdenCompraProveedor uCOrdenCompraProveedor;
        private UCProveedores uCProveedores;

        private FormPrincipal formPrincipal;

        public UCComprasN()
        {
            InitializeComponent();
        }

        public UCComprasN(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void togglePanelMain(string panelName)
        {
            this.limpiarControles();
            switch (panelName)
            {
                case "compras":
                    if (uCCompras == null)
                    {
                        this.uCCompras = new Admeli.Compras.UCCompras(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCompras);
                        this.uCCompras.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCompras.Location = new System.Drawing.Point(0, 0);
                        this.uCCompras.Name = "uCCompras";
                        this.uCCompras.Size = new System.Drawing.Size(250, 776);
                        this.uCCompras.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCompras);
                        this.uCCompras.reLoad();
                    }
                    break;
                case "cuentaPagar":
                    if (uCCuentaPagar == null)
                    {
                        this.uCCuentaPagar = new Admeli.Compras.UCCuentaPagar(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCuentaPagar);
                        this.uCCuentaPagar.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCuentaPagar.Location = new System.Drawing.Point(0, 0);
                        this.uCCuentaPagar.Name = "uCCuentaPagar";
                        this.uCCuentaPagar.Size = new System.Drawing.Size(250, 776);
                        this.uCCuentaPagar.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCuentaPagar);
                        this.uCCuentaPagar.reLoad();
                    }
                    break;
                case "ordenCompraProveedor":
                    if (uCOrdenCompraProveedor == null)
                    {
                        this.uCOrdenCompraProveedor = new Admeli.Compras.UCOrdenCompraProveedor(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCOrdenCompraProveedor);
                        this.uCOrdenCompraProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCOrdenCompraProveedor.Location = new System.Drawing.Point(0, 0);
                        this.uCOrdenCompraProveedor.Name = "uCOrdenCompraProveedor";
                        this.uCOrdenCompraProveedor.Size = new System.Drawing.Size(250, 776);
                        this.uCOrdenCompraProveedor.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCOrdenCompraProveedor);
                        this.uCOrdenCompraProveedor.reLoad();
                    }
                    break;
                case "proveedores":
                    if (uCProveedores == null)
                    {
                        this.uCProveedores = new Admeli.Compras.UCProveedores(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCProveedores);
                        this.uCProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProveedores.Location = new System.Drawing.Point(0, 0);
                        this.uCProveedores.Name = "uCProveedores";
                        this.uCProveedores.Size = new System.Drawing.Size(250, 776);
                        this.uCProveedores.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCProveedores);
                        this.uCProveedores.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            if (uCProveedores != null) uCProveedores.lisenerKeyEvents = false;
            if (uCOrdenCompraProveedor != null) uCOrdenCompraProveedor.lisenerKeyEvents = false;
            if (uCCompras != null) uCCompras.lisenerKeyEvents = false;
            if (uCCuentaPagar != null) uCCuentaPagar.lisenerKeyEvents = false;
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            togglePanelMain("ordenCompraProveedor");
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            togglePanelMain("compras");
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            togglePanelMain("proveedores");
        }

    }
}
