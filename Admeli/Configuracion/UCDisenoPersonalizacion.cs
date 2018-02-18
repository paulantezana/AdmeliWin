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
using Admeli.Componentes;

namespace Admeli.Configuracion
{
    public partial class UCDisenoPersonalizacion : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }
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

        #region ============================ Root Load ============================
        private void UCDisenoPersonalizacion_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            cargarRegistros();
            lisenerKeyEvents = true; // Active lisener key events
        } 
        #endregion

        #region =========================== Paint and Decoration ===========================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

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
        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                List<TipoDocumento> listData = await tipoDocumentoModel.tipodoc(1);
                if (listData == null) return; /// Verificar si hay datos

                // Ingresando
                tipoDocumentoBindingSource.DataSource = listData;
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
            //toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }
        #endregion


        #region ==================== CRUD ====================

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }
        #endregion

    }
}
