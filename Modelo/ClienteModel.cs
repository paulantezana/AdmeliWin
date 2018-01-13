using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteModel
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
        public async Task<RootObject<Cliente>> getByPersonalEstado(int page, int items)
        {
            try
            {
                RootObject<Cliente> clientes = await webService.Get<Cliente>("clientes", String.Format("estado/{0}/{1}", page, items));
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
