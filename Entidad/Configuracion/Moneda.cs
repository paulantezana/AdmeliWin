using Entidad.Util;
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
        public int idPersonal { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }

        public string tieneRegistros { get; set; }
    }
}
