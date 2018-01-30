using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class StockModel
    {
        private WebService webService = new WebService();

        public async Task<List<Stock>> stockProducto(int idProducto)
        {
            try
            {
                // www.lineatienda.com/services.php/psalmacenes/producto/445
                List<Stock> list = await webService.GETLis<Stock>("psalmacenes", String.Format("producto/{0}", idProducto));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
