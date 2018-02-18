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
using Admeli.Compras.Nuevo;
using Modelo;
using Entidad;
using Newtonsoft.Json;

namespace Admeli.Compras
{
    public partial class UCOrdenCompraProveedor : UserControl
    {
        private OrdenCompraModel ordenCompraModel = new OrdenCompraModel();
        private PersonalModel personalModel = new PersonalModel();
        private Paginacion paginacion;
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        #region ==================== Constructor and methods windows form ====================
        public UCOrdenCompraProveedor()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCOrdenCompraProveedor(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private async void UCOrdenCompraProveedor_Load(object sender, EventArgs e)
        {
            await cargarComponentes();
            await cargarRegistros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCompraProveedorNuevo compraProveedorNuevo = new FormCompraProveedorNuevo();
            compraProveedorNuevo.ShowDialog();
        }
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            panelNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion

        #region ======================= Loads =======================
        private async Task cargarComponentes()
        {
            // Cargando el combobox de personales
            formPrincipal.appLoadState(true);
            loadState(true);
            try
            {
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(ConfigModel.sucursal.idSucursal);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cargando item por pagina a mostra desde las configuraciones generales
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();

            // Estado cargar en falso
            loadState(false);
        }
        private async Task cargarRegistros()
        {
            formPrincipal.appLoadState(true);
            loadState(true);
            try
            {

                RootObject<OrdenCompra> ordenCompra = await ordenCompraModel.ocompras(ConfigModel.sucursal.idSucursal,
                                                                                      Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue),
                                                                                      paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = ordenCompra.nro_registros;
                paginacion.reload();

                // Ingresando
                ordenCompraBindingSource.DataSource = ordenCompra.datos;
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
                formPrincipal.appLoadState(false);
            }
        }

        internal void reLoad()
        {
            cargarComponentes();
            cargarRegistros();
            lisenerKeyEvents = true; // Active lisener key events
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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await cargarRegistros();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await cargarRegistros();
        }
    }
}
