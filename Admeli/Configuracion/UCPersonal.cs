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
using Entidad;
using Newtonsoft.Json;
using Admeli.Componentes;

namespace Admeli.Configuracion
{
    public partial class UCPersonal : UserControl
    {
        private PersonalModel personalModel = new PersonalModel();
        private Paginacion paginacion;
        private FormPrincipal formPrincipal;

        #region ========================== Constructor ==========================
        public UCPersonal()
        {
            InitializeComponent();
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCPersonal(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }
        #endregion

        #region ======================= Load Root =======================
        private void UCPersonal_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            cargarRegistros();
        } 
        #endregion

        #region ======================= Paint =======================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        } 
        #endregion

        #region ======================= Loads =======================
        private async void cargarComponentes()
        {
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

                //int personalId = (cbxPersonales.SelectedIndex == -1) ? PersonalModel.personal.idPersonal : Convert.ToInt32(cbxPersonales.ComboBox.SelectedValue);
                //string estado = (cbxEstados.SelectedIndex == -1) ? "todos" : cbxEstados.ComboBox.SelectedValue.ToString();

                RootObject<Personal> personal = await personalModel.listar(paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = personal.nro_registros;
                paginacion.reload();

                // Ingresando
                personalBindingSource.DataSource = personal.datos;
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
            /*FormComprarNuevo comprarNuevo = new FormComprarNuevo();
            comprarNuevo.ShowDialog();*/
        }
        #endregion

    }
}
