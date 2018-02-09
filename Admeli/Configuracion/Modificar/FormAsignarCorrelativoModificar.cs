using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;
using Entidad;
using Modelo;

namespace Admeli.Configuracion.Modificar
{
    public partial class FormAsignarCorrelativoModificar : Form
    {
        private DocCorrelativo currentDocCorrelativo;

        private PuntoVentaModel puntoVentaModel = new PuntoVentaModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private TipoDocumentoModel tipoDocumentoModel = new TipoDocumentoModel();

        #region ========================= Constructor =========================
        public FormAsignarCorrelativoModificar()
        {
            InitializeComponent();
        }

        public FormAsignarCorrelativoModificar(DocCorrelativo currentDocCorrelativo)
        {
            InitializeComponent();
            this.currentDocCorrelativo = currentDocCorrelativo;
        }

        #endregion

        #region ================================== Root Load ==================================
        private void FormAsignarCorrelativoModificar_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            this.cargarSucursales();
            this.cargarTipoDocumento();
        }
        #endregion


        #region ================================== Loads ==================================
        private async void cargarSucursales()
        {
            try
            {

                sucursalBindingSource.DataSource = await sucursalModel.sucursales();
                cargarPuntoVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarTipoDocumento()
        {
            try
            {

                tipoDocumentoBindingSource.DataSource = await tipoDocumentoModel.tipoDocumentoVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarPuntoVenta()
        {
            try
            {
                int sucursalID = (cbxSucursal.SelectedIndex == -1) ? 0 : Convert.ToInt32(cbxSucursal.SelectedValue);
                puntoDeVentaBindingSource.DataSource = await puntoVentaModel.puntoventas(sucursalID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region ============================ Decoration ============================
        private void FormAsignarCorrelativoModificar_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panel2, 157, 157, 157);
            drawShape.lineBorder(panel4, 157, 157, 157);
            drawShape.lineBorder(panel5, 157, 157, 157);
            drawShape.lineBorder(panel6, 157, 157, 157);
        } 
        #endregion
    }
}
