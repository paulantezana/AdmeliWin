using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Admeli.Componentes;
using Entidad;
using Admeli.Configuracion.Nuevo;

namespace Admeli.Configuracion
{
    public partial class UCSucursales : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private Sucursal currentSucursal { get; set; }
        private List<Sucursal> sucursales { get; set; }

        private Paginacion paginacion;
        private SucursalModel sucursalModel = new SucursalModel();

        #region =========================== Constructores ===========================
        public UCSucursales()
        {
            InitializeComponent();
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCSucursales(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        } 
        #endregion

        #region ================ Root load ================
        private void UCSucursales_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        internal void reLoad()
        {
            cargarRegistros();
            cargarComponentes();
        }

        #endregion

        #region ===================== Paint =====================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }
        #endregion

        #region =========================== Decoration ===========================
        private void decorationDataGridView()
        {
            /*
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var estado = dataGridView.Rows[i].Cells.get.Value.ToString();
                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DeepPink;
            }*/
        }
        #endregion

        #region ======================= Loads =======================
        private  void cargarComponentes()
        {
            // Cargando el combobox de personales
            loadState(true);

            // Estado cargar en falso
            loadState(false);
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                RootObject<Sucursal> sucursalesRoot = await sucursalModel.sucursales(paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = sucursalesRoot.nro_registros;
                paginacion.reload();

                // Ingresando
                sucursales = sucursalesRoot.datos;
                sucursalBindingSource.DataSource = sucursales;
                dataGridView.Refresh();
                mostrarPaginado();
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
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            toolStripNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion

        #region ===================== Eventos Páginación =====================
        private void mostrarPaginado()
        {
            // Cargando el combobox
            lblCurrentPage.Items.Clear();
            for (int i = 1; i <= paginacion.pageCount; i++)
            {
                lblCurrentPage.Items.AddRange(new object[] { i.ToString() });
            }
            if (paginacion.pageCount != 0) lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

            // Paginados
            lblPageAllItems.Text = paginacion.itemsCount.ToString();
            lblPageCount.Text = paginacion.pageCount.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.previousPage();
                cargarRegistros();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.firstPage();
                cargarRegistros();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                cargarRegistros();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                cargarRegistros();
            }
        }

        private void lblSpeedPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSpeedPages.Text);
                paginacion.currentPage = 1;
                cargarRegistros();
            }
        }

        private void lblCurrentPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.reloadPage(Convert.ToInt32(lblCurrentPage.Text));
                cargarRegistros();
            }
        }
        #endregion

        #region ==================== CRUD ====================
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            executeNuevo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            executeEliminar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            executeModificar();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            executeAnular();
        }

        private void executeNuevo()
        {
            FormSucursalNuevo clienteNuevo = new FormSucursalNuevo();
            clienteNuevo.ShowDialog();
            this.reLoad();
        }

        private void executeModificar()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idSucursal = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentSucursal = sucursales.Find(x => x.idSucursal == idSucursal); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormSucursalNuevo formPuntoVenta = new FormSucursalNuevo(currentSucursal);
            formPuntoVenta.ShowDialog();
            this.reLoad(); // Recargando los registros
        }

        private async void executeEliminar()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Pregunta de seguridad de eliminacion
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;


            try
            {
                int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentSucursal = new Sucursal(); //creando una instancia del objeto categoria
                currentSucursal.idSucursal = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

                loadState(true); // cambiando el estado
                Response response = await sucursalModel.eliminar(currentSucursal); // Eliminando con el webservice correspondiente
                MessageBox.Show(response.msj, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRegistros(); // recargando el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false); // cambiando el estado
            }
        }

        private async void executeAnular()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Desactivar o anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                loadState(true);
                int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentSucursal = new Sucursal(); //creando una instancia del objeto correspondiente
                currentSucursal.idSucursal = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

                // Comprobando si el registro ya esta desactivado
                if (sucursales.Find(x => x.idSucursal == currentSucursal.idSucursal).estado == 0)
                {
                    MessageBox.Show("Este registro ya esta desactivado", "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Procediendo con las desactivacion
                // Response response = await sucursalModel.anular(currentSucursal);
                // MessageBox.Show(response.msj, "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRegistros(); // recargando los registros en el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }
        #endregion
    }
}
