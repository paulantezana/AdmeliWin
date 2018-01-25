using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AlmacenModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Almacen param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/guardar
                return await webService.POSTSend("almacen", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Almacen param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/modificar
                return await webService.POSTSend("almacen", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<Response> desactivar(Almacen param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/desactivar
                return await webService.POSTSend("almacen", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<Response> eliminar(Almacen param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/eliminar
                return await webService.POSTSend("almacen", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Almacen>> almacenes(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/almacenes/estado/1/100
                RootObject<Almacen> almacenes = await webService.GETRoot<Almacen>("almacenes", String.Format("estado/{0}/{1}", page, items));
                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Almacen>> almacenesProducto()
        {
            try
            {
                // www.lineatienda.com/services.php/almacenes/id/nombre/estado/1
                List<Almacen> almacenes = await webService.GETLis<Almacen>("almacenes", "id/nombre/estado/1");
                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
