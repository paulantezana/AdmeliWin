using Admeli.Componentes;
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

namespace Admeli.Configuracion.Nuevo
{
    public partial class FormPuntoVentaNuevo : Form
    {
        private PuntoVentaModel puntoVentaModel = new PuntoVentaModel();
        private SucursalModel sucursalModel = new SucursalModel();

        private PuntoDeVenta puntoVenta { get; set; }
        private bool nuevo { get; set; }
        private int currentIDPuntoVenta { get; set; }

        public FormPuntoVentaNuevo()
        {
            InitializeComponent();
            this.nuevo = true;
        }

        public FormPuntoVentaNuevo(PuntoDeVenta puntoDeVenta)
        {
            InitializeComponent();

            this.nuevo = false;
            this.currentIDPuntoVenta = puntoDeVenta.idPuntoVenta;

            textPuntoVenta.Text = puntoDeVenta.nombre;
            cbxSucursalPV.SelectedValue = puntoDeVenta.idSucursal;
            chkActivo.Checked = Convert.ToBoolean(puntoDeVenta.estado);
        }

        private async void cargarSucursal()
        {
            sucursalBindingSource.DataSource = await sucursalModel.sucursalesProducto();
        }

        #region ===================== Paint =====================
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panel2);
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelFooter);
        }
        #endregion

        #region ===================== Guardar o guardar cambios =====================
        private bool validarCampos()
        {
            if (textPuntoVenta.Text == "")
            {
                errorProvider1.SetError(textPuntoVenta, "Rellene este campo");
                textPuntoVenta.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (cbxSucursalPV.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxSucursalPV, "Rellene este campo");
                cbxSucursalPV.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private async void guardar()
        {
            try
            {
                if (nuevo)
                {
                    Response response = await puntoVentaModel.guardar(puntoVenta);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await puntoVentaModel.modificar(puntoVenta);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearObjeto()
        {
            puntoVenta = new PuntoDeVenta();
            if (!nuevo) puntoVenta.idPuntoVenta = currentIDPuntoVenta; // Llenar el id categoria cuando este en esdo modificar

            puntoVenta.nombre = textPuntoVenta.Text;
            puntoVenta.idSucursal = Convert.ToInt32(cbxSucursalPV.SelectedValue);
            puntoVenta.estado = Convert.ToInt32(chkActivo.Checked);
        } 
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                crearObjeto();
                guardar();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPuntoVentaNuevo_Load(object sender, EventArgs e)
        {
            cargarSucursal();
        }
    }
}
