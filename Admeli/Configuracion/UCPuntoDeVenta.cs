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
using Entidad.Configuracion;

namespace Admeli.Configuracion
{
    public partial class UCPuntoDeVenta : UserControl
    {
        private FormPrincipal formPrincipal;
        private Paginacion paginacion;
        private PuntoVentaModel puntoVentaModel = new PuntoVentaModel();
        private SucursalModel sucursalModel = new SucursalModel();

        public UCPuntoDeVenta()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCPuntoDeVenta(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        private void UCPuntoDeVenta_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            cargarRegistros();
        }

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
        private async void cargarComponentes()
        {
            // Cargando el combobox ce estados
            DataTable table = new DataTable();
            table.Columns.Add("idEstado", typeof(string));
            table.Columns.Add("estado", typeof(string));

            table.Rows.Add("todos", "Todos los estados");
            table.Rows.Add("0", "Anulados");
            table.Rows.Add("1", "Activos");

            cbxEstados.ComboBox.DataSource = table;
            cbxEstados.ComboBox.DisplayMember = "estado";
            cbxEstados.ComboBox.ValueMember = "idEstado";
            cbxEstados.ComboBox.SelectedIndex = 0;

            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxSucursales.ComboBox.DataSource = await sucursalModel.listarSucursalesActivos();
                cbxSucursales.ComboBox.DisplayMember = "nombre";
                cbxSucursales.ComboBox.ValueMember = "idSucursal";
                cbxSucursales.ComboBox.SelectedValue = ConfigModel.sucursal.idSucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Estado cargar en falso
            loadState(false);
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                int sucursaId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);
                string estado = (cbxEstados.SelectedIndex == -1) ? "todos" : cbxEstados.ComboBox.SelectedValue.ToString();

                RootObject<PuntoDeVenta> puntoVenta = await puntoVentaModel.puntoventas(ConfigModel.sucursal.idSucursal, estado, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = puntoVenta.nro_registros;
                paginacion.reload();

                // Ingresando
                puntoDeVentaBindingSource.DataSource = puntoVenta.datos;
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
            /*FormComprarNuevo comprarNuevo = new FormComprarNuevo();
            comprarNuevo.ShowDialog();*/
        }
        #endregion
    }
}
