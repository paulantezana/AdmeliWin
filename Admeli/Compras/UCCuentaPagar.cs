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
using Admeli.Compras.Modificar;

namespace Admeli.Compras
{
    public partial class UCCuentaPagar : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        public UCCuentaPagar()
        {
            InitializeComponent();

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCCuentaPagar(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lisenerKeyEvents = true; // Active lisener key events
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormCuentaPagarModificar formCuenta = new FormCuentaPagarModificar();
            formCuenta.ShowDialog();
        }

        internal void reLoad()
        {


            lisenerKeyEvents = true; // Active lisener key events
        }
    }
}
