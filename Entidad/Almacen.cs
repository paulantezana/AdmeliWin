﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Almacen
    {
        public int idAlmacen { get; set; }
        public string nombre { get; set; }
        public int idPersonalAlmacen { get; set; }
        public bool principal { get; set; }
    }
}
