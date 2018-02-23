using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Navigation.SubMenu
{
    public partial class UCConfigNav : UserControl
    {
        private FormPrincipal formPrincipal;
        private UCTiendaRoot uCTiendaRoot;

        public UCConfigNav()
        {
            InitializeComponent();
        }

        public UCConfigNav(FormPrincipal formPrincipal, UCTiendaRoot uCTiendaRoot)
        {
            this.formPrincipal = formPrincipal;
            this.uCTiendaRoot = uCTiendaRoot;
        }
    }
}
