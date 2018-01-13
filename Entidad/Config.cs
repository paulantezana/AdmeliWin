using Entidad.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Config
    {
        // DATOS GENERALES
        // SUCURSALES PERSONA
        // ASIGNACION PERSONAL
        // CONFIGURACION GENERAL
        // MONEDAS
        // TIPOS DE CAMBIOS
        public DatosGenerales datosGenerales { get; set; }
        public Sucursal sucursal { get; set; }
        public AsignacionPersonal asignacionPersonal { get; set; }
        public ConfiguracionGeneral configuracionGeneral { get; set; }
        public List<Moneda> monedas { get; set; }
        public List<TipoCambioMoneda> tipoCambioMoneda { get; set; }
    }
}
