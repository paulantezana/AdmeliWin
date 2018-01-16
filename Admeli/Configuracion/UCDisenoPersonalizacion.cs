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
using Entidad.Configuracion;

namespace Admeli.Configuracion
{
    public partial class UCDisenoPersonalizacion : UserControl
    {
        private FormPrincipal formPrincipal;
        TipoDocumentoModel tipoDocumentoModel = new TipoDocumentoModel();

        public UCDisenoPersonalizacion()
        {
            InitializeComponent();
        }

        public UCDisenoPersonalizacion(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void UCDisenoPersonalizacion_Load(object sender, EventArgs e)
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
        private void cargarComponentes()
        {
            // Cargando el combobox ce estados
            
            // Cargando el combobox de personales
            loadState(true);
            /*try
            {
                cbxPersonales.ComboBox.DataSource = await personalModel.listarPersonalCompras(ConfigModel.sucursal.idSucursal);
                cbxPersonales.ComboBox.DisplayMember = "nombres";
                cbxPersonales.ComboBox.ValueMember = "idPersonal";
                cbxPersonales.ComboBox.SelectedValue = PersonalModel.personal.idPersonal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            // Estado cargar en falso
            loadState(false);
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                List<TipoDocumento> tipoDocs = await tipoDocumentoModel.tipodoc(1);

                // Ingresando
                tipoDocumentoBindingSource.DataSource = tipoDocs;
                dataGridView.Refresh();
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
            toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
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
