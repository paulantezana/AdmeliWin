﻿using Admeli.Productos.Nuevo.PDetalle;
using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Productos.Nuevo
{
    public partial class FormProductoNuevo : Form
    {
        private UCAdicionalPD uCAdicionalPD { get; set; }
        private UCDescuentosPD uCDescuentosPD { get; set; }
        private UCGeneralesPD uCGeneralesPD { get; set; }
        private UCImpuestoPD uCImpuestoPD { get; set; }
        private UCStockPD uCStockPD { get; set; }
        private UCTiendaOnlinePD uCTiendaOnlinePD { get; set; } 

        public int currentIDProducto { get; set; }
        public Producto currentProducto { get; set; }
        public bool nuevo { get; set; }

        public ProductoModel productoModel = new ProductoModel();

        public FormProductoNuevo(Producto currentProducto)
        {
            InitializeComponent();
            this.currentProducto = currentProducto;
            this.currentIDProducto = currentProducto.idProducto;
            this.nuevo = false;
            this.reLoad();
        }

        public FormProductoNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
            this.reLoad();
        }

        #region =============================== TOGGLE Panels ===============================
        private void togglePanelMain(string panelName)
        {
            limpiarControles();
            btnColor();
            switch (panelName)
            {
                case "adicionales":
                    if (uCAdicionalPD == null)
                    {
                        this.uCAdicionalPD = new Admeli.Productos.Nuevo.PDetalle.UCAdicionalPD(this);
                        this.panelMainNP.Controls.Add(uCAdicionalPD);
                        this.uCAdicionalPD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAdicionalPD.Location = new System.Drawing.Point(0, 0);
                        this.uCAdicionalPD.Name = "uCAdicionalPD";
                        this.uCAdicionalPD.Size = new System.Drawing.Size(250, 776);
                        this.uCAdicionalPD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCAdicionalPD);
                        this.uCAdicionalPD.reLoad();
                    }
                    break;
                case "descuentos":
                    if (uCDescuentosPD == null)
                    {
                        this.uCDescuentosPD = new Admeli.Productos.Nuevo.PDetalle.UCDescuentosPD(this);
                        this.panelMainNP.Controls.Add(uCDescuentosPD);
                        this.uCDescuentosPD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDescuentosPD.Location = new System.Drawing.Point(0, 0);
                        this.uCDescuentosPD.Name = "uCDescuentosPD";
                        this.uCDescuentosPD.Size = new System.Drawing.Size(250, 776);
                        this.uCDescuentosPD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCDescuentosPD);
                        this.uCDescuentosPD.reLoad();
                    }
                    break;
                case "generales":
                    if (uCGeneralesPD == null)
                    {
                        this.uCGeneralesPD = new Admeli.Productos.Nuevo.PDetalle.UCGeneralesPD(this);
                        this.panelMainNP.Controls.Add(uCGeneralesPD);
                        this.uCGeneralesPD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCGeneralesPD.Location = new System.Drawing.Point(0, 0);
                        this.uCGeneralesPD.Name = "uCGeneralesPD";
                        this.uCGeneralesPD.Size = new System.Drawing.Size(250, 776);
                        this.uCGeneralesPD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCGeneralesPD);
                        this.uCGeneralesPD.reLoad();
                    }
                    break;
                case "impuestos":
                    if (uCImpuestoPD == null)
                    {
                        this.uCImpuestoPD = new Admeli.Productos.Nuevo.PDetalle.UCImpuestoPD(this);
                        this.panelMainNP.Controls.Add(uCImpuestoPD);
                        this.uCImpuestoPD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCImpuestoPD.Location = new System.Drawing.Point(0, 0);
                        this.uCImpuestoPD.Name = "uCImpuestoPD";
                        this.uCImpuestoPD.Size = new System.Drawing.Size(250, 776);
                        this.uCImpuestoPD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCImpuestoPD);
                        this.uCImpuestoPD.reLoad();
                    }
                    break;
                case "stock":
                    if (uCStockPD == null)
                    {
                        this.uCStockPD = new Admeli.Productos.Nuevo.PDetalle.UCStockPD(this);
                        this.panelMainNP.Controls.Add(uCStockPD);
                        this.uCStockPD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCStockPD.Location = new System.Drawing.Point(0, 0);
                        this.uCStockPD.Name = "uCStockPD";
                        this.uCStockPD.Size = new System.Drawing.Size(250, 776);
                        this.uCStockPD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCStockPD);
                        this.uCStockPD.reLoad();
                    }
                    break;
                case "tiendaOnline":
                    if (uCTiendaOnlinePD == null)
                    {
                        this.uCTiendaOnlinePD = new Admeli.Productos.Nuevo.PDetalle.UCTiendaOnlinePD(this);
                        this.panelMainNP.Controls.Add(uCTiendaOnlinePD);
                        this.uCTiendaOnlinePD.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCTiendaOnlinePD.Location = new System.Drawing.Point(0, 0);
                        this.uCTiendaOnlinePD.Name = "uCIniciarCaja";
                        this.uCTiendaOnlinePD.Size = new System.Drawing.Size(250, 776);
                        this.uCTiendaOnlinePD.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMainNP.Controls.Add(uCTiendaOnlinePD);
                        this.uCTiendaOnlinePD.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.panelMainNP.Controls.Clear();
            if (uCAdicionalPD != null) uCAdicionalPD.lisenerKeyEvents = false;
            if (uCDescuentosPD != null) uCDescuentosPD.lisenerKeyEvents = false;
            if (uCGeneralesPD != null) uCGeneralesPD.lisenerKeyEvents = false;
            if (uCImpuestoPD != null) uCImpuestoPD.lisenerKeyEvents = false;
            if (uCStockPD != null) uCStockPD.lisenerKeyEvents = false;
            if (uCTiendaOnlinePD != null) uCTiendaOnlinePD.lisenerKeyEvents = false;
        }

        private void btnColor()
        {
            btnGenerales.BackColor = Color.FromArgb(230, 231, 232);
            btnStock.BackColor = Color.FromArgb(230, 231, 232);
            btnOtros.BackColor = Color.FromArgb(230, 231, 232);
            btnImpuestos.BackColor = Color.FromArgb(230, 231, 232);
            btnOfertas.BackColor = Color.FromArgb(230, 231, 232);
            btnWeb.BackColor = Color.FromArgb(230, 231, 232);
        }

        public void appLoadState(bool state)
        {
            if (state)
            {
                Cursor.Current = Cursors.WaitCursor;
                progressBarApp.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                Cursor.Current = Cursors.Default;
                progressBarApp.Style = ProgressBarStyle.Blocks;
            }
        }

        private void FormProductoNuevo_Load(object sender, EventArgs e)
        {
            togglePanelMain("generales");
            btnGenerales.BackColor = Color.White;
        }

        private void btnGenerales_Click(object sender, EventArgs e)
        {
            togglePanelMain("generales");
            btnGenerales.BackColor = Color.White;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            togglePanelMain("stock");
            btnStock.BackColor = Color.White;
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            togglePanelMain("adicionales");
            btnOtros.BackColor = Color.White;
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            togglePanelMain("impuestos");
            btnImpuestos.BackColor = Color.White;
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            togglePanelMain("descuentos");
            btnOfertas.BackColor = Color.White;
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            togglePanelMain("tiendaOnline");
            btnWeb.BackColor = Color.White;
        }
        #endregion

        #region ============================ Root Load ============================
        internal void reLoad()
        {
            if (this.nuevo)
            {
                this.btnImpuestos.Enabled = false;
                this.btnOfertas.Enabled = false;
                this.btnOtros.Enabled = false;
                this.btnWeb.Enabled = false;
                this.btnStock.Enabled = false;
            }
            else
            {
                this.btnImpuestos.Enabled = true;
                this.btnOfertas.Enabled = true;
                this.btnOtros.Enabled = true;
                this.btnWeb.Enabled = true;
                this.btnStock.Enabled = true;
                this.Text = "MANTENIMIENTO PRODUCTO " + currentProducto.nombreProducto;
                cargarDatosModificar();
            }
        } 
        #endregion

        private async void cargarDatosModificar()
        {
            currentProducto = await productoModel.productoDatos(currentIDProducto);
        }

        #region ========================== Guardar ==========================
        internal async void executeGuardar()
        {
            // Ejecutando el guardado
            try
            {
                if (nuevo)
                {
                    Response response = await productoModel.guardar(currentProducto);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Consulta de guardar =============================================
                    this.nuevo = false;
                }
                else
                {
                    Response response = await productoModel.modificar(currentProducto);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal async void executeGuardarSalir()
        {
            // Ejecutando el guardado
            try
            {
                if (nuevo)
                {
                    Response response = await productoModel.guardar(currentProducto);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await productoModel.modificar(currentProducto);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
        #endregion
    }
}
