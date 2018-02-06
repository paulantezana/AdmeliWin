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
using Modelo;

namespace Admeli.Compras.Nuevo
{
    public partial class FormComprarNuevo : Form
    {
        private Compra currentCompra;
        private Proveedor currentProveedor { get; set; }


        private MonedaModel monedaModel = new MonedaModel();
        private TipoDocumentoModel tipoDocumentoModel = new TipoDocumentoModel();
        private FechaModel fechaModel = new FechaModel();

        private List<DetalleCompra> carrito = new List<DetalleCompra>();

        private bool nuevo { get; set; }

        public FormComprarNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
            cargarFechaSistema();
        }

        public FormComprarNuevo(Compra currentCompra)
        {
            InitializeComponent();
            this.currentCompra = currentCompra;
            this.nuevo = false;
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

        #region ================================ Root Load ================================
        private void FormComprarNuevo_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            cargarMonedas();
            cargarTipoDocumento();
        }
        #endregion

        #region ============================== Load ==============================
        private async void cargarMonedas()
        {
            try
            {
                cbxMoneda.DataSource = await monedaModel.monedas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarTipoDocumento()
        {
            try
            {
                cbxTipoDocumento.DataSource = await tipoDocumentoModel.tipoDocumentoVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarFechaSistema()
        {
            try
            {
                if (!nuevo) return;
                dynamic response = await fechaModel.fechaSistema();
                DateTime currentDateTime = (response.fecha != nuevo) ? response.fecha : DateTime.Now;
                dtpEmision.Value = currentDateTime;
                dtpPago.Value = currentDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

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
            }
        }

        private void textNombreEmpresa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            executeBuscarProveedor();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.ShowDialog();
        }
    }
}
