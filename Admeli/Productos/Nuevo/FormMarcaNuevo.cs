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
        private Marca marca { get; set; }
        private MarcaModel marcaModel = new MarcaModel();
        private int currentIdMarca { get; set; }
        private bool nuevo { get; set; }

        public FormMarcaNuevo()
        {
            InitializeComponent();
            chkActivoMarca.Checked = true;
            nuevo = true;
        }

        public FormMarcaNuevo(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            this.currentIdMarca = marca.idMarca;
            this.nuevo = false;
            this.btnAceptar.Text = "Guardar cambios";
            this.cargarRegistrosModificar();
        }

        private void cargarRegistrosModificar()
        {
            textNombreMarca.Text = marca.nombreMarca;
            textWebMarca.Text = marca.sitioWeb;
            textDescripcionMarca.Text = marca.descripcion;
            chkActivoMarca.Checked = Convert.ToBoolean(marca.estado);
        }

        private void FormMarcaNuevo_Load(object sender, EventArgs e)
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
                if (nuevo)
                {
                    Response response = await marcaModel.guardar(marca);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await marcaModel.modificar(marca);
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
            marca = new Marca();
            if (!nuevo) marca.idMarca = currentIdMarca; // Llenar el id categoria cuando este en esdo modificar

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
