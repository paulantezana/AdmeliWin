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
using Entidad.Configuracion;

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormArquearCaja : Form
    {
        private CierreCaja currentCierreCaja;
        private CajaSesion currentCajaSesion;

        public FormArquearCaja()
        {
            InitializeComponent();
        }

        public FormArquearCaja(CierreCaja currentCierreCaja)
        {
            this.currentCierreCaja = currentCierreCaja;
        }

        public FormArquearCaja(CajaSesion currentCajaSesion)
        {
            this.currentCajaSesion = currentCajaSesion;
        }
    }
}
