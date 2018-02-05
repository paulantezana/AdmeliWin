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
    public partial class FormComentarioNuevo : Form
    {
        private FormProductoNuevo formProductoNuevo;
        private Comentario currentComentario;

        public FormComentarioNuevo()
        {
            InitializeComponent();
        }

        public FormComentarioNuevo(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        public FormComentarioNuevo(FormProductoNuevo formProductoNuevo, Comentario currentComentario)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
            this.currentComentario = currentComentario;
        }
    }
}
