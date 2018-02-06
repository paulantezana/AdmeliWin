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
using Entidad;
using Newtonsoft.Json;
using Admeli.Productos.Importar;

namespace Admeli.Productos
{
    public partial class UCListadoProducto : UserControl
    {
        private ProductoModel productoModel = new ProductoModel();
        private CategoriaModel categoriaModel = new CategoriaModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private AlmacenModel almacenModel = new AlmacenModel();

        private Paginacion paginacion;
        private FormPrincipal formPrincipal;

        public bool lisenerKeyEvents { get; set; }
        private List<Producto> productos { get; set; }
        private Producto currentProducto { get; set; }

        private bool verStock { get; set; }

        public UCListadoProducto()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCListadoProducto(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));

            lisenerKeyEvents = true; // Active lisener key events
        }

        private void UCListadoProducto_Load(object sender, EventArgs e)
        {
            this.reLoad();

            // Escuchando los eventos del formulario padre
            if (TopLevelControl is Form)
            {
                (TopLevelControl as Form).KeyPreview = true;
                TopLevelControl.KeyUp += TopLevelControl_KeyUp;
            }
        }

        internal void reLoad(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        internal void reLoad()
        {
            // agregando un checkbox en toostriptools
            addCheckBox();

            // load data
            cargarComponentes();
            cargarCategorias();
            cargarComponentesThird();
            cargarRegistros();

            lisenerKeyEvents = true; // Active lisener key events
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        #region ======================== KEYBOARD ========================
        private void TopLevelControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (!lisenerKeyEvents) return;
            switch (e.KeyCode)
            {
                case Keys.F3:
                    executeNuevo();
                    break;
                case Keys.F4:
                    executeModificar();
                    break;
                case Keys.F5:
                    cargarRegistros();
                    break;
                case Keys.F6:
                    executeEliminar();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region =========================== Decoration ===========================
        private void decorationDataGridView()
        {
            /*
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var estado = dataGridView.Rows[i].Cells.get.Value.ToString();
                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DeepPink;
            }*/
        }
        #endregion

        #region ======================= Loads =======================
        private async void cargarComponentes()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxSucursales.ComboBox.DataSource = await sucursalModel.sucursales();
                cbxSucursales.ComboBox.DisplayMember = "nombre";
                cbxSucursales.ComboBox.ValueMember = "idSucursal";
                cbxSucursales.ComboBox.SelectedValue = ConfigModel.sucursal.idSucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarCategorias()
        {
            loadState(true);
            try
            {
                // Cargando las categorias desde el webservice
                List<Categoria> categoriaList = await categoriaModel.categoriasTodo();
                Categoria lastCategori = categoriaList.Last();
                categoriaList.Remove(lastCategori);

                // Cargando
                treeViewCategoria.Nodes.Clear(); // limpiando
                treeViewCategoria.Nodes.Add(lastCategori.idCategoria.ToString(), lastCategori.nombreCategoria); // Cargando categoria raiz

                foreach (Categoria categoria in categoriaList)
                {
                    if (categoria.padre == null)
                    {
                        // Cargando categorias padre
                        treeViewCategoria.Nodes[0].ImageIndex = 1;
                        treeViewCategoria.Nodes[0].Nodes.Add(categoria.idCategoria.ToString(), categoria.nombreCategoria);
                    }
                    else
                    {
                        // Cargando subcategorias
                        int nodeIndex = treeViewCategoria.Nodes[0].Nodes.IndexOfKey(categoria.idPadreCategoria.ToString());
                       /* string parent = categoria.idPadreCategoria.ToString();
                        var node = treeViewCategoria.Nodes.Cast<TreeNode>().Where(r => r.Name == parent);*/
                        treeViewCategoria.Nodes[0].Nodes[nodeIndex].ImageIndex = 1;
                        treeViewCategoria.Nodes[0].Nodes[nodeIndex].Nodes.Add(categoria.idCategoria.ToString(), categoria.nombreCategoria);
                    }
                }

                // Estableciendo valores por defecto
                if (ConfigModel.currentProductoCategory.Count > 0)
                {
                    recuperarCatSeleccionado();
                }
                else
                {
                    treeViewCategoria.Nodes[0].ExpandAll();
                }
                treeViewCategoria.Nodes[0].Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadState(false);
        }
        /*
        private void treeNodeAddRecursive(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }*/

        private async void cargarComponentesThird()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxAlmacenes.ComboBox.DataSource = await almacenModel.almacenes();
                cbxAlmacenes.ComboBox.DisplayMember = "nombre";
                cbxAlmacenes.ComboBox.ValueMember = "idAlmacen";
                cbxAlmacenes.ComboBox.SelectedValue = ConfigModel.currentIdAlmacen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                RootObject<Producto> productosRoot = await productoModel.productosPorCategoria(sendList, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productosRoot.nro_registros;
                paginacion.reload();

                // Ingresando
                productos = productosRoot.datos;
                productoBindingSource.DataSource = productos;
                dataGridView1.Refresh();

                // Mostrando la paginacion
                mostrarPaginado();

                // Formato de celdas
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
        private async void cargarRegistrosBuscar()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                RootObject<Producto> productos = await productoModel.productosPorCategoriaBuscar(sendList, textBuscar.Text, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productos.nro_registros;
                paginacion.reload();

                // Ingresando
                productoBindingSource.DataSource = productos.datos;
                dataGridView1.Refresh();
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

        private async void cargarRegistrosStock()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                int idAlmacen = Convert.ToInt32(cbxAlmacenes.ComboBox.SelectedValue);
                int idSucursal = Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);

                RootObject<Producto> productos = await productoModel.productosStock(sendList, textBuscar.Text, idAlmacen, idSucursal, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productos.nro_registros;
                paginacion.reload();

                // Ingresando
                productoBindingSource.DataSource = productos.datos;
                dataGridView1.Refresh();
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

        private async void cargarRegistrosStockLike()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                int idAlmacen = Convert.ToInt32(cbxAlmacenes.ComboBox.SelectedValue);
                int idSucursal = Convert.ToInt32(cbxSucursales.ComboBox.SelectedValue);

                RootObject<Producto> productos = await productoModel.productosStock(sendList, textBuscar.Text, idAlmacen, idSucursal, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productos.nro_registros;
                paginacion.reload();

                // Ingresando
                productoBindingSource.DataSource = productos.datos;
                dataGridView1.Refresh();
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
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            toolStripNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView1.Enabled = !state;
        }

        private void stateCombobox(bool state)
        {
            cbxAlmacenes.Enabled = state;
            cbxSucursales.Enabled = state;
        }
        #endregion

        #region ===================== Eventos Páginación =====================
        private void mostrarPaginado()
        {
            // Cargando el combobox
            lblCurrentPage.Items.Clear();
            for (int i = 1; i <= paginacion.pageCount; i++)
            {
                lblCurrentPage.Items.AddRange(new object[] { i.ToString() });
            }
            if (paginacion.pageCount != 0) lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

            // Paginados
            lblPageAllItems.Text = paginacion.itemsCount.ToString();
            lblPageCount.Text = paginacion.pageCount.ToString();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.nextPage();
                cargarRegistros();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lblPageCount.Text == "0") return;
            if (lblPageCount.Text != lblCurrentPage.Text)
            {
                paginacion.lastPage();
                cargarRegistros();
            }
        }

        private void lblSpeedPages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paginacion.speed = Convert.ToInt32(lblSpeedPages.Text);
                paginacion.currentPage = 1;
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
        #endregion

        #region ==================== CRUD ====================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            executeNuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            executeModificar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            executeEliminar();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBuscar.Text != "")
            {
                if (verStock)
                {
                    cargarRegistrosStockLike();
                }
                else
                {
                    cargarRegistrosBuscar();
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                cargarRegistrosBuscar();
            }
        }

        private void executeNuevo()
        {
            FormProductoNuevo formProducto = new FormProductoNuevo();
            formProducto.ShowDialog();
            cargarRegistros();
        }

        private void executeModificar()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridView1.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idProducto = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentProducto = productos.Find(x => x.idProducto == idProducto); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormProductoNuevo formProducto = new FormProductoNuevo(currentProducto);
            formProducto.ShowDialog();
            cargarRegistros(); // recargando loas registros en el datagridview
        }

        private async void executeEliminar()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView1.Rows.Count == 0)
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
                int index = dataGridView1.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentProducto = new Producto(); //creando una instancia del objeto categoria
                currentProducto.idProducto = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

                loadState(true); // cambiando el estado
                Response response = await productoModel.eliminar(currentProducto); // Eliminando con el webservice correspondiente
                MessageBox.Show(response.msj, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRegistros(); // recargando el datagridview
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

        /*
        private async void executeAnular()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Desactivar o anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
                int idProducto = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

                currentProducto = productos.Find(x => x.idProducto == idProducto); // Buscando la registro especifico en la lista de registros
                currentProducto.estado = 0;

                // Procediendo con las desactivacion
                Response response = await productoModel.modificar(currentProducto);
                MessageBox.Show(response.msj, "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarRegistros(); // recargando los registros en el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        */
        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            FormCategoriaNuevo formCategoria = new FormCategoriaNuevo();
            formCategoria.ShowDialog();
            cargarCategorias();
        }
        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        // Nueva ventana para importar los productos desde un archivo excel
        private void btnImportar_Click(object sender, EventArgs e)
        {
            FormImportarProduto formImportar = new FormImportarProduto();
            formImportar.ShowDialog();
            this.reLoad();
        }

        #endregion



        #region ======================== Treeview control checked ========================

        private void recuperarCatSeleccionado()
        {
            foreach (var item in ConfigModel.currentProductoCategory)
            {

                int nodeIndex = treeViewCategoria.Nodes[0].Nodes.IndexOfKey(item.Value.ToString());
            }
        }


        private int itemNumber { get; set; }

        private void treeViewCategoria_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // OBteniendo los datos seleccionados del treeView y almacenando en un diccionary
            TreeNode mainNode = treeViewCategoria.Nodes[0];
            itemNumber = 0;
            ConfigModel.currentProductoCategory.Clear();
            getRecursiveNodes(mainNode);

            // cargando los registros
            cargarRegistros();
        }
        public void getRecursiveNodes(TreeNode parentNode)
        {
            if (parentNode.Checked)
            {
                ConfigModel.currentProductoCategory.Add("id" + itemNumber.ToString(), Convert.ToInt32(parentNode.Name));
                itemNumber++;
            }
            foreach (TreeNode subNode in parentNode.Nodes)
            {
                getRecursiveNodes(subNode);
            }
        }
        #endregion

        #region ======================= Control de isChecked en el treeview =======================
        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }

        private void treeViewCategoria_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }
        #endregion

        #region ======= Agregando un nuevo checkbox a las herramientas en toolstrip =========
        private void addCheckBox()
        {
            CheckBox cb = new CheckBox();
            cb.Text = "Ver Stock";
            //cb.CheckStateChanged += (s, ex) =&gt; this.Text = cb.CheckState.ToString();
            cb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            ToolStripControlHost host = new ToolStripControlHost(cb);
            toolStripTools.Items.Insert(3,host);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            verStock = ((CheckBox)sender).Checked;
            if (verStock)
            {
                cargarRegistrosStock();
            }
            else
            {
                cargarRegistros();
            }
            stateCombobox(verStock);
        }
        #endregion

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            executeModificar();
        }
    }
}
