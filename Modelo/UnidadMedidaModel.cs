using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UnidadMedidaModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(UnidadMedida param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/unimed/guardar
                return await webService.POSTSend("unimed", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

        public async Task<RootObject<UnidadMedida>> unimedidas(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/unimedidas/estado/1/100
                RootObject<UnidadMedida> unidadesMedidad = await webService.GETRoot<UnidadMedida>("unimedidas", String.Format("estado/{0}/{1}", page, items));
                return unidadesMedidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
