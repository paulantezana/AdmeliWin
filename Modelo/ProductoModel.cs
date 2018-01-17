using Entidad;
using Modelo.Recursos;
using Newtonsoft.Json;
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

        public async Task<RootObject<Producto>> productosPorCategoria(Dictionary<string, int> dictionary, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/productos/categoria/1/100
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                json = String.Format("[\r\n{0}\r\n]", json);
                RootObject<Producto> productos = await webService.POSTRoot<Producto>("productos", String.Format("categoria/{0}/{1}",page,items), json);
                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RootObject<Producto>> productosPorCategoriaBuscar(Dictionary<string, int> dictionary, string like, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/productos/categoria/1/100/pantalla
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                json = String.Format("[\r\n{0}\r\n]", json);
                RootObject<Producto> productos = await webService.POSTRoot<Producto>("productos", String.Format("categoria/{0}/{1}/{2}", page, items,like), json);
                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
