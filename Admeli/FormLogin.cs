using Admeli.Componentes;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private int nLoads { get; set; }
        private int currentLoad { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            this.nLoads = 0;
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

                    await Task.Run(() =>
                    {
                        while (true)
                        {
                            Thread.Sleep(50);
                            if (nLoads >= 10)
                            {
                                break;
                            }
                        }
                    });

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
                await configModel.loadDatosGenerales();
                this.nLoads++;

                await configModel.loadSucursalPersonal(PersonalModel.personal.idPersonal);
                this.nLoads++;

                await configModel.loadAsignacionPersonales(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                this.nLoads++;

                loadConfiGeneral();

                loadMonedas();

                loadTipoCambioMonedas();

                loadTipoDocumento();

                loadAlmacenes();

                loadPuntoDeVenta();

                loadCajaSesion();

                // await configModel.loadCierreIngresoEgreso(1, ConfigModel.cajaSesion.idCajaSesion); // Falta Buscar de donde viene el primer parametro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void loadConfiGeneral()
        {
            await configModel.loadConfiGeneral();
            this.nLoads++;
        }

        private async void loadCajaSesion()
        {
            await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
            this.nLoads++;
        }

        private async void loadPuntoDeVenta()
        {
            await configModel.loadPuntoDeVenta(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
            this.nLoads++;
        }

        private async void loadAlmacenes()
        {
            await configModel.loadAlmacenes(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
            this.nLoads++;
        }

        private async void loadTipoDocumento()
        {
            await configModel.loadTipoDocumento();
            this.nLoads++;
        }

        private async void loadTipoCambioMonedas()
        {
            await configModel.loadTipoCambioMonedas();
            this.nLoads++;
        }

        private async void loadMonedas()
        {
            await configModel.loadMonedas();
            this.nLoads++;
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

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer,150,150,150);
        }
    }
}
