using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Configuracion
{
    public partial class UCTipoCambio : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCTipoCambio()
        {
            InitializeComponent();
        }

        public UCTipoCambio(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }
    }
}
