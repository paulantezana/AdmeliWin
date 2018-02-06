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
        private Producto currentProducto { get; set; }

        private MonedaModel monedaModel = new MonedaModel();
        private TipoDocumentoModel tipoDocumentoModel = new TipoDocumentoModel();
        private ProductoModel productoModel = new ProductoModel();
        private VarianteModel varianteModel = new VarianteModel();
        private PresentacionModel presentacionModel = new PresentacionModel();
        private FechaModel fechaModel = new FechaModel();

        private List<DetalleCompra> carrito = new List<DetalleCompra>();

        private bool nuevo { get; set; }

        #region ============================ Constructor ============================
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
        #endregion

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
            cargarProductos();
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

        private async void cargarProductos()
        {
            try
            {
                productoBindingSource.DataSource = await productoModel.productos();
                cbxCodigoProducto.SelectedIndex = -1;
                cbxDescripcion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarVariantes()
        {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return;
            try
            {
               // varianteBindingSource.DataSource = await varianteModel.productos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarPrecentaciones()
        {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return;
            try
            {
                presentacionBindingSource.DataSource = await presentacionModel.presentacionVentas(Convert.ToInt32(cbxCodigoProducto.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarPrepararCarro()
        {
            textCantidad.Text = "1";
            //textPrecioUnidario.Text = 
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

        private void cargarProductoSeleccionado()
        {
            if (currentProducto == null) return;
            


        }

        private void cbxCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecentaciones();
        }

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecentaciones();
        }
    }
}
