﻿using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PresentacionModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Presentacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/presentacion/guardar
                return await webService.POSTSend("presentacion", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Presentacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/presentacion/modificar
                return await webService.POSTSend("presentacion", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Presentacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/presentacion/eliminar
                return await webService.POSTSend("presentacion", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Presentacion>> presentaciones(int idProducto)
        {
            try
            {
                // localhost/admeli/xcore/services.php/presentacion/producto/21
                List<Presentacion> list = await webService.GET<List<Presentacion>>("presentacion", String.Format("producto/{0}", idProducto));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Presentacion>> presentacionVentas(int idProducto)
        {
            try
            {
                // localhost/admeli/xcore/services.php/listarpresentacionventas/producto/28
                List<Presentacion> list = await webService.GET<List<Presentacion>>("listarpresentacionventas", String.Format("producto/{0}", idProducto));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
