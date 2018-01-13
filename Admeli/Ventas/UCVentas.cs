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
using Admeli.Ventas.Nuevo;

namespace Admeli.Ventas
{
    public partial class UCVentas : UserControl
    {
        /**
         *  Web services
         *  http://www.lineatienda.com/services.php/ventas/sucursal/1/puntoventa/0/per/0/estado/todos/1/100
         * 
         * 
         * 
         * */

        private Paginacion paginacion;
        private FormPrincipal formPrincipal;

        public UCVentas()
        {
            InitializeComponent();
        }

        public UCVentas(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormVentaNuevo ventaNuevo = new FormVentaNuevo();
            ventaNuevo.ShowDialog();
        }
    }
}
