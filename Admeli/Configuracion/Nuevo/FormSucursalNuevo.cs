using Admeli.Componentes;
using Entidad;
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

        private List<LabelUbicacion> labelUbicaciones { get; set; }
        private UbicacionGeografica ubicacionGeografica { get; set; }

        private Pais currentPais { get; set; }
        private int currentIDPais { get; set; }
        private bool nuevo { get; set; }

        private Sucursal currentSucursal { get; set; }

        public FormSucursalNuevo()
        {
            InitializeComponent();
            nuevo = true;
        }

        private  void FormSucursalNuevo_Load(object sender, EventArgs e)
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
            ubicacionGeografica = await locationModel.ubicacionGeografica(ConfigModel.sucursal.idUbicacionGeografica);
            cbxPaises.SelectedValue = ubicacionGeografica.idPais;
        }

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
                cbxNivel1.SelectedIndex = -1;
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
                cbxNivel2.SelectedIndex = -1;
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
                cbxNivel3.SelectedIndex = -1;
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
                    Response response = await sucursalModel.modificar(currentSucursal);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panel2);
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelFooter);
        }
    }
}
