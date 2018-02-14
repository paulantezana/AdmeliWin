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
using Entidad;

namespace Admeli.CajaBox
{
    public partial class UCIniciarCaja : UserControl
    {
        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }

        private CajaModel cajaModel = new CajaModel();
        private MonedaModel monedaModel = new MonedaModel();
        private MedioPagoModel medioPagoModel = new MedioPagoModel();
        private FechaModel fechaModel = new FechaModel();
        private ConfigModel configModel = new ConfigModel();

        private IngresoModel ingresoModel = new IngresoModel();

        private List<Moneda> monedas { get; set; }
        private MedioPago medioPago { get; set; }
        private CajaSesion currentCajaSesion { get; set; }
        private ObjectSaveCajaSesion saveCajaSesion { get; set; }

        #region =========================== Constructor ===========================
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
        #endregion

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
            // verificaciones
           verificarEstadoCaja();

            // loads
            cargarCajaSesion();
            cargarMonedas();
            cargarMediosPago();
            cargarFecha();
        }
        #endregion

        #region ============================= Estados =============================
        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
        } 
        #endregion

        #region =============================== Loads ===============================
        private async void cargarCajaSesion()
        {
            try
            {
                loadState(true);
                List<CajaSesion> list = await cajaModel.cajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
                if (list.Count == 0) return;
                currentCajaSesion = list[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }

        private async void cargarMediosPago()
        {
            try
            {
                loadState(true);
                List<MedioPago> list = await medioPagoModel.medioPagos();
                medioPago = list[0];

                dynamic currentFecha = await fechaModel.fechaSistema();
                dtpFechaInicio.Value = currentFecha.fecha;
                dtpFechaIngreso.Value = currentFecha.fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }

        private async void cargarFecha()
        {
            try
            {
                loadState(true);
                dynamic currentFecha = await fechaModel.fechaSistema();
                dtpFechaInicio.Value = currentFecha.fecha;
                dtpFechaIngreso.Value = currentFecha.fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }

        private async void cargarMonedas()
        {
            try
            {
                loadState(true);
                monedas = await monedaModel.monedas();
                int y = 255;
                foreach (Moneda money in monedas)
                {
                    crearElementosMoneda(money.moneda, money.idMoneda, y);
                    y += 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upps! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }

        }

        private async void verificarEstadoCaja()
        {
            await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
            if (ConfigModel.cajaSesion != null)
            {
                if (ConfigModel.cajaSesion.idCajaSesion > 0)
                {
                    Validator.labelAlert(lblCajaEstado, 1, "Usted ya inicio caja.");
                    btnAceptar.Enabled = false;
                }
                else
                {
                    Validator.labelAlert(lblCajaEstado, 0, "No se inicio la caja");
                    btnAceptar.Enabled = true;
                }
            }
            else
            {
                Validator.labelAlert(lblCajaEstado, 0, "No se inicio la caja");
                btnAceptar.Enabled = true;
            }
        }

        #endregion

        #region ============================= Crear Elementos =============================
        private void crearElementosMoneda(string content, int idMoneda,  int y)
        {

            Label lblMonedaLabel = new Label()
            {
                // creando un nuevo label
                AutoSize = true,
                BackColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.DodgerBlue,
                Margin = new System.Windows.Forms.Padding(2, 0, 2, 0),
                Size = new System.Drawing.Size(52, 14),

                // Modificar al gusto del cliente
                Name = "lbl" + idMoneda,
                Text = String.Format("{0}", content.ToUpper()),
                Location = new System.Drawing.Point(25, (y + 8)),
                TabIndex = 93,
            };
            BunifuMetroTextbox textMoneda1 = new BunifuMetroTextbox()
            {
                BackColor = System.Drawing.Color.White,
                BorderColorFocused = System.Drawing.Color.DodgerBlue,
                BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157))))),
                BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157))))),
                
                BorderThickness = 1,
                Cursor = System.Windows.Forms.Cursors.IBeam,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
                isPassword = false,
                Margin = new System.Windows.Forms.Padding(4),
                Padding = new System.Windows.Forms.Padding(5, 18, 5, 0),
                Size = new System.Drawing.Size(389, 50),
                TextAlign = System.Windows.Forms.HorizontalAlignment.Left,

                // al gusto del cliente
                Location = new System.Drawing.Point(18, y),
                Name = idMoneda.ToString(),
                TabIndex = 91,
                //OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            };
            textMoneda1.OnValueChanged += new EventHandler(this.textMoneda1_OnValueChanged);
            textMoneda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMoneda1_KeyPress);


            // Agreganto los dos elementos
            this.panelContainer.Controls.Add(lblMonedaLabel);
            this.panelContainer.Controls.Add(textMoneda1);

        }


        #endregion

        #region ================================ Validaciones Tiempo Real ================================
        private void textMoneda1_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string currentIDMoneda = ((BunifuMetroTextbox)sender).Name;
                if (currentIDMoneda != "")
                {
                    for (int i = 0; i < monedas.Count; i++)
                    {
                        if (monedas[i].idMoneda == Convert.ToInt32(currentIDMoneda))
                        {
                            string contentText = ((BunifuMetroTextbox)sender).Text;
                            monedas[i].monto = (contentText == "") ? 0 : Convert.ToInt32(contentText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textMoneda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
        #endregion

        #region ============================ Save ============================
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            executeGuardar();
        }

        private async void executeGuardar()
        {
            try
            {
                // Cambiando de estado
                loadState(true);

                // Guardar la caja sesion
                crearObjetoCajaSesion();
                Response responseCaja = await cajaModel.guardar(saveCajaSesion);

                

                // Guardando las monedas
                foreach (Moneda money in monedas)
                {
                    if (money.monto == 0) continue;
                    money.fechaPago = dtpFechaIngreso.Value.ToString("yyyy-MM-dd HH':'mm':'ss");
                    money.observacion = textObservacion.Text;
                    money.idCaja = ConfigModel.asignacionPersonal.idCaja;
                    money.idCajaSesion = responseCaja.id;
                    money.idMedioPago = medioPago.idMedioPago;
                    money.medioPago = medioPago.nombre;
                    money.motivo = "INCIO CAJA";
                    money.numeroOperacion = "";

                    Response response = await ingresoModel.guardarEnUno(money);
                }

                // Mensaje de confirmacion
                MessageBox.Show("Se inicio caja correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Recargar Datos despues de iniciar la caja
                await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
                loadState(false);
                this.reLoad();
            }
        }

        private void crearObjetoCajaSesion()
        {
            saveCajaSesion = new ObjectSaveCajaSesion();
            saveCajaSesion.idAsignarCaja = ConfigModel.asignacionPersonal.idAsignarCaja;
            saveCajaSesion.estado = 0;
        }

        #endregion
    }
    public class ObjectSaveCajaSesion
    {
        public int estado { get; set; }
        public int idAsignarCaja { get; set; }
    }
}
