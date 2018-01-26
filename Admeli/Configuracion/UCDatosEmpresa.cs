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
using Entidad.Location;

namespace Admeli.Configuracion
{
    public partial class UCDatosEmpresa : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private ConfigModel configModel = new ConfigModel();
        private LocationModel locationModel = new LocationModel();

        private DatosGenerales datosGenerales { get; set; }
        private ConfiguracionGeneral configuracionGeneral { get; set; }
        private List<LabelUbicacion> labelUbicaciones { get; set; }
        private UbicacionGeografica ubicacionGeografica { get; set; }

        private Pais pais { get; set; }

        #region ============================ Loads ============================
        private void UCDatosEmpresa_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private async Task cargarPaises()
        {
            // cargando los paises
            paisBindingSource.DataSource = await locationModel.paises();

            // cargando la ubicacion geografica por defecto
            ubicacionGeografica = await locationModel.ubicacionGeografica(ConfigModel.sucursal.idUbicacionGeografica);
            cbxPaises.SelectedValue = ubicacionGeografica.idPais;
        }

        internal async void reLoad()
        {
            await cargarPaises();
            crearNivelesPais();
            // Cargando los datos generales
            datosGenerales = await configModel.getDatosGenerales();

            // Cargando la configuracion general
            configuracionGeneral = await configModel.getConfiGeneral();

            lisenerKeyEvents = true; // Active lisener key events

            // MOstrando los datos en los campos
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            textNombreEmpresa.Text = datosGenerales.razonSocial;
            textNumeroIdentificacion.Text = datosGenerales.ruc;
            textEmail.Text = datosGenerales.email;
            textDireccion.Text = datosGenerales.direccion;
            textFormaDePago.Text = datosGenerales.cuentaBancaria;

            textItemPagina.Text = configuracionGeneral.itemPorPagina.ToString();
            textNumeroDigitos.Text = configuracionGeneral.numeroDecimales.ToString();
            textPorcentajeUtilidad.Text = configuracionGeneral.porcentajeUtilidad;
            chkArquearMarcador.Checked = configuracionGeneral.arquearMarcador;
        }
        #endregion

        #region ================== Formando los niveles de cada pais ==================
        private async void crearNivelesPais()
        {
            try
            {
                loadStateApp(true);
                labelUbicaciones = await locationModel.labelUbicacion(Convert.ToInt32(cbxPaises.SelectedValue));
                ocultarNiveles(); // Ocultando todo los niveles

                // Mostrando los niveles uno por uno
                if (labelUbicaciones.Count >= 1)
                {
                    lblNivel1.Visible = true;
                    lblNivel1.Text = labelUbicaciones[0].denominacion;
                    cbxNivel1.Visible = true;
                }

                if (labelUbicaciones.Count >= 2)
                {
                    lblNivel2.Visible = true;
                    lblNivel2.Text = labelUbicaciones[1].denominacion;
                    cbxNivel2.Visible = true;
                }

                if (labelUbicaciones.Count >= 3)
                {
                    lblNivel3.Visible = true;
                    lblNivel3.Text = labelUbicaciones[2].denominacion;
                    cbxNivel3.Visible = true;
                }

                if (labelUbicaciones.Count > 4)
                {
                    lblNivel4.Visible = true;
                    lblNivel4.Text = labelUbicaciones[3].denominacion;
                    cbxNivel4.Visible = true;
                }

                // Cargar el primer nivel de la localizacion
                cargarNivel1();
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                loadStateApp(false);
            }
        }

        private void ocultarNiveles()
        {
            lblNivel1.Visible = false;
            lblNivel2.Visible = false;
            lblNivel3.Visible = false;
            lblNivel4.Visible = false;

            cbxNivel1.Visible = false;
            cbxNivel2.Visible = false;
            cbxNivel3.Visible = false;
            cbxNivel4.Visible = false;

            cbxNivel1.SelectedIndex = -1;
            cbxNivel2.SelectedIndex = -1;
            cbxNivel3.SelectedIndex = -1;
            cbxNivel4.SelectedIndex = -1;
        }

        private async void cargarNivel1()
        {
            try
            {
                // No cargar directo al comobobox esto causara que el evento SelectedIndexChange de forma automatica
                if (labelUbicaciones.Count < 1) return;
                loadStateApp(true);
                nivel1BindingSource.DataSource = await locationModel.nivel1(Convert.ToInt32(cbxPaises.SelectedValue));

                // seleccionando el valor por defecto
                if (ubicacionGeografica.idNivel1 > 0)
                {
                    cbxNivel1.SelectedValue = ubicacionGeografica.idNivel1;
                }
                else
                {
                    cbxNivel1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadStateApp(false);
                desactivarNivelDesde(2);
            }
        }

        private async void cargarNivel2()
        {
            try
            {
                if (labelUbicaciones.Count < 2) return;
                loadStateApp(true);
                nivel2BindingSource.DataSource = await locationModel.nivel2(Convert.ToInt32(cbxNivel1.SelectedValue));

                // seleccionando el valor por defecto
                if (Convert.ToInt32(ubicacionGeografica.idNivel2) > 0)
                {
                    cbxNivel2.SelectedValue = Convert.ToInt32(ubicacionGeografica.idNivel2);
                }
                else
                {
                    cbxNivel2.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                desactivarNivelDesde(3);
                loadStateApp(false);
            }
        }

        private async void cargarNivel3()
        {
            try
            { 
                if (labelUbicaciones.Count < 3) return;
                loadStateApp(true);
                nivel3BindingSource.DataSource = await locationModel.nivel3(Convert.ToInt32(cbxNivel2.SelectedValue));

                // seleccionando el valor por defecto
                if (Convert.ToInt32(ubicacionGeografica.idNivel3) > 0)
                {
                    cbxNivel3.SelectedValue = Convert.ToInt32(ubicacionGeografica.idNivel3);
                }
                else
                {
                    cbxNivel3.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadStateApp(false);
                desactivarNivelDesde(4);
            }
        }

        private async void cargarNivel4()
        {
            try
            {
                if (labelUbicaciones.Count < 4) return;
                loadStateApp(true);
                nivel4BindingSource.DataSource = await locationModel.nivel4(Convert.ToInt32(cbxNivel3.SelectedValue));

                // seleccionando el valor por defecto
                /*if (Convert.ToInt32(ubicacionGeografica.idNivel4) > 0)
                {
                    cbxNivel4.SelectedValue = Convert.ToInt32(ubicacionGeografica.idNivel4);
                }
                else
                {
                    cbxNivel4.SelectedIndex = -1;
                }*/

                cbxNivel4.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadStateApp(false);
            }
        }

        private void desactivarNivelDesde(int n)
        {
            cbxNivel1.Enabled = true;
            cbxNivel2.Enabled = true;
            cbxNivel3.Enabled = true;
            cbxNivel4.Enabled = true;

            if (n < 2) cbxNivel1.Enabled = false;
            if (n < 3) cbxNivel2.Enabled = false;
            if (n < 4) cbxNivel3.Enabled = false;
            if (n < 5) cbxNivel4.Enabled = false;
        }
        #endregion

        #region ==================== Estados =====================
        private void loadStateApp(bool state)
        {
            if (state)
            {
                formPrincipal.appLoadState(state);
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                formPrincipal.appLoadState(state);
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region ========================= Constructor =========================
        public UCDatosEmpresa()
        {
            InitializeComponent();
            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCDatosEmpresa(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion

        #region ===================== Eventos Para cargar paise y niveles =====================
        private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            crearNivelesPais();
        }

        private void cbxNivel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarNivel2();
        }

        private void cbxNivel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarNivel3();
        }

        private void cbxNivel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarNivel4();
        }
        #endregion

        #region ============================ Guardar ============================
        private void actualizarObejeto()
        {
            // Actualizando los datos generales
            datosGenerales.razonSocial = textNombreEmpresa.Text;
            datosGenerales.ruc = textNumeroIdentificacion.Text;
            datosGenerales.email = textEmail.Text;
            datosGenerales.direccion = textDireccion.Text;
            datosGenerales.cuentaBancaria = textFormaDePago.Text;

            // Actualizando las configuraciones generales
            configuracionGeneral.numeroDecimales = Convert.ToInt32(textNumeroDigitos.Text);
            configuracionGeneral.itemPorPagina = Convert.ToInt32(textItemPagina.Text);
            configuracionGeneral.porcentajeUtilidad = textPorcentajeUtilidad.Text;
            configuracionGeneral.arquearMarcador = chkArquearMarcador.Checked;

            // Ubicacion geografica
            ubicacionGeografica.idPais = (cbxPaises.SelectedIndex == -1) ? ubicacionGeografica.idPais : Convert.ToInt32(cbxPaises.SelectedValue);
            ubicacionGeografica.idNivel1 = (cbxNivel1.SelectedIndex == -1) ? ubicacionGeografica.idNivel1 : Convert.ToInt32(cbxNivel1.SelectedValue);
            ubicacionGeografica.idNivel2 = (cbxNivel2.SelectedIndex == -1) ? ubicacionGeografica.idNivel2 : Convert.ToInt32(cbxNivel2.SelectedValue);
            ubicacionGeografica.idNivel3 = (cbxNivel3.SelectedIndex == -1) ? ubicacionGeografica.idNivel3 : Convert.ToInt32(cbxNivel3.SelectedValue);
        }

        private bool validarCampos()
        {
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                executeGuardar();
            }
        }

        private async void executeGuardar()
        {
            loadStateApp(true);
            actualizarObejeto();
            await configModel.guardarConfigGeneral(configuracionGeneral);
            await configModel.guardarDatosGenerales(ubicacionGeografica, datosGenerales);
            loadStateApp(false);
        }
        #endregion

    }
}
