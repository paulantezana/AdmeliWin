using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VarianteModel
    {
        private WebService webService = new WebService();

        public async Task<List<Variante>> precioProducto(int idProducto)
        {
            try
            {
                // www.lineatienda.com/services.php/producto/403/variantes
                List<Variante> list = await webService.GETLis<Variante>("producto", String.Format("{0}/variantes", idProducto));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
