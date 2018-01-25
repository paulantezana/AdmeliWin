using Admeli.Componentes;
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

namespace Admeli.Configuracion.Nuevo
{
    public partial class FormDocumentoIdetificaionNuevo : Form
    {
        private DocumentoIdentificacionModel documentoModel = new DocumentoIdentificacionModel();
        private DocumentoIdentificacion currentDocumentoIdentificacion;

        private DocumentoIdentificacion documentoIdentificacion { get; set; }
        private bool nuevo { get; set; }
        private int currentIDDocI { get; set; }

        public FormDocumentoIdetificaionNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
        }

        public FormDocumentoIdetificaionNuevo(DocumentoIdentificacion document)
        {
            InitializeComponent();
            this.nuevo = false;

            this.currentDocumentoIdentificacion = document;
            currentIDDocI = document.idDocumento;
            textNombreDocumentoIdenti.Text = document.nombre;
            textDigitosDocumentoIdenti.Text = document.numeroDigitos.ToString();
            cbxTipoDocumento.Text = document.tipoDocumento;
            chkActivoDI.Checked = Convert.ToBoolean(document.estado);
        }

        #region =================== Paint ===================
        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelFooter);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panel2);
        } 
        #endregion

        private bool validarCampos()
        {
            if (textNombreDocumentoIdenti.Text == "")
            {
                errorProvider1.SetError(textNombreDocumentoIdenti, "Rellene este campo");
                textNombreDocumentoIdenti.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (textDigitosDocumentoIdenti.Text == "")
            {
                errorProvider1.SetError(textDigitosDocumentoIdenti, "Rellene este campo");
                textDigitosDocumentoIdenti.Focus();
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
                    Response response = await documentoModel.guardar(documentoIdentificacion);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await documentoModel.modificar(documentoIdentificacion);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearObjeto()
        {
            documentoIdentificacion = new DocumentoIdentificacion();
            if (!nuevo) documentoIdentificacion.idDocumento = currentIDDocI; // Llenar el id categoria cuando este en esdo modificar

            documentoIdentificacion.nombre = textNombreDocumentoIdenti.Text;
            documentoIdentificacion.numeroDigitos = Convert.ToInt32(textDigitosDocumentoIdenti.Text);
            documentoIdentificacion.tipoDocumento = cbxTipoDocumento.SelectedText;
            documentoIdentificacion.estado = Convert.ToInt32(chkActivoDI.Checked);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            crearObjeto();
            if (validarCampos())
            {
                guardar();
            }
        }

        private void FormDocumentoIdetificaionNuevo_Load(object sender, EventArgs e)
        {

        }

        private void textDigitosDocumentoIdenti_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
