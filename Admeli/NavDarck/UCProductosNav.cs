using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.NavDarck
{
    public partial class UCProductosNav : UserControl
    {
        private FormPrincipal formHomeDarck;

        public UCProductosNav()
        {
            InitializeComponent();
        }

        public UCProductosNav(FormPrincipal formHomeDarck)
        {
            InitializeComponent();
            this.formHomeDarck = formHomeDarck;
        }
    }
}
