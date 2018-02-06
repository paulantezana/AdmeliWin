using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class FechaModel
    {
        private WebService webService = new WebService();

        public async Task<dynamic> fechaSistema()
        {
            try
            {
                // localhost/admeli/xcore/services.php/fechasystema
                return await webService.GETObject<dynamic>("fechasystema");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
