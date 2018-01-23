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
            int y = 165;
            int selectedIdPais = (cbxPaises.SelectedIndex == -1) ? ubicacionGeografica.idPais : Convert.ToInt32(cbxPaises.SelectedValue);
            List<LabelUbicacion> labelUbicaciones = await locationModel.labelUbicacion(Convert.ToInt32(cbxPaises.SelectedValue.ToString()));
            labelUbicaciones.ForEach(item =>
            {
                crearGrupoLabel(item, y);
                y += 55;
            });
        }

        private void crearGrupoLabel(LabelUbicacion labelUbicacion, int y)
        {
            ComboBox cbxDepartamento = new System.Windows.Forms.ComboBox()
            {
                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                FormattingEnabled = true,
                Location = new System.Drawing.Point(20, y),
                Name = "cbx" + labelUbicacion.denominacion,
                Size = new System.Drawing.Size(328, 24),
                TabIndex = 42,
            };

            Label lblDepartametno = new System.Windows.Forms.Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))),
                Location = new System.Drawing.Point(17, (y-20)),
                Margin = new System.Windows.Forms.Padding(2, 0, 2, 0),
                Name = "lbl" + labelUbicacion.denominacion,
                Size = new System.Drawing.Size(89, 16),
                TabIndex = 41,
                Text = labelUbicacion.denominacion,
            };

            groupDatoSucursales.Controls.Add(lblDepartametno);
            groupDatoSucursales.Controls.Add(cbxDepartamento);
        }
        #endregion

        private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            crearNivelesPais();
        }
    }
}
