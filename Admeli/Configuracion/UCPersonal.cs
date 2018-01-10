using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Entidad;

namespace Admeli.Configuracion
{
    public partial class UCPersonal : UserControl
    {
        PersonalModel personalModel = new PersonalModel();

        public UCPersonal()
        {
            InitializeComponent();
        }

        private async void UCPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                dynamic response = await personalModel.listar("1","15");

                List<Personal> listPersonal = new List<Personal>();
                foreach (var item in response.datos)
                {
                    Personal personal = new Personal();
                    personal.idPersonal = item.idPersonal;
                    personal.nombres = item.nombres;
                    personal.apellidos = item.apellidos;
                    personal.tipoDocumento = item.tipoDocumento;
                    personal.numeroDocumento = item.numeroDocumento;
                    personal.sexo = item.sexo;
                    personal.email = item.email;
                    personal.telefono = item.telefono;
                    personal.celular = item.celular;
                    personal.direccion = item.direccion;
                    personal.estado = item.estado;
                    personal.idDocumento = item.idDocumento;
                    personal.usuario = item.usuario;

                    listPersonal.Add(personal);
                }
                personalBindingSource.DataSource = listPersonal;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.personalBindingSource.Sort = this.dataGridView.SortString;
        }

        private void dataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.personalBindingSource.Filter = this.dataGridView.FilterString;
        }
    }
}
