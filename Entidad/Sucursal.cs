﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Sucursal
    {
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public bool principal { get; set; }
        public int idUbicacionGeografica { get; set; }
    }
}