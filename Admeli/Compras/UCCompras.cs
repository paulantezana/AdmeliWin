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
using Entidad;
using Modelo;

namespace Admeli.Compras
{
    public partial class UCCompras : UserControl
    {
        /*
         * SERVICIOS QUE SE ESTAN CONSUMIENDO
         *  www.lineatienda.com/services.php/listarpersonalcompras/sucursal/1
         *  www.lineatienda.com/services.php/compras/sucursal/1/personal/0/estado/todos/1/100
         * */

        #region ===================== Metodos =====================
        private CompraModel compraModel = new CompraModel();
        private PersonalModel personalModel = new PersonalModel();
        private Paginacion paginacion;
        private FormPrincipal formPrincipal; 
        #endregion

        #region ========================== Constructor ==========================
        public UCCompras()
        {
            InitializeComponent();
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página

            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCCompras(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }
        #endregion

        #region ======================= Paint =======================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }
        #endregion

        #region ============================= root load =============================
        private async void UCCompras_Load(object sender, EventArgs e)
        {
            await cargarComponentes();
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
        private async Task cargarComponentes()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(SucursalModel.sucursal.idSucursal);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = PersonalModel.personal.idPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

            // Estado cargar en falso
            loadState(false);
        }

        private async Task cargarRegistros()
        {
            loadState(true);
            try
            {
                RootObject<Compra> ordenCompra = await compraModel.getByPersonalEstado( SucursalModel.sucursal.idSucursal,
                                                                                        Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue),
                                                                                        cbxEstados.ComboBox.SelectedValue.ToString(),
                                                                                        paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = ordenCompra.nro_registros;
                paginacion.reload();

                // Ingresando
                compraBindingSource.DataSource = ordenCompra.datos;
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
            if(paginacion.pageCount != 0) lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

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
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await cargarRegistros();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await cargarRegistros();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormComprarNuevo comprarNuevo = new FormComprarNuevo();
            comprarNuevo.ShowDialog();
        } 
        #endregion
    }
}
