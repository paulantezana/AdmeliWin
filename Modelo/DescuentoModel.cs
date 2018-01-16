using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DescuentoModel
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

        public async Task<RootObject<Descuento>> descuentoOfertaCodigo(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/descuentoofertacodigo/1/100
                RootObject<Descuento> descuentos = await webService.GETRoot<Descuento>("descuentoofertacodigo", String.Format("{0}/{1}", page, items));
                return descuentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
