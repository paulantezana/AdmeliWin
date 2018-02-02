using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AlternativaModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Alternativa param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/alternativa/guardar
                return await webService.POSTSend("alternativa", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Alternativa param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/alternativa/modificar
                return await webService.POSTSend("alternativa", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Alternativa param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/alternativa/desactivar
                return await webService.POSTSend("alternativa", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Alternativa param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/alternativa/eliminar
                return await webService.POSTSend("alternativa", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Alternativa>> alternativas(int idVariante)
        {
            try
            {
                // localhost/admeli/xcore/services.php/variante/1/alternativas
                List<Alternativa> list = await webService.GETLis<Alternativa>("variante", String.Format("{0}/alternativas", idVariante));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
