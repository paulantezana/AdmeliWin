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
    public partial class FormMarcaNuevo : Form
    {
        private Marca marca = new Marca();
        private MarcaModel marcaModel = new MarcaModel();

        public FormMarcaNuevo()
        {
            InitializeComponent();
        }

        private void FormMarcaNuevo_Load(object sender, EventArgs e)
        {
            chkActivoMarca.Checked = true;
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
            if (textNombreMarca.Text == "")
            {
                errorProvider1.SetError(textNombreMarca, "Rellene este campo");
                textNombreMarca.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private async void guardar()
        {
            try
            {
                Response response = await marcaModel.guardar(marca);
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
            marca.nombreMarca = textNombreMarca.Text;
            marca.sitioWeb = textWebMarca.Text;
            marca.descripcion = textDescripcionMarca.Text;
            marca.estado = Convert.ToInt32(chkActivoMarca.Checked);
            marca.captionImagen = "";
            marca.ubicacionLogo = "";
            marca.tieneRegistros = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
