using Admeli.NavDarck;
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
        private UCReporteNav uCReporteNav;
        private UCProductosNav uCProductosNav;
        private UCHome uCHome;
        private UCIniciar uCIniciar;
        private FormLogin formLogin;

        private SucursalModel sucursalModel = new SucursalModel();
        private ConfigModel configModel = new ConfigModel();

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

        #region ========================= ASIDE LEFT MENU =========================
        private void btnColor()
        {
            btnCompra.Textcolor = Color.FromArgb(139, 138, 141);
            btnHerramienta.Textcolor = Color.FromArgb(139, 138, 141);
            btnVenta.Textcolor = Color.FromArgb(139, 138, 141);
            btnProducto.Textcolor = Color.FromArgb(139, 138, 141);
            btnCaja.Textcolor = Color.FromArgb(139, 138, 141);
            btnAlmacen.Textcolor = Color.FromArgb(139, 138, 141);
            btnReporte.Textcolor = Color.FromArgb(139, 138, 141);
            btnConfiguracion.Textcolor = Color.FromArgb(139, 138, 141);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnReporte.Location;
            btnReporte.Textcolor = Color.White;
            togglePanelMain("reportes");
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnHerramienta.Location;
            btnHerramienta.Textcolor = Color.White;
            togglePanelMain("herramientas");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnProducto.Location;
            btnProducto.Textcolor = Color.White;
            togglePanelMain("productos");
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnAlmacen.Location;
            btnAlmacen.Textcolor = Color.White;
            togglePanelMain("almacen");
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCaja.Location;
            btnCaja.Textcolor = Color.White;
            togglePanelMain("caja");
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnVenta.Location;
            btnVenta.Textcolor = Color.White;
            togglePanelMain("ventas");
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnCompra.Location;
            btnCompra.Textcolor = Color.White;
            togglePanelMain("compras");
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnColor();
            borderLeftActive.Location = btnConfiguracion.Location;
            btnConfiguracion.Textcolor = Color.White;
            togglePanelMain("configuracion");
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
                        this.panelMain.Controls.Add(uCProductosNav);
                    }

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
                panelAsideContainer.Size = new Size(200, 700);
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

        #region ================================ LOADS ================================
        private void mostrarModuloPorDefecto()
        {
            if (ConfigModel.puntosDeVenta.Count > 1 || ConfigModel.alamacenes.Count > 1)
            {
                togglePanelMain("iniciar");
                ConfigModel.currentIdAlmacen = ConfigModel.alamacenes[0].idAlmacen;
                ConfigModel.currentPuntoVenta = ConfigModel.puntosDeVenta[1].idAsignarPuntoVenta;
            }
            else
            {
                togglePanelMain("home");
            }
        }
        #endregion

        #region =============================== SATATES ===============================
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
        #endregion

        #region ================================= ROOT LOAD =================================
        private void FormHomeDarck_Shown(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private void reLoad()
        {
            mostrarModuloPorDefecto();
        } 
        #endregion
    }
}
