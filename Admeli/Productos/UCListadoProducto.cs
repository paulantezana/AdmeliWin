﻿using System;
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

        #region ============================== Constructor ==============================
        public UCListadoProducto()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCListadoProducto(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }
        #endregion

        #region ============================== Root Load ==============================
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

        internal void reLoad(bool refreshData = true)
        {
            if (refreshData)
            {
                cargarCategorias();
                cargarSucursales();
                cargarAlmacenes();
                cargarRegistros();
            }
            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion



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
        private async void cargarSucursales()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                sucursalBindingSource.DataSource = await sucursalModel.sucursales();
                cbxSucursales.SelectedValue = ConfigModel.sucursal.idSucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarAlmacenes()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                almacenBindingSource.DataSource = await almacenModel.almacenes();
                cbxAlmacenes.SelectedValue = ConfigModel.currentIdAlmacen;
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


                List<TreeNode> listNode = new List<TreeNode>();

                foreach (Categoria categoria in categoriaList)
                {
                    TreeNode aux = new TreeNode(categoria.nombreCategoria);
                    aux.Name = categoria.idCategoria.ToString();
                    listNode.Add(aux);

                }
                treeviewVista(categoriaList, treeViewCategoria.Nodes[0], listNode);



                // Estableciendo valores por defecto
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadState(false);
        }
        #region ======================= metodos para treeview =======================
        private Categoria primerElemento(List<Categoria> categoriaList)
        {

            Categoria lastCategori = categoriaList[0];//raiz
            categoriaList.Remove(lastCategori);
            return lastCategori;
        }
        private bool hijos(List<Categoria> categoriaList, Categoria padre)
        {
            bool tieneHijos = false;

            foreach (Categoria categoria in categoriaList)
            {
                if (categoria.padre == padre.nombreCategoria)
                {
                    tieneHijos = true;
                    break;

                }

            }
            return tieneHijos;
        }
        private TreeNode buscar(Categoria categoria, List<TreeNode> listNode)
        {
            TreeNode aux = new TreeNode();

            foreach (TreeNode node in listNode)
            {
                if (categoria.nombreCategoria == node.Text)
                {

                    aux = node;
                    break;
                }

            }

            return aux;

        }
        private TreeNode buscarPadre(Categoria categoria, List<TreeNode> listNode)
        {
            TreeNode aux = new TreeNode();

            foreach (TreeNode node in listNode)
            {
                if (categoria.padre == node.Text)
                {

                    aux = node;
                    break;
                }

            }

            return aux;

        }
        private void treeviewVista(List<Categoria> categoriaList, TreeNode padreNode, List<TreeNode> listNode)
        {
            if (categoriaList.Count == 0)
            {
                return;

            }
            else
            {
                Categoria aux = primerElemento(categoriaList);
                TreeNode auxTreeNode = buscar(aux, listNode);
                TreeNode nodePadre = buscarPadre(aux, listNode);
                if (hijos(categoriaList, aux))
                {
                    auxTreeNode.ImageIndex = 1;
                }

                if (nodePadre.Text != "")
                {

                    nodePadre.Nodes.Add(auxTreeNode);
                    treeviewVista(categoriaList, padreNode, listNode);
                }
                else
                {

                    padreNode.Nodes.Add(auxTreeNode);

                    treeviewVista(categoriaList, padreNode, listNode);

                }



            }



        }
        #endregion =============================

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
                dataGridView.Refresh();

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

        private async void cargarRegistrosStock()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                int idAlmacen = Convert.ToInt32(cbxAlmacenes.SelectedValue);
                int idSucursal = Convert.ToInt32(cbxSucursales.SelectedValue);

                RootObject<Producto> productos = await productoModel.productosStock(sendList, textBuscar.Text, idAlmacen, idSucursal, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productos.nro_registros;
                paginacion.reload();

                // Ingresando
                productoBindingSource.DataSource = productos.datos;
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

        private async void cargarRegistrosStockLike()
        {
            loadState(true);
            try
            {
                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                int idAlmacen = Convert.ToInt32(cbxAlmacenes.SelectedValue);
                int idSucursal = Convert.ToInt32(cbxSucursales.SelectedValue);

                RootObject<Producto> productos = await productoModel.productosStock(sendList, textBuscar.Text, idAlmacen, idSucursal, paginacion.currentPage, paginacion.speed);

                // actualizando datos de páginacón
                paginacion.itemsCount = productos.nro_registros;
                paginacion.reload();

                // Ingresando
                productoBindingSource.DataSource = productos.datos;
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
        #endregion

        #region =========================== Estados ===========================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            panelNavigation.Enabled = !state;
            panelCrud.Enabled = !state;
            panelTools.Enabled = !state;
            dataGridView.Enabled = !state;
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
            lblCurrentPage.Text = paginacion.currentPage.ToString();
            lblPageAllItems.Text = String.Format("{0} Registros", paginacion.itemsCount.ToString());
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

        private void lblCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }

        private void lblSpeedPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
        #endregion

        #region ==================== CRUD ====================
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            executeModificar();
        }

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
            if (e.KeyCode == Keys.Enter && textBuscar.Text.Trim() != "")
            {
                if (chkVerStock.Checked)
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
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idProducto = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentProducto = productos.Find(x => x.idProducto == idProducto); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormProductoNuevo formProducto = new FormProductoNuevo(currentProducto);
            formProducto.ShowDialog();
        }

        private async void executeEliminar()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridView.Rows.Count == 0)
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
                int index = dataGridView.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentProducto = new Producto(); //creando una instancia del objeto categoria
                currentProducto.idProducto = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value); // obteniedo el idCategoria del datagridview

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


        private void chkActivoAlmacen_OnChange(object sender, EventArgs e)
        {
            cbxAlmacenes.Enabled = chkVerStock.Checked;
            cbxSucursales.Enabled = chkVerStock.Checked;
            if (chkVerStock.Checked)
            {
                cargarRegistrosStock();
            }
            {
                cargarRegistros();
            }
        }

        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkVerStock.Checked)
            {
                cargarRegistrosStock();
            }
        }

        private void cbxAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkVerStock.Checked)
            {
                cargarRegistrosStock();
            }
        }
    }
}
