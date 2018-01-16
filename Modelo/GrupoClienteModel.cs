using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GrupoClienteModel
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

        public async Task<RootObject<GrupoCliente>> gclientes(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/gclientes/estado/1/100
                RootObject<GrupoCliente> grupoClientes = await webService.GETRoot<GrupoCliente>("gclientes", String.Format("estado/{0}/{1}", page, items));
                return grupoClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
