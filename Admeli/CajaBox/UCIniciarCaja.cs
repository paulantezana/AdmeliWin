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
            InitializeComponent();
        }
    }
}
