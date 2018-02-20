using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Productos.Nuevo.PDetalle.sub
{
    public partial class FormgGenerar : Form
    {
        private AlmacenModel almacenModel = new AlmacenModel();
        private AlternativaModel alternativaModel = new AlternativaModel();
        private FormProductoNuevo formProductoNuevo;

        private List<AlternativaCombinacion> alternativaCombinaciones { get; set; }
        private AlternativaCombinacion currentAlternativaCombinacion { get; set; }

        public FormgGenerar()
        {
            InitializeComponent();
        }

        public FormgGenerar(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        private void FormgGenerar_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            cargarAlmacenes();
        }

        private async void cargarAlmacenes()
        {
            try
            {
                /// ========================================================
                almacenBindingSource.DataSource = await almacenModel.almacenesPorSucursales(ConfigModel.sucursal.idSucursal);

                /// ========================= Cargando registros en la tabla
                int almacenId = (cbxAlmacenes.SelectedIndex == -1) ? ConfigModel.currentIdAlmacen : Convert.ToInt32(cbxAlmacenes.SelectedValue);
                alternativaCombinaciones = await alternativaModel.alternativaCombinacion(formProductoNuevo.currentIDProducto, almacenId);
                alternativaCombinacionBindingSource.DataSource = alternativaCombinaciones;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                recargarNuevosDatos();
                Response response1 = await alternativaModel.modificarAlternativa(currentAlternativaCombinacion);
                Response response2 = await alternativaModel.modificarCombinacionAlternativa(currentAlternativaCombinacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void recargarNuevosDatos()
        {
            int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idCombinacionAlternativa = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            AlternativaCombinacion alternativaCombinacion = alternativaCombinaciones.Find(x => x.idCombinacionAlternativa == idCombinacionAlternativa); // Buscando la registro especifico en la lista de registros

            alternativaCombinacion.codigoSku = textCodigo.Text;
            alternativaCombinacion.nombreCombinacion = textNombreCombinacion.Text;
            alternativaCombinacion.precio = textPrecio.Text;
            alternativaCombinacion.stock = textStock.Text;
            alternativaCombinacion.stockIdeal = textStockIdeal.Text;
            alternativaCombinacion.stockMinimo = textStockMinimo.Text;
            alternativaCombinacion.codigoSku = textAlertaStock.Text;
        }
    }
}
