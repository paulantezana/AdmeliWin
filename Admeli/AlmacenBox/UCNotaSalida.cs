﻿using System;
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
    public partial class UCNotaSalida : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCNotaSalida()
        {
            InitializeComponent();
        }

        public UCNotaSalida(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }
    }
}