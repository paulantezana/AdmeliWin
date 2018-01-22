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
        private UnidadMedida unidadMedida { get; set; }
        private UnidadMedida unidad;
        private int currentIdUnidadMedida { get; set; }
        private bool nuevo { get; set; }

        public FormUnidadMedidaNuevo()
        {
            InitializeComponent();
            nuevo = true;
            chkActivoUM.Checked = true;
        }

        public FormUnidadMedidaNuevo(UnidadMedida unidad)
        {
            InitializeComponent();
            this.unidad = unidad;
            this.nuevo = false;
            btnAceptar.Text = "Guardar cambios";
            this.cargarRegistrosModificar();
        }

        private void cargarRegistrosModificar()
        {
            currentIdUnidadMedida = unidad.idUnidadMedida;
            textNombreUM.Text = unidad.nombreUnidad;
            textSimboloUM.Text = unidad.simbolo;
            chkActivoUM.Checked = Convert.ToBoolean(unidad.estado);
        }

        private void FormUnidadMedidaNuevo_Load(object sender, EventArgs e)
        {
            
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
                if (nuevo)
                {
                    Response response = await unidadMedidaModel.guardar(unidadMedida);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await unidadMedidaModel.modificar(unidadMedida);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarObjeto()
        {
            unidadMedida = new UnidadMedida();
            if (!nuevo) unidadMedida.idUnidadMedida = currentIdUnidadMedida; // Llenar el id categoria cuando este en esdo modificar

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
