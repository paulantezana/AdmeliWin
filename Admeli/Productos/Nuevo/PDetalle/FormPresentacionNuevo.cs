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
    public partial class FormPresentacionNuevo : Form
    {
        private Presentacion currentPresentacion;

        public FormPresentacionNuevo()
        {
            InitializeComponent();
        }

        public FormPresentacionNuevo(Presentacion currentPresentacion)
        {
            InitializeComponent();
            this.currentPresentacion = currentPresentacion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
