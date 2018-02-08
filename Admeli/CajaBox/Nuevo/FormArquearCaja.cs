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

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormArquearCaja : Form
    {
        private CierreCaja currentCierreCaja;

        public FormArquearCaja()
        {
            InitializeComponent();
        }

        public FormArquearCaja(CierreCaja currentCierreCaja)
        {
            this.currentCierreCaja = currentCierreCaja;
        }
    }
}
