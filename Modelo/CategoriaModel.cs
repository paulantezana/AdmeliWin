using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CategoriaModel
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

        public async Task<List<Categoria>> categoriasTodo(int estado = 1)
        {
            try
            {
                // www.lineatienda.com/services.php/categoriastodo/estado/1
                List<Categoria> categorias = await webService.GETLis<Categoria>("categoriastodo", String.Format("estado/{0}",estado));
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Categoria>> categoriastree()
        {
            try
            {
                // www.lineatienda.com/services.php/categoriastree
                RootObject<Categoria> categorias = await webService.GETRoot<Categoria>("categoriastree");
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
