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

namespace Admeli
{
    public partial class FormLogin : Form
    {
        private PersonalModel personalModel = new PersonalModel();
        private FormPrincipal formPrincipal { get; set; }
        private FormPrincipal formHomeDarck { get; set; }

        private SucursalModel sucursalModel = new SucursalModel();
        private ConfigModel configModel = new ConfigModel();

        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                btnLogin.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                if (validarCampos())
                {
                    await personalModel.loginPersonal(textUsuario.Text, textPassword.Text);
                    // Formulario Darck UI

                    await cargarComponente();

                    formHomeDarck = new FormPrincipal(this);
                    formHomeDarck.Show();

                    // Formulario Office UI
                    // formPrincipal = new FormPrincipal(this);
                    // formPrincipal.Show();

                    // Ocultar formulario actual
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                btnLogin.Enabled = true;
            }
        }

        private async Task cargarComponente()
        {
            try
            {
                loadState(1, "Datos generales");
                await configModel.loadDatosGenerales();
                loadState(10, "sucursales");
                await configModel.loadSucursalPersonal(PersonalModel.personal.idPersonal);
                loadState(20, "cajas");
                await configModel.loadAsignacionPersonales(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                loadState(30, "configuracion");
                await configModel.loadConfiGeneral();
                loadState(40, "monedas");
                await configModel.loadMonedas();
                loadState(50, "tipos de cambio");
                await configModel.loadTipoCambioMonedas();
                loadState(60, "documentos");
                await configModel.loadTipoDocumento();
                loadState(70, "almacenes");
                await configModel.loadAlmacenes(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                loadState(80, "puntos de venta");
                await configModel.loadPuntoDeVenta(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                loadState(90, "caja sesion");
                await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
                loadState(100, "completo");
                // await configModel.loadCierreIngresoEgreso(1, ConfigModel.cajaSesion.idCajaSesion); // Falta Buscar de donde viene el primer parametro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadState(int value, string message)
        {
            lblProgress.Text = String.Format("Cargando {0} ... {1} %", message, value);
            progressbar.Value = value;
            progressbar.Refresh();
        }

        private bool validarCampos()
        {
            if (textUsuario.Text == "")
            {
                errorProvider1.SetError(textUsuario, "Debe ingresar un nombre de usuario");
                textUsuario.Focus();
                return false;
            }
            errorProvider1.Clear();
            if (textPassword.Text == "")
            {
                errorProvider1.SetError(textPassword, "Debe ingresar una contraseña");
                textPassword.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           // formFadeTransition1.ShowAsyc(this);
        }
    }
}
