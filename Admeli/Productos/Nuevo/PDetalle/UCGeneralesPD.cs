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
               /* if (nuevo)
                {
                    Response response = await marcaModel.guardar(producto);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await marcaModel.modificar(marca);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarObjeto()
        {
           /* marca = new Marca();
            if (!nuevo) marca.idMarca = currentIdMarca; // Llenar el id categoria cuando este en esdo modificar

            marca.nombreMarca = textNombreMarca.Text;
            marca.sitioWeb = textWebMarca.Text;
            marca.descripcion = textDescripcionMarca.Text;
            marca.estado = Convert.ToInt32(chkActivoMarca.Checked);
            marca.captionImagen = "";
            marca.ubicacionLogo = "";
            marca.tieneRegistros = "";*/
        }

    }
}
