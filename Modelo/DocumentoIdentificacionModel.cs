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

        public void guardar()
        {

        }

        public void modificar()
        {

        }

        public void eliminar()
        {

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
