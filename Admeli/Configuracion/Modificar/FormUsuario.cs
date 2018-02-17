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

namespace Admeli.Configuracion.Modificar
{
    public partial class FormUsuario : Form
    {
        private Personal currentPersonal;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(Personal currentPersonal)
        {
            this.currentPersonal = currentPersonal;
        }
    }
}
