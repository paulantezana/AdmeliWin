using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VentaModel
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

        public async Task<RootObject<Venta>> ventas(int idSucursal, int idPuntoVenta, int idPersonal, string idEstado, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/ventas/sucursal/0/puntoventa/0/per/0/estado/todos/1/100
                RootObject<Venta> ventas = await webService.GETRoot<Venta>("ventas", String.Format("sucursal/{0}/puntoventa/{1}/per/{2}/estado/{3}/{4}/{5}", idSucursal, idPuntoVenta, idPersonal, idEstado, page, items));
                return ventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<List<Venta>> ventasUltimas(int idPersonal, int idSucursal, int todos, int gerente)
        {
            try
            {
                // www.lineatienda.com/services.php/ventasultimas/3/1/1/1
                List<Venta> ventasultimas = await webService.GETLis<Venta>("ventasultimas", String.Format("{0}/{1}/{2}/{3}",idPersonal,idSucursal,todos,gerente));
                return ventasultimas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
