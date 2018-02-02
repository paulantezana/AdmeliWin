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
using Modelo;
using Entidad;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCGeneralesPD : UserControl
    {
        public UnidadMedidaModel unidadMedidaModel = new UnidadMedidaModel();
        public MarcaModel marcaModel = new MarcaModel();
        public ProductoModel productoModel = new ProductoModel();


        private Producto producto { get; set; }
        private bool nuevo { get; set; }

        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;


        public UCGeneralesPD()
        {
            InitializeComponent();
            this.nuevo = true;
        }

        public UCGeneralesPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.nuevo = true;
            this.formProductoNuevo = formProductoNuevo;
        }

        #region ================================ Root Load ================================
        private void UCGeneralesPD_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        internal void reLoad()
        {
            cargarMarcas();
            cargarUnidadesMedida();
        } 
        #endregion

        #region ============================= Loads =============================
        internal async void cargarMarcas()
        {
            marcaBindingSource.DataSource = await marcaModel.marcas();
        }
        internal async void cargarUnidadesMedida()
        {
            unidadMedidaBindingSource.DataSource = await unidadMedidaModel.unimedidas();
        }
        #endregion

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            FormMarcaNuevo formMarca = new FormMarcaNuevo();
            formMarca.ShowDialog();
            this.cargarMarcas();
        }

        private void btnAddUnidadMedida_Click(object sender, EventArgs e)
        {
            FormUnidadMedidaNuevo formUnidad = new FormUnidadMedidaNuevo();
            formUnidad.ShowDialog();
            this.cargarUnidadesMedida();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormElegirCategoria formElegir = new FormElegirCategoria();
            formElegir.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                cargarObjeto();
                guardar();
            }
        }
        
        private bool validarCampos()
        {
            /*if (textNombreMarca.Text == "")
            {
                errorProvider1.SetError(textNombreMarca, "Rellene este campo");
                textNombreMarca.Focus();
                return false;
            }
            errorProvider1.Clear();*/
            return true;
        }

        private async void guardar()
        {
            try
            {
                if (nuevo)
                {
                    Response response = await productoModel.guardar(producto);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await productoModel.modificar(producto);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarObjeto()
        {
            producto = new Producto();
            if (!nuevo) producto.idProducto = 1; // Llenar el id categoria cuando este en esdo modificar

            producto.cantidadFraccion = false;
            producto.codigoBarras = ""; 

            producto.codigoProducto = textCodigoProducto.Text;
            producto.controlSinStock = "sin_stock";
            producto.descripcionCorta = textDescripcion.Text;

            producto.descripcionLarga = "";

            producto.enCategoriaEstrella = false;
            producto.enPortada = false;
            producto.enUso = false;

            producto.estado = chkActivoProducto.Checked;
            producto.idMarca = Convert.ToInt32(cbxMarcas.SelectedValue);
            producto.idUnidadMedida = Convert.ToInt32(cbxUnidadMedida.SelectedValue);

            producto.keywords = "";

            producto.limiteMaximo = "0";
            producto.limiteMinimo = "0";
            producto.mostrarPrecioWeb = true;
            producto.mostrarVideo = true;
            producto.mostrarWeb = true;

            producto.nombreMarca = cbxMarcas.Text;
            producto.nombreProducto = textNombreProducto.Text;
            producto.nombreUnidad = cbxUnidadMedida.Text;

            producto.precioCompra = Convert.ToInt32(textPrecioCompra.Text);
            producto.urlVideo = "";
            producto.ventaVarianteSinStock = false;
        }

        private async Task<bool> validarProductoNuevo(int elegir)
        {
            // 1 ==> validar codigo producto
            // 2 ==> validar nombre producto
            // 3 ==> validar ambos
            Producto np = new Producto();
            if (elegir == 1) np.codigo = textCodigoProducto.Text;
            if (elegir == 2) np.nombre = textCodigoProducto.Text;
            if (elegir == 3)
            {
                np.codigo = textCodigoProducto.Text;
                np.nombre = textCodigoProducto.Text;
            }
            List<Producto> list = await productoModel.validarProducto(np);
            return (list.Count > 0) ? false : true;
        }

        private bool validarPrecio()
        {
            if (textPrecioCompra.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textPrecioCompra, false);
                errorProvider1.SetError(textPrecioCompra, "Campo obligatorio");
                return false;
            }
            Validator.textboxValidateColor(textPrecioCompra, true);
            errorProvider1.Clear();
            return true;
        }

        private async Task<bool> validarProductoNombre()
        {
            // Validando si el campo esta vacia
            if (textNombreProducto.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textNombreProducto, false);
                errorProvider1.SetError(textNombreProducto, "Campo obligatorio");
                return false;
            }

            // Creando el objeto para enviar
            Producto np = new Producto();
            np.nombre = textNombreProducto.Text;

            // validando si el codigo del producto existe
            List<Producto> list = await productoModel.validarProducto(np);
            if (list.Count > 0)
            {
                errorProvider1.SetError(textNombreProducto, "Ya existe un producto con el mismo nombre.");
                Validator.textboxValidateColor(textNombreProducto, false);
                return false;
            }

            // Dando el formato adecuado cuando paso toda las validaciones
            Validator.textboxValidateColor(textNombreProducto, true);
            errorProvider1.Clear();
            return true;
        }

        private async Task<bool>  validarProductoCodigo()
        {

            // Validando si el campo esta vacia
            if (textCodigoProducto.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textCodigoProducto, false);
                errorProvider1.SetError(textCodigoProducto, "Campo obligatorio");
                return false;
            }

            // Creando el objeto para enviar
            Producto np = new Producto();
            np.codigo = textCodigoProducto.Text;

            // validando si el codigo del producto existe
            List<Producto> list = await productoModel.validarProducto(np);
            if (list.Count > 0)
            {
                errorProvider1.SetError(textCodigoProducto, "Ya existe un producto con el mismo código.");
                Validator.textboxValidateColor(textCodigoProducto, false);
                return false;
            }

            // Dando el formato adecuado cuando paso toda las validaciones
            Validator.textboxValidateColor(textCodigoProducto, true);
            errorProvider1.Clear();
            return true;
        }

        #region =================================== Validaciones en tiempo real ===================================
        private async void textCodigoProducto_Validated(object sender, EventArgs e)
        {
            await validarProductoCodigo();
        }

        private async void textNombreProducto_Validated(object sender, EventArgs e)
        {
            await validarProductoNombre();
        }

        private void textPrecioCompra_Validated(object sender, EventArgs e)
        {
            validarPrecio();
        }

        private void textPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        } 
        #endregion
    }
}
