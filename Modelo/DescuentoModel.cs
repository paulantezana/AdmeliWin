using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DescuentoModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Descuento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/descuento/guardar
                return await webService.POSTSend("descuento", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Descuento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/descuento/modificar
                return await webService.POSTSend("descuento", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Descuento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/desccascasuento/elicascsminar
                return await webService.POSTSend("catecascascasgoria", "dascascasesactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Descuento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/descuento/eliminar
                return await webService.POSTSend("descuento", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Descuento>> descuentoOfertaCodigo(int idProducto)
        {
            try
            {
                // localhost/admeli/xcore/services.php/descuento/producto/21
                RootObject<Descuento> descuentos = await webService.GETRoot<Descuento>("descuento", String.Format("producto/{0}", idProducto));
                return descuentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
