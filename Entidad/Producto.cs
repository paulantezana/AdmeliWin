using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string codigoProducto { get; set; }
        public string descripcionCorta { get; set; }
        public string precioCompra { get; set; }
        public int estado { get; set; }
        public int idUnidadMedida { get; set; }
        public int idMarca { get; set; }
        public string nombreUnidad { get; set; }
        public string nombreMarca { get; set; }
        public bool enUso { get; set; }
        public bool mostrarWeb { get; set; }
        public bool mostrarPrecioWeb { get; set; }
    }
}
