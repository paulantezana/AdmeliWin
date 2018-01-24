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
        private UbicacionGeografica ubicacionGeografica { get; set; }

        private Pais currentPais { get; set; }
        private int currentIDPais { get; set; }

        public FormSucursalNuevo()
        {
            InitializeComponent();
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
            cbxPaises.DataSource = await locationModel.paises();
            cbxPaises.DisplayMember = "nombre";
            cbxPaises.ValueMember = "idPais";

            // cargando la ubicacion geografica por defecto
            ubicacionGeografica = await locationModel.ubicacionGeografica(ConfigModel.sucursal.idUbicacionGeografica);
            cbxPaises.SelectedValue = ubicacionGeografica.idPais;
        }

        #region ======================== Formando los niveles de cada pais ========================
        private async void crearNivelesPais()
        {
            try
            {
                loadStateApp(true);
                List<LabelUbicacion> labelUbicaciones = await locationModel.labelUbicacion(Convert.ToInt32(cbxPaises.SelectedValue));
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
                loadStateApp(true);
                cbxNivel1.SelectedIndexChanged -= new EventHandler(cbxNivel1_SelectedIndexChanged);
                cbxNivel1.DataSource = await locationModel.nivel1(Convert.ToInt32(cbxPaises.SelectedValue));
                cbxNivel1.ValueMember = "idNivel1";
                cbxNivel1.DisplayMember = "nombre";
                cbxNivel1.SelectedIndexChanged += new EventHandler(cbxNivel1_SelectedIndexChanged);
                loadStateApp(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void cargarNivel2()
        {
            try
            {
                loadStateApp(true);
                cbxNivel2.SelectedIndexChanged -= new EventHandler(cbxNivel2_SelectedIndexChanged);
                cbxNivel2.DataSource = await locationModel.nivel2(Convert.ToInt32(cbxNivel1.SelectedValue));
                cbxNivel2.DisplayMember = "nombre";
                cbxNivel2.ValueMember = "idNivel2";
                cbxNivel2.SelectedIndexChanged += new EventHandler(cbxNivel2_SelectedIndexChanged);
                loadStateApp(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void cargarNivel3()
        {
            try
            {
                loadStateApp(true);
                cbxNivel3.DataSource = await locationModel.nivel3(Convert.ToInt32(cbxNivel2.SelectedValue));
                cbxNivel3.DisplayMember = "nombre";
                cbxNivel3.ValueMember = "idNivel3";
                loadStateApp(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void cargarNivel4()
        {
            try
            {
                loadStateApp(true);
                cbxNivel4.DataSource = await locationModel.nivel4(Convert.ToInt32(cbxNivel3.SelectedValue));
                cbxNivel4.DisplayMember = "nombre";
                cbxNivel4.ValueMember = "idNivel4";
                loadStateApp(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


        private void loadStateApp(bool state)
        {
            if (state)
            {
                progressBarApp.Style = ProgressBarStyle.Marquee;
            }
            else{
                progressBarApp.Style = ProgressBarStyle.Blocks;
            }
        }

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


    }
}
