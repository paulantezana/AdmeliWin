using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class FormDescuentoNuevo : Form
    {
        private FormProductoNuevo formProductoNuevo;
        private Descuento currentDescuento;

        public FormDescuentoNuevo()
        {
            InitializeComponent();
        }

        public FormDescuentoNuevo(FormProductoNuevo formProductoNuevo)
        {
            this.formProductoNuevo = formProductoNuevo;
        }

        public FormDescuentoNuevo(FormProductoNuevo formProductoNuevo, Descuento currentDescuento) : this(formProductoNuevo)
        {
            this.currentDescuento = currentDescuento;
        }
    }
}
