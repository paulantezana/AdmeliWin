﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class GrupoCliente
    {
        public int idGrupoCliente { get; set; }
        public string nombreGrupo { get; set; }
        public string descripcion { get; set; }
        public int minimoOrden { get; set; }
        public int estado { get; set; }
        public bool enUso { get; set; }
    }
}
