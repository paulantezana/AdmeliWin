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

namespace Admeli.Caja
{
    public partial class UCIniciarCaja : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCIniciarCaja()
        {
            InitializeComponent();
        }

        public UCIniciarCaja(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }
    }
}
