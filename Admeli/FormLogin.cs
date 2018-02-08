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

namespace Admeli
{
    public partial class FormLogin : Form
    {
        private PersonalModel personalModel = new PersonalModel();
        private FormPrincipal formPrincipal { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (validarCampos())
                {
                    await personalModel.loginPersonal(textUsuario.Text, textPassword.Text);
                    formPrincipal = new FormPrincipal(this);
                    formPrincipal.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private bool validarCampos()
        {
            if (textUsuario.Text == "")
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            formFadeTransition1.ShowAsyc(this);
        }
    }
}
