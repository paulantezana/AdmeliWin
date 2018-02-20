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
        private ProductoModel productoModel = new ProductoModel();
        private AlternativaModel alternativaModel = new AlternativaModel(); 
        private PresentacionModel presentacionModel = new PresentacionModel();
        private FechaModel fechaModel = new FechaModel();

        private List<Presentacion> presentaciones { get; set; }
        private List<Producto> productos { get; set; }
        private Producto currentProducto { get; set; }

        /// Send
        private List<CarroCompra> carroCompras { get; set; }

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

        #region ============================== CRUDS ==============================
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            executeBuscarProveedor();
        } 
        #endregion

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
                FechaSistema fechaSistema = await fechaModel.fechaSistema();
                dtpEmision.Value = fechaSistema.fecha;
                dtpPago.Value = fechaSistema.fecha;
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
                productos = await productoModel.productos();
                productoBindingSource.DataSource = productos;
                cbxCodigoProducto.SelectedIndex = -1;
                cbxDescripcion.SelectedIndex = -1;
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

        #region ============================  Agrgar Producto Al Carro ============================
        private void cbxCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarProductoDetalle();
        }

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarProductoDetalle();
        }

        private void textCantidad_OnValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void textDescuento_OnValueChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void cbxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecioUnitario();
            calcularTotal();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (carroCompras == null) carroCompras = new List<CarroCompra>();
            CarroCompra carroCompra = new CarroCompra();

            carroCompra.cantidad = Convert.ToDouble(textCantidad.Text.Trim());
            carroCompra.cantidadUnitaria = Convert.ToDouble(textPrecioUnidario.Text.Trim());
            carroCompra.codigoProducto = cbxCodigoProducto.Text.Trim();
            carroCompra.descripcion = cbxDescripcion.Text.Trim();
            carroCompra.descuento = Convert.ToDouble(textDescuento.Text.Trim());
            carroCompra.estado = 1;

            carroCompras.Add(carroCompra);
            //carroCompraBindingSource.Clear();
            //carroCompraBindingSource.DataSource = carroCompras;
            //dataGridView1.Refresh();
        }


        private void cargarProductoDetalle()
        {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return;
            try
            {
                /// Buscando el producto seleccionado
                int idProducto = Convert.ToInt32(cbxCodigoProducto.SelectedValue) | Convert.ToInt32(cbxDescripcion.SelectedValue);
                currentProducto = productos.Find(x => x.idProducto == idProducto);

                // Llenar los campos del producto escogido
                textCantidad.Text = "1";
                textDescuento.Text = "0";

                /// Cargando presentaciones
                cargarPresentaciones();

                // Cargando alternativas del producto
                cargarAlternativas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarPresentaciones()
        {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return; /// validacion
            /// Cargar las precentaciones
            presentaciones = await presentacionModel.presentacionVentas(Convert.ToInt32(cbxCodigoProducto.SelectedValue));
            presentacionBindingSource.DataSource = presentaciones;
            cbxUnidad.SelectedIndex = -1;

            /// calculos
            calcularPrecioUnitario();
            calcularTotal();
        }

        private async void cargarAlternativas()
        {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return; /// validacion
            /// cargando las alternativas del producto
            List<AlternativaCombinacion> alternativaCombinacion = await alternativaModel.cAlternativa31(Convert.ToInt32(cbxCodigoProducto.SelectedValue));
            alternativaCombinacionBindingSource.DataSource = alternativaCombinacion;

            /// calculos
            calcularPrecioUnitario();
            calcularTotal();
        }

        /// <summary>
        /// Calcular Total
        /// </summary>
        private void calcularTotal()
        {
            try
            {
                if (textCantidad.Text.Trim() == "") textTotal.Text = "0";
                if (textPrecioUnidario.Text.Trim() == "" || textCantidad.Text.Trim() == "" || textDescuento.Text.Trim() == "") return; /// Validación
                textTotal.Text = ((Convert.ToDouble(textPrecioUnidario.Text) * Convert.ToDouble(textCantidad.Text)) - Convert.ToDouble(textDescuento.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calcular total", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Calcular Precio Unitario
        /// </summary>
        private void calcularPrecioUnitario() {
            if (cbxCodigoProducto.SelectedIndex == -1 || cbxDescripcion.SelectedIndex == -1) return; /// Validación
            try
            {
                if (cbxUnidad.SelectedIndex == -1)
                {
                    textPrecioUnidario.Text = currentProducto.precioCompra;
                }
                else
                {
                    int idPresentacion = Convert.ToInt32(cbxUnidad.SelectedValue);
                    Presentacion findPresentacion = presentaciones.Find(x => x.idPresentacion == idPresentacion);
                    textPrecioUnidario.Text = Convert.ToString(Convert.ToDouble(currentProducto.precioCompra) * Convert.ToInt32(findPresentacion.cantidadUnitaria)) ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calcular total", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.ShowDialog();

        }

        private void cargarProductoSeleccionado()
        {
            if (currentProducto == null) return;
        }
    }
}
