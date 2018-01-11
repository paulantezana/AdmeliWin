using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoModel
    {
        public static Producto producto { get; set; }

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
        public void cambiarClave()
        {

        }
        public async Task<dynamic> listarPorCategoria(string page, string items)
        {
            try
            {

                List<Object> list = new List<Object>();
                list.Add(new object[] { "id0", "id0" });
                list.Add(new object[] { "id1", "id1" });
                list.Add(new object[] { "id2", "id2" });
                list.Add(new object[] { "id3", "id3" });

                dynamic result = await webService.JsonMetodoPost22("productos", String.Format("categoria/{0}/{1}", page, items), new object[,] { { "usuario", "admin" }, { "password", "admin123pass" } });
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
