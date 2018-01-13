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
    public partial class UCEgresos : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCEgresos()
        {
            InitializeComponent();
        }

        public UCEgresos(FormPrincipal formPrincipal)
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
