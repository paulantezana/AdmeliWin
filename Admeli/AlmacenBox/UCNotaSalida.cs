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

namespace Admeli.AlmacenBox
{
    public partial class UCNotaSalida : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private Paginacion paginacion;

        private SucursalModel sucursalModel = new SucursalModel();
        private AlmacenModel almacenModel = new AlmacenModel();
        private PersonalModel personalModel = new PersonalModel();

        public UCNotaSalida()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCNotaSalida(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        private void UCNotaSalida_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        #region ======================= Loads =======================
        private void cargarComponentes()
        {
            // Cargando el combobox ce estados
            DataTable table = new DataTable();
            table.Columns.Add("idEstado", typeof(string));
            table.Columns.Add("estado", typeof(string));

            table.Rows.Add("todos", "Pendiente de Salida");
            table.Rows.Add("0", "Productos Verificados");
            table.Rows.Add("1", "Entregado");

            cbxEstados.ComboBox.DataSource = table;
            cbxEstados.ComboBox.DisplayMember = "estado";
            cbxEstados.ComboBox.ValueMember = "idEstado";
            //cbxEstados.ComboBox.SelectedIndex = 0;
        }


        private async void cargarSucursales()
        {
            // cargando los sucursales activos
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
        }


        private async void cargarAlmacenes()
        {
            // cargando los sucursales activos
            loadState(true);
            try
            {
                int idAlmacen = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);

                cbxAlmacenes.ComboBox.DataSource = await almacenModel.almacenesPorSucursales(idAlmacen);
                cbxAlmacenes.ComboBox.DisplayMember = "nombre";
                cbxAlmacenes.ComboBox.ValueMember = "idAlmacen";
                cbxAlmacenes.ComboBox.SelectedValue = ConfigModel.currentIdAlmacen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarPersonales()
        {
            // cargando los sucursales activos
            try
            {
                int idAlmacen = (cbxAlmacenes.ComboBox.SelectedIndex == -1) ? ConfigModel.currentIdAlmacen : Convert.ToInt32(cbxAlmacenes.ComboBox.SelectedValue);
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalAlmacen(idAlmacen);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = PersonalModel.personal.idPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void reLoad()
        {
            cargarComponentes();
            cargarSucursales();
            cargarAlmacenes();
            cargarPersonales();

            cargarRegistros();
            lisenerKeyEvents = true; // Active lisener key events
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                int personalId = (cbxAlmacenes.SelectedIndex == -1) ? PersonalModel.personal.idPersonal : Convert.ToInt32(cbxAlmacenes.ComboBox.SelectedValue);
                int sucursalId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);
                string estado = (cbxEstados.SelectedIndex == -1) ? "todos" : cbxEstados.ComboBox.SelectedValue.ToString();
                int puntoVentaId = (cbxPersonales.SelectedIndex == -1) ? ConfigModel.currentPuntoVenta : Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue);

               /* RootObject<Venta> ventas = await ventaModel.ventas(sucursalId, puntoVentaId, personalId, estado, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = ventas.nro_registros;
                paginacion.reload();

                // Ingresando
                ventaBindingSource.DataSource = ventas.datos;
                dataGridView.Refresh();
                mostrarPaginado();*/
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


        #region ===================== Eventos Páginación =====================
        private void mostrarPaginado()
        {
            lblCurrentPage.Text = paginacion.currentPage.ToString();
            lblPageAllItems.Text = String.Format("{0} Registros", paginacion.itemsCount.ToString());
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

        private void lblCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }

        private void lblSpeedPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            panelNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion
    }
}
