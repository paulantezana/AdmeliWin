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
    public partial class FormOfertaNuevo : Form
    {
        private FormProductoNuevo formProductoNuevo;
        private Oferta currentOferta;

        public FormOfertaNuevo()
        {
            InitializeComponent();
        }

        public FormOfertaNuevo(FormProductoNuevo formProductoNuevo)
        {
            this.formProductoNuevo = formProductoNuevo;
        }

        public FormOfertaNuevo(FormProductoNuevo formProductoNuevo, Oferta currentOferta) : this(formProductoNuevo)
        {
            this.currentOferta = currentOferta;
        }
    }
}
