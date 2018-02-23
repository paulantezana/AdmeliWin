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

namespace Admeli.Ventas.Nuevo
{
    public partial class FormClienteNuevo : Form
    {
        private Cliente currentCliente;

        public FormClienteNuevo()
        {
            InitializeComponent();
        }

        public FormClienteNuevo(Cliente currentCliente)
        {
            this.currentCliente = currentCliente;
        }
    }
}
