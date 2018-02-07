﻿using Entidad.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Configuracion
{
    public class Moneda
    {
        public int idMoneda { get; set; }
        public string moneda { get; set; }
        public string simbolo { get; set; }
        public bool porDefecto { get; set; }
        public int estado { get; set; }
        public string tipoCambio { get; set; }
        public Fecha fechaCreacion { get; set; }
        public dynamic idPersonal { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tieneRegistros { get; set; }

        public DateTime fechaPago { get; set; }
        public int idCaja { get; set; }
        public int idCajaSesion { get; set; }
        public int idMedioPago { get; set; }
        public string medioPago { get; set; }
        public int monto { get; set; }
        public string motivo { get; set; }
        public string numeroOperacion { get; set; }
        public string observacion { get; set; }

    }
}
