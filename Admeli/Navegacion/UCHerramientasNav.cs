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
using Admeli.Herramientas;

namespace Admeli.Navegacion
{
    public partial class UCHerramientasNav : UserControl
    {
        private UCAsignarCategorias uCAsignarCategorias;
        private UCAsignarImpuesto UCAsignarImpuesto;
        private UCInicializarStock uCInicializarStock;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado
        private FormPrincipal formPrincipal;

        public UCHerramientasNav()
        {
            InitializeComponent();
        }

        public UCHerramientasNav(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader, 220, 220, 220);
        }

        private void togglePanelMain(string panelName)
        {
            this.formPrincipal.panelMain.Controls.Clear();
            btnColor();
            switch (panelName)
            {
                case "asignarCategoria":
                    this.uCAsignarCategorias = new Admeli.Herramientas.UCAsignarCategorias(this.formPrincipal);
                    this.formPrincipal.panelMain.Controls.Add(uCAsignarCategorias);
                    this.uCAsignarCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCAsignarCategorias.Location = new System.Drawing.Point(0, 0);
                    this.uCAsignarCategorias.Name = "uCAsignarCategorias";
                    this.uCAsignarCategorias.Size = new System.Drawing.Size(250, 776);
                    this.uCAsignarCategorias.TabIndex = 0;
                    break;
                case "asignarImpuesto":
                    this.UCAsignarImpuesto = new Admeli.Herramientas.UCAsignarImpuesto(this.formPrincipal);
                    this.formPrincipal.panelMain.Controls.Add(UCAsignarImpuesto);
                    this.UCAsignarImpuesto.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.UCAsignarImpuesto.Location = new System.Drawing.Point(0, 0);
                    this.UCAsignarImpuesto.Name = "uCCotizacionCliente";
                    this.UCAsignarImpuesto.Size = new System.Drawing.Size(250, 776);
                    this.UCAsignarImpuesto.TabIndex = 0;
                    break;
                case "inicializarStock":
                    this.uCInicializarStock = new Admeli.Herramientas.UCInicializarStock(this.formPrincipal);
                    this.formPrincipal.panelMain.Controls.Add(uCInicializarStock);
                    this.uCInicializarStock.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCInicializarStock.Location = new System.Drawing.Point(0, 0);
                    this.uCInicializarStock.Name = "uCInicializarStock";
                    this.uCInicializarStock.Size = new System.Drawing.Size(250, 776);
                    this.uCInicializarStock.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void btnColor()
        {
            btnAsignarCategoria.BackColor = this.BackColor;
            btnAsignarImpuesto.BackColor = this.BackColor;
            btnInicializarStock.BackColor = this.BackColor; ;
        }

        private void btnAsignarCategoria_Click(object sender, EventArgs e)
        {
            togglePanelMain("asignarCategoria");
            btnAsignarCategoria.BackColor = colorActive;
        }

        private void btnInicializarStock_Click(object sender, EventArgs e)
        {
            togglePanelMain("inicializarStock");
            btnInicializarStock.BackColor = colorActive;
        }

        private void btnAsignarImpuesto_Click(object sender, EventArgs e)
        {
            togglePanelMain("asignarImpuesto");
            btnAsignarImpuesto.BackColor = colorActive;
        }
    }
}
