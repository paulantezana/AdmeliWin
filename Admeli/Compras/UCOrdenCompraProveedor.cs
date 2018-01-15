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

        #region ==================== Constructor and methods windows form ====================
        public UCOrdenCompraProveedor()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCOrdenCompraProveedor(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
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
            toolStripNavigation.Enabled = !state;
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
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(SucursalModel.sucursal.idSucursal);
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

                RootObject<OrdenCompra> ordenCompra = await ordenCompraModel.ocompras( SucursalModel.sucursal.idSucursal,
                                                                                      Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue),
                                                                                      paginacion.currentPage, 
                                                                                      paginacion.speed);

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

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.previousPage();
                await cargarRegistros();
            }
        }

        private async void btnFirst_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.firstPage();
                await cargarRegistros();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                await cargarRegistros();
            }
        }

        private async void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                await cargarRegistros();
            }
        }

        private async void lblSteepPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSpeedPages.Text);
                await cargarRegistros();
            }
        }

        private async void lblCurrentPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.reloadPage(Convert.ToInt32(lblCurrentPage.Text));
                await cargarRegistros();
            }
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
