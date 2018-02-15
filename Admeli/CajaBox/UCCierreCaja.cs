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
using Entidad;
using Modelo;
using Admeli.CajaBox.Nuevo;

namespace Admeli.CajaBox
{
    public partial class UCCierreCaja : UserControl
    {
        private CierreCajaModel cierreCajaModel = new CierreCajaModel();
        private PersonalModel personalModel = new PersonalModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private ConfigModel configModel = new ConfigModel();

        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private Paginacion paginacion;
        private List<CierreCaja> cierreCajas { get; set; }
        private CierreCaja currentCierreCaja { get; set; }

        public UCCierreCaja()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCCierreCaja(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        #region ======================== Root Load ============================= 
        private void UCCierreCaja_Load(object sender, EventArgs e)
        {
            this.reLoad();

            // Escuchando los eventos del formulario padre
            if (TopLevelControl is Form)
            {
                (TopLevelControl as Form).KeyPreview = true;
                TopLevelControl.KeyUp += TopLevelControl_KeyUp;
            }
        }

        internal void reLoad()
        {
            this.cargarPersonales();
            this.cargarSucursales();
            this.cargarRegistros();

            // Verificar caja
            this.verificarCaja();

            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion


        #region ============================ Verificar Caja ============================
        private async void verificarCaja()
        {
            await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
            if (ConfigModel.cajaIniciada)
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                lblCajaEstado.Visible = false;
            }
            else
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                lblCajaEstado.Visible = true;
                Validator.labelAlert(lblCajaEstado, 0, "No se inició la caja");
            }
        }
        #endregion

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
                default:
                    break;
            }
        }
        #endregion

        #region ======================= Loads =======================
        private void cargarComponentes()
        {
            loadState(true);

            // Cargando item por pagina a mostra desde las configuraciones generales
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();

            // Estado cargar en falso
            loadState(false);
        }

        private async void cargarSucursales()
        {
            // cargando los sucursales activos
            try
            {
                loadState(true);
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


        private async void cargarPersonales()
        {
            // cargando los sucursales activos
            try
            {

                // Cargando el combobox de personales
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(ConfigModel.sucursal.idSucursal);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = PersonalModel.personal.idPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                int personalId = (cbxPersonales.SelectedIndex == -1) ? PersonalModel.personal.idPersonal : Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue);
                int sucursalId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);
                RootObject<CierreCaja> dataRoot = await cierreCajaModel.cierreCajas(personalId, sucursalId, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = dataRoot.nro_registros;
                paginacion.reload();

                // Ingresando
                cierreCajas = dataRoot.datos;
                cierreCajaBindingSource.DataSource = cierreCajas;
                dataGridView.Refresh();
                mostrarPaginado();

                // Mostrando la páginacion
                mostrarPaginado();

                // Formato de celdas
                // 
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            executeModificar();
        }

        private void executeNuevo()
        {
            FormArquearCaja formArquearCaja = new FormArquearCaja();
            formArquearCaja.ShowDialog();
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
            int idCierreCaja = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentCierreCaja = cierreCajas.Find(x => x.idCierreCaja == idCierreCaja); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormArquearCaja formArquearCaja = new FormArquearCaja(currentCierreCaja);
            formArquearCaja.ShowDialog();
            cargarRegistros(); // recargando loas registros en el datagridview
        }
        #endregion

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }


    }
}
