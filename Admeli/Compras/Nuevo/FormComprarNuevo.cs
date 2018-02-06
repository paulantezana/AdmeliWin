using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Compras.Buscar;
using Entidad;

namespace Admeli.Compras.Nuevo
{
    public partial class FormComprarNuevo : Form
    {
        private Compra currentCompra;
        private Proveedor currentProveedor { get; set; }

        public FormComprarNuevo()
        {
            InitializeComponent();
        }

        public FormComprarNuevo(Compra currentCompra)
        {
            this.currentCompra = currentCompra;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            executeBuscarProveedor();
        }

        private void executeBuscarProveedor()
        {
            BuscarProveedor buscarProveedor = new BuscarProveedor();
            buscarProveedor.ShowDialog();
            currentProveedor = buscarProveedor.currentProveedor;
            mostrarProveedor();
        }

        private void mostrarProveedor()
        {
            if (currentProveedor != null)
            {
                textNombreEmpresa.Text = currentProveedor.razonSocial;
                textIdentificacion.Text = currentProveedor.ruc;
                textDireccion.Text = currentProveedor.direccion;
            }
        }

        private void textNombreEmpresa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            executeBuscarProveedor();
        }
    }
}
