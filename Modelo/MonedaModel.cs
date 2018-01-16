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
    public class MonedaModel
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

        public async Task<RootObject<Moneda>> monedas(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/monedas/estado/1/100
                RootObject<Moneda> monedas = await webService.GETRoot<Moneda>("monedas", String.Format("estado/{0}/{1}", page, items));
                return monedas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
