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

namespace Admeli.Herramientas
{
    public partial class UCInicializarStock : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private CategoriaModel categoriaModel = new CategoriaModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private AlmacenModel almacenModel = new AlmacenModel();
        private ProductoModel productoModel = new ProductoModel();

        private Paginacion paginacion;
        private List<ProductoData> productos { get; set; }
        private ProductoData currentProdcuto { get; set; }

        public UCInicializarStock()
        {
            InitializeComponent();

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        public UCInicializarStock(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lblSpeedPages.Text = ConfigModel.configuracionGeneral.itemPorPagina.ToString();     // carganto los items por página
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSpeedPages.Text));
        }

        #region ================================= Paint =================================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void UCInicializarStock_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelSucursal);
            drawShape.lineBorder(panelAlmacen);
        } 
        #endregion

        private void UCInicializarStock_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            this.lisenerKeyEvents = true; // Active lisener key events
            this.cargarCategorias(); // 
            this.cargarSucursales();
            this.cargarAlmacenes();
            this.cargarRegistros();
        }

        #region ==================================== Load ====================================
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
                /* if (ConfigModel.currentProductoCategory.Count > 0)
                 {
                     recuperarCatSeleccionado();
                 }
                 else
                 {
                     treeViewCategoria.Nodes[0].ExpandAll();
                 }
                 treeViewCategoria.Nodes[0].Checked = true;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            loadState(false);
        }

        private async void cargarSucursales()
        {
            // Cargando el combobox de personales
            loadState(true);
            try
            {
                cbxSucursales.DataSource = await sucursalModel.sucursales();
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
                cbxAlmacenes.DataSource = await almacenModel.almacenes();
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

                int sucursalId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.SelectedValue);
                int almacenID = (cbxAlmacenes.SelectedIndex == -1) ? ConfigModel.currentIdAlmacen : Convert.ToInt32(cbxAlmacenes.SelectedValue);

                RootObjectData rootObjectData = await productoModel.stockHerramienta<RootObjectData>(sendList, almacenID, sucursalId, paginacion.currentPage, paginacion.speed);

                
                // actualizando datos de páginacón
                paginacion.itemsCount = rootObjectData.nro_registros;
                paginacion.reload();

                // Ingresando
                productos = rootObjectData.productos;
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
                if (textBuscar.Text == "")
                {
                    cargarRegistros();
                    return;
                }

                Dictionary<string, int> list = new Dictionary<string, int>();
                list.Add("id0", 0);
                Dictionary<string, int> sendList = (ConfigModel.currentProductoCategory.Count == 0) ? list : ConfigModel.currentProductoCategory;

                int sucursalId = (cbxSucursales.SelectedIndex == -1) ? ConfigModel.sucursal.idSucursal : Convert.ToInt32(cbxSucursales.SelectedValue);
                int almacenID = (cbxAlmacenes.SelectedIndex == -1) ? ConfigModel.currentIdAlmacen : Convert.ToInt32(cbxAlmacenes.SelectedValue);

                RootObjectData rootObjectData = await productoModel.stockHerramientaLike<RootObjectData>(sendList, textBuscar.Text, almacenID, sucursalId, paginacion.currentPage, paginacion.speed);


                // actualizando datos de páginacón
                paginacion.itemsCount = rootObjectData.nro_registros;
                paginacion.reload();

                // Ingresando
                productos = rootObjectData.productos;
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

        #region ============================= Estados =============================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
            toolStripNavigation.Enabled = !state;
            dataGridView1.Enabled = !state;
        }
        #endregion

        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void cbxAlmacenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
                cargarRegistrosBuscar();
           }
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            cargarRegistros();
        }
    }
}


public class RootObjectData
{
    public List<ProductoData> productos { get; set; }
    public List<object> combinacion { get; set; }
    public int nro_registros { get; set; }
}

public class ImpuestoData
{
    public int idImpuesto { get; set; }
    public string valorImpuesto { get; set; }
    public bool porcentual { get; set; }
}

public class ProductoData
{
    public int idProducto { get; set; }
    public string codigoProducto { get; set; }
    public string nombreProducto { get; set; }
    public string descripcionCorta { get; set; }
    public string precioCompra { get; set; }
    public object precioConImpuesto { get; set; }
    public string utilidad { get; set; }
    public int estado { get; set; }
    public int idUnidadMedida { get; set; }
    public int idMarca { get; set; }
    public string nombreUnidad { get; set; }
    public string nombreMarca { get; set; }
    public bool enUso { get; set; }
    public bool mostrarWeb { get; set; }
    public bool mostrarPrecioWeb { get; set; }
    public string precioVenta { get; set; }
    public string stock { get; set; }
    public string stockFinanciero { get; set; }
    public int idSucursal { get; set; }
    public string sucursal { get; set; }
    public int idAlmacen { get; set; }
    public string almacen { get; set; }
    public string productoAlmacen { get; set; }
    public List<ImpuestoData> impuesto { get; set; }
}