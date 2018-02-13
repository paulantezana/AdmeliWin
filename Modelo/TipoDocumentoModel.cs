using Entidad;
using Entidad.Configuracion;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoDocumentoModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(TipoDocumento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/tipodoc/guardar
                return await webService.POSTSend("tipodoc", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(TipoDocumento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/tipodoc/modificar
                return await webService.POSTSend("tipodoc", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*
        public async Task<Response> desactivar(Marca param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/marca/desactivar
                return await webService.POSTSend("marca", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public async Task<Response> eliminar(TipoDocumento param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/tipodoc/eliminar
                return await webService.POSTSend("tipodoc", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<TipoDocumento>> tipodocumentos(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/tipodocumentos/1/100
                RootObject<TipoDocumento> tipoDocumento = await webService.GET<RootObject<TipoDocumento>>("tipodocumentos", String.Format("{0}/{1}", page, items));
                return tipoDocumento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<TipoDocumento>> tipodoc(int estado = 1)
        {
            try
            {
                // www.lineatienda.com/services.php/tipodoc/estado/1
                List<TipoDocumento> tipoDocumentos = await webService.GET<List<TipoDocumento>>("tipodoc", String.Format("estado/{0}", estado));
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<TipoDocumento>> tipoDocumentoVentas()
        {
            try
            {
                // localhost/admeli/xcore/services.php/tipodocumentoventas/ventas
                List<TipoDocumento> tipoDocumentos = await webService.GET<List<TipoDocumento>>("tipodocumentoventas", "ventas");
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
