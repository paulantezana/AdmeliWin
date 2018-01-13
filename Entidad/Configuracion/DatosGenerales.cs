﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Configuracion
{
    public class DatosGenerales
    {
        public int idDatosGenerales { get; set; }
        public string razonSocial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string logoEmpresa { get; set; }
        public string email { get; set; }
        public string cuentaBancaria { get; set; }
        public int estado { get; set; }
        public int idUbicacionGeografica { get; set; }
    }
}
