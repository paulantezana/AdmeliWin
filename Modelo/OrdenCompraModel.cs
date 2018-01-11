using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class OrdenCompraModel
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
        public void cambiarClave()
        {

        }
        public async Task<dynamic> getData(string page, string items)
        {
            try
            {
                List<OrdenCompra> listPersonal = new List<OrdenCompra>();
                dynamic result = await webService.JsonMetodoGet("ocompras", String.Format("suc/1/per/0/{0}/{1}", page, items));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
