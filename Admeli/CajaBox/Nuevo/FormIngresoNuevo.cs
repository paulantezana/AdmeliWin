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

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormIngresoNuevo : Form
    {
        private Ingreso currentIngreso;

        public FormIngresoNuevo()
        {
            InitializeComponent();
        }

        public FormIngresoNuevo(Ingreso currentIngreso)
        {
            this.currentIngreso = currentIngreso;
        }
    }
}
