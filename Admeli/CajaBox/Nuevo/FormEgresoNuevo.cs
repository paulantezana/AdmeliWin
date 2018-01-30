using Entidad;
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

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormEgresoNuevo : Form
    {
        private MonedaModel monedaModel = new MonedaModel();
        private CajaModel cajaModel = new CajaModel();
        private Egreso currentEgreso;

        public FormEgresoNuevo()
        {
            InitializeComponent();
        }

        public FormEgresoNuevo(Egreso currentEgreso)
        {
            this.currentEgreso = currentEgreso;
        }

        private void FormEgresoNuevo_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            this.cargarMonedas();
            this.cargarCorrelativo();
        }

        private async void cargarMonedas()
        {
            monedaBindingSource.DataSource = await monedaModel.monedas();
        }

        private async void cargarCorrelativo()
        {
            var data = ConfigModel.cajaSesion.idCajaSesion;
            dynamic response = await cajaModel.correlativoSerie(1, 0);
            textNOperacion.Text = Convert.ToString(response.correlativoActual);
        }
    }
}
