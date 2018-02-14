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
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnHerramienta.Location;
            btnHerramienta.Textcolor = Color.White;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnProducto.Location;
            btnProducto.Textcolor = Color.White;
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnAlmacen.Location;
            btnAlmacen.Textcolor = Color.White;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCaja.Location;
            btnCaja.Textcolor = Color.White;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnVenta.Location;
            btnVenta.Textcolor = Color.White;
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCompra.Location;
            btnCompra.Textcolor = Color.White;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnConfiguracion.Location;
            btnConfiguracion.Textcolor = Color.White;
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


    }
}
