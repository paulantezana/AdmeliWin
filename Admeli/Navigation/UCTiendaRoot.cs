﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Navigation.SubMenu;

namespace Admeli.Navigation
{
    public partial class UCTiendaRoot : UserControl
    {
        // User control preparado para main = contenedor principal
        private UCComprasNav uCComprasNav;
        private UCVentasNav uCVentasNav;
        private UCCajaNav uCCajaNav;
        private UCAlmacenNav uCAlmacenNav;
        private UCHerramientasNav uCHerramientasNav;
        private UCReporteNav uCReporteNav;
        private UCProductosNav uCProductosNav;
        private UCConfigNav uCConfigNav;

        private FormPrincipal formPrincipal;

        public UCTiendaRoot()
        {
            InitializeComponent();
        }

        public UCTiendaRoot(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        internal void togglePanelAsideMain(string panelName)
        {
            this.panelMulos.Controls.Clear();
            this.formPrincipal.showMenuLeft(); /// Muestra el panel izquierdo si esta oculto
            switch (panelName)
            {
                case "compras":
                    if (this.uCComprasNav == null)
                    {
                        this.uCComprasNav = new UCComprasNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCComprasNav);
                        this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCComprasNav.Name = "uCComprasNav";
                        this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCComprasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCComprasNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Compras - "; /// Titulo en el encabezado
                    break;
                case "ventas":
                    if (this.uCVentasNav == null)
                    {
                        this.uCVentasNav = new UCVentasNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCVentasNav);
                        this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCVentasNav.Name = "uCVentasNav";
                        this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCVentasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCVentasNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Ventas - "; /// Titulo en el encabezado
                    break;
                case "caja":
                    if (this.uCCajaNav == null)
                    {
                        this.uCCajaNav = new UCCajaNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCCajaNav);
                        this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                        this.uCCajaNav.Name = "uCCajaNav";
                        this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                        this.uCCajaNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCCajaNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Caja - "; /// Titulo en el encabezado
                    break;
                case "almacen":
                    if (this.uCAlmacenNav == null)
                    {
                        this.uCAlmacenNav = new UCAlmacenNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCAlmacenNav);
                        this.uCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                        this.uCAlmacenNav.Name = "uCAlmacenNav";
                        this.uCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                        this.uCAlmacenNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCAlmacenNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Almacen - "; /// Titulo en el encabezado
                    break;
                case "productos":
                    if (this.uCProductosNav == null)
                    {
                        this.uCProductosNav = new UCProductosNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCProductosNav);
                        this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                        this.uCProductosNav.Name = "uCProductosNav";
                        this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                        this.uCProductosNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCProductosNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Productos - "; /// Titulo en el encabezado
                    break;
                case "herramientas":
                    if (this.uCHerramientasNav == null)
                    {
                        this.uCHerramientasNav = new UCHerramientasNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCHerramientasNav);
                        this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCHerramientasNav.Name = "uCHerramientasNav";
                        this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCHerramientasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCHerramientasNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Herramientas - "; /// Titulo en el encabezado
                    break;
                case "reportes":
                    if (this.uCReporteNav == null)
                    {
                        this.uCReporteNav = new UCReporteNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCReporteNav);
                        this.uCReporteNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCReporteNav.Location = new System.Drawing.Point(0, 0);
                        this.uCReporteNav.Name = "uCReporteNav";
                        this.uCReporteNav.Size = new System.Drawing.Size(250, 776);
                        this.uCReporteNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCReporteNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Reportes - "; /// Titulo en el encabezado
                    break;
                case "config":
                    if (this.uCConfigNav == null)
                    {
                        this.uCConfigNav = new UCConfigNav(formPrincipal, this);
                        this.panelMulos.Controls.Add(uCConfigNav);
                        this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                        this.uCConfigNav.Name = "uCConfigNav";
                        this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                        this.uCConfigNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMulos.Controls.Add(uCConfigNav);
                    }
                    this.formPrincipal.lblTitlePage.Text = "Configuracion - "; /// Titulo en el encabezado
                    break;
                default:
                    break;
            }
        }

        private void btnColor()
        {
            /// Reset Color Text
            btnCompra.ForeColor = Color.FromArgb(139, 138, 141);
            btnHerramienta.ForeColor = Color.FromArgb(139, 138, 141);
            btnVenta.ForeColor = Color.FromArgb(139, 138, 141);
            btnProducto.ForeColor = Color.FromArgb(139, 138, 141);
            btnCaja.ForeColor = Color.FromArgb(139, 138, 141);
            btnAlmacen.ForeColor = Color.FromArgb(139, 138, 141);
            btnReporte.ForeColor = Color.FromArgb(139, 138, 141);
            btnConfiguracion.ForeColor = Color.FromArgb(139, 138, 141);

            // Reset Back Color
            btnCompra.BackColor = Color.FromArgb(52, 49, 58);
            btnHerramienta.BackColor = Color.FromArgb(52, 49, 58);
            btnVenta.BackColor = Color.FromArgb(52, 49, 58);
            btnProducto.BackColor = Color.FromArgb(52, 49, 58);
            btnCaja.BackColor = Color.FromArgb(52, 49, 58);
            btnAlmacen.BackColor = Color.FromArgb(52, 49, 58);
            btnReporte.BackColor = Color.FromArgb(52, 49, 58);
            btnConfiguracion.BackColor = Color.FromArgb(52, 49, 58);

            // ICONS cambiar el indice
            btnVenta.ImageIndex = 0;
            btnCompra.ImageIndex = 2;
            btnProducto.ImageIndex = 4;
            btnAlmacen.ImageIndex = 6;
            btnCaja.ImageIndex = 8;
            btnHerramienta.ImageIndex = 10;
            btnReporte.ImageIndex = 12;
            btnConfiguracion.ImageIndex = 14;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnVenta.Location; /// Decoracion
            btnVenta.ForeColor = Color.White; /// Color
            btnVenta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("ventas"); /// Navegar
            btnVenta.ImageIndex = 1; /// Indice imagen
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnCompra.Location; /// Decoracion
            btnCompra.ForeColor = Color.White; /// Color
            btnCompra.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("compras"); /// Navegar
            btnCompra.ImageIndex = 3; /// Indice imagen
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnProducto.Location; /// Decoracion
            btnProducto.ForeColor = Color.White; /// Color
            btnProducto.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("productos"); /// Navegar
            btnProducto.ImageIndex = 5; /// Indice imagen
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnAlmacen.Location; /// Decoracion
            btnAlmacen.ForeColor = Color.White; /// Color
            btnAlmacen.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("almacen"); /// Navegar
            btnAlmacen.ImageIndex = 7; /// Indice imagen
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnCaja.Location; /// Decoracion
            btnCaja.ForeColor = Color.White; /// Color
            btnCaja.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("caja"); /// Navegar
            btnCaja.ImageIndex = 9; /// Indice imagen
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnHerramienta.Location; /// Decoracion
            btnHerramienta.ForeColor = Color.White; /// Color
            btnHerramienta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("herramientas"); /// Navegar
            btnHerramienta.ImageIndex = 11; /// Indice imagen
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnReporte.Location; /// Decoracion
            btnReporte.ForeColor = Color.White; /// Color
            btnReporte.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("reportes"); /// Navegar
            btnReporte.ImageIndex = 13; /// Indice imagen
        }

        // ================================================================================
        //      -- Mostrar Panel por defecto
        //      ----------------------------
        //

        private void UCTiendaRoot_Load(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnVenta.Location; /// Decoracion
            btnVenta.ForeColor = Color.White; /// Color
            btnVenta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("ventas"); /// Navegar
            btnVenta.ImageIndex = 1; /// Indice imagen
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnConfiguracion.Location; /// Decoracion
            btnConfiguracion.ForeColor = Color.White; /// Color
            btnConfiguracion.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("config"); /// Navegar
            btnConfiguracion.ImageIndex = 15; /// Indice imagen
        }
    }
}
