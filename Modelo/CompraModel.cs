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

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }
        public async Task<RootObject<Compra>> getByPersonalEstado(int idSucursal, int idPersonal, string idEstado, int page, int items)
        {
            try
            {
                RootObject<Compra> ordenCompra = await webService.Get<Compra>("compras", String.Format("sucursal/{0}/personal/{1}/estado/{2}/{3}/{4}", idSucursal,idPersonal,idEstado, page, items));
                return ordenCompra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
