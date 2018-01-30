using Admeli.Configuracion.Nuevo;
using Entidad;
using Entidad.Configuracion;
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
    public partial class FormPrecioDetalle : Form
    {
        private MonedaModel monedaModel = new MonedaModel();
        private SucursalModel sucursalModel = new SucursalModel();
        private Precio currentPrecio;

        public FormPrecioDetalle()
        {
            InitializeComponent();
        }

        public FormPrecioDetalle(Precio currentPrecio)
        {
            this.currentPrecio = currentPrecio;
        }

        private void FormPrecioDetalle_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            this.cargarMonedas();
            this.cargarSucursales();
        }

        private async void cargarSucursales()
        {
            sucursalBindingSource.DataSource = await sucursalModel.sucursales();
        }

        private async void cargarMonedas()
        {
            monedaBindingSource.DataSource = await monedaModel.monedas();
            Moneda moneda = await monedaModel.monedaPorDefecto();
            cbxMoneda.SelectedValue = moneda.idMoneda;
        }

        private void btnAddMoneda_Click(object sender, EventArgs e)
        {
            FormMonedaNuevo formMoneda = new FormMonedaNuevo();
            formMoneda.ShowDialog();
            this.cargarMonedas();
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            FormSucursalNuevo formSucursalNuevo = new FormSucursalNuevo();
            formSucursalNuevo.ShowDialog();
            this.cargarSucursales();
        }
    }
}
