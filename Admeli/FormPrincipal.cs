using Admeli.Componentes;
using Admeli.Compras;
using Admeli.NavDarck;
using Admeli.Navigation;
using Admeli.Productos;
using Admeli.Ventas;
using Entidad.Configuracion;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Admeli
{
    public partial class FormPrincipal : Form
    {
        // User Control preparado para el aside menu
        private UCComprasN uCComprasN;
        private UCVentasN uCVentasN;
        private UCCajaN uCCajaN;
        private UCAlmacenN UCAlmacenN;
        private UCHerramientasN uCHerramientasN;
        private UCReporteN uCReporteN;
        private UCProductosN uCProductosN;

        // User control preparado para main = contenedor principal
        private UCComprasNav uCComprasNav;
        private UCVentasNav uCVentasNav;
        private UCCajaNav uCCajaNav;
        private UCAlmacenNav UCAlmacenNav;
        private UCHerramientasNav uCHerramientasNav;
        private UCReporteNav uCReporteNav;
        private UCProductosNav uCProductosNav;
        private UCConfigNav uCConfigNav;
        private UCHome uCHome;

        // Formularios
        private FormLogin formLogin;

        // Accessos directos
        private UCVentas uCVentas;
        private UCListadoProducto uCListadoProducto;
        private UCCompras uCCompras;
        private DataSunat d;
        // Modelos
        private SucursalModel sucursalModel = new SucursalModel();
        private ConfigModel configModel = new ConfigModel();
        private SunatModel sunatModel = new SunatModel();
        // Metodos
        private bool notCloseApp { get; set; }

        #region =============================== Constructor ===============================
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

        #region =============================== PAINT ===============================
        private void FormPrincipal_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
            drawShape.leftLine(panelMenuRight);
        }
        #endregion

        #region ========================= ASIDE LEFT MENU =========================
        private void btnColor()
        {
            /// Reset Color buttons
            btnCompra.ForeColor = Color.FromArgb(139, 138, 141);
            btnHerramienta.ForeColor = Color.FromArgb(139, 138, 141);
            btnVenta.ForeColor = Color.FromArgb(139, 138, 141);
            btnProducto.ForeColor = Color.FromArgb(139, 138, 141);
            btnCaja.ForeColor = Color.FromArgb(139, 138, 141);
            btnAlmacen.ForeColor = Color.FromArgb(139, 138, 141);
            btnReporte.ForeColor = Color.FromArgb(139, 138, 141);
            btnConfiguracion.ForeColor = Color.FromArgb(139, 138, 141);

            btnCompra.BackColor = Color.FromArgb(52, 49, 58);
            btnHerramienta.BackColor = Color.FromArgb(52, 49, 58);
            btnVenta.BackColor = Color.FromArgb(52, 49, 58);
            btnProducto.BackColor = Color.FromArgb(52, 49, 58);
            btnCaja.BackColor = Color.FromArgb(52, 49, 58);
            btnAlmacen.BackColor = Color.FromArgb(52, 49, 58);
            btnReporte.BackColor = Color.FromArgb(52, 49, 58);
            btnConfiguracion.BackColor = Color.FromArgb(52, 49, 58);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            togglePanelMain("home"); /// Navegar
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnReporte.Location; /// Decoracion
            btnReporte.ForeColor = Color.White; /// Color
            btnReporte.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("reportes"); /// Navegar
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnHerramienta.Location; /// Decoracion
            btnHerramienta.ForeColor = Color.White; /// Color
            btnHerramienta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("herramientas"); /// Navegar
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnProducto.Location; /// Decoracion
            btnProducto.ForeColor = Color.White; /// Color
            btnProducto.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("productos"); /// Navegar
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnAlmacen.Location; /// Decoracion
            btnAlmacen.ForeColor = Color.White; /// Color
            btnAlmacen.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("almacen"); /// Navegar
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnCaja.Location; /// Decoracion
            btnCaja.ForeColor = Color.White; /// Color
            btnCaja.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("caja"); /// Navegar
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnVenta.Location; /// Decoracion
            btnVenta.ForeColor = Color.White; /// Color
            btnVenta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("ventas"); /// Navegar
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnCompra.Location; /// Decoracion
            btnCompra.ForeColor = Color.White; /// Color
            btnCompra.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("compras"); /// Navegar
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnColor(); /// Color reset
            borderLeftActive.Location = btnConfiguracion.Location; /// Decoracion
            btnConfiguracion.ForeColor = Color.White; /// Color
            btnConfiguracion.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelMain("configuracion"); /// Navegar
        }
        #endregion

        #region ===================== TOGGLE PANEL ASIDE LEFT =====================
        internal void togglePanelMain(string panelName)
        {
            this.panelMain.Controls.Clear();
            switch (panelName)
            {
                case "compras":
                    if (this.uCComprasNav == null)
                    {
                        this.uCComprasNav = new UCComprasNav(this);
                        this.panelMain.Controls.Add(uCComprasNav);
                        this.uCComprasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCComprasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCComprasNav.Name = "uCComprasNav";
                        this.uCComprasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCComprasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCComprasNav);
                    }
                    this.lblTitlePage.Text = "Compras - "; /// Titulo en el encabezado
                    break;
                case "ventas":
                    if (this.uCVentasNav == null)
                    {
                        this.uCVentasNav = new UCVentasNav(this);
                        this.panelMain.Controls.Add(uCVentasNav);
                        this.uCVentasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCVentasNav.Name = "uCVentasNav";
                        this.uCVentasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCVentasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCVentasNav);
                    }
                    this.lblTitlePage.Text = "Ventas - "; /// Titulo en el encabezado
                    break;
                case "caja":
                    if (this.uCCajaNav == null)
                    {
                        this.uCCajaNav = new UCCajaNav(this);
                        this.panelMain.Controls.Add(uCCajaNav);
                        this.uCCajaNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajaNav.Location = new System.Drawing.Point(0, 0);
                        this.uCCajaNav.Name = "uCCajaNav";
                        this.uCCajaNav.Size = new System.Drawing.Size(250, 776);
                        this.uCCajaNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCCajaNav);
                    }
                    this.lblTitlePage.Text = "Caja - "; /// Titulo en el encabezado
                    break;
                case "almacen":
                    if (this.UCAlmacenNav == null)
                    {
                        this.UCAlmacenNav = new UCAlmacenNav(this);
                        this.panelMain.Controls.Add(UCAlmacenNav);
                        this.UCAlmacenNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.UCAlmacenNav.Location = new System.Drawing.Point(0, 0);
                        this.UCAlmacenNav.Name = "UCAlmacenNav";
                        this.UCAlmacenNav.Size = new System.Drawing.Size(250, 776);
                        this.UCAlmacenNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(UCAlmacenNav);
                    }
                    this.lblTitlePage.Text = "Almacen - "; /// Titulo en el encabezado
                    break;
                case "productos":
                    if (this.uCProductosNav == null)
                    {
                        this.uCProductosNav = new UCProductosNav(this);
                        this.panelMain.Controls.Add(uCProductosNav);
                        this.uCProductosNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProductosNav.Location = new System.Drawing.Point(0, 0);
                        this.uCProductosNav.Name = "uCProductosNav";
                        this.uCProductosNav.Size = new System.Drawing.Size(250, 776);
                        this.uCProductosNav.TabIndex = 0;
                    }
                    else
                    {

                        //cargar el opcion previa de listado de productos
                        int lugar = uCProductosNav.lugar;
                        switch (lugar)
                        {

                            case 1:
                                this.panelMain.Controls.Add(uCProductosNav.uCListadoProducto);
                                break;
                            case 2:
                               this.panelMain.Controls.Add(uCProductosNav.uCMarcas);
                                break;
                            case 3:
                                this.panelMain.Controls.Add(uCProductosNav.uCUnidadesMedida);
                                break;
                            case 4:
                                this.Controls.Add(uCProductosNav.uCCategorias);
                                break;
                            default:
                                break;

                        }

                        this.panelMain.Controls.Add(uCProductosNav);
                    }
                    this.lblTitlePage.Text = "Productos - "; /// Titulo en el encabezado
                    break;
                case "configuracion":
                    if (this.uCConfigNav == null)
                    {
                        this.uCConfigNav = new UCConfigNav(this);
                        this.panelMain.Controls.Add(uCConfigNav);
                        this.uCConfigNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCConfigNav.Location = new System.Drawing.Point(0, 0);
                        this.uCConfigNav.Name = "uCConfigNav";
                        this.uCConfigNav.Size = new System.Drawing.Size(250, 776);
                        this.uCConfigNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCConfigNav);
                    }
                    this.lblTitlePage.Text = "Configuracion - "; /// Titulo en el encabezado
                    break;
                case "herramientas":
                    if (this.uCHerramientasNav == null)
                    {
                        this.uCHerramientasNav = new UCHerramientasNav(this);
                        this.panelMain.Controls.Add(uCHerramientasNav);
                        this.uCHerramientasNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHerramientasNav.Location = new System.Drawing.Point(0, 0);
                        this.uCHerramientasNav.Name = "uCHerramientasNav";
                        this.uCHerramientasNav.Size = new System.Drawing.Size(250, 776);
                        this.uCHerramientasNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCHerramientasNav);
                    }
                    this.lblTitlePage.Text = "Herramientas - "; /// Titulo en el encabezado
                    break;
                case "reportes":
                    if (this.uCReporteNav == null)
                    {
                        this.uCReporteNav = new UCReporteNav(this);
                        this.panelMain.Controls.Add(uCReporteNav);
                        this.uCReporteNav.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCReporteNav.Location = new System.Drawing.Point(0, 0);
                        this.uCReporteNav.Name = "uCReporteNav";
                        this.uCReporteNav.Size = new System.Drawing.Size(250, 776);
                        this.uCReporteNav.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCReporteNav);
                    }
                    this.lblTitlePage.Text = "Reportes - "; /// Titulo en el encabezado
                    break;
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
                    this.lblTitlePage.Text = "Home - "; /// Titulo en el encabezado
                    break;
                case "compras2":
                    if (this.uCCompras == null)
                    {
                        this.uCCompras = new UCCompras(this);
                        this.panelMain.Controls.Add(uCCompras);
                        this.uCCompras.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCompras.Location = new System.Drawing.Point(0, 0);
                        this.uCCompras.Name = "uCCompras";
                        this.uCCompras.Size = new System.Drawing.Size(250, 776);
                        this.uCCompras.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCCompras);
                    }
                    this.lblTitlePage.Text = "Compras - Compra"; /// Titulo en el encabezado
                    break;
                case "ventas2":
                    if (this.uCVentas == null)
                    {
                        this.uCVentas = new UCVentas(this);
                        this.panelMain.Controls.Add(uCVentas);
                        this.uCVentas.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentas.Location = new System.Drawing.Point(0, 0);
                        this.uCVentas.Name = "uCVentas";
                        this.uCVentas.Size = new System.Drawing.Size(250, 776);
                        this.uCVentas.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCVentas);
                    }
                    this.lblTitlePage.Text = "Ventas - Venta"; /// Titulo en el encabezado
                    break;
                case "productos2":
                    if (this.uCListadoProducto == null)
                    {
                        this.uCListadoProducto = new UCListadoProducto(this);
                        this.panelMain.Controls.Add(uCListadoProducto);
                        this.uCListadoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCListadoProducto.Location = new System.Drawing.Point(0, 0);
                        this.uCListadoProducto.Name = "uCListadoProducto";
                        this.uCListadoProducto.Size = new System.Drawing.Size(250, 776);
                        this.uCListadoProducto.TabIndex = 0;
                    }
                    else
                    {
                        this.panelMain.Controls.Add(uCListadoProducto);
                    }
                    this.lblTitlePage.Text = "Productos - Listar"; /// Titulo en el encabezado
                    break;
                default:
                    break;
            }
        }
        internal void togglePanelAsideMain(string panelName)
        {
            this.panelAsideMain.Controls.Clear();
            switch (panelName)
            {
                case "compras":
                    if (this.uCComprasN == null)
                    {
                        this.uCComprasN = new UCComprasN(this);
                        this.panelAsideMain.Controls.Add(uCComprasN);
                        this.uCComprasN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCComprasN.Location = new System.Drawing.Point(0, 0);
                        this.uCComprasN.Name = "uCComprasN";
                        this.uCComprasN.Size = new System.Drawing.Size(250, 776);
                        this.uCComprasN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCComprasN);
                    }
                    this.lblTitlePage.Text = "Compras - "; /// Titulo en el encabezado
                    break;
                case "ventas":
                    if (this.uCVentasN == null)
                    {
                        this.uCVentasN = new UCVentasN(this);
                        this.panelAsideMain.Controls.Add(uCVentasN);
                        this.uCVentasN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCVentasN.Location = new System.Drawing.Point(0, 0);
                        this.uCVentasN.Name = "uCVentasN";
                        this.uCVentasN.Size = new System.Drawing.Size(250, 776);
                        this.uCVentasN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCVentasN);
                    }
                    this.lblTitlePage.Text = "Ventas - "; /// Titulo en el encabezado
                    break;
                case "caja":
                    if (this.uCCajaN == null)
                    {
                        this.uCCajaN = new UCCajaN(this);
                        this.panelAsideMain.Controls.Add(uCCajaN);
                        this.uCCajaN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajaN.Location = new System.Drawing.Point(0, 0);
                        this.uCCajaN.Name = "uCCajaN";
                        this.uCCajaN.Size = new System.Drawing.Size(250, 776);
                        this.uCCajaN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCCajaN);
                    }
                    this.lblTitlePage.Text = "Caja - "; /// Titulo en el encabezado
                    break;
                case "almacen":
                    if (this.UCAlmacenN == null)
                    {
                        this.UCAlmacenN = new UCAlmacenN(this);
                        this.panelAsideMain.Controls.Add(UCAlmacenN);
                        this.UCAlmacenN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.UCAlmacenN.Location = new System.Drawing.Point(0, 0);
                        this.UCAlmacenN.Name = "UCAlmacenN";
                        this.UCAlmacenN.Size = new System.Drawing.Size(250, 776);
                        this.UCAlmacenN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(UCAlmacenN);
                    }
                    this.lblTitlePage.Text = "Almacen - "; /// Titulo en el encabezado
                    break;
                case "productos":
                    if (this.uCProductosN == null)
                    {
                        this.uCProductosN = new UCProductosN(this);
                        this.panelAsideMain.Controls.Add(uCProductosN);
                        this.uCProductosN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCProductosN.Location = new System.Drawing.Point(0, 0);
                        this.uCProductosN.Name = "uCProductosN";
                        this.uCProductosN.Size = new System.Drawing.Size(250, 776);
                        this.uCProductosN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCProductosN);
                    }
                    this.lblTitlePage.Text = "Productos - "; /// Titulo en el encabezado
                    break;
                case "configuracion":
                    this.lblTitlePage.Text = "Configuracion - "; /// Titulo en el encabezado
                    break;
                case "herramientas":
                    if (this.uCHerramientasN == null)
                    {
                        this.uCHerramientasN = new UCHerramientasN(this);
                        this.panelAsideMain.Controls.Add(uCHerramientasN);
                        this.uCHerramientasN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCHerramientasN.Location = new System.Drawing.Point(0, 0);
                        this.uCHerramientasN.Name = "uCHerramientasN";
                        this.uCHerramientasN.Size = new System.Drawing.Size(250, 776);
                        this.uCHerramientasN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCHerramientasN);
                    }
                    this.lblTitlePage.Text = "Herramientas - "; /// Titulo en el encabezado
                    break;
                case "reportes":
                    if (this.uCReporteN == null)
                    {
                        this.uCReporteN = new UCReporteN(this);
                        this.panelAsideMain.Controls.Add(uCReporteN);
                        this.uCReporteN.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCReporteN.Location = new System.Drawing.Point(0, 0);
                        this.uCReporteN.Name = "uCReporteN";
                        this.uCReporteN.Size = new System.Drawing.Size(250, 776);
                        this.uCReporteN.TabIndex = 0;
                    }
                    else
                    {
                        this.panelAsideMain.Controls.Add(uCReporteN);
                    }
                    this.lblTitlePage.Text = "Reportes - "; /// Titulo en el encabezado
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region ========================= MENU =========================
        private void btnToggleMenuRigth_Click(object sender, EventArgs e)
        {
            if (panelMenuRight.Size.Width > 1)
            {
                panelMenuRight.Size = new Size(0, 700);
            }
            else
            {
                panelMenuRight.Size = new Size(200, 700);
            }
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (panelAsideContainer.Size.Width > 60)
            {
                panelAsideContainer.Size = new Size(50, 700);
            }
            else
            {
                panelAsideContainer.Size = new Size(250, 700);
            }
        }
        #endregion

        #region ========================= EVENTS =========================
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region ========================= CLOSE =========================
        private void FormHomeDarck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!notCloseApp)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
        #endregion

        #region =============================== SATATES ===============================
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
        #endregion

        #region ================================= ROOT LOAD =================================
        private void FormHomeDarck_Shown(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            /// mostrando el panel por defecto
            togglePanelMain("home");
            lblUserName.Text = PersonalModel.personal.usuario.ToUpper();
            lblDocumento.Text = String.Format("{0}", PersonalModel.personal.numeroDocumento);
            /// Foto Del Usuario



            /// Mostrando el menu por defecto
            btnColor(); /// Color reset
            borderLeftActive.Location = btnVenta.Location; /// Decoracion
            btnVenta.ForeColor = Color.White; /// Color
            btnVenta.BackColor = Color.FromArgb(36, 35, 40); /// Color
            togglePanelAsideMain("ventas"); /// Navegar

            cargarDatosAsideRight();
        }

        private void cargarDatosAsideRight()
        {
            lblName.Text = PersonalModel.personal.nombres;
            lblLastName.Text = PersonalModel.personal.apellidos;
            lblDNI.Text = PersonalModel.personal.numeroDocumento;
            lblUsuario.Text = PersonalModel.personal.nombres;
            lblDocumentType.Text = PersonalModel.personal.tipoDocumento;

            lblSucursal.Text = ConfigModel.sucursal.nombre;

            // datos dinamicos
            int y = lblTipoCambio.Location.Y + 50;
            List<TipoCambioMoneda> tipoCambios = ConfigModel.tipoCambioMonedas;
            foreach (TipoCambioMoneda cambio in tipoCambios)
            {
                createElements(y, cambio);
                y += 22;
            }
        }
        #endregion

        #region ================================= MENU ATAJOS =================================
        private void btnCompra2_Click(object sender, EventArgs e)
        {
            togglePanelMain("compras2");
        }
        private void btnVentaTocuh_Click(object sender, EventArgs e)
        {
            FormVentaTouch ventaTouch = new FormVentaTouch();
            ventaTouch.ShowDialog();
        }

        private void btnVenta2_Click(object sender, EventArgs e)
        {
            togglePanelMain("ventas2");
        }

        private void btnProductos2_Click(object sender, EventArgs e)
        {
            togglePanelMain("productos2");
        }
        #endregion

        #region ==================== Create Dynamic Elements ====================
        private void createElements(int y, TipoCambioMoneda param)
        {
            /// 
            /// lblEfectivoName
            /// 
            Label lblEfectivoName = new System.Windows.Forms.Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.FromArgb(84, 110, 122),
                Location = new System.Drawing.Point(13, y),
                Name = "lblEfectivoName",
                Size = new System.Drawing.Size(44, 16),
                TabIndex = 10,
                Text = param.moneda,
            };

            /// 
            /// lblEfectivoValue
            /// 
            Label lblEfectivoValue = new System.Windows.Forms.Label()
            {
                AutoSize = true,
                ForeColor = System.Drawing.SystemColors.ControlDarkDark,
                Location = new System.Drawing.Point(150, y),
                Name = "lblEfectivoValue",
                Size = new System.Drawing.Size(65, 13),
                TabIndex = 11,
                Text = String.Format("{0:0.00}", param.cambio)
            };

            /// 
            /// Add Controls
            /// 
            panelMenuRight.Controls.Add(lblEfectivoName);
            panelMenuRight.Controls.Add(lblEfectivoValue);
        }

        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
