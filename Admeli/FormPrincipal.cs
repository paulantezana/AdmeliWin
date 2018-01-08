using Admeli.Componentes;
using Admeli.Compras;
using Admeli.Navegacion;
using Admeli.Productos;
using Admeli.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli
{
    public partial class btnCaja : Form
    {
        private UCComprasNav uCComprasNav;
        private UCVentasNav uCVentasNav;
        private UCCajaNav uCCajaNav;
        private UCAlmacenNav UCAlmacenNav;
        private UCConfigNav uCConfigNav;
        private UCHerramientasNav uCHerramientasNav;
        private UCProductosNav uCProductosNav;

        private UCVentas uCVentas;
        private UCListadoProducto uCListadoProducto;
        private UCCompras uCCompras;

        private int widthPanelAside { get; set; }

        public btnCaja()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnToogleAside_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.togglePanelAside("compras");
        }

        private void togglePanelAside(string panelName)
        {
            this.panelAsideMain.Controls.Clear();
            switch (panelName)
            {
                case "compras":
                    this.uCComprasNav = new Admeli.Navegacion.UCComprasNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCComprasNav);
                    this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCComprasNav.Name = "uCComprasNav";
                    this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCComprasNav.TabIndex = 0;
                    break;
                case "ventas":
                    this.uCVentasNav = new Admeli.Navegacion.UCVentasNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCVentasNav);
                    this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCVentasNav.Name = "uCVentasNav";
                    this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCVentasNav.TabIndex = 0;
                    break;
                case "caja":
                    this.uCCajaNav = new Admeli.Navegacion.UCCajaNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCCajaNav);
                    this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                    this.uCCajaNav.Name = "uCCajaNav";
                    this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                    this.uCCajaNav.TabIndex = 0;
                    break;
                case "almacen":
                    this.UCAlmacenNav = new Admeli.Navegacion.UCAlmacenNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(UCAlmacenNav);
                    this.UCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.UCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                    this.UCAlmacenNav.Name = "UCAlmacenNav";
                    this.UCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                    this.UCAlmacenNav.TabIndex = 0;
                    break;
                case "productos":
                    this.uCProductosNav = new Admeli.Navegacion.UCProductosNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCProductosNav);
                    this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                    this.uCProductosNav.Name = "uCProductosNav";
                    this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                    this.uCProductosNav.TabIndex = 0;
                    break;
                case "configuracion":
                    this.uCConfigNav = new Admeli.Navegacion.UCConfigNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCConfigNav);
                    this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                    this.uCConfigNav.Name = "uCConfigNav";
                    this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                    this.uCConfigNav.TabIndex = 0;
                    break;
                case "herramientas":
                    this.uCHerramientasNav = new Admeli.Navegacion.UCHerramientasNav(this.panelMain);
                    this.panelAsideMain.Controls.Add(uCHerramientasNav);
                    this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCHerramientasNav.Name = "uCHerramientasNav";
                    this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCHerramientasNav.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }


        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            switch (panelName)
            {
                case "ventas":
                    this.uCVentas = new Admeli.Ventas.UCVentas();
                    this.panelMain.Controls.Add(uCVentas);
                    this.uCVentas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVentas.Location = new System.Drawing.Point(0, 0);
                    this.uCVentas.Name = "uCVentas";
                    this.uCVentas.Size = new System.Drawing.Size(250, 776);
                    this.uCVentas.TabIndex = 0;
                    break;
                case "compras":
                    this.uCCompras = new Admeli.Compras.UCCompras();
                    this.panelMain.Controls.Add(uCCompras);
                    this.uCCompras.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCompras.Location = new System.Drawing.Point(0, 0);
                    this.uCCompras.Name = "uCCompras";
                    this.uCCompras.Size = new System.Drawing.Size(250, 776);
                    this.uCCompras.TabIndex = 0;
                    break;
                case "productos":
                    this.uCListadoProducto = new Admeli.Productos.UCListadoProducto();
                    this.panelMain.Controls.Add(uCListadoProducto);
                    this.uCListadoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCListadoProducto.Location = new System.Drawing.Point(0, 0);
                    this.uCListadoProducto.Name = "uCListadoProducto";
                    this.uCListadoProducto.Size = new System.Drawing.Size(250, 776);
                    this.uCListadoProducto.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            togglePanelAside("ventas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            togglePanelAside("caja");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            togglePanelAside("almacen");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            togglePanelAside("configuracion");
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            togglePanelAside("herramientas");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            togglePanelAside("productos");
        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelProfile);
        }

        private void btnVentaShorkout_Click(object sender, EventArgs e)
        {
            togglePanelMain("ventas");
        }

        private void btnProductoShortcut_Click(object sender, EventArgs e)
        {
            togglePanelMain("productos");
        }

        private void btnComprasShortcut_Click(object sender, EventArgs e)
        {
            togglePanelMain("compras");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
