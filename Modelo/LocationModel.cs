﻿using Entidad.Location;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LocationModel
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

        public async Task<UbicacionGeografica> ubicacionGeografica(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/ubigeoAtrib/2
                List<UbicacionGeografica> data = await webService.GETLis<UbicacionGeografica>("ubigeoAtrib/2");
                return data[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Pais>> paises(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/pais
                List<Pais> painsesData = await webService.GETLis<Pais>("pais");
                return painsesData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
