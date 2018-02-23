﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Productos;

namespace Admeli.Navigation.SubMenu
{
    public partial class UCProductosNav : UserControl
    {
        public UCListadoProducto uCListadoProducto;
        public UCMarcas uCMarcas;
        public UCUnidadesMedida uCUnidadesMedida;
        public UCCategorias uCCategorias;

        private UCTiendaRoot uCTiendaRoot;
        private FormPrincipal formPrincipal;

        public UCProductosNav()
        {
            InitializeComponent();
        }

        public UCProductosNav(FormPrincipal formPrincipal, UCTiendaRoot uCTiendaRoot)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.uCTiendaRoot = uCTiendaRoot;
        }

        public void togglePanelMain(string panelName)
        {
            limpiarControles();
            switch (panelName)
            {
                case "listadoProducto":
                    if (uCListadoProducto == null)
                    {
                        this.uCListadoProducto = new Admeli.Productos.UCListadoProducto(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCListadoProducto);
                        this.uCListadoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCListadoProducto.Location = new System.Drawing.Point(0, 0);
                        this.uCListadoProducto.Name = "uCListadoProducto";
                        this.uCListadoProducto.Size = new System.Drawing.Size(250, 776);
                        this.uCListadoProducto.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCListadoProducto);
                        this.uCListadoProducto.reLoad();
                    }
                    formPrincipal.lblTitlePage.Text = "Producto - Listar Productos"; /// Titulo en el encabezado
                    break;
                case "marcas":
                    if (uCMarcas == null)
                    {
                        this.uCMarcas = new Admeli.Productos.UCMarcas(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCMarcas);
                        this.uCMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCMarcas.Location = new System.Drawing.Point(0, 0);
                        this.uCMarcas.Name = "uCMarcas";
                        this.uCMarcas.Size = new System.Drawing.Size(250, 776);
                        this.uCMarcas.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCMarcas);
                        this.uCMarcas.reLoad();
                    }
                    formPrincipal.lblTitlePage.Text = "Producto - Marcas"; /// Titulo en el encabezado
                    break;
                case "unidadesMedida":
                    if (uCUnidadesMedida == null)
                    {
                        this.uCUnidadesMedida = new Admeli.Productos.UCUnidadesMedida(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCUnidadesMedida);
                        this.uCUnidadesMedida.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCUnidadesMedida.Location = new System.Drawing.Point(0, 0);
                        this.uCUnidadesMedida.Name = "uCUnidadesMedida";
                        this.uCUnidadesMedida.Size = new System.Drawing.Size(250, 776);
                        this.uCUnidadesMedida.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCUnidadesMedida);
                        this.uCUnidadesMedida.reLoad();
                    }
                    formPrincipal.lblTitlePage.Text = "Producto - Unidad Medida"; /// Titulo en el encabezado
                    break;
                case "categorias":
                    if (uCCategorias == null)
                    {
                        this.uCCategorias = new Admeli.Productos.UCCategorias(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCategorias);
                        this.uCCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCategorias.Location = new System.Drawing.Point(0, 0);
                        this.uCCategorias.Name = "uCCategorias";
                        this.uCCategorias.Size = new System.Drawing.Size(250, 776);
                        this.uCCategorias.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCategorias);
                        this.uCCategorias.reLoad();
                    }
                    formPrincipal.lblTitlePage.Text = "Producto - Categorias"; /// Titulo en el encabezado
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            this.formPrincipal.hideMenuRight(); /// Ocultar el menu derecho del formulario principal
            if (uCListadoProducto != null) uCListadoProducto.lisenerKeyEvents = false;
            if (uCMarcas != null) uCMarcas.lisenerKeyEvents = false;
            if (uCUnidadesMedida != null) uCUnidadesMedida.lisenerKeyEvents = false;
            if (uCCategorias != null) uCCategorias.lisenerKeyEvents = false;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            togglePanelMain("listadoProducto");
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            togglePanelMain("marcas");
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            togglePanelMain("unidadesMedida");
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            togglePanelMain("categorias");
        }

    }
}
