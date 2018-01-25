using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ImpuestoModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Impuesto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/impuesto/guardar
                return await webService.POSTSend("impuesto", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Impuesto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/impuesto/modificar
                return await webService.POSTSend("impuesto", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Impuesto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/impuesto/desactivar
                return await webService.POSTSend("impuesto", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Impuesto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/impuesto/eliminar
                return await webService.POSTSend("impuesto", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Impuesto>> impuestos(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/impuestos/estado/1/100
                RootObject<Impuesto> impuestos = await webService.GETRoot<Impuesto>("impuestos", String.Format("estado/{0}/{1}", page, items));
                return impuestos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
