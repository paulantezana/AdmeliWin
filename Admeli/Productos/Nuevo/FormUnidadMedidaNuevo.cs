using Entidad;
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

namespace Admeli.Productos.Nuevo
{
    public partial class FormUnidadMedidaNuevo : Form
    {
        private UnidadMedidaModel unidadMedidaModel = new UnidadMedidaModel();
        private UnidadMedida unidadMedida = new UnidadMedida();
        private UnidadMedida unidad;

        public FormUnidadMedidaNuevo()
        {
            InitializeComponent();
        }

        public FormUnidadMedidaNuevo(UnidadMedida unidad)
        {
            this.unidad = unidad;
        }

        private void FormUnidadMedidaNuevo_Load(object sender, EventArgs e)
        {
            chkActivoUM.Checked = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarObjeto();
            if (validarCampos())
            {
                guardar();
            }
        }
        private bool validarCampos()
        {
            if (textNombreUM.Text == "")
            {
                errorProvider1.SetError(textNombreUM, "Rellene este campo");
                textNombreUM.Focus();
                return false;
            }
            if (textSimboloUM.Text == "")
            {
                errorProvider1.SetError(textSimboloUM, "Rellene este campo");
                textSimboloUM.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private async void guardar()
        {
            try
            {
                Response response = await unidadMedidaModel.guardar(unidadMedida);
                MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarObjeto()
        {
            unidadMedida.nombreUnidad = textNombreUM.Text;
            unidadMedida.simbolo = textSimboloUM.Text;
            unidadMedida.estado = Convert.ToInt32(chkActivoUM.Checked);
            unidadMedida.tieneRegistros = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
