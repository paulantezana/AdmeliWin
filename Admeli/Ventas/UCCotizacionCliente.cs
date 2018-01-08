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
using Admeli.Ventas.Nuevo;

namespace Admeli.Ventas
{
    public partial class UCCotizacionCliente : UserControl
    {
        public UCCotizacionCliente()
        {
            InitializeComponent();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCotizacionNuevo cotizacionNuevo = new FormCotizacionNuevo();
            cotizacionNuevo.ShowDialog();
        }
    }
}
