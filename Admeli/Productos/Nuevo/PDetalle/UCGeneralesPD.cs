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
    public partial class UCGeneralesPD : UserControl
    {
        public UnidadMedidaModel unidadMedidaModel = new UnidadMedidaModel();
        public MarcaModel marcaModel = new MarcaModel();


        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCGeneralesPD()
        {
            InitializeComponent();
        }

        public UCGeneralesPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        #region ================================ Root Load ================================
        private void UCGeneralesPD_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        internal void reLoad()
        {
            cargarMarcas();
            cargarUnidadesMedida();
        } 
        #endregion

        #region ============================= Loads =============================
        internal async void cargarMarcas()
        {
            marcaBindingSource.DataSource = await marcaModel.marcas();
        }
        internal async void cargarUnidadesMedida()
        {
            unidadMedidaBindingSource.DataSource = await unidadMedidaModel.unimedidas();
        }
        #endregion

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            FormMarcaNuevo formMarca = new FormMarcaNuevo();
            formMarca.ShowDialog();
            this.cargarMarcas();
        }

        private void btnAddUnidadMedida_Click(object sender, EventArgs e)
        {
            FormUnidadMedidaNuevo formUnidad = new FormUnidadMedidaNuevo();
            formUnidad.ShowDialog();
            this.cargarUnidadesMedida();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormElegirCategoria formElegir = new FormElegirCategoria();
            formElegir.ShowDialog();
        }
    }
}
