using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PresentacionModel
    {
        private WebService webService = new WebService();

        public async Task<List<Presentacion>> precioProducto(int idProducto)
        {
            try
            {
                // www.lineatienda.com/services.php/presentacion/producto/403
                List<Presentacion> list = await webService.GETLis<Presentacion>("presentacion", String.Format("producto/{0}", idProducto));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
