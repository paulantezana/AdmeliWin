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
using Entidad.Configuracion;
using Bunifu.Framework.UI;
using Entidad;

namespace Admeli.Configuracion
{
    public partial class UCTipoCambio : UserControl
    {
        private MonedaModel monedaModel = new MonedaModel();

        private FormPrincipal formPrincipal;
        public bool lisenerKeyEvents { get; set; }
        private List<Moneda> monedas { get; set; }
        private Moneda monedaPorDefecto { get; set; }

        private List<SaveObject> saveObjects { get; set; }

        public UCTipoCambio()
        {
            InitializeComponent();
            lisenerKeyEvents = true; // Active lisener key events
        }

        public UCTipoCambio(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            lisenerKeyEvents = true; // Active lisener key events
        }

        #region ========================== Root Load ==========================
        private void UCTipoCambio_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            cargarMonedas();
            lisenerKeyEvents = true; // Active lisener key events
        }
        #endregion

        #region ======================== Loads ========================
        private async void cargarMonedas()
        {
            try
            {
                loadState(true);
                monedas = await monedaModel.monedas();
                int y = 170;
                foreach (Moneda money in monedas)
                {
                    if (money.porDefecto)
                    {
                        lblMonedaPorDefecto.Text = String.Format("Moneda por defecto: {0}", money.moneda);
                        monedaPorDefecto = money;
                    }
                    else
                    {
                        crearElementosMoneda(money, y);
                        y += 60;
                    }
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
        #endregion

        #region ============================= Crear Elementos =============================
        private void crearElementosMoneda(Moneda moneda, int y)
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
                Name = "lbl" + moneda.idMoneda,
                Text = String.Format("1 {0} es igual a ... {1} ↓", monedaPorDefecto.moneda, moneda.moneda.ToUpper()),
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
                Size = new System.Drawing.Size(350, 50),
                TextAlign = System.Windows.Forms.HorizontalAlignment.Left,

                // al gusto del cliente
                Location = new System.Drawing.Point(18, y),
                Name = moneda.idMoneda.ToString(),
                TabIndex = 91,
                //OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            };
            textMoneda1.OnValueChanged += new EventHandler(this.textMoneda1_OnValueChanged);


            // Agreganto los dos elementos
            this.panelContainer.Controls.Add(lblMonedaLabel);
            this.panelContainer.Controls.Add(textMoneda1);

        }

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
        #endregion

        #region ================================ SAVE AND UPDATE ================================
        private async void guardar()
        {
            try
            {
                foreach (SaveObject item in saveObjects)
                {
                    Response response = await monedaModel.guardar(item);
                }
                MessageBox.Show("Se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearObjeto()
        {
            foreach (Moneda moneda in monedas)
            {
                SaveObject save = new SaveObject();
                save.cambioCompra = moneda.monto;
                save.cambioVenta = moneda.monto;
                save.estado = moneda.estado;
                save.idMoneda = monedaPorDefecto.idMoneda;
                save.idMonedaCambio = moneda.idMoneda;
                save.idPersonal = PersonalModel.personal.idPersonal;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            crearObjeto();
            guardar();
        }

        struct SaveObject
        {
            public double cambioCompra { get; set; }
            public double cambioVenta { get; set; }
            public int estado { get; set; }
            public int idMoneda { get; set; }
            public int idMonedaCambio { get; set; }
            public int idPersonal { get; set; }
        }

        #endregion

        private void loadState(bool state)
        {
            formPrincipal.appLoadState(state);
        }
    }
}
