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
    public class CajaModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar<T>(T param)
        {
            try
            {
                // localhost/admeli/xcore/services.php/cajasesion/guardar
                return await webService.POSTSend("cajasesion", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

        public async Task<dynamic> correlativoSerie(int idCaja, int tipo = 0)
        {
            try
            {
                // www.lineatienda.com/services.php/cajacorrelativoserie/caja/1/tipo/0
                List<dynamic> list = await webService.GETLis<dynamic>("cajacorrelativoserie", String.Format("caja/{0}/tipo/{1}", idCaja,tipo));
                return list[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<CajaSesion>> cajaSesionesInicializadas(int idSucursal, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/cajasesionesinicializadas/suc/1/1/100
                RootObject<CajaSesion> cajaSesion = await webService.GETRoot<CajaSesion>("cajasesionesinicializadas", String.Format("suc/{0}/{1}/{2}", idSucursal, page, items));
                return cajaSesion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Moneda>> cierreCajaIngresoMenosEgreso(int mediopago, int cajaSesion)
        {
            try
            {
                // localhost/admeli/xcore/services.php/cierrecajaingresomenosegreso/mediopago/1/cajasesion/7
                List<Moneda> list = await webService.GETLis<Moneda>("cajasesionesinicializadas", String.Format("mediopago/{0}/cajasesion/{1}", mediopago, cajaSesion));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CajaSesion>> cajaSesion(int idAsignarCaja)
        {
            try
            {
                // localhost/admeli/xcore/services.php/cajasesion/idasignarcaja/1
                List<CajaSesion> list = await webService.GETLis<CajaSesion>("cajasesion", String.Format("idasignarcaja/{0}", idAsignarCaja));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
