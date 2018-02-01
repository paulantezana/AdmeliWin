using Entidad;
using Entidad.Location;
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
        private LocationModel locationModel = new LocationModel();

        public async Task<Response> guardar(UbicacionGeografica ubicacionGeografica, Almacen param)
        {
            try
            {
                // Obteniendo de la ubicacion geografica del sucursal
                Response res = await locationModel.guardarUbigeo(ubicacionGeografica);
                param.idUbicacionGeografica = res.id;

                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/guardar
                return await webService.POSTSend("almacen", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(UbicacionGeografica ubicacionGeografica, Almacen param)
        {
            try
            {
                // Obteniendo de la ubicacion geografica del sucursal
                Response res = await locationModel.guardarUbigeo(ubicacionGeografica);
                param.idUbicacionGeografica = res.id;

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

        public async Task<List<Almacen>> almacenes(int estado = 1)
        {
            try
            {
                // www.lineatienda.com/services.php/almacenes/id/nombre/estado/1
                List<Almacen> list = await webService.GETLis<Almacen>("almacenes", String.Format("id/nombre/estado/{0}",estado));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Almacen>> almacenesPorSucursales(int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/almacenesporsucursal/sucursal/0
                List<Almacen> list = await webService.GETLis<Almacen>("almacenesporsucursal", String.Format("sucursal/{0}", idSucursal));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
