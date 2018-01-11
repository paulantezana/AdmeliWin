using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SucursalModel
    {
        private WebService webService = new WebService();

        public static Sucursal sucursal { get; set; }

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }

        public async Task sucursalesPersonal(int idPersonal)
        {
            try
            {
                List<Sucursal> listSucursal = await webService.getLis<Sucursal>("sucursalespersonal", idPersonal.ToString());
                SucursalModel.sucursal = listSucursal[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
