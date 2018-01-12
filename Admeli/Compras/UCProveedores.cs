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

namespace Admeli.Compras
{
    public partial class UCProveedores : UserControl
    {
        #region ===================== Metodos =====================
        private ProveedorModel proveedorModel = new ProveedorModel();
        private FormPrincipal formPrincipal;
        private Paginacion paginacion; 
        #endregion

        #region ======================= Constructor =======================
        public UCProveedores()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCProveedores(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }
        #endregion

        #region ============================ Paint ============================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }
        #endregion

        #region ====================== root load ======================
        private async void UCProveedores_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            await cargarRegistros();
            decorationDataGridView();
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
        private void cargarComponentes()
        {
            loadState(true);

            // Cargando item por pagina a mostra desde las configuraciones generales
            lblSpeedPages.Text = ConfigModel.config.itemPorPagina.ToString();

            // Estado cargar en falso
            loadState(false);
        }

        private async Task cargarRegistros()
        {
            loadState(true);
            try
            {
                RootObject<Proveedor> ordenCompra = await proveedorModel.proveedores(paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = ordenCompra.nro_registros;
                paginacion.reload();

                // Ingresando
                proveedorBindingSource.DataSource = ordenCompra.datos;
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

        private async Task cargarRegistrosBuscados()
        {
            loadState(true);
            try
            {
                RootObject<Proveedor> ordenCompra = await proveedorModel.proveedoreslike(paginacion.currentPage, paginacion.speed, textBuscar.Text);

                // actualizando datos de páginacón
                paginacion.itemsCount = ordenCompra.nro_registros;
                paginacion.reload();

                // Ingresando
                proveedorBindingSource.DataSource = ordenCompra.datos;
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
            toolStripTools.Enabled = !state;
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

        private async void lblSpeedPages_KeyUp(object sender, KeyEventArgs e)
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

        #region ==================== CRUD ====================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormProveedorNuevo proveedorNuevo = new FormProveedorNuevo();
            proveedorNuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormProveedorNuevo proveedorNuevo = new FormProveedorNuevo();
            proveedorNuevo.ShowDialog();
        }
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await cargarRegistrosBuscados();
        }

        private async void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await cargarRegistrosBuscados();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await cargarRegistros();
        } 
        #endregion
    }
}
