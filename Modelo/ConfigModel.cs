using Entidad;
using Entidad.Configuracion;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ConfigModel
    {
        private WebService webService = new WebService();
        public static Config config { get; set; }

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }

        // DATOS GENERALES
        // SUCURSALES PERSONA
        // ASIGNACION PERSONAL
        // CONFIGURACION GENERAL
        // MONEDAS
        // TIPOS DE CAMBIOS
        public async Task datosGenerales()
        {
            try
            {
                // www.lineatienda.com/services.php/generales
                List<DatosGenerales> datosGenerales = await webService.getLis<DatosGenerales>("generales");
                config.datosGenerales = datosGenerales[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task sucursalPersonal(int idPersonal)
        {
            try
            {
                // www.lineatienda.com/services.php/sucursalespersonal/8
                List<Sucursal> sucursal = await webService.getLis<Sucursal>("sucursalespersonal",idPersonal.ToString());
                config.sucursal = sucursal[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task asignacionPersonal(int idPersonal, int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/personales/asignacionpersonal/per/8/suc/1
                AsignacionPersonal asignacionPersonal = await webService.getObject<AsignacionPersonal>("personales", String.Format("asignacionpersonal/per/{0}/suc/{1}", idPersonal, idSucursal));
                config.asignacionPersonal = asignacionPersonal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task confiGeneral()
        {
            try
            {
                // www.lineatienda.com/services.php/configeneral
                List<ConfiguracionGeneral> configuracionGeneral = await webService.getLis<ConfiguracionGeneral>("configeneral");
                config.configuracionGeneral = configuracionGeneral[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task monedas()
        {
            try
            {
                // www.lineatienda.com/services.php/monedas/estado/1
                List<Moneda> monedas = await webService.getLis<Moneda>("monedas", "estado/1");
                config.monedas = monedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task tiposCambio()
        {
            try
            {
                // www.lineatienda.com/services.php/tipocambiotodasmonedas/hoy
                List<TipoCambioMoneda> tipoCambioMoneda = await webService.getLis<TipoCambioMoneda>("tipocambiotodasmonedas", "hoy");
                config.tipoCambioMoneda = tipoCambioMoneda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
