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
using Admeli.Configuracion;

namespace Admeli.Navegacion
{
    public partial class UCConfigNav : UserControl
    {

        private UCAlmacenes uCAlmacenes;
        private UCAsignarCorrelativo uCAsignarCorrelativo;
        private UCCajasInicializadas uCCajasInicializadas;
        private UCDatosEmpresa uCDatosEmpresa;
        private UCDenominaciones uCDenominaciones;
        private UCDisenoPersonalizacion uCDisenoPersonalizacion;
        private UCDocumentoIdentificacion uCDocumentoIdentificacion;
        private UCGrupoClientes uCGrupoClientes;
        private UCImpuestoDocumento uCImpuestoDocumento;
        private UCImpuestos uCImpuestos;
        private UCListadoDocumentos uCListadoDocumentos;
        private UCListadoMoneda uCListadoMoneda;
        private UCPersonal uCPersonal;
        private UCSucursales uCSucursales;
        private UCPuntoDeVenta uCPuntoDeVenta;
        private UCTipoCambio uCTipoCambio;

        private Color colorActive = Color.FromArgb(189, 226, 255);  // Color que se muestra del ultimo voton clikeado
        private FormPrincipal formPrincipal;

        public UCConfigNav()
        {
            InitializeComponent();
        }

        public UCConfigNav(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader,220, 220, 220);
        }

        private void panelDivide_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelDivide1);
        }

        private void panelDivide2_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelDivide2);
        }


        private void togglePanelMain(string panelName)
        {
            limpiarControles();
            btnColor();
            switch (panelName)
            {
                case "alamacenes":
                    if (uCAlmacenes == null)
                    {
                        this.uCAlmacenes = new Admeli.Configuracion.UCAlmacenes(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCAlmacenes);
                        this.uCAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAlmacenes.Location = new System.Drawing.Point(0, 0);
                        this.uCAlmacenes.Name = "uCAlmacenes";
                        this.uCAlmacenes.Size = new System.Drawing.Size(250, 776);
                        this.uCAlmacenes.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCAlmacenes);
                        this.uCAlmacenes.reLoad();
                    }
                    break;
                case "asignarCorrelativo":
                    if (uCAsignarCorrelativo == null)
                    {
                        this.uCAsignarCorrelativo = new Admeli.Configuracion.UCAsignarCorrelativo(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarCorrelativo);
                        this.uCAsignarCorrelativo.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCAsignarCorrelativo.Location = new System.Drawing.Point(0, 0);
                        this.uCAsignarCorrelativo.Name = "uCAsignarCorrelativo";
                        this.uCAsignarCorrelativo.Size = new System.Drawing.Size(250, 776);
                        this.uCAsignarCorrelativo.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCAsignarCorrelativo);
                        this.uCAsignarCorrelativo.reLoad();
                    }
                    break;
                case "cajasInicializadas":
                    if (uCCajasInicializadas == null)
                    {
                        this.uCCajasInicializadas = new Admeli.Configuracion.UCCajasInicializadas(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCCajasInicializadas);
                        this.uCCajasInicializadas.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCCajasInicializadas.Location = new System.Drawing.Point(0, 0);
                        this.uCCajasInicializadas.Name = "uCCajasInicializadas";
                        this.uCCajasInicializadas.Size = new System.Drawing.Size(250, 776);
                        this.uCCajasInicializadas.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCCajasInicializadas);
                        this.uCCajasInicializadas.reLoad();
                    }
                    break;
                case "datosEmpresa":
                    if (uCDatosEmpresa == null)
                    {
                        this.uCDatosEmpresa = new Admeli.Configuracion.UCDatosEmpresa(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCDatosEmpresa);
                        this.uCDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDatosEmpresa.Location = new System.Drawing.Point(0, 0);
                        this.uCDatosEmpresa.Name = "uCDatosEmpresa";
                        this.uCDatosEmpresa.Size = new System.Drawing.Size(250, 776);
                        this.uCDatosEmpresa.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCDatosEmpresa);
                        this.uCDatosEmpresa.reLoad();
                    }
                    break;
                case "denominaciones":
                    if (uCDenominaciones == null)
                    {
                        this.uCDenominaciones = new Admeli.Configuracion.UCDenominaciones(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCDenominaciones);
                        this.uCDenominaciones.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDenominaciones.Location = new System.Drawing.Point(0, 0);
                        this.uCDenominaciones.Name = "uCDenominaciones";
                        this.uCDenominaciones.Size = new System.Drawing.Size(250, 776);
                        this.uCDenominaciones.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCDenominaciones);
                        this.uCDenominaciones.reLoad();
                    }
                    break;
                case "disenoPersonalizacion":
                    if (uCDisenoPersonalizacion == null)
                    {
                        this.uCDisenoPersonalizacion = new Admeli.Configuracion.UCDisenoPersonalizacion(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCDisenoPersonalizacion);
                        this.uCDisenoPersonalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDisenoPersonalizacion.Location = new System.Drawing.Point(0, 0);
                        this.uCDisenoPersonalizacion.Name = "uCDisenoPersonalizacion";
                        this.uCDisenoPersonalizacion.Size = new System.Drawing.Size(250, 776);
                        this.uCDisenoPersonalizacion.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCDisenoPersonalizacion);
                        this.uCDisenoPersonalizacion.reLoad();
                    }
                    break;
                case "documentoIdentificacion":
                    if (uCDocumentoIdentificacion == null)
                    {
                        this.uCDocumentoIdentificacion = new Admeli.Configuracion.UCDocumentoIdentificacion(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCDocumentoIdentificacion);
                        this.uCDocumentoIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCDocumentoIdentificacion.Location = new System.Drawing.Point(0, 0);
                        this.uCDocumentoIdentificacion.Name = "uCDocumentoIdentificacion";
                        this.uCDocumentoIdentificacion.Size = new System.Drawing.Size(250, 776);
                        this.uCDocumentoIdentificacion.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCDocumentoIdentificacion);
                        this.uCDocumentoIdentificacion.reLoad();
                    }
                    break;
                case "grupoClientes":
                    if (uCGrupoClientes == null)
                    {
                        this.uCGrupoClientes = new Admeli.Configuracion.UCGrupoClientes(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCGrupoClientes);
                        this.uCGrupoClientes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCGrupoClientes.Location = new System.Drawing.Point(0, 0);
                        this.uCGrupoClientes.Name = "uCGrupoClientes";
                        this.uCGrupoClientes.Size = new System.Drawing.Size(250, 776);
                        this.uCGrupoClientes.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCGrupoClientes);
                        this.uCGrupoClientes.reLoad();
                    }
                    break;
                case "impuestoDocumento":
                    if (uCImpuestoDocumento == null)
                    {
                        this.uCImpuestoDocumento = new Admeli.Configuracion.UCImpuestoDocumento(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCImpuestoDocumento);
                        this.uCImpuestoDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCImpuestoDocumento.Location = new System.Drawing.Point(0, 0);
                        this.uCImpuestoDocumento.Name = "uCImpuestoDocumento";
                        this.uCImpuestoDocumento.Size = new System.Drawing.Size(250, 776);
                        this.uCImpuestoDocumento.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCImpuestoDocumento);
                        this.uCImpuestoDocumento.reLoad();
                    }
                    break;
                case "impuestos":
                    if (uCImpuestos == null)
                    {
                        this.uCImpuestos = new Admeli.Configuracion.UCImpuestos(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCImpuestos);
                        this.uCImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCImpuestos.Location = new System.Drawing.Point(0, 0);
                        this.uCImpuestos.Name = "uCImpuestos";
                        this.uCImpuestos.Size = new System.Drawing.Size(250, 776);
                        this.uCImpuestos.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCImpuestos);
                        this.uCImpuestos.reLoad();
                    }
                    break;
                case "listadoDocumento":
                    if (uCListadoDocumentos == null)
                    {
                        this.uCListadoDocumentos = new Admeli.Configuracion.UCListadoDocumentos(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCListadoDocumentos);
                        this.uCListadoDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCListadoDocumentos.Location = new System.Drawing.Point(0, 0);
                        this.uCListadoDocumentos.Name = "uCListadoDocumentos";
                        this.uCListadoDocumentos.Size = new System.Drawing.Size(250, 776);
                        this.uCListadoDocumentos.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCListadoDocumentos);
                        this.uCListadoDocumentos.reLoad();
                    }
                    break;
                case "listadoMoneda":
                    if (uCListadoMoneda == null)
                    {
                        this.uCListadoMoneda = new Admeli.Configuracion.UCListadoMoneda(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCListadoMoneda);
                        this.uCListadoMoneda.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCListadoMoneda.Location = new System.Drawing.Point(0, 0);
                        this.uCListadoMoneda.Name = "uCListadoMoneda";
                        this.uCListadoMoneda.Size = new System.Drawing.Size(250, 776);
                        this.uCListadoMoneda.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCListadoMoneda);
                        this.uCListadoMoneda.reLoad();
                    }
                    break;
                case "personal":
                    if (uCPersonal == null)
                    {
                        this.uCPersonal = new Admeli.Configuracion.UCPersonal(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCPersonal);
                        this.uCPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCPersonal.Location = new System.Drawing.Point(0, 0);
                        this.uCPersonal.Name = "uCPersonal";
                        this.uCPersonal.Size = new System.Drawing.Size(250, 776);
                        this.uCPersonal.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCPersonal);
                        this.uCPersonal.reLoad();
                    }
                    break;
                    
                case "sucursales":
                    if (uCSucursales == null)
                    {
                        this.uCSucursales = new Admeli.Configuracion.UCSucursales(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCSucursales);
                        this.uCSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCSucursales.Location = new System.Drawing.Point(0, 0);
                        this.uCSucursales.Name = "uCSucursales";
                        this.uCSucursales.Size = new System.Drawing.Size(250, 776);
                        this.uCSucursales.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCSucursales);
                        this.uCSucursales.reLoad();
                    }
                    break;
                case "puntodeventa":
                    if (uCPuntoDeVenta == null)
                    {
                        this.uCPuntoDeVenta = new Admeli.Configuracion.UCPuntoDeVenta(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCPuntoDeVenta);
                        this.uCPuntoDeVenta.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCPuntoDeVenta.Location = new System.Drawing.Point(0, 0);
                        this.uCPuntoDeVenta.Name = "uCPuntoDeVenta";
                        this.uCPuntoDeVenta.Size = new System.Drawing.Size(250, 776);
                        this.uCPuntoDeVenta.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCPuntoDeVenta);
                        this.uCPuntoDeVenta.reLoad();
                    }
                    break;
                case "tipoCambio":
                    if (uCTipoCambio == null)
                    {
                        this.uCTipoCambio = new Admeli.Configuracion.UCTipoCambio(this.formPrincipal);
                        this.formPrincipal.panelMain.Controls.Add(uCTipoCambio);
                        this.uCTipoCambio.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.uCTipoCambio.Location = new System.Drawing.Point(0, 0);
                        this.uCTipoCambio.Name = "uCTipoCambio";
                        this.uCTipoCambio.Size = new System.Drawing.Size(250, 776);
                        this.uCTipoCambio.TabIndex = 0;
                    }
                    else
                    {
                        this.formPrincipal.panelMain.Controls.Add(uCTipoCambio);
                        this.uCTipoCambio.reLoad();
                    }
                    break;
                default:
                    break;
            }
        }

        private void limpiarControles()
        {
            this.formPrincipal.panelMain.Controls.Clear();
            if (uCAlmacenes != null) uCAlmacenes.lisenerKeyEvents = false;
            if (uCAsignarCorrelativo != null) uCAsignarCorrelativo.lisenerKeyEvents = false;
            if (uCCajasInicializadas != null) uCCajasInicializadas.lisenerKeyEvents = false;
            if (uCDatosEmpresa != null) uCDatosEmpresa.lisenerKeyEvents = false;
            if (uCDenominaciones != null) uCDenominaciones.lisenerKeyEvents = false;
            if (uCDisenoPersonalizacion != null) uCDisenoPersonalizacion.lisenerKeyEvents = false;
            if (uCDocumentoIdentificacion != null) uCDocumentoIdentificacion.lisenerKeyEvents = false;
            if (uCGrupoClientes != null) uCGrupoClientes.lisenerKeyEvents = false;
            if (uCImpuestoDocumento != null) uCImpuestoDocumento.lisenerKeyEvents = false;
            if (uCImpuestos != null) uCImpuestos.lisenerKeyEvents = false;
            if (uCListadoDocumentos != null) uCListadoDocumentos.lisenerKeyEvents = false;
            if (uCListadoMoneda != null) uCListadoMoneda.lisenerKeyEvents = false;
            if (uCPersonal != null) uCPersonal.lisenerKeyEvents = false;
            if (uCSucursales != null) uCSucursales.lisenerKeyEvents = false;
            if (uCPuntoDeVenta != null) uCPuntoDeVenta.lisenerKeyEvents = false;
            if (uCTipoCambio != null) uCTipoCambio.lisenerKeyEvents = false;
        }


        private void btnColor()
        {
            btnAsignarCorrelativo.BackColor = this.BackColor;
            btnCajaInicializada.BackColor = this.BackColor;
            btnDatoEmpresa.BackColor = this.BackColor;
            btnDenominaciones.BackColor = this.BackColor;
            btnDisenoPersonalizacion.BackColor = this.BackColor;
            btnDocumentoIdentificacion.BackColor = this.BackColor;
            btnGrupoCliente.BackColor = this.BackColor;
            btnImpuestoDocumento.BackColor = this.BackColor;
            btnImpuestos.BackColor = this.BackColor;
            btnListadoDocumento.BackColor = this.BackColor;
            btnListadoMoneda.BackColor = this.BackColor;
            btnPersonal.BackColor = this.BackColor;
            btnSucursales.BackColor = this.BackColor;
            btnTipoCambio.BackColor = this.BackColor;
        }

        private void btnDatoEmpresa_Click(object sender, EventArgs e)
        {
            togglePanelMain("datosEmpresa");
            btnDatoEmpresa.BackColor = this.colorActive;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            togglePanelMain("personal");
            btnPersonal.BackColor = this.colorActive;
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            togglePanelMain("impuestos");
            btnImpuestos.BackColor = this.colorActive;
        }

        private void btnGrupoCliente_Click(object sender, EventArgs e)
        {
            togglePanelMain("grupoClientes");
            btnGrupoCliente.BackColor = this.colorActive;
        }

        private void btnCajaInicializada_Click(object sender, EventArgs e)
        {
            togglePanelMain("cajasInicializadas");
            btnCajaInicializada.BackColor = this.colorActive;
        }

        private void btnImpuestoDocumento_Click(object sender, EventArgs e)
        {
            togglePanelMain("impuestoDocumento");
            btnImpuestoDocumento.BackColor = this.colorActive;
        }

        private void btnListadoDocumento_Click(object sender, EventArgs e)
        {
            togglePanelMain("listadoDocumento");
            btnListadoDocumento.BackColor = this.colorActive;
        }

        private void btnAsignarCorrelativo_Click(object sender, EventArgs e)
        {
            togglePanelMain("asignarCorrelativo");
            btnAsignarCorrelativo.BackColor = this.colorActive;
        }

        private void btnDisenoPersonalizacion_Click(object sender, EventArgs e)
        {
            togglePanelMain("disenoPersonalizacion");
            btnDisenoPersonalizacion.BackColor = this.colorActive;
        }

        private void btnListadoMoneda_Click(object sender, EventArgs e)
        {
            togglePanelMain("listadoMoneda");
            btnListadoMoneda.BackColor = this.colorActive;
        }

        private void btnTipoCambio_Click(object sender, EventArgs e)
        {
            togglePanelMain("tipoCambio");
            btnTipoCambio.BackColor = this.colorActive;
        }

        private void btnDenominaciones_Click(object sender, EventArgs e)
        {
            togglePanelMain("denominaciones");
            btnDenominaciones.BackColor = this.colorActive;
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            togglePanelMain("sucursales");
            btnSucursales.BackColor = this.colorActive;
        }

        private void btnDocumentoIdentificacion_Click(object sender, EventArgs e)
        {
            togglePanelMain("documentoIdentificacion");
            btnDocumentoIdentificacion.BackColor = this.colorActive;
        }

        private void btnPuntoVenta_Click(object sender, EventArgs e)
        {
            togglePanelMain("puntodeventa");
            btnPuntoVenta.BackColor = this.colorActive;
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            togglePanelMain("alamacenes");
            btnAlmacenes.BackColor = this.colorActive;
        }
    }
}
