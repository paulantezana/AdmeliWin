using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Modelo;

namespace Admeli.Compras.Nuevo.Detalle
{
    public partial class FormContactoNuevo : Form
    {
        private ContactoModel contactoModel = new ContactoModel();
        private FormProveedorNuevo formProveedorNuevo;

        private Contacto currentContacto { get; set; }
        private int currentIDContacto { get; set; }
        private bool nuevo { get; set; }

        public FormContactoNuevo()
        {
            InitializeComponent();
        }

        private void FormContactoNuevo_Load(object sender, EventArgs e)
        {

        }

        public FormContactoNuevo(FormProveedorNuevo formProveedorNuevo, Contacto currentContacto)
        {
            this.formProveedorNuevo = formProveedorNuevo;
            this.currentContacto = currentContacto;
        }

        public FormContactoNuevo(FormProveedorNuevo formProveedorNuevo)
        {
            this.formProveedorNuevo = formProveedorNuevo;
        }

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
                if (this.nuevo)
                {
                    Response response = await contactoModel.guardar(currentContacto);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await contactoModel.modificar(currentContacto);
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
            currentContacto = new Contacto();

            if (!this.nuevo) currentContacto.idProveedor = currentIDContacto; // Llenar el id categoria cuando este en esdo modificar

            currentContacto.nombres = textNombres.Text;
            currentContacto.apellidos = textApellidos.Text;
            currentContacto.numeroDocumento = textNDocumento.Text;
            currentContacto.telefono = textTelefono.Text;
            currentContacto.celular = textCelular.Text;
            currentContacto.email = textEmail.Text;
            currentContacto.direccion = textDireccion.Text;
            currentContacto.estado = Convert.ToInt32(chkEstado.Checked);
            currentContacto.idDocumento = 
            currentContacto.idProveedor = formProveedorNuevo.currentIDProveedor;
        }

        private bool validarCampos()
        {
            if (textNombres.Text == "")
            {
                errorProvider1.SetError(textNombres, "Este campo esta bacía");
                textNombres.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (textApellidos.Text == "")
            {
                errorProvider1.SetError(textApellidos, "Este campo esta bacía");
                textApellidos.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (cbxTipoDocumento.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxTipoDocumento, "Elija almenos uno");
                cbxTipoDocumento.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
