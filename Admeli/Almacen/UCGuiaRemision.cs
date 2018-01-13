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

namespace Admeli.Almacen
{
    public partial class UCGuiaRemision : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCGuiaRemision()
        {
            InitializeComponent();
        }

        public UCGuiaRemision(FormPrincipal formPrincipal)
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
