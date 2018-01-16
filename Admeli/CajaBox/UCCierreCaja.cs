using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.CajaBox
{
    public partial class UCCierreCaja : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCCierreCaja()
        {
            InitializeComponent();
        }

        public UCCierreCaja(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
    }
}
