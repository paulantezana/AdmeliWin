using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MarcaModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Marca param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/marca/guardar
                return await webService.POSTSend("marca", "guardar", param);
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

        public async Task<RootObject<Marca>> marcas(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/marcas/estado/1/100
                RootObject<Marca> marcas = await webService.GETRoot<Marca>("marcas", String.Format("estado/{0}/{1}", page, items));
                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
