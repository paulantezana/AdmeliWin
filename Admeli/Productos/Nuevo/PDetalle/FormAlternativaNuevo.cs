﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class FormAlternativaNuevo : Form
    {
        private Alternativa currentAlternativa;

        public FormAlternativaNuevo()
        {
            InitializeComponent();
        }

        public FormAlternativaNuevo(Alternativa currentAlternativa)
        {
            this.currentAlternativa = currentAlternativa;
        }
    }
}