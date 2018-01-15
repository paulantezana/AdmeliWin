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

        public static DatosGenerales datosGenerales { get; set; }
        public static Sucursal sucursal { get; set; }
        public static AsignacionPersonal asignacionPersonal { get; set; }
        public static ConfiguracionGeneral configuracionGeneral { get; set; }
        public static List<Moneda> monedas { get; set; }
        public static List<TipoCambioMoneda> tipoCambioMonedas { get; set; }


        // TIPOS DE DOCUMENTO       www.lineatienda.com/services.php/tipodoc21/estado/1
        // ALMACENES                www.lineatienda.com/services.php/personalalmacenes/per/8/suc/1
        // ASIGNACION PERSONAL      www.lineatienda.com/services.php/asignarpuntoventas/sucursal/1/personal/8
        // CAJA SECION  
        public static List<TipoDocumento> tipoDocumento { get; set; }
        public static List<Almacen> alamacenes { get; set; }
        public static List<PuntoDeVenta> puntosDeVenta { get; set; }


        // www.lineatienda.com/services.php/cierrecajaingresomenosegreso/mediopago/1/cajasesion/62
        public static List<Moneda> cierreIngresoEgreso { get; set; }



        /**
         * OTROS PARAMETROS
         * estas configuraciones se deben establecer al inicial la aplicacion
         * segun el numero de almacenes y puntos de venta
         * */
        public static int currentIdAlmacen { get; set; }
        public static int currentPuntoVenta { get; set; }

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
        public async Task loadDatosGenerales()
        {
            try
            {
                // www.lineatienda.com/services.php/generales
                List<DatosGenerales> list = await webService.GETLis<DatosGenerales>("generales");
                datosGenerales = list[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task loadSucursalPersonal(int idPersonal)
        {
            try
            {
                // www.lineatienda.com/services.php/sucursalespersonal/8
                List<Sucursal> list = await webService.GETLis<Sucursal>("sucursalespersonal",idPersonal.ToString());
                sucursal = list[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task loadAsignacionPersonales(int idPersonal, int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/personales/asignacionpersonal/per/8/suc/1
                AsignacionPersonal datos = await webService.GETObject<AsignacionPersonal>("personales", String.Format("asignacionpersonal/per/{0}/suc/{1}", idPersonal, idSucursal));
                asignacionPersonal = datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task loadConfiGeneral()
        {
            try
            {
                // www.lineatienda.com/services.php/configeneral
                List<ConfiguracionGeneral> list = await webService.GETLis<ConfiguracionGeneral>("configeneral");
                configuracionGeneral = list[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task loadMonedas()
        {
            try
            {
                // www.lineatienda.com/services.php/monedas/estado/1
                List<Moneda> list = await webService.GETLis<Moneda>("monedas", "estado/1");
                monedas = list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task loadTipoCambioMonedas()
        {
            try
            {
                // www.lineatienda.com/services.php/tipocambiotodasmonedas/hoy
                List<TipoCambioMoneda> list = await webService.GETLis<TipoCambioMoneda>("tipocambiotodasmonedas", "hoy");
                tipoCambioMonedas = list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // TIPOS DE DOCUMENTO       www.lineatienda.com/services.php/tipodoc21/estado/1
        // ALMACENES                www.lineatienda.com/services.php/personalalmacenes/per/8/suc/1
        // ASIGNACION PERSONAL      www.lineatienda.com/services.php/asignarpuntoventas/sucursal/1/personal/8
        // CAJA SECION              www.lineatienda.com/services.php/cajasesion/idasignarcaja/8

        public async Task loadTipoDocumento()
        {
            try
            {
                // www.lineatienda.com/services.php/tipodoc21/estado/1
                List<TipoDocumento> list = await webService.GETLis<TipoDocumento>("tipodoc21", "estado/1");
                tipoDocumento = list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task loadAlmacenes(int idPersonal, int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/personalalmacenes/per/8/suc/1
                List<Almacen> list = await webService.GETLis<Almacen>("personalalmacenes", String.Format("per/{0}/suc/{1}",idPersonal,idSucursal));
                alamacenes = list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task loadPuntoDeVenta(int idPersonal, int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/asignarpuntoventas/sucursal/1/personal/8
                List<PuntoDeVenta> list = await webService.GETLis<PuntoDeVenta>("asignarpuntoventas", String.Format("sucursal/{0}/personal/{1}",idSucursal,idPersonal));
                puntosDeVenta = list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
