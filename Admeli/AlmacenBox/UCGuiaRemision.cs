using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.AlmacenBox
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
    }
}
