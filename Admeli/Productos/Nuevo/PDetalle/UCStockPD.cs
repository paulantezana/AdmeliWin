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

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCStockPD : UserControl
    {
        private PrecioModel precioModel = new PrecioModel();
        private StockModel stockModel = new StockModel();

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
            precioBindingSource.DataSource = await precioModel.precioProducto(formProductoNuevo.currentIDProducto);
        }

        private async void cargarStock()
        {
            stockBindingSource.DataSource = await stockModel.stockProducto(formProductoNuevo.currentIDProducto);
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

        private void btnNuevoStock_Click(object sender, EventArgs e)
        {
            FormStockNuevo formStock = new FormStockNuevo();
            formStock.ShowDialog();
            this.cargarStock();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormPrecioDetalle formPrecioDetalle = new FormPrecioDetalle();
            formPrecioDetalle.ShowDialog();
            this.cargarPrecios();
        }
    }
}
