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
    public class PuntoVentaModel
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

        public async Task<RootObject<PuntoDeVenta>> puntoventas(int idSucursal, string idEstado, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/puntoventas/sucursal/0/estado/todos/1/100
                RootObject<PuntoDeVenta> puntoVenta = await webService.GETRoot<PuntoDeVenta>("puntoventas", String.Format("sucursal/{0}/estado/{1}/{2}/{3}", idSucursal, idEstado, page, items));
                return puntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<PuntoDeVenta>> puntoVentasyTodos(int idSucursal)
        {
            try
            {
                // www.lineatienda.com/services.php/puntoventasytodos/suc/0
                List<PuntoDeVenta> puntoVenta = await webService.GETLis<PuntoDeVenta>("puntoventasytodos", String.Format("suc/{0}", idSucursal));
                return puntoVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
