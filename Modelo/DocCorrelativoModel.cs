using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DocCorrelativoModel
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

        public async Task<RootObject<DocCorrelativo>> listartodoCorrelativo(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/listartodocorrelativo/1/100
                RootObject<DocCorrelativo> docCorrelativo = await webService.GETRoot<DocCorrelativo>("listartodocorrelativo", String.Format("{0}/{1}", page, items));
                return docCorrelativo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
