using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;

namespace Admeli.Herramientas
{
    public partial class UCAsignarCategorias : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        public UCAsignarCategorias()
        {
            InitializeComponent();

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCAsignarCategorias(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lisenerKeyEvents = true; // Active lisener key events
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        internal void reLoad()
        {

            lisenerKeyEvents = true; // Active lisener key events
        }
    }
}
