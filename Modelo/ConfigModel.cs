using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ConfigModel
    {
        private WebService webService = new WebService();
        public static Config config { get; set; }

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }

        public async Task configeneral()
        {
            try
            {
                List<Config> listSucursal = await webService.getLis<Config>("configeneral");
                config = listSucursal[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
