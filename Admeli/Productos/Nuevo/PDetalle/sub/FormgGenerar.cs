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
                loadState(true);
                recargarNuevosDatos();
                Response response1 = await alternativaModel.modificarAlternativa(currentAlternativaCombinacion);
                Response response2 = await alternativaModel.modificarCombinacionAlternativa(currentAlternativaCombinacion);
                MessageBox.Show(String.Format("{0}\n{1}", response1.msj, response2.msj), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarAlmacenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }

        private void recargarNuevosDatos()
        {
            int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idCombinacionAlternativa = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

            currentAlternativaCombinacion = alternativaCombinaciones.Find(x => x.idCombinacionAlternativa == idCombinacionAlternativa); // Buscando la categoria en las lista de categorias
            int almacenId = (cbxAlmacenes.SelectedIndex == -1) ? ConfigModel.currentIdAlmacen : Convert.ToInt32(cbxAlmacenes.SelectedValue);

            currentAlternativaCombinacion.idAlmacen = almacenId;
            currentAlternativaCombinacion.codigoSku = textCodigo.Text;
            currentAlternativaCombinacion.nombreCombinacion = textNombreCombinacion.Text;
            currentAlternativaCombinacion.precio = textPrecio.Text;
            currentAlternativaCombinacion.stock = textStock.Text;
            currentAlternativaCombinacion.stockIdeal = textStockIdeal.Text;
            currentAlternativaCombinacion.stockMinimo = textStockMinimo.Text;
            currentAlternativaCombinacion.alertaStock = textAlertaStock.Text;
            currentAlternativaCombinacion.idProducto = formProductoNuevo.currentIDProducto;
        }

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            btnAceptar.Enabled = !state;
            dataGridView.Enabled = !state;
            if (state)
            {
                progressBarApp.Style = ProgressBarStyle.Marquee;
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                progressBarApp.Style = ProgressBarStyle.Blocks;
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

    }
}
