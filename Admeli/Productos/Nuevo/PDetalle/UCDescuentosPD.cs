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

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCDescuentosPD : UserControl
    {
        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCDescuentosPD()
        {
            InitializeComponent();
        }

        public UCDescuentosPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }


        internal void reLoad()
        {
            // throw new NotImplementedException();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }
    }
}
