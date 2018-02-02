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

        // validacion de un producto     
        public async Task<List<Producto>> validarProducto(Producto param)
        {
            try
            {
                // localhost/admeli/xcore/services.php/verificarproductonombrecodigo
                List<Producto> list = await webService.POSTResponse("verificarproductonombrecodigo", param);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void guardar()
        {
            // 
        }

        public async Task<Response> guardar(Producto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/producto/guardar
                return await webService.POSTSend("producto", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public async Task<RootObject<Producto>> productosStock(Dictionary<string, int> dictionary, string like, int idAlmacen, int idSucursal, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/productos/categoria/stock/1/100/1/1
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                json = String.Format("[\r\n{0}\r\n]", json);
                RootObject<Producto> productos = await webService.POSTRoot<Producto>("productos", String.Format("categoria/stock/{0}/{1}/{2}/{3}", page, items, idAlmacen, idSucursal), json);
                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RootObject<Producto>> productosStockLike(Dictionary<string, int> dictionary, string like, int idAlmacen, int idSucursal, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/productos/categoria/stock/1/100/1/1
                // www.lineatienda.com/services.php/productos/categoria/stock/1/100/pantalla/1/1
                string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                json = String.Format("[\r\n{0}\r\n]", json);
                RootObject<Producto> productos = await webService.POSTRoot<Producto>("productos", String.Format("categoria/stock/{0}/{1}/{2}/{3}/{4}", page, items, like, idAlmacen, idSucursal), json);
                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> modificar(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
