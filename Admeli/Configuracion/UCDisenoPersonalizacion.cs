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
    public partial class UCDisenoPersonalizacion : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCDisenoPersonalizacion()
        {
            InitializeComponent();
        }

        public UCDisenoPersonalizacion(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }
    }
}
