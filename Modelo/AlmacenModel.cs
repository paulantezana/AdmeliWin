using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AlmacenModel
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

        public async Task<RootObject<Almacen>> almacenes(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/almacenes/estado/1/100
                RootObject<Almacen> almacenes = await webService.GETRoot<Almacen>("almacenes", String.Format("estado/{0}/{1}", page, items));
                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
