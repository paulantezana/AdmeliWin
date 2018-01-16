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

        public void guardar()
        {

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
