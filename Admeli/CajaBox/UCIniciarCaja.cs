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
using Entidad.Configuracion;
using Bunifu.Framework.UI;

namespace Admeli.CajaBox
{
    public partial class UCIniciarCaja : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private FechaModel fechaModel = new FechaModel();
        private MonedaModel monedaModel = new MonedaModel();

        private List<Moneda> monedas { get; set; }

        public UCIniciarCaja()
        {
            InitializeComponent();

            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCIniciarCaja(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            lisenerKeyEvents = true; // Active lisener key events
        }

        #region ============================== Paint and Decoration ==============================
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        } 
        #endregion

        #region ============================== Root Load ==============================
        private void UCIniciarCaja_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            cargarEstadoCaja();
            cargarFecha();
            cargarMonedas();
        }
        #endregion


        private async void cargarFecha()
        {
            try
            {
                dynamic currentFecha = await fechaModel.fechaSistema();
                dtpFechaInicio.Value = currentFecha.fecha;
                dtpFechaIngreso.Value = currentFecha.fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarMonedas()
        {
            try
            {
                monedas = await monedaModel.monedas();
                int y = 255;
                foreach (Moneda money in monedas)
                {
                    crearElementosMoneda(money.moneda, money.idMoneda, y);
                    y += 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cargarEstadoCaja()
        {
            if(ConfigModel.cajaSesion != null)
            {
                if (ConfigModel.cajaSesion.idCajaSesion > 0)
                {
                    lblCajaEstado.Text = "Usted ya inicio caja.";
                    lblCajaEstado.ForeColor = Color.FromArgb(76, 175, 80);
                    lblCajaEstado.BackColor = Color.FromArgb(232, 250, 239);
                    btnAceptar.Enabled = false;
                }
                else
                {
                    lblCajaEstado.Text = "No se inicio la caja";
                    lblCajaEstado.ForeColor = Color.FromArgb(250, 5, 73);
                    lblCajaEstado.BackColor = Color.FromArgb(255, 224, 224);
                    btnAceptar.Enabled = true;
                }
            }
            else
            {
                lblCajaEstado.Text = "No se inicio la caja";
                lblCajaEstado.ForeColor = Color.FromArgb(250, 5, 73);
                lblCajaEstado.BackColor = Color.FromArgb(255, 224, 224);
                btnAceptar.Enabled = true;
            }
        }

        #region ============================= Crear Elementos 
        private void crearElementosMoneda(string content, int idMoneda,  int y)
        {

            Label lblMonedaLabel = new Label()
            {
                // creando un nuevo label
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250))))),
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))),
                Margin = new System.Windows.Forms.Padding(2, 0, 2, 0),
                Size = new System.Drawing.Size(52, 14),

                // Modificar al gusto del cliente
                Name = "lbl" + idMoneda,
                Text = String.Format("{0}  | ", content.ToUpper()),
                Location = new System.Drawing.Point(25, (y + 9)),
                TabIndex = 93,
            };
            BunifuMetroTextbox textMoneda1 = new BunifuMetroTextbox()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250))))),
                BorderColorFocused = System.Drawing.Color.DodgerBlue,
                BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216))))),
                BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219))))),
                BorderThickness = 1,
                Cursor = System.Windows.Forms.Cursors.IBeam,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
                isPassword = false,
                Margin = new System.Windows.Forms.Padding(4),
                Padding = new System.Windows.Forms.Padding(100, 0, 6, 0),
                Size = new System.Drawing.Size(300, 30),
                TextAlign = System.Windows.Forms.HorizontalAlignment.Left,

                // al gusto del cliente
                Location = new System.Drawing.Point(18, y),
                Name = idMoneda.ToString(),
                TabIndex = 91,
                //OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            };
            textMoneda1.OnValueChanged += new EventHandler(this.textMoneda1_OnValueChanged);


            // Agreganto los dos elementos
            this.panelContainer.Controls.Add(lblMonedaLabel);
            this.panelContainer.Controls.Add(textMoneda1);

        }
        #endregion

        #region ================================ Validaciones Tiempo Real ================================
        private void textMoneda1_OnValueChanged(object sender, EventArgs e)
        {
            string currentIDMoneda = ((BunifuMetroTextbox)sender).Name;
            if (currentIDMoneda != "")
            {
                for (int i = 0; i < monedas.Count; i++)
                {
                    if (monedas[i].idMoneda == Convert.ToInt32(currentIDMoneda))
                    {
                        monedas[i].monto = Convert.ToInt32(((BunifuMetroTextbox)sender).Text);
                    }
                }
            }
        }
        #endregion

    }
}
