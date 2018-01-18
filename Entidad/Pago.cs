using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pago
    {
        public string valorTotal { get; set; }
        public string valorPagado { get; set; }
        public string saldo { get; set; }
        public string motivo { get; set; }
        public string numeroDocumento { get; set; }
        public string simbolo { get; set; }
        public string moneda { get; set; }
    }
}
