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
    public partial class UCAdicionalPD : UserControl
    {
        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCAdicionalPD()
        {
            InitializeComponent();
        }

        public UCAdicionalPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        internal void reLoad()
        {
            //throw new NotImplementedException();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelHeader);
        }

        private void UCAdicionalPD_Paint(object sender, PaintEventArgs e)
        {
            int containerWidth = this.Size.Width;
            int itemWidth = containerWidth / 2;
            panelItem1.Size = new Size(itemWidth, 100);
        }
    }
}
