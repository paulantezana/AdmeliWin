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

namespace Admeli.Productos.Nuevo.PDetalle.web
{
    public partial class FormRelacionNuevo : Form
    {
        private FormProductoNuevo formProductoNuevo;
        private ProductoRelacion currentProductoRelacion;

        public FormRelacionNuevo()
        {
            InitializeComponent();
        }

        public FormRelacionNuevo(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        public FormRelacionNuevo(FormProductoNuevo formProductoNuevo, ProductoRelacion currentProductoRelacion)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
            this.currentProductoRelacion = currentProductoRelacion;
        }
    }
}
