using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CompraModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Producto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/compra/guardar
                return await webService.POSTSend("compra", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Compra param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/compra/modificar
                return await webService.POSTSend("compra", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> anular(Compra param)
        {
            try
            {
                // localhost/admeli/xcore/services.php/compra/anular
                return await webService.POSTSend("compra", "anular", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<RootObject<Compra>> getByPersonalEstado(int idSucursal, int idPersonal, string idEstado, int page, int items)
        {
            try
            {
                RootObject<Compra> ordenCompra = await webService.GETRoot<Compra>("compras", String.Format("sucursal/{0}/personal/{1}/estado/{2}/{3}/{4}", idSucursal,idPersonal,idEstado, page, items));
                return ordenCompra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Compra>> comprasUltimas(int idPersonal, int idSucursal, int todos, int gerente)
        {
            try
            {
                // www.lineatienda.com/services.php/comprasultimas/3/1/1/1
                List<Compra> comprasultimas = await webService.GETLis<Compra>("comprasultimas", String.Format("{0}/{1}/{2}/{3}", idPersonal, idSucursal, todos, gerente));
                return comprasultimas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
