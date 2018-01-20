﻿using Entidad;
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

        public async  Task<Response> guardar(Categoria param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/categorias/guardar
                return await webService.POSTSend("categorias", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> modificar(Categoria param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/categorias/modificar
                return await webService.POSTSend("categorias", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> desactivar(Categoria param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/categoria/desactivar
                return await webService.POSTSend("categoria", "desactivar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Response> eliminar(Categoria param)
        {
            try
            {
                // localhost:8080/admeli/xcore2/xcore/services.php/categorias/eliminar
                return await webService.POSTSend("categorias", "eliminar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public async Task<List<Categoria>> categorias21(int estado = 1)
        {
            try
            {
                // www.lineatienda.com/services.php/categorias21/-1
                List<Categoria> categorias = await webService.GETLis<Categoria>("categorias21", "-1");
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
