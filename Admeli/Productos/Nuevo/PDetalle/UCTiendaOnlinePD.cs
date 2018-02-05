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
using Modelo;
using Entidad;
using Admeli.Productos.Nuevo.PDetalle.web;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCTiendaOnlinePD : UserControl
    {
        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        private ComentarioModel comentarioModel = new ComentarioModel();
        private ProductoRelacionModel productoRelacionModel = new ProductoRelacionModel();

        private List<Comentario> comentarios { get; set; }
        private List<ProductoRelacion> productoRelaciones { get; set; }

        private Comentario currentComentario { get; set; }
        private ProductoRelacion currentProductoRelacion { get; set; }

        public UCTiendaOnlinePD()
        {
            InitializeComponent();
        }

        public UCTiendaOnlinePD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void UCTiendaOnlinePD_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            cargarComentarios();
            cargarRelacionProducto();
        }

        private async void cargarComentarios()
        {
            loadState(true);
            try
            {
                List<Comentario> list = await comentarioModel.comentarios(formProductoNuevo.currentIDProducto);

                // cargando los datos
                comentarios = list;
                comentarioBindingSource.DataSource = comentarios;
                dataGridViewComentarios.Refresh();

                // formato de celadas
                // decorationDataGridView();
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

        private void loadState(bool state)
        {
            formProductoNuevo.appLoadState(state);
        }

        private async void cargarRelacionProducto()
        {
            loadState(true);
            try
            {
                List<ProductoRelacion> list = await productoRelacionModel.productoRelaciones(formProductoNuevo.currentIDProducto);

                // cargando los datos
                productoRelaciones = list;
                productoRelacionBindingSource.DataSource = productoRelaciones;
                dataGridViewRelaciones.Refresh();

                // formato de celadas
                // decorationDataGridView();
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

        #region ============================ CRUD RELACION ============================
        private void btnNuevoRelacion_Click(object sender, EventArgs e)
        {
            executeNuevoRelacion();
        }

        private void btnModificarRelacion_Click(object sender, EventArgs e)
        {
            executeModificarRelacion();
        }

        private void btnEliminarRelacion_Click(object sender, EventArgs e)
        {
            executeEliminarRelacion();
        }
        private void btnActualizarRelacion_Click(object sender, EventArgs e)
        {
            executeActualizarRelacion();
        }

        private void executeNuevoRelacion()
        {
            FormRelacionNuevo formRelacion = new FormRelacionNuevo(formProductoNuevo);
            formRelacion.ShowDialog();
            cargarRelacionProducto();
        }

        private void executeModificarRelacion()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewRelaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridViewRelaciones.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idProductoRelacion = Convert.ToInt32(dataGridViewRelaciones.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentProductoRelacion = productoRelaciones.Find(x => x.idProductoRelacion == idProductoRelacion); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormRelacionNuevo formRelacion = new FormRelacionNuevo(formProductoNuevo, currentProductoRelacion);
            formRelacion.ShowDialog();
            cargarRelacionProducto(); // recargando loas registros en el datagridview
        }

        private async void executeEliminarRelacion()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewRelaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Pregunta de seguridad de eliminacion
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;


            try
            {
                int index = dataGridViewRelaciones.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentProductoRelacion = new ProductoRelacion(); //creando una instancia del objeto categoria
                currentProductoRelacion.idProductoRelacion = Convert.ToInt32(dataGridViewRelaciones.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

                loadState(true); // cambiando el estado
                Response response = await productoRelacionModel.eliminar(currentProductoRelacion); // Eliminando con el webservice correspondiente
                MessageBox.Show(response.msj, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRelacionProducto(); // recargando el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false); // cambiando el estado
            }
        }

        private void executeActualizarRelacion()
        {
            cargarRelacionProducto();
        }
        #endregion

        #region ========================== CRUD Comentario ==========================
        private void btnNuevoComentario_Click(object sender, EventArgs e)
        {
            executeNuevoComentario();
        }

        private void btnModificarComentario_Click(object sender, EventArgs e)
        {
            executeModificarComentario();
        }

        private void btnEliminarComentario_Click(object sender, EventArgs e)
        {
            executeEliminarComentario();
        }

        private void btnActualizarComentario_Click(object sender, EventArgs e)
        {
            executeActualizarComentario();
        }

        private void executeNuevoComentario()
        {
            FormComentarioNuevo formComentario = new FormComentarioNuevo(formProductoNuevo);
            formComentario.ShowDialog();
            cargarComentarios();
        }

        private void executeModificarComentario()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewComentarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridViewComentarios.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idComentario = Convert.ToInt32(dataGridViewComentarios.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentComentario = comentarios.Find(x => x.idComentario == idComentario); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormComentarioNuevo formComentario = new FormComentarioNuevo(formProductoNuevo, currentComentario);
            formComentario.ShowDialog();
            cargarComentarios(); // recargando loas registros en el datagridview
        }

        private async void executeEliminarComentario()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewComentarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Pregunta de seguridad de eliminacion
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;


            try
            {
                int index = dataGridViewComentarios.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentComentario = new Comentario(); //creando una instancia del objeto categoria
                currentComentario.idComentario = Convert.ToInt32(dataGridViewComentarios.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

                loadState(true); // cambiando el estado
                Response response = await comentarioModel.eliminar(currentComentario); // Eliminando con el webservice correspondiente
                MessageBox.Show(response.msj, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarComentarios(); // recargando el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false); // cambiando el estado
            }
        }

        private void executeActualizarComentario()
        {
            cargarComentarios();
        } 
        #endregion
    }
}
