using Entidad;
using Entidad.Util;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormEgresoNuevo : Form
    {
        private MonedaModel monedaModel = new MonedaModel();
        private EgresoModel egresoModel = new EgresoModel();
        private CajaModel cajaModel = new CajaModel();

        private int currentIDEgreso { get; set; }
        private bool nuevo { get; set; }
        private Egreso currentEgreso { get; set; }


        public FormEgresoNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
            dtpFechaPago.Value = DateTime.Now;
        }

        public FormEgresoNuevo(Egreso currentEgreso)
        {
            this.currentEgreso = currentEgreso;
            this.nuevo = false;
        }

        private void FormEgresoNuevo_Load(object sender, EventArgs e)
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
                    Response response = await egresoModel.guardar(currentEgreso);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await egresoModel.modificar(currentEgreso);
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
            currentEgreso = new Egreso();

            if (!nuevo) currentEgreso.idEgreso = currentIDEgreso; // Llenar el id categoria cuando este en esdo modificar

            currentEgreso.numeroOperacion = textNOperacion.Text;
            currentEgreso.monto = textMonto.Text;
            currentEgreso.moneda = cbxMoneda.Text;
            currentEgreso.idMoneda = Convert.ToInt32(cbxMoneda.SelectedValue);
            currentEgreso.motivo = textMotivo.Text;
            currentEgreso.observacion = textObcervacion.Text;
            Fecha currentFecha = new Fecha()
            {
                date = (DateTime)dtpFechaPago.Value
            };
            currentEgreso.fechaPago = currentFecha;
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
}
