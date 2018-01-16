using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EgresoModel
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

        public async Task<RootObject<Egreso>> egresos(int idSucursal, int idPersonal, int idCajaSesion, string idEstado, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/egresos/sucursal/0/personal/0/cajasesion/0/estado/todos/1/100
                RootObject<Egreso> egresos = await webService.GETRoot<Egreso>("egresos", String.Format("sucursal/{0}/personal/{1}/cajasesion/{2}/estado/{3}/{4}/{5}", idSucursal, idPersonal, idCajaSesion, idEstado, page, items));
                return egresos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
