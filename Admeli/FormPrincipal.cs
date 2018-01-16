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

        private int widthPanelAside { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnToogleAside_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.togglePanelAside("compras");
        }


        #region ===================== Paint =====================
        private void panelMainHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelMainHeader);
        }
        #endregion

        #region ===================== Toogle panel navegations =====================
        private void togglePanelAside(string panelName)
        {
            this.panelAsideMain.Controls.Clear();
            switch (panelName)
            {
                case "compras":
                    this.uCComprasNav = new Admeli.Navegacion.UCComprasNav(this);
                    this.panelAsideMain.Controls.Add(uCComprasNav);
                    this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCComprasNav.Name = "uCComprasNav";
                    this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCComprasNav.TabIndex = 0;
                    break;
                case "ventas":
                    this.uCVentasNav = new Admeli.Navegacion.UCVentasNav(this);
                    this.panelAsideMain.Controls.Add(uCVentasNav);
                    this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCVentasNav.Name = "uCVentasNav";
                    this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCVentasNav.TabIndex = 0;
                    break;
                case "caja":
                    this.uCCajaNav = new Admeli.Navegacion.UCCajaNav(this);
                    this.panelAsideMain.Controls.Add(uCCajaNav);
                    this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                    this.uCCajaNav.Name = "uCCajaNav";
                    this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                    this.uCCajaNav.TabIndex = 0;
                    break;
                case "almacen":
                    this.UCAlmacenNav = new Admeli.Navegacion.UCAlmacenNav(this);
                    this.panelAsideMain.Controls.Add(UCAlmacenNav);
                    this.UCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.UCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                    this.UCAlmacenNav.Name = "UCAlmacenNav";
                    this.UCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                    this.UCAlmacenNav.TabIndex = 0;
                    break;
                case "productos":
                    this.uCProductosNav = new Admeli.Navegacion.UCProductosNav(this);
                    this.panelAsideMain.Controls.Add(uCProductosNav);
                    this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                    this.uCProductosNav.Name = "uCProductosNav";
                    this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                    this.uCProductosNav.TabIndex = 0;
                    break;
                case "configuracion":
                    this.uCConfigNav = new Admeli.Navegacion.UCConfigNav(this);
                    this.panelAsideMain.Controls.Add(uCConfigNav);
                    this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                    this.uCConfigNav.Name = "uCConfigNav";
                    this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                    this.uCConfigNav.TabIndex = 0;
                    break;
                case "herramientas":
                    this.uCHerramientasNav = new Admeli.Navegacion.UCHerramientasNav(this);
                    this.panelAsideMain.Controls.Add(uCHerramientasNav);
                    this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                    this.uCHerramientasNav.Name = "uCHerramientasNav";
                    this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                    this.uCHerramientasNav.TabIndex = 0;
                    break;
                case "home":
                    this.uCHomeNav = new Admeli.Navegacion.UCHomeNav(this);
                    this.panelAsideMain.Controls.Add(uCHomeNav);
                    this.uCHomeNav.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCHomeNav.Location = new System.Drawing.Point(0, 0);
                    this.uCHomeNav.Name = "uCHomeNav";
                    this.uCHomeNav.Size = new System.Drawing.Size(250, 776);
                    this.uCHomeNav.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        private void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            btnColorShorCout();
            switch (panelName)
            {
                case "ventas":
                    this.uCVentas = new Admeli.Ventas.UCVentas();
                    this.panelMain.Controls.Add(uCVentas);
                    this.uCVentas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVentas.Location = new System.Drawing.Point(0, 0);
                    this.uCVentas.Name = "uCVentas";
                    this.uCVentas.Size = new System.Drawing.Size(250, 776);
                    this.uCVentas.TabIndex = 0;
                    break;
                case "compras":
                    this.uCCompras = new Admeli.Compras.UCCompras(this);
                    this.panelMain.Controls.Add(uCCompras);
                    this.uCCompras.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCompras.Location = new System.Drawing.Point(0, 0);
                    this.uCCompras.Name = "uCCompras";
                    this.uCCompras.Size = new System.Drawing.Size(250, 776);
                    this.uCCompras.TabIndex = 0;
                    break;
                case "productos":
                    this.uCListadoProducto = new Admeli.Productos.UCListadoProducto();
                    this.panelMain.Controls.Add(uCListadoProducto);
                    this.uCListadoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCListadoProducto.Location = new System.Drawing.Point(0, 0);
                    this.uCListadoProducto.Name = "uCListadoProducto";
                    this.uCListadoProducto.Size = new System.Drawing.Size(250, 776);
                    this.uCListadoProducto.TabIndex = 0;
                    break;
                case "home":
                    this.uCHome = new Admeli.UCHome(this);
                    this.panelMain.Controls.Add(uCHome);
                    this.uCHome.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCHome.Location = new System.Drawing.Point(0, 0);
                    this.uCHome.Name = "uCHome";
                    this.uCHome.Size = new System.Drawing.Size(250, 776);
                    this.uCHome.TabIndex = 0;
                    break;
                case "iniciar":
                    this.uCIniciar = new Admeli.UCIniciar(this);
                    this.panelMain.Controls.Add(uCIniciar);
                    this.uCIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCIniciar.Location = new System.Drawing.Point(0, 0);
                    this.uCIniciar.Name = "uCIniciar";
                    this.uCIniciar.Size = new System.Drawing.Size(250, 776);
                    this.uCIniciar.TabIndex = 0;
                    break;
                default:
                    break;
            }
        }

        public void toggleHome()
        {
            togglePanelAside("home");
            togglePanelMain("home");
        }
        private void toggleConfiguracionInicial()
        {
            togglePanelMain("iniciar");
            lblSucursal.Text = ConfigModel.sucursal.nombre;
            
        }
        #endregion

        #region ======================== Evnetos ========================
        private void btnVentas_Click(object sender, EventArgs e)
        {
            togglePanelAside("ventas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            togglePanelAside("caja");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            togglePanelAside("almacen");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            togglePanelAside("configuracion");
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            togglePanelAside("herramientas");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            togglePanelAside("productos");
        }

        private void btnVentaShorkout_Click(object sender, EventArgs e)
        {
            togglePanelMain("ventas");
            btnVentaShorkout.BackColor = Color.FromArgb(243, 243, 243); ;
        }

        private void btnProductoShortcut_Click(object sender, EventArgs e)
        {
            togglePanelMain("productos");
            btnProductoShortcut.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnComprasShortcut_Click(object sender, EventArgs e)
        {
            togglePanelMain("compras");
            btnComprasShortcut.BackColor = Color.FromArgb(243, 243, 243);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            toggleHome();
        }

        #endregion

        private void btnColorShorCout()
        {
            btnComprasShortcut.BackColor = Color.White;
            btnVentaShorkout.BackColor = Color.White;
            btnProductoShortcut.BackColor = Color.White;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Load datas
            lblDniPersonal.Text = PersonalModel.personal.numeroDocumento;
            lblUsuarioPersonal.Text = PersonalModel.personal.usuario;
            lblNombrePersonal2.Text = PersonalModel.personal.nombres;

            // Cargando los componentes necesarios para el funcionamiento de todo el sistema
            cargarComponente();

            // Open Panel Default
            
        }

        public void appLoadState(bool state)
        {
            if (state)
            {
                progressBarApp.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                progressBarApp.Style = ProgressBarStyle.Blocks;
            }
        }

        public void appLoadInciComponents()
        {
            panelAside.Visible = true;
            panelMainHeader.Visible = true;
            panelFooter.Visible = true;
        }

        private async void cargarComponente()
        {
            try
            {
                this.appLoadState(true);
                await sucursalModel.sucursalesPersonal(PersonalModel.personal.idPersonal);

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
                    toggleHome();
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
    }
}
