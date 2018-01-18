using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NotaEntradaModel
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

        public async Task<List<NotaEntrada>> nEntradaPendientes(int idPersonal, int idAlmacen, int todos, int gerente)
        {
            try
            {
                // www.lineatienda.com/services.php/nentrada/pendientes/3/1/1/1
                List<NotaEntrada> nEntradaPendientes = await webService.GETLis<NotaEntrada>("nentrada", String.Format("pendientes/{0}/{1}/{2}/{3}", idPersonal, idAlmacen, todos, gerente));
                return nEntradaPendientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
