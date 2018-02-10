using Admeli.Componentes;
using Entidad;
using Entidad.Configuracion;
using Entidad.Location;
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

namespace Admeli.Configuracion.Nuevo
{
    public partial class FormSucursalNuevo : Form
    {
        private LocationModel locationModel = new LocationModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private PuntoModel puntoModel = new PuntoModel();

        private List<LabelUbicacion> labelUbicaciones { get; set; }
        private UbicacionGeografica ubicacionGeografica { get; set; }

        private PuntoAdministracion puntoAdministracion { get; set; }
        private PuntoCompra puntoCompra { get; set; }
        private List<PuntoDeVenta> puntosDeVenta { get; set; }
        private List<Caja> cajas { get; set; }
        private PuntoGerencia puntoGerencia { get; set; }

        private int currentIDSucursal { get; set; }
        private bool nuevo { get; set; }
        private Sucursal currentSucursal { get; set; }

        #region ========================= Constructor =========================
        public FormSucursalNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
        }

        public FormSucursalNuevo(Sucursal currentSucursal)
        {
            InitializeComponent();
            this.currentSucursal = currentSucursal;
            this.currentIDSucursal = currentSucursal.idSucursal;
            this.mostrarDatosModificar();
            this.nuevo = false;
        }
        #endregion

        #region ========================= Paint =========================
        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelFooter);
        }
        #endregion

        #region ========================== Load ==========================
        private void mostrarDatosModificar()
        {
            textNombreSucursal.Text = currentSucursal.nombre;
            textDirecionSucursal.Text = currentSucursal.direccion;
            chkPrincipalSucursal.Checked = currentSucursal.principal;
            chkActivoSucursal.Checked = Convert.ToBoolean(currentSucursal.estado);

            /*loadPuntoAdministracion();
            loadPuntoCompra();
            loadPuntoVenta();
            loadCajas();
            loadPuntoGerencia();*/
        }

        /*
        private async void loadPuntoAdministracion(){
            puntoAdministracion = await puntoModel.puntoAdministracion(currentSucursal.idSucursal);
            chkAdministracionSucursal.Checked = Convert.ToBoolean(puntoAdministracion.estado);
        }
        private async void loadPuntoCompra() {
            puntoCompra = await puntoModel.puntoCompra(currentSucursal.idSucursal);
            chkCompraSucursal.Checked = Convert.ToBoolean(puntoCompra.estado);
        }
        private async void loadPuntoVenta() {
            puntosDeVenta = await puntoModel.puntoVentas(currentSucursal.idSucursal);
            chkVentaSucursal.Checked = Convert.ToBoolean((puntosDeVenta.Count > 0) ? puntosDeVenta[0].estado : 0);
        }
        private async void loadCajas() {
            cajas = await puntoModel.cajas(currentSucursal.idSucursal);
            chkCajaSucursal.Checked = Convert.ToBoolean(cajas[0].estado);
        }
        private async void loadPuntoGerencia() {
            puntoGerencia = await puntoModel.puntoGerencia(currentSucursal.idSucursal);
            chkGerenciaSucursal.Checked = Convert.ToBoolean(puntoGerencia.estado);
        }*/

        private void FormSucursalNuevo_Load(object sender, EventArgs e)
        {
            loadRootData();
        }

        private async void loadRootData()
        {
            await cargarPaises();
            crearNivelesPais();
        }

        private async Task cargarPaises()
        {
            // cargando los paises
            paisBindingSource.DataSource = await locationModel.paises();

            // cargando la ubicacion geografica por defecto
            if (nuevo)
            {
                ubicacionGeografica = await locationModel.ubigeoActual(ConfigModel.sucursal.idUbicacionGeografica);
            }
            else
            {
                ubicacionGeografica = await locationModel.ubigeoActual(currentSucursal.idUbicacionGeografica);
            }
            cbxPaises.SelectedValue = ubicacionGeografica.idPais;
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
            finally{
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
                if (ubicacionGeografica.idNivel2 > 0)
                {
                    cbxNivel2.SelectedValue = ubicacionGeografica.idNivel2;
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
            finally{
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
                if (ubicacionGeografica.idNivel3 > 0)
                {
                    cbxNivel3.SelectedValue = ubicacionGeografica.idNivel3;
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
                /*if (ubicacionGeografica.idNivel4 > 0)
                {
                    cbxNivel4.SelectedValue = ubicacionGeografica.idNivel4;
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
                progressBarApp.Style = ProgressBarStyle.Marquee;
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                progressBarApp.Style = ProgressBarStyle.Blocks;
                Cursor.Current = Cursors.Default;
            }
        } 
        #endregion

        #region ====================== Niveles localizacion eventos =====================
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
                    Response response = await sucursalModel.guardar(ubicacionGeografica, currentSucursal);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await sucursalModel.modificar(ubicacionGeografica, currentSucursal);
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
            currentSucursal = new Sucursal();

            if (!nuevo) currentSucursal.idSucursal = currentIDSucursal; // Llenar el id categoria cuando este en esdo modificar

            currentSucursal.nombre = textNombreSucursal.Text;
            currentSucursal.principal = chkPrincipalSucursal.Checked;
            currentSucursal.estado = Convert.ToInt32(chkActivoSucursal.Checked);
            currentSucursal.direccion = textDirecionSucursal.Text;
            currentSucursal.tieneRegistros = "0";

            // Cargando estados
            currentSucursal.estados = "";
            currentSucursal.estados = Convert.ToInt32(chkGerenciaSucursal.Checked) + ",";
            currentSucursal.estados = Convert.ToInt32(chkAdministracionSucursal.Checked) + ",";
            currentSucursal.estados = Convert.ToInt32(chkCajaSucursal.Checked) + ",";
            currentSucursal.estados = Convert.ToInt32(chkVentaSucursal.Checked) + ",";
            currentSucursal.estados = Convert.ToInt32(chkCompraSucursal.Checked).ToString();

            // Ubicacion geografica
            ubicacionGeografica.idPais = (cbxPaises.SelectedIndex == -1) ? ubicacionGeografica.idPais : Convert.ToInt32(cbxPaises.SelectedValue);
            ubicacionGeografica.idNivel1 = (cbxNivel1.SelectedIndex == -1) ? ubicacionGeografica.idNivel1 : Convert.ToInt32(cbxNivel1.SelectedValue);
            ubicacionGeografica.idNivel2 = (cbxNivel2.SelectedIndex == -1) ? ubicacionGeografica.idNivel2 : Convert.ToInt32(cbxNivel2.SelectedValue);
            ubicacionGeografica.idNivel3 = (cbxNivel3.SelectedIndex == -1) ? ubicacionGeografica.idNivel3 : Convert.ToInt32(cbxNivel3.SelectedValue);
        }

        private bool validarCampos()
        {
            if (textNombreSucursal.Text == "")
            {
                errorProvider1.SetError(textNombreSucursal, "Este campo esta bacía");
                textNombreSucursal.Focus();
                return false;
            }
            errorProvider1.Clear();

            switch (labelUbicaciones.Count)
            {
                case 1:
                    if (cbxNivel1.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cbxNivel1, "No se seleccionó ningún elemento");
                        cbxNivel1.Focus();
                        return false;
                    }
                    errorProvider1.Clear();
                    break;
                case 2:
                    if (cbxNivel2.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cbxNivel2, "No se seleccionó ningún elemento");
                        cbxNivel2.Focus();
                        return false;
                    }
                    errorProvider1.Clear();
                    break;
                case 3:
                    if (cbxNivel3.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cbxNivel3, "No se seleccionó ningún elemento");
                        cbxNivel3.Focus();
                        return false;
                    }
                    errorProvider1.Clear();
                    break;
                case 4:
                    if (cbxNivel4.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cbxNivel4, "No se seleccionó ningún elemento");
                        cbxNivel4.Focus();
                        return false;
                    }
                    errorProvider1.Clear();
                    break;
                default:
                    break;
            }

            if (textDirecionSucursal.Text == "")
            {
                errorProvider1.SetError(textDirecionSucursal, "Este campo esta bacía");
                textDirecionSucursal.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        #endregion

    }
}
