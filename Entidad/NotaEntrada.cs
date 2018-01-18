using Entidad.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class NotaEntrada
    {
        public int idNotaEntrada { get; set; }
        public string numeroDocumento { get; set; }
        public Fecha fecha { get; set; }
        public string nombreAlmacen { get; set; }
        public object numeroDocumentoCompra { get; set; }
        public object nombreProveedor { get; set; }
    }
}
