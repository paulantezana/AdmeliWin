using Entidad.Configuracion;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PuntoModel
    {
        private WebService webService = new WebService();

        public async Task<PuntoAdministracion> puntoAdministracion(int idSucursal)
        {
            try
            {
                // www.admeli.com/demo2/services.php/puntoadministracion/suc/5
                List<PuntoAdministracion> responseData = await webService.GETLis<PuntoAdministracion>("puntoadministracion", String.Format("suc/{0}",idSucursal));
                return responseData[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<PuntoCompra> puntoCompra(int idSucursal)
        {
            try
            {
                // www.admeli.com/demo2/services.php/puntocompra/suc/5
                List<PuntoCompra> responseData = await webService.GETLis<PuntoCompra>("puntocompra", String.Format("suc/{0}", idSucursal));
                return responseData[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<PuntoDeVenta>> puntoVentas(int idSucursal)
        {
            try
            {
                // www.admeli.com/demo2/services.php/puntoventas/suc/5
                List<PuntoDeVenta> responseData = await webService.GETLis<PuntoDeVenta>("puntoventas", String.Format("suc/{0}", idSucursal));
                return responseData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Caja>> cajas(int idSucursal)
        {
            try
            {
                // www.admeli.com/demo2/services.php/cajas/suc/5
                List<Caja> responseData = await webService.GETLis<Caja>("cajas", String.Format("suc/{0}", idSucursal));
                return responseData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<PuntoGerencia> puntoGerencia(int idSucursal)
        {
            try
            {
                // www.admeli.com/demo2/services.php/puntogerencia/suc/5
                List<PuntoGerencia> responseData = await webService.GETLis<PuntoGerencia>("puntogerencia", String.Format("suc/{0}", idSucursal));
                return responseData[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
