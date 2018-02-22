﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Herramientas;

namespace Admeli.Navigation.SubMenu
{
    public partial class UCHerramientasNav : UserControl
    {
        private UCAsignarCategorias uCAsignarCategorias;
        private UCAsignarImpuesto uCAsignarImpuesto;
        private UCInicializarStock uCInicializarStock;

        private UCTiendaRoot uCTiendaRoot;
        private FormPrincipal formPrincipal;

        public UCHerramientasNav()
        {
            InitializeComponent();
        }

        public UCHerramientasNav(FormPrincipal formPrincipal, UCTiendaRoot uCTiendaRoot)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.uCTiendaRoot = uCTiendaRoot;
        }

        private void togglePanelMain(string panelName)
        {
            limpiarControles();
            switch (panelName)
            {
                case "asignarCategoria":
                    if (uCAsignarCategorias == null)
                    {
                        this.uCAsignarCategorias = new Admeli.Herramientas.UCAsignarCategorias(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarCategorias);
                        this.uCAsignarCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAsignarCategorias.Location = new System.Drawing.Point(0, 0);
                        this.uCAsignarCategorias.Name = "uCAsignarCategorias";
                        this.uCAsignarCategorias.Size = new System.Drawing.Size(250, 776);
                        this.uCAsignarCategorias.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarCategorias);
                        this.uCAsignarCategorias.reLoad();
                    }

                    break;
                case "asignarImpuesto":
                    if (uCAsignarImpuesto == null)
                    {
                        this.uCAsignarImpuesto = new Admeli.Herramientas.UCAsignarImpuesto(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarImpuesto);
                        this.uCAsignarImpuesto.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAsignarImpuesto.Location = new System.Drawing.Point(0, 0);
                        this.uCAsignarImpuesto.Name = "uCCotizacionCliente";
                        this.uCAsignarImpuesto.Size = new System.Drawing.Size(250, 776);
                        this.uCAsignarImpuesto.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarImpuesto);
                        this.uCAsignarImpuesto.reLoad();
                    }

                    break;
                case "inicializarStock":
                    if (uCInicializarStock == null)
                    {
                        this.uCInicializarStock = new Admeli.Herramientas.UCInicializarStock(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCInicializarStock);
                        this.uCInicializarStock.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCInicializarStock.Location = new System.Drawing.Point(0, 0);
                        this.uCInicializarStock.Name = "uCInicializarStock";
                        this.uCInicializarStock.Size = new System.Drawing.Size(250, 776);
                        this.uCInicializarStock.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCInicializarStock);
                        this.uCInicializarStock.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            if (uCAsignarCategorias != null) uCAsignarCategorias.lisenerKeyEvents = false;
            if (uCAsignarImpuesto != null) uCAsignarImpuesto.lisenerKeyEvents = false;
            if (uCInicializarStock != null) uCInicializarStock.lisenerKeyEvents = false;
        }

        private void btnPrecioStock_Click(object sender, EventArgs e)
        {
            togglePanelMain("inicializarStock");
        }

        private void btnAsignarCategoria_Click(object sender, EventArgs e)
        {
            togglePanelMain("asignarCategoria");
        }

        private void btnAsignarImpuesto_Click(object sender, EventArgs e)
        {
            togglePanelMain("asignarImpuesto");
        }

        private void btnGenerarCodigoDeBarra_Click(object sender, EventArgs e)
        {
            togglePanelMain("codigoDeBarra");
        }

    }
}
