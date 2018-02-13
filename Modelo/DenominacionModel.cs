﻿using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DenominacionModel
    {
        private WebService webService = new WebService();

        public async Task<Response> guardar(Denominacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/denominacion/guardar
                return await webService.POSTSend("denominacion", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Denominacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/denominacion/modificar
                return await webService.POSTSend("denominacion", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Denominacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/denominacion/modificar
                return await webService.POSTSend("denominacion", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Denominacion param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/denominacion/eliminar
                return await webService.POSTSend("denominacion", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Denominacion>> denominaciones(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/denominaciones/paginacion/1/100
                RootObject<Denominacion> almacenes = await webService.GET<RootObject<Denominacion>>("denominaciones", String.Format("paginacion/{0}/{1}", page, items));
                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Denominacion>> verificarDenominaciones(string nombre, double valor, int moneda, int idDenominacion)
        {
            try
            {
                // localhost/admeli/xcore/services.php/verificardenominaciones/nombre/100%20DOLAR/valor/200/moneda/1/denominacion/0
                List<Denominacion> almacenes = await webService.GET<List<Denominacion>>("verificardenominaciones", String.Format("nombre/{0}/valor/{1}/moneda/{2}/denominacion/{3}", nombre, valor, moneda, idDenominacion));
                return almacenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
