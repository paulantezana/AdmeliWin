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

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCStockPD : UserControl
    {
        private PrecioModel precioModel = new PrecioModel();
        private StockModel stockModel = new StockModel();

        private Precio currentPrecio { get; set; }
        private Stock currentStock { get; set; }

        private List<Precio> precios { get; set; }
        private List<Stock> stocks { get; set; }

        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCStockPD()
        {
            InitializeComponent();
        }

        public UCStockPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }


        internal void reLoad()
        {
            cargarPrecios();
            cargarStock();
        }

        private async void cargarPrecios()
        {
            precios = await precioModel.precioProducto(formProductoNuevo.currentIDProducto);
            precioBindingSource.DataSource = precios;
        }

        private async void cargarStock()
        {
            stocks = await stockModel.stockProducto(formProductoNuevo.currentIDProducto);
            stockBindingSource.DataSource = stocks;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void UCStockPD_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }




        #region ==================== CRUD ====================
        private void btnNuevoStock_Click(object sender, EventArgs e)
        {
            FormStockNuevo formStock = new FormStockNuevo();
            formStock.ShowDialog();
            this.cargarStock();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            executeModificarPrecio();
        }

        private void btnDesactiarStock_Click(object sender, EventArgs e)
        {
            executeAnularStock();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            executeAnularPrecio();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarPrecios();
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            this.cargarStock();
        }

        private void executeModificarPrecio()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewPrecios.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridViewPrecios.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idPrecioProducto = Convert.ToInt32(dataGridViewPrecios.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentPrecio = precios.Find(x => x.idPrecioProducto == idPrecioProducto); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormPrecioDetalle formPrecioDetalle = new FormPrecioDetalle(currentPrecio);
            formPrecioDetalle.ShowDialog();
            this.cargarPrecios(); // recargando loas registros en el datagridview
        }

        private void executeModificarStock()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewStocks.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = dataGridViewStocks.CurrentRow.Index; // Identificando la fila actual del datagridview
            int idProductoStockAlmacen = Convert.ToInt32(dataGridViewStocks.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

            currentStock = stocks.Find(x => x.idProductoStockAlmacen == idProductoStockAlmacen); // Buscando la registro especifico en la lista de registros

            // Mostrando el formulario de modificacion
            FormStockNuevo formStock = new FormStockNuevo(currentStock);
            formStock.ShowDialog();
            this.cargarStock(); // recargando los registros
        }

        private async void executeAnularPrecio()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewPrecios.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Desactivar o anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int index = dataGridViewPrecios.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentPrecio = new Precio(); //creando una instancia del objeto correspondiente
                currentPrecio.idPrecioProducto = Convert.ToInt32(dataGridViewPrecios.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

                // Comprobando si el registro ya esta desactivado
                if (precios.Find(x => x.idPrecioProducto == currentPrecio.idPrecioProducto).estado == 0)
                {
                    MessageBox.Show("Este registro ya esta desactivado", "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Procediendo con las desactivacion
                Response response = await precioModel.desactivar(currentPrecio);
                MessageBox.Show(response.msj, "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarPrecios(); // recargando los registros en el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void executeAnularStock()
        {
            // Verificando la existencia de datos en el datagridview
            if (dataGridViewStocks.Rows.Count == 0)
            {
                MessageBox.Show("No hay un registro seleccionado", "Desactivar o anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int index = dataGridViewStocks.CurrentRow.Index; // Identificando la fila actual del datagridview
                currentStock = new Stock(); //creando una instancia del objeto correspondiente
                currentStock.idProductoStockAlmacen = Convert.ToInt32(dataGridViewStocks.Rows[index].Cells[0].Value); // obteniedo el idRegistro del datagridview

                // Comprobando si el registro ya esta desactivado
                if (stocks.Find(x => x.idProductoStockAlmacen == currentStock.idProductoStockAlmacen).estado == 0)
                {
                    MessageBox.Show("Este registro ya esta desactivado", "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Procediendo con las desactivacion
                Response response = await stockModel.desactivar(currentStock);
                MessageBox.Show(response.msj, "Desactivar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarStock(); // recargando los registros en el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Anular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
