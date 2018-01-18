using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Admeli.Componentes;

namespace Admeli
{
    public partial class UCHome : UserControl
    {
        private FormPrincipal formPrincipal;
        private CompraModel compraModel = new CompraModel();
        private VentaModel ventaModel = new VentaModel();
        private NotaEntradaModel notaEntradaModel = new NotaEntradaModel();
        private CobroModel cobroModel = new CobroModel();
        private PagoModel pagoModel = new PagoModel();

        public UCHome()
        {
            InitializeComponent();
        }

        public UCHome(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            cargarRegistros1();
            cargarRegistros2();
            cargarRegistros3();
            cargarRegistros4();
            cargarRegistros5();
            cargarRegistros6();
        }

        private async void cargarRegistros1()
        {
            compraBindingSource.DataSource = await compraModel.comprasUltimas(PersonalModel.personal.idPersonal,ConfigModel.sucursal.idSucursal,1,1);
        }

        private async void cargarRegistros2()
        {
            ventaBindingSource.DataSource = await ventaModel.ventasUltimas(PersonalModel.personal.idPersonal,ConfigModel.sucursal.idSucursal,1,1);
        }

        private async void cargarRegistros3()
        {
            notaEntradaBindingSource.DataSource = await notaEntradaModel.nEntradaPendientes(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal, 1, 1);
        }

        private void cargarRegistros4()
        {
            // 
        }
        private async void cargarRegistros5()
        {
            cobroBindingSource.DataSource = await cobroModel.porCobrar(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal, ConfigModel.asignacionPersonal.idAsignarCaja, 1, 1);
        }
        private async void cargarRegistros6()
        {
            pagoBindingSource.DataSource = await pagoModel.porPagar(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal, ConfigModel.asignacionPersonal.idAsignarCaja, 1, 1);
        }

        private void cardContainer1_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer1);
        }

        private void cardContainer2_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer2);
        }

        private void cardContainer3_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer3);
        }

        private void cardContainer4_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer4);
        }

        private void cardContainer5_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer5);
        }

        private void cardContainer6_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(cardContainer6);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            int sizeW = panelContainer.Size.Width;
            int sizeH = panelContainer.Size.Height;
            sizeW = sizeW / 2;
            panelItem1.Size = new Size(sizeW, sizeH);
        }
    }
}
