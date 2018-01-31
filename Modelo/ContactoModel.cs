using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ContactoModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Contacto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/contactoproveedor/guardar
                return await webService.POSTSend("contactoproveedor", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Contacto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/contactoproveedor/modificar
                return await webService.POSTSend("contactoproveedor", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Contacto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/almacen/desactivar
                // return await webService.POSTSend("almacen", "desactivar", param);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Contacto param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/contactoproveedor/eliminar
                return await webService.POSTSend("contactoproveedor", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Contacto>> contactos(int idProveedor)
        {
            try
            {
                // www.lineatienda.com/services.php/almacenes/proveedor/7/contactos
                List<Contacto> list = await webService.GETLis<Contacto>("proveedor", String.Format("{0}/contactos", idProveedor));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
