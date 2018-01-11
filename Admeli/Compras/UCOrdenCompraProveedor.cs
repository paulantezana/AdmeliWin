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
        private Paginacion paginacion;

        #region ==================== Constructor and methods windows form ====================
        public UCOrdenCompraProveedor()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSteepPages.Text));
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void UCOrdenCompraProveedor_Load(object sender, EventArgs e)
        {
            cargarRegistros();
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
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion

        #region ======================= Loads =======================
        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                RootObject<OrdenCompra> ordenCompra = await ordenCompraModel.getData(paginacion.currentPage.ToString(), paginacion.speed.ToString());

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
            lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

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
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                cargarRegistros();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                cargarRegistros();
            }
        }

        private void lblSteepPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSteepPages.Text);
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
    }
}
