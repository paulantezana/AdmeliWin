﻿using Entidad;
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
                List<NotaEntrada> nEntradaPendientes = await webService.GET<List<NotaEntrada>>("nentrada", String.Format("pendientes/{0}/{1}/{2}/{3}", idPersonal, idAlmacen, todos, gerente));
                return nEntradaPendientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<NotaEntrada>> notaEntradas(int idSucursal, int idAlmacen, int idPersonal,  int estado, int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/nentrada/sucursal/0/almacen/0/personal/0/estado/0/1/30
                RootObject<NotaEntrada> rootData = await webService.GET<RootObject<NotaEntrada>>("nentrada", String.Format("sucursal/{0}/almacen/{1}/personal/{2}/estado/{3}/{4}/{5}", idSucursal, idAlmacen, idPersonal, estado, page, items));
                return rootData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> eliminar(NotaEntrada currentNotaEntrada)
        {
            throw new NotImplementedException();
        }

        public Task<Response> anular(NotaEntrada currentNotaEntrada)
        {
            throw new NotImplementedException();
        }
    }
}
