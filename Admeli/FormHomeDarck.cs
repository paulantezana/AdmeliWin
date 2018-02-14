using Admeli.NavDarck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli
{
    public partial class FormHomeDarck : Form
    {
        private UCComprasNav uCComprasNav;
        private UCVentasNav uCVentasNav;
        private UCCajaNav uCCajaNav;
        private UCAlmacenNav UCAlmacenNav;
        private UCConfigNav uCConfigNav;
        private UCHerramientasNav uCHerramientasNav;
        private UCProductosNav uCProductosNav;

        public FormHomeDarck()
        {
            InitializeComponent();
        }

        private void btnColor()
        {
            btnCompra.Textcolor = Color.FromArgb(139, 138, 141);
            btnHerramienta.Textcolor = Color.FromArgb(139, 138, 141);
            btnVenta.Textcolor = Color.FromArgb(139, 138, 141);
            btnProducto.Textcolor = Color.FromArgb(139, 138, 141);
            btnCaja.Textcolor = Color.FromArgb(139, 138, 141);
            btnAlmacen.Textcolor = Color.FromArgb(139, 138, 141);
            btnReporte.Textcolor = Color.FromArgb(139, 138, 141);
            btnConfiguracion.Textcolor = Color.FromArgb(139, 138, 141);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnReporte.Location;
            btnReporte.Textcolor = Color.White;
            togglePanelMain("reporte");
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnHerramienta.Location;
            btnHerramienta.Textcolor = Color.White;
            togglePanelMain("herramientas");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnProducto.Location;
            btnProducto.Textcolor = Color.White;
            togglePanelMain("producto");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnAlmacen.Location;
            btnAlmacen.Textcolor = Color.White;
            togglePanelMain("almacen");
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCaja.Location;
            btnCaja.Textcolor = Color.White;
            togglePanelMain("caja");
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnVenta.Location;
            btnVenta.Textcolor = Color.White;
            togglePanelMain("ventas");
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCompra.Location;
            btnCompra.Textcolor = Color.White;
            togglePanelMain("compras");
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnConfiguracion.Location;
            btnConfiguracion.Textcolor = Color.White;
            togglePanelMain("configuracion");
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (panelAsideContainer.Size.Width > 60)
            {
                panelAsideContainer.Size = new Size(50, 700);
            }
            else
            {
                panelAsideContainer.Size = new Size(200, 700);
            }
        }


        #region ===================== Toogle panel navegations =====================
        internal void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            switch (panelName)
            {
                case "compras":
                    if (this.uCComprasNav == null)
                    {
                        this.uCComprasNav = new UCComprasNav(this);
                        this.panelMain.Controls.Add(uCComprasNav);
                        this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCComprasNav.Name = "uCComprasNav";
                        this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCComprasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCComprasNav);
                    }
                    break;
                case "ventas":
                    if (this.uCVentasNav == null)
                    {
                        this.uCVentasNav = new UCVentasNav(this);
                        this.panelMain.Controls.Add(uCVentasNav);
                        this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCVentasNav.Name = "uCVentasNav";
                        this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCVentasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCVentasNav);
                    }

                    break;
                case "caja":
                    if (this.uCCajaNav == null)
                    {
                        this.uCCajaNav = new UCCajaNav(this);
                        this.panelMain.Controls.Add(uCCajaNav);
                        this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                        this.uCCajaNav.Name = "uCCajaNav";
                        this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                        this.uCCajaNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCCajaNav);
                    }
                    break;
                case "almacen":
                    if (this.UCAlmacenNav == null)
                    {
                        this.UCAlmacenNav = new UCAlmacenNav(this);
                        this.panelMain.Controls.Add(UCAlmacenNav);
                        this.UCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.UCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                        this.UCAlmacenNav.Name = "UCAlmacenNav";
                        this.UCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                        this.UCAlmacenNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(UCAlmacenNav);
                    }
                    break;
                case "productos":
                    if (this.uCProductosNav == null)
                    {
                        this.uCProductosNav = new UCProductosNav(this);
                        this.panelMain.Controls.Add(uCProductosNav);
                        this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                        this.uCProductosNav.Name = "uCProductosNav";
                        this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                        this.uCProductosNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCProductosNav);
                    }

                    break;
                case "configuracion":
                    if (this.uCConfigNav == null)
                    {
                        this.uCConfigNav = new UCConfigNav(this);
                        this.panelMain.Controls.Add(uCConfigNav);
                        this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                        this.uCConfigNav.Name = "uCConfigNav";
                        this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                        this.uCConfigNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCConfigNav);
                    }

                    break;
                case "herramientas":
                    if (this.uCHerramientasNav == null)
                    {
                        this.uCHerramientasNav = new UCHerramientasNav(this);
                        this.panelMain.Controls.Add(uCHerramientasNav);
                        this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCHerramientasNav.Name = "uCHerramientasNav";
                        this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCHerramientasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCHerramientasNav);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion


    }
}
