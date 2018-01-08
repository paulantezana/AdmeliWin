using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                btnCaja formPrincipal = new btnCaja();
                formPrincipal.Show();
                this.Hide();
            }
        }
        private bool validarCampos()
        {
            if(textUsuario.Text == "")
            {
                errorProvider1.SetError(textUsuario, "Debe ingresar un nombre de usuario");
                textUsuario.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (textPassword.Text == "")
            {
                errorProvider1.SetError(textPassword, "Debe ingresar una contraseña");
                textPassword.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
    }
}
