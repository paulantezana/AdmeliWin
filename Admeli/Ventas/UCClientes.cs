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
using Admeli.Ventas.Nuevo;
using Modelo;
using Entidad;

namespace Admeli.Ventas
{
    public partial class UCClientes : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }
        private Paginacion paginacion;
        private PersonalModel personalModel = new PersonalModel();
        private ClienteModel clienteModel = new ClienteModel();

        public UCClientes()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCClientes(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }


        private void UCClientes_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            cargarRegistros();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
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

        internal void reLoad()
        {


            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion

        #region ======================= Loads =======================
        private void cargarComponentes()
        {
            // Cargando el combobox ce estados
           
            // Cargando el combobox de personales
            // loadState(true);
            
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                RootObject<Cliente> clientes = await clienteModel.clientes(paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = clientes.nro_registros;
                paginacion.reload();

                // Ingresando
                clienteBindingSource.DataSource = clientes.datos;
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
        private async void cargarRegistrosBuscar()
        {
            loadState(true);
            try
            {

                RootObject<Cliente> clientes = await clienteModel.buscarClientesLike(textBuscar.Text, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = clientes.nro_registros;
                paginacion.reload();

                // Ingresando
                clienteBindingSource.DataSource = clientes.datos;
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
            panelNavigation.Enabled = !state;
            panelCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
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

        #region ==================== CRUD ====================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormClienteNuevo clienteNuevo = new FormClienteNuevo();
            clienteNuevo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormClienteNuevo clienteNuevo = new FormClienteNuevo();
            clienteNuevo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBuscar.Text != "")
            {
                cargarRegistrosBuscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                cargarRegistrosBuscar();
            }
        }
        #endregion
    }
}
