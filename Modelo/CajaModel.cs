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
    public class CajaModel
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

        public async Task<dynamic> correlativoSerie(int idCaja, int tipo = 0)
        {
            try
            {
                // www.lineatienda.com/services.php/cajacorrelativoserie/caja/1/tipo/0
                List<dynamic> list = await webService.GETLis<dynamic>("cajacorrelativoserie", String.Format("caja/{0}/tipo/{1}", idCaja,tipo));
                return list[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<CajaSesion>> cajaSesionesInicializadas(int idSucursal, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/cajasesionesinicializadas/suc/1/1/100
                RootObject<CajaSesion> cajaSesion = await webService.GETRoot<CajaSesion>("cajasesionesinicializadas", String.Format("suc/{0}/{1}/{2}", idSucursal, page, items));
                return cajaSesion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
