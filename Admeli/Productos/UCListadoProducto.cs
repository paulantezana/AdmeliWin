using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;
using Admeli.Productos.Nuevo;
using Modelo;

namespace Admeli.Productos
{
    public partial class UCListadoProducto : UserControl
    {
        private ProductoModel productoModel = new ProductoModel();
        private Paginacion paginacion;

        public UCListadoProducto()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSteepPages.Text));
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormProductoNuevo productoNuevo = new FormProductoNuevo();
            productoNuevo.ShowDialog();
        }

        private void UCListadoProducto_Load(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void loadState(bool state)
        {
            toolStripNavigation.Enabled = !state;
            //toolStripCrud.Enabled = !state;
            //toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }

        private void mostrarPaginado()
        {
            // Cargando el combobox
            lblCurrentPage.Items.Clear();
            for (int i = 1; i <= paginacion.pageCount; i++)
            {
                lblCurrentPage.Items.AddRange(new object[] { i.ToString(), i.ToString() });
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

               /* dynamic response = await OrdenCompraModel.li(paginacion.currentPage.ToString(), paginacion.speed.ToString());

                // Enviando la cantidad de registros al objeto paginacion
                paginacion.itemsCount = response.nro_registros;
                paginacion.reload();

                List<Personal> listPersonal = new List<Personal>();
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
                }
                // JsonConvert.DeserializeObject<List<Personal>>(response.datos);
                personalBindingSource.DataSource = listPersonal;
                dataGridView.Refresh();
                mostrarPaginado();*/
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



    }
}
