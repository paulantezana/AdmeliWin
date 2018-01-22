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
using Admeli.Productos.Nuevo;
using Modelo;
using Entidad;

namespace Admeli.Productos
{
    public partial class UCMarcas : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }
        private Paginacion paginacion;
        private MarcaModel marcaModel = new MarcaModel();
        private Marca currentMarca { get; set; }
        private List<Marca> marcas { get; set; }

        public UCMarcas()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCMarcas(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        }

        private void UCMarcas_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            cargarRegistros();

            // Escuchando los eventos del formulario padre
            if (TopLevelControl is Form)
            {
                (TopLevelControl as Form).KeyPreview = true;
                TopLevelControl.KeyUp += TopLevelControl_KeyUp;
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        #region ======================== KEYBOARD ========================
        private void TopLevelControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (!lisenerKeyEvents) return;
            switch (e.KeyCode)
            {
                case Keys.F3:
                    executeNuevo();
                    break;
                case Keys.F4:
                    executeModificar();
                    break;
                case Keys.F5:
                    cargarRegistros();
                    break;
                case Keys.F7:
                    executeAnular();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region =========================== Decoration ===========================
        private void decorationDataGridView()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int idMarca = Convert.ToInt32(row.Cells[0].Value); // obteniedo el idCategoria del datagridview

                Marca categoria = marcas.Find(x => x.idMarca == idMarca); // Buscando la categoria en las lista de categorias
                if (categoria.estado == 0)
                {
                    dataGridView.ClearSelection();
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 224);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(250, 5, 73);
                }
            }
        }

        internal void reLoad()
        {
            cargarComponentes();
            cargarRegistros();
            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion

        #region ======================= Loads =======================
        private void cargarComponentes()
        {
            // Cargando el combobox ce estados
           
            // Cargando el combobox de personales
            // loadState(true);
            // Estado cargar en falso
            // loadState(false);
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                RootObject<Marca> marcasRoot = await marcaModel.marcas(paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = marcasRoot.nro_registros;
                paginacion.reload();

                // cargando datos
                marcas = marcasRoot.datos;
                marcaBindingSource.DataSource = marcas;
                dataGridView.Refresh(); // refrescar la tabla

                // Mostrando la paginacion
                mostrarPaginado();

                // formato de celdas
                decorationDataGridView();
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            executeNuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            executeModificar();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            executeAnular();
        }

        private void executeNuevo()
        {
            FormMarcaNuevo formCategoria = new FormMarcaNuevo();
            formCategoria.ShowDialog();
            cargarRegistros();
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
            int idMarca = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            Marca marca = marcas.Find(x => x.idMarca == idMarca); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormMarcaNuevo formCategoria = new FormMarcaNuevo(marca);
            formCategoria.ShowDialog();
            cargarRegistros(); // recargando loas registros en el datagridview
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
                int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentMarca = new Marca(); //creando una instancia del objeto correspondiente
                currentMarca.idMarca = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

                // Comprobando si el registro ya esta desactivado
                if (marcas.Find(x => x.idMarca == currentMarca.idMarca).estado == 0)
                {
                    MessageBox.Show("Este registro ya esta desactivado", "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Procediendo con las desactivacion
                Response response = await marcaModel.desactivar(currentMarca);
                MessageBox.Show(response.msj, "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRegistros(); // recargando los registros en el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
