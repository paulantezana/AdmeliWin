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
    public partial class UCIniciar : UserControl
    {
        private FormPrincipal formPrincipal;

        public UCIniciar()
        {
            InitializeComponent();
        }

        public UCIniciar(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void UCIniciar_Load(object sender, EventArgs e)
        {
            cbxAlmacenes.DataSource = ConfigModel.alamacenes;
            cbxAlmacenes.DisplayMember = "nombre";
            cbxAlmacenes.ValueMember = "idAlmacen";
            cbxAlmacenes.SelectedIndex = 0;

            cbxPuntosVenta.DataSource = ConfigModel.puntosDeVenta;
            cbxPuntosVenta.DisplayMember = "nombre";
            cbxPuntosVenta.ValueMember = "idPuntoVenta";
            cbxPuntosVenta.SelectedIndex = 0;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cbxAlmacenes.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxAlmacenes, "No se seleccionó nungun almacen");
                cbxAlmacenes.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cbxPuntosVenta.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxPuntosVenta, "No se seleccionó nungun puntos de venta");
                cbxPuntosVenta.Focus();
                return;
            }
            errorProvider1.Clear();

            ConfigModel.currentIdAlmacen = Convert.ToInt32(cbxAlmacenes.SelectedValue.ToString());
            ConfigModel.currentPuntoVenta = Convert.ToInt32(cbxPuntosVenta.SelectedValue.ToString());

            // Mostrando Todo Los Elementos
            formPrincipal.appLoadInciComponents();
            formPrincipal.toggleHome();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContent, 243, 243, 243);
        }
    }
}
