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
    public partial class UCClientes : UserControl
    {
        /**
         *  Web services
         *   http://www.lineatienda.com/services.php/clientes/estado/1/100
         * 
         * 
         * 
         * */
        private Paginacion paginacion;
        private FormPrincipal formPrincipal;

        public UCClientes()
        {
            InitializeComponent();
        }

        public UCClientes(FormPrincipal formPrincipal)
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
            FormClienteNuevo clienteNuevo = new FormClienteNuevo();
            clienteNuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormClienteNuevo clienteNuevo = new FormClienteNuevo();
            clienteNuevo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;
        }
    }
}
