using Admeli.Configuracion.Nuevo;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class FormStockNuevo : Form
    {
        private AlmacenModel almacenModel = new AlmacenModel();

        public FormStockNuevo()
        {
            InitializeComponent();
        }

        private void FormStockNuevo_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            cargarAlmacenes();
        }

        private async void cargarAlmacenes() {
            almacenBindingSource.DataSource = await almacenModel.almacenes();
        }

        private void btnAddAlmacen_Click(object sender, EventArgs e)
        {
            FormAlmacenNuevo formAlmacen = new FormAlmacenNuevo();
            formAlmacen.ShowDialog();
            this.cargarAlmacenes();
        }
    }
}
