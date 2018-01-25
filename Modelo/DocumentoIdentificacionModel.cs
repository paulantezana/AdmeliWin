using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DocumentoIdentificacionModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(DocumentoIdentificacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/documentoidentificacion/guardar
                return await webService.POSTSend("documentoidentificacion", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(DocumentoIdentificacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/documentoidentificacion/modificar
                return await webService.POSTSend("documentoidentificacion", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Response> desactivar(DocumentoIdentificacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/documentoidentificacion/desactivar
                // return await webService.POSTSend("almacen", "desactivar", param);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(DocumentoIdentificacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/documentoidentificacion/eliminar
                return await webService.POSTSend("documentoidentificacion", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<RootObject<DocumentoIdentificacion>> documentoidentificaciones(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/documentoidentificaciones/1/100
                RootObject<DocumentoIdentificacion> documetoIdentificacion = await webService.GETRoot<DocumentoIdentificacion>("documentoidentificaciones", String.Format("{0}/{1}", page, items));
                return documetoIdentificacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
