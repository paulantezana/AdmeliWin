using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Entidad;
using Entidad.Configuracion;
using Modelo;

namespace Admeli.CajaBox.Nuevo
{
    public partial class FormArquearCaja : Form
    {
        private CierreCaja currentCierreCaja;
        private CajaSesion currentCajaSesion;

        private MedioPagoModel medioPagoModel = new MedioPagoModel();
        private IngresoModel ingresoModel = new IngresoModel();
        private ConfigModel configModel = new ConfigModel();
        private FechaModel fechaModel = new FechaModel();
        private MonedaModel monedaModel = new MonedaModel();
        private CierreCajaModel cierreCajaModel = new CierreCajaModel();
        private DenominacionModel denominacionModel = new DenominacionModel();

        private List<MedioPago> medioPagos { get; set; }
        private List<Moneda> ingresoMenosEgreso { get; set; }

        // variables de los elementos en el aside
        private int x = 13, y = 10;

        #region =========================== Constructor ===========================
        public FormArquearCaja()
        {
            InitializeComponent();
        }

        public FormArquearCaja(CierreCaja currentCierreCaja)
        {
            InitializeComponent();
            this.currentCierreCaja = currentCierreCaja;
        }

        public FormArquearCaja(CajaSesion currentCajaSesion)
        {
            InitializeComponent();
            this.currentCajaSesion = currentCajaSesion;
        }
        #endregion

        #region ============================= Root Load =============================
        private void FormArquearCaja_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            this.cargarMedioPago(); // carga mas los ingresosMenosEgresos()
            this.cargarIngreso();
            this.cargarCajaSesion();
            this.cargarFecha();
            this.cargarMoneda();
            this.cargarDenomincacion();
        } 
        #endregion

        #region ================================ Load ================================
        private async void cargarMedioPago()
        {
            try
            {
                // mediosDePagos = await medioPagoModel.medioPagos();
                medioPagos = await medioPagoModel.medioPagos();
                this.cargarIngresoMenosEgreso();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarIngreso()
        {
            try
            {
                List<Ingreso> ingresos = await ingresoModel.ingresos(ConfigModel.cajaSesion.idCajaSesion); // Listas
                int columnas = 3; // Indicar numero de columnas de la grilla

                this.createLabel(x - 5,this.y, "Monto inicio caja");
                this.y += 25;

                // =========================================== Algoritmo para crear una grilla
                int items = ingresos.Count % columnas;      // Detectar cuandos elementos hay en la ultima fila de la grilla
                int rowComplete = Convert.ToInt32(Math.Floor((decimal)(ingresos.Count / columnas))) * columnas; // detectar cuantos fila esta lleno de  registros
                for (int i = 0; i < ingresos.Count; i++) // for para las filas
                {
                    for (int j = 0; j < columnas; j++) // For para las columnas
                    {
                        if (i > rowComplete) // validacion
                        {
                            if (items == j) break; // salir de este for
                        }
                        this.createElement(x, this.y, ingresos[i].moneda, ingresos[i].monto);
                        i = (columnas - 1 == j ) ? i : i + 1; // indice de registros aumento
                        x += 170; // cordenada x aumentado
                    }
                    this.y += 50; // cordenada y
                    x = 13; // cordenada x regresando al valor original
                }
                // ==============================================================================
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarCajaSesion()
        {
            try
            {
                await configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);
                CajaSesion cajaSesion = ConfigModel.cajaSesion;
                lblFechInicio.Text = cajaSesion.fechaInicio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarFecha()
        {
            try
            {
                FechaSistema date = await fechaModel.fechaSistema();
                lblFechaFin.Text = date.fecha.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarMoneda()
        {
            try
            {
                // mediosDePagos = await medioPagoModel.medioPagos();
                /// List<Moneda> monedas = await monedaModel.monedas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void cargarIngresoMenosEgreso()
        {
            try
            {
                // 
                int medioPagoID = medioPagos.First<MedioPago>().idMedioPago;
                ingresoMenosEgreso = await cierreCajaModel.ingresoMenosEgreso(medioPagoID,ConfigModel.cajaSesion.idCajaSesion);

                this.createLabel(x - 5, this.y, "Cálculo efectivo");
                this.y += 25;

                
                foreach (Moneda moneda in ingresoMenosEgreso)
                {
                    this.createElement(x, y, "Teorico " + moneda.moneda, moneda.total.ToString());
                    this.createElement(x + 170, y, "Real " + moneda.moneda, "0");   // Falta 
                    this.createElement(x + 340, y, "Descuadre " + moneda.moneda, "0");   // Falta 
                    this.y += 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarDenomincacion()
        {
            try
            {
                // mediosDePagos = await medioPagoModel.medioPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        /// <summary>
        /// Crear bunifutextbox con un label indicar las cordenadas, contenido, y el valor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="content"></param>
        /// <param name="value"></param>
        private void createElement(int x, int y, string content, string value)
        {
            Label titlefield = new Label()
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.DimGray,
                Location = new System.Drawing.Point(x + 3, y + 3),
                Margin = new System.Windows.Forms.Padding(2, 0, 2, 0),
                Name = "label1111",
                Size = new System.Drawing.Size(59, 14),
                TabIndex = 8,
                Text = content
            };


            BunifuMetroTextbox textBoxBF1 = new BunifuMetroTextbox()
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
                Location = new System.Drawing.Point(x, y),
                Margin = new System.Windows.Forms.Padding(4),
                Name = "textBox1111",
                Padding = new System.Windows.Forms.Padding(2, 18, 5, 2),
                Size = new System.Drawing.Size(160, 40),
                TabIndex = 9,
                TextAlign = System.Windows.Forms.HorizontalAlignment.Left,
                Text = value
            };
            this.panelAside.Controls.Add(titlefield);
            this.panelAside.Controls.Add(textBoxBF1);
        }

        private void createLabel(int x, int y, string content)
        {
            Label titlefield = new Label()
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(76, 76, 76),
                Location = new System.Drawing.Point(x + 3, y + 3),
                Margin = new System.Windows.Forms.Padding(2, 0, 2, 0),
                Name = "label1111",
                Size = new System.Drawing.Size(59, 14),
                TabIndex = 8,
                Text = content
            };
            this.panelAside.Controls.Add(titlefield);
        }
    }
}
