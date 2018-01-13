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
using Admeli.Productos.Nuevo;

namespace Admeli.Productos
{
    public partial class UCUnidadesMedida : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCUnidadesMedida()
        {
            InitializeComponent();
        }

        public UCUnidadesMedida(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormUnidadMedidaNuevo unidadMedidaNuevo = new FormUnidadMedidaNuevo();
            unidadMedidaNuevo.ShowDialog();
        }
    }
}
