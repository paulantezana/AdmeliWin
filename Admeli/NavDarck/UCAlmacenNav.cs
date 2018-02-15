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
    public partial class UCAlmacenNav : UserControl
    {
        private FormPrincipal formHomeDarck;

        public UCAlmacenNav()
        {
            InitializeComponent();
        }

        public UCAlmacenNav(FormPrincipal formHomeDarck)
        {
            InitializeComponent();
            this.formHomeDarck = formHomeDarck;
        }
    }
}
