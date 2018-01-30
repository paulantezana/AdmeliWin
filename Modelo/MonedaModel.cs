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
    public class MonedaModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Moneda param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/moneda/guardar
                return await webService.POSTSend("moneda", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Moneda param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/moneda/modificar
                return await webService.POSTSend("moneda", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Moneda param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/moneda/desactivar
                return await webService.POSTSend("moneda", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Moneda param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/moneda/eliminar
                return await webService.POSTSend("moneda", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Moneda>> monedas(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/monedas/estado/1
                // www.lineatienda.com/services.php/monedas/estado/1/100
                RootObject<Moneda> monedas = await webService.GETRoot<Moneda>("monedas", String.Format("estado/{0}/{1}", page, items));
                return monedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Moneda>> monedas(int estado = 1)
        {
            try
            {
                // www.lineatienda.com/services.php/monedas/estado/1
                List<Moneda> list = await webService.GETLis<Moneda>("monedas", String.Format("estado/{0}", estado));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
