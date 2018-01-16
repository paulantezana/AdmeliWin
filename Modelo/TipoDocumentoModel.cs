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

        public void guardar()
        {

        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

        public async Task<RootObject<TipoDocumento>> tipodocumentos(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/tipodocumentos/1/100
                RootObject<TipoDocumento> tipoDocumento = await webService.GETRoot<TipoDocumento>("tipodocumentos", String.Format("{0}/{1}", page, items));
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
                List<TipoDocumento> tipoDocumentos = await webService.GETLis<TipoDocumento>("tipodoc", String.Format("estado/{0}", estado));
                return tipoDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
