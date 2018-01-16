using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ImpuestoModel
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

        public async Task<RootObject<Impuesto>> impuestos(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/impuestos/estado/1/100
                RootObject<Impuesto> impuestos = await webService.GETRoot<Impuesto>("impuestos", String.Format("estado/{0}/{1}", page, items));
                return impuestos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
