using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Configuracion;

namespace Admeli.NavDarck
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

        private FormPrincipal formHomeDarck;

        public UCConfigNav()
        {
            InitializeComponent();
        }

        public UCConfigNav(FormPrincipal formHomeDarck)
        {
            InitializeComponent();
            this.formHomeDarck = formHomeDarck;
        }
    }
}
