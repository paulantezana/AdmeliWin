using Admeli.Componentes;
using Admeli.Compras;
using Admeli.Navegacion;
using Admeli.Productos;
using Admeli.Ventas;
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

namespace Admeli
{
    public partial class FormPrincipal : Form
    {
        private UCComprasNav uCComprasNav;
        private UCVentasNav uCVentasNav;
        private UCCajaNav uCCajaNav;
        private UCAlmacenNav UCAlmacenNav;
        private UCConfigNav uCConfigNav;
        private UCHerramientasNav uCHerramientasNav;
        private UCProductosNav uCProductosNav;
        private UCHomeNav uCHomeNav;

        private UCVentas uCVentas;
        private UCListadoProducto uCListadoProducto;
        private UCCompras uCCompras;

        private UCHome uCHome;
        private UCIniciar uCIniciar;

        private SucursalModel sucursalModel = new SucursalModel();
        private ConfigModel configModel = new ConfigModel();
        private FormLogin formLogin;

        private int widthPanelAside { get; set; }
        private bool notCloseApp { get; set; }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!notCloseApp)
            {
                Application.Exit();
            }
        }

        #region ========================= Constructors =========================
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }
        #endregion

        #region ===================== Paint =====================
        private void panelAside_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelAside);
        }
        #endregion

        #region ===================== Toogle panel navegations =====================
        internal void togglePanelAside(string panelName)
        {
            this.panelAsideMain.Controls.Clear();
            this.btnMainMenu();
            switch (panelName)
            {
                case "compras":
                    if (this.uCComprasNav == null)
                    {
                        this.uCComprasNav = new Admeli.Navegacion.UCComprasNav(this);
                        this.panelAsideMain.Controls.Add(uCComprasNav);
                        this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCComprasNav.Name = "uCComprasNav";
                        this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCComprasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCComprasNav);
                    }
                    break;
                case "ventas":
                    if (this.uCVentasNav == null)
                    {
                        this.uCVentasNav = new Admeli.Navegacion.UCVentasNav(this);
                        this.panelAsideMain.Controls.Add(uCVentasNav);
                        this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCVentasNav.Name = "uCVentasNav";
                        this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCVentasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCVentasNav);
                    }

                    break;
                case "caja":
                    if (this.uCCajaNav == null)
                    {
                        this.uCCajaNav = new Admeli.Navegacion.UCCajaNav(this);
                        this.panelAsideMain.Controls.Add(uCCajaNav);
                        this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                        this.uCCajaNav.Name = "uCCajaNav";
                        this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                        this.uCCajaNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCCajaNav);
                    }
                    break;
                case "almacen":
                    if (this.UCAlmacenNav == null)
                    {
                        this.UCAlmacenNav = new Admeli.Navegacion.UCAlmacenNav(this);
                        this.panelAsideMain.Controls.Add(UCAlmacenNav);
                        this.UCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.UCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                        this.UCAlmacenNav.Name = "UCAlmacenNav";
                        this.UCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                        this.UCAlmacenNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(UCAlmacenNav);
                    }
                    break;
                case "productos":
                    if (this.uCProductosNav == null)
                    {
                        this.uCProductosNav = new Admeli.Navegacion.UCProductosNav(this);
                        this.panelAsideMain.Controls.Add(uCProductosNav);
                        this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                        this.uCProductosNav.Name = "uCProductosNav";
                        this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                        this.uCProductosNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCProductosNav);
                    }

                    break;
                case "configuracion":
                    if (this.uCConfigNav == null)
                    {
                        this.uCConfigNav = new Admeli.Navegacion.UCConfigNav(this);
                        this.panelAsideMain.Controls.Add(uCConfigNav);
                        this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                        this.uCConfigNav.Name = "uCConfigNav";
                        this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                        this.uCConfigNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCConfigNav);
                    }
                    
                    break;
                case "herramientas":
                    if (this.uCHerramientasNav == null)
                    {
                        this.uCHerramientasNav = new Admeli.Navegacion.UCHerramientasNav(this);
                        this.panelAsideMain.Controls.Add(uCHerramientasNav);
                        this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCHerramientasNav.Name = "uCHerramientasNav";
                        this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCHerramientasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCHerramientasNav);
                    }
                    break;
                case "home":
                    if (this.uCHomeNav == null)
                    {
                        this.uCHomeNav = new Admeli.Navegacion.UCHomeNav(this);
                        this.panelAsideMain.Controls.Add(uCHomeNav);
                        this.uCHomeNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHomeNav.Location = new System.Drawing.Point(0, 0);
                        this.uCHomeNav.Name = "uCHomeNav";
                        this.uCHomeNav.Size = new System.Drawing.Size(250, 776);
                        this.uCHomeNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCHomeNav);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnMainMenu()
        {
            btnCompras.BackColor = Color.FromArgb(1, 102, 179);
            btnVentas.BackColor = Color.FromArgb(1, 102, 179);
            btnConfiguracion.BackColor = Color.FromArgb(1, 102, 179);
            btnHerramientas.BackColor = Color.FromArgb(1, 102, 179);
            btnCaja.BackColor = Color.FromArgb(1, 102, 179);
            btnAlmacen.BackColor = Color.FromArgb(1, 102, 179);
            btnProducto.BackColor = Color.FromArgb(1, 102, 179);

            btnCompras.ForeColor = Color.White;
            btnVentas.ForeColor = Color.White;
            btnConfiguracion.ForeColor = Color.White;
            btnHerramientas.ForeColor = Color.White;
            btnCaja.ForeColor = Color.White;
            btnAlmacen.ForeColor = Color.White;
            btnProducto.ForeColor = Color.White;
        }

        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            switch (panelName)
            {
                case "home":
                    if (this.uCHome == null)
                    {
                        this.uCHome = new Admeli.UCHome(this);
                        this.panelMain.Controls.Add(uCHome);
                        this.uCHome.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHome.Location = new System.Drawing.Point(0, 0);
                        this.uCHome.Name = "uCHome";
                        this.uCHome.Size = new System.Drawing.Size(250, 776);
                        this.uCHome.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCHome);
                    }

                    break;
                case "iniciar":
                    if (this.uCIniciar == null)
                    {
                        this.uCIniciar = new Admeli.UCIniciar(this);
                        this.panelMain.Controls.Add(uCIniciar);
                        this.uCIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCIniciar.Location = new System.Drawing.Point(0, 0);
                        this.uCIniciar.Name = "uCIniciar";
                        this.uCIniciar.Size = new System.Drawing.Size(250, 776);
                        this.uCIniciar.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCIniciar);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region ======================== Evnetos ========================
        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.togglePanelAside("compras");
            btnCompras.BackColor = Color.White;
            btnCompras.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            togglePanelAside("ventas");
            btnVentas.BackColor = Color.White;
            btnVentas.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            togglePanelAside("caja");
            btnCaja.BackColor = Color.White;
            btnCaja.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            togglePanelAside("almacen");
            btnAlmacen.BackColor = Color.White;
            btnAlmacen.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            togglePanelAside("configuracion");
            btnConfiguracion.BackColor = Color.White;
            btnConfiguracion.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            togglePanelAside("herramientas");
            btnHerramientas.BackColor = Color.White;
            btnHerramientas.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            togglePanelAside("productos");
            btnProducto.BackColor = Color.White;
            btnProducto.ForeColor = Color.FromArgb(1, 102, 179);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            togglePanelAside("home");
        }
        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        internal void reLoad()
        {
            // Cargando los componentes necesarios para el funcionamiento de todo el sistema
            cargarComponente();
        }

        public void appLoadState(bool state)
        {
            if (state)
            {
                Cursor.Current = Cursors.WaitCursor;
               // progressBarApp.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                Cursor.Current = Cursors.Default;
               // progressBarApp.Style = ProgressBarStyle.Blocks;
            }
        }

        #region ================================ Mostrar Interfaces ================================
        public void appLoadInciComponents()
        {
            panelAside.Visible = true;
            togglePanelAside("home");
            togglePanelMain("home");
        }

        private void toggleConfiguracionInicial()
        {
            togglePanelMain("iniciar");
        } 
        #endregion

        private async void cargarComponente()
        {
            try
            {
                this.appLoadState(true);
                //await sucursalModel.sucursalesPersonal(PersonalModel.personal.idPersonal);

                // DATOS GENERALES
                // SUCURSALES PERSONA
                // ASIGNACION PERSONAL
                // CONFIGURACION GENERAL
                // MONEDAS
                // TIPOS DE CAMBIOS

                // TIPOS DE DOCUMENTO
                // ALMACENES
                // ASIGNACION PERSONAL PUNTO DE VENTA
                // CAJA SECION
                await configModel.loadDatosGenerales();
                await configModel.loadSucursalPersonal(PersonalModel.personal.idPersonal);
                await configModel.loadAsignacionPersonales(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                await configModel.loadConfiGeneral();
                configModel.loadMonedas();
                configModel.loadTipoCambioMonedas();

                configModel.loadTipoDocumento();
                await configModel.loadAlmacenes(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                await configModel.loadPuntoDeVenta(PersonalModel.personal.idPersonal, ConfigModel.sucursal.idSucursal);
                configModel.loadCajaSesion(ConfigModel.asignacionPersonal.idAsignarCaja);

                // Eligiendo el puntode venta y almacen
                if (ConfigModel.puntosDeVenta.Count > 1 || ConfigModel.alamacenes.Count > 1)
                {
                    toggleConfiguracionInicial();
                    ConfigModel.currentIdAlmacen = ConfigModel.alamacenes[0].idAlmacen;
                    ConfigModel.currentPuntoVenta = ConfigModel.puntosDeVenta[1].idAsignarPuntoVenta;
                }
                else
                {
                    appLoadInciComponents();

                    // Mostrando el menu por defecto
                    togglePanelAside("Home");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Personal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.appLoadState(false);
            }
        }

        private void btnToggleAsideMenu_Click(object sender, EventArgs e)
        {
            if (panelAside.Size.Width < 1)
            {
                panelAside.Size = new Size(250, 881);
            }
            else
            {
                panelAside.Size = new Size(0, 0);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // mostrar nuevamente el login del usuario
            this.formLogin.Show();

            // limpiar loas campos de login usuario
            this.formLogin.textUsuario.Text = "";
            this.formLogin.textPassword.Text = "";
            this.formLogin.textUsuario.Focus();

            // Cerrando el formulario actual
            this.notCloseApp = true;
            this.Close();
        }

    }
}
