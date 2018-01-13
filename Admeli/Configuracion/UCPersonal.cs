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
using Newtonsoft.Json;
using Admeli.Componentes;

namespace Admeli.Configuracion
{
    public partial class UCPersonal : UserControl
    {
        private PersonalModel personalModel = new PersonalModel();
        private Paginacion paginacion;
        private FormPrincipal formPrincipal;

        public UCPersonal()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSteepPages.Text));
        }

        public UCPersonal(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        private void UCPersonal_Load(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void loadState(bool state)
        {
            toolStripNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }

        private void mostrarPaginado()
        {
            // Cargando el combobox
            lblCurrentPage.Items.Clear();
            for (int i = 1; i <= paginacion.pageCount; i++)
            {
               lblCurrentPage.Items.AddRange(new object[] { i.ToString() });
            }
            lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

            // Paginados
            lblPageAllItems.Text = paginacion.itemsCount.ToString();
            lblPageCount.Text = paginacion.pageCount.ToString();
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                
                RootObject<Personal>  personales = await personalModel.listar(paginacion.currentPage.ToString(), paginacion.speed.ToString());

                // Enviando la cantidad de registros al objeto paginacion
                paginacion.itemsCount = personales.nro_registros;
                paginacion.reload();
                
               /* List<Personal> listPersonal = new List<Personal>();
                foreach (var item in response.datos)
                {
                    Personal personal = new Personal();
                    personal.idPersonal = item.idPersonal;
                    personal.nombres = item.nombres;
                    personal.apellidos = item.apellidos;
                    personal.fechaNacimiento = item.fechaNacimiento.date;
                    personal.tipoDocumento = item.tipoDocumento;
                    personal.numeroDocumento = item.numeroDocumento;
                    personal.sexo = item.sexo;
                    personal.email = item.email;
                    personal.telefono = item.telefono;
                    personal.celular = item.celular;
                    personal.usuario = item.usuario;
                    personal.password = item.password;
                    personal.direccion = item.direccion;
                    personal.estado = item.estado;
                    personal.idUbicacionGeografica = item.idUbicacionGeografica;
                    personal.idDocumento = item.idDocumento;

                    listPersonal.Add(personal);
                }*/
                // JsonConvert.DeserializeObject<List<Personal>>(response.datos);
                personalBindingSource.DataSource = personales.datos;
                dataGridView.Refresh();
                mostrarPaginado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
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

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                cargarRegistros();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.previousPage();
                cargarRegistros();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text != "1")
            {
                paginacion.firstPage();
                cargarRegistros();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                cargarRegistros();
            }
        }

        private void lblSteepPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSteepPages.Text);
                cargarRegistros();
            }
        }

        private void lblCurrentPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.reloadPage(Convert.ToInt32(lblCurrentPage.Text));
                cargarRegistros();
            }
        }
    }
}
