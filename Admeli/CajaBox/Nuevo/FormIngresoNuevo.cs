using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Modelo;

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormIngresoNuevo : Form
    {
        private IngresoModel ingresoModel = new IngresoModel();
        private MonedaModel monedaModel = new MonedaModel();
        private CajaModel cajaModel = new CajaModel();

        private int currentIDIngreso { get; set; }
        private bool nuevo { get; set; }
        private Ingreso currentIngreso { get; set; }
        private SaveObject currentSaveObject { get; set; }

        public FormIngresoNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
        }

        public FormIngresoNuevo(Ingreso currentIngreso)
        {
            this.currentIngreso = currentIngreso;
            this.nuevo = false;
        }

        private void FormIngresoNuevo_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            this.cargarMonedas();
            this.cargarCorrelativo();
        }

        private async void cargarMonedas()
        {
            monedaBindingSource.DataSource = await monedaModel.monedas();
        }

        private async void cargarCorrelativo()
        {
            dynamic response = await cajaModel.correlativoSerie(1, 0);
            textNOperacion.Text = Convert.ToString(response.correlativoActual);
        }


        #region ========================== SAVE AND UPDATE ===========================
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarSucursal();
        }

        private async void guardarSucursal()
        {
            if (!validarCampos()) return;
            try
            {
                crearObjetoSucursal();
                if (nuevo)
                {
                    Response response = await ingresoModel.guardar(currentIngreso);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await ingresoModel.modificar(currentIngreso);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearObjetoSucursal()
        {
            currentSaveObject = new SaveObject();

            if (!nuevo) currentSaveObject.idIngreso = currentIDIngreso; // Llenar el id categoria cuando este en esdo modificar

            currentSaveObject.estado = 1;
            currentSaveObject.fechaPago = dtpFechaPago.Value.ToString();
            currentSaveObject.idCaja = ConfigModel.cajaSesion.idCajaSesion;
            // currentSaveObject
            currentSaveObject.numeroOperacion = textNOperacion.Text;
            currentSaveObject.monto = textMonto.Text;
            currentSaveObject.moneda = cbxMoneda.Text;
            currentSaveObject.idMoneda = Convert.ToInt32(cbxMoneda.SelectedValue);
            currentSaveObject.motivo = textMotivo.Text;
            currentSaveObject.observacion = textObcervacion.Text;

        }

        private bool validarCampos()
        {
            if (textNOperacion.Text == "")
            {
                errorProvider1.SetError(textNOperacion, "Este campo esta bacía");
                textNOperacion.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (textMonto.Text == "")
            {
                errorProvider1.SetError(textMonto, "Este campo esta bacía");
                textMonto.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
    class SaveObject
    {
        public int idIngreso { get; set; }
        public int estado { get; set; }
        public string fechaPago { get; set; }
        public int idCaja { get; set; }
        public int idCajaSesion { get; set; }
        public int idMedioPago { get; set; }
        public int idMoneda { get; set; }
        public string medioPago { get; set; }
        public string moneda { get; set; }
        public string monto { get; set; }
        public string motivo { get; set; }
        public string numeroOperacion { get; set; }
        public string observacion { get; set; }
        public string personal { get; set; }
    }

}
