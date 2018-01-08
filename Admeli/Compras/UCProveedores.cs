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
using Admeli.Compras.Nuevo;

namespace Admeli.Compras
{
    public partial class UCProveedores : UserControl
    {
        public UCProveedores()
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
            FormProveedorNuevo proveedorNuevo = new FormProveedorNuevo();
            proveedorNuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormProveedorNuevo proveedorNuevo = new FormProveedorNuevo();
            proveedorNuevo.ShowDialog();
        }
    }
}
