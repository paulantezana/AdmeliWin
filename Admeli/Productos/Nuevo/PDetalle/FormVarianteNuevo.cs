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
    public partial class FormVarianteNuevo : Form
    {
        private Variante currentVariante;

        public FormVarianteNuevo()
        {
            InitializeComponent();
        }

        public FormVarianteNuevo(Variante currentVariante)
        {
            InitializeComponent();
            this.currentVariante = currentVariante;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
