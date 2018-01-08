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
using Admeli.Almacen.Nuevo;

namespace Admeli.Almacen
{
    public partial class UCNotaSalida : UserControl
    {
        public UCNotaSalida()
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
            FormGuiaSalidaNuevo guiaSalidaNuevo = new FormGuiaSalidaNuevo();
            guiaSalidaNuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormGuiaSalidaNuevo guiaSalidaNuevo = new FormGuiaSalidaNuevo();
            guiaSalidaNuevo.ShowDialog();
        }
    }
}
