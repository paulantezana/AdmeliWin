using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProveedorModel
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

        public async Task<RootObject<Proveedor>> proveedoreslike(int page, int items, string like = "")
        {
            try
            {
                RootObject<Proveedor> proveedores = await webService.Get<Proveedor>("proveedoreslike", String.Format("razonsocial/{0}/{1}/{2}", like, page, items));
                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Proveedor>> proveedores( int page, int items, string estado = "estado")
        {
            try
            {
                RootObject<Proveedor> proveedores = await webService.Get<Proveedor>("proveedores", String.Format("{0}/{1}/{2}", estado, page, items));
                return proveedores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
