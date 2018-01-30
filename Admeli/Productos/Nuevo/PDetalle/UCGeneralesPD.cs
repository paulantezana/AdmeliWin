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
            cargarObjeto();
            if (validarCampos())
            {
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

            producto.codigoProducto = textCodigoProducto.Text;
            producto.precioCompra = textPrecioCompra.Text;
            producto.nombreProducto = textNombreProducto.Text;
            producto.idMarca = Convert.ToInt32(cbxMarcas.SelectedValue);
            producto.nombreMarca = cbxMarcas.Text;
            producto.idUnidadMedida = Convert.ToInt32(cbxUnidadMedida.SelectedValue);
            producto.nombreUnidad = cbxUnidadMedida.Text;
        }

    }
}
