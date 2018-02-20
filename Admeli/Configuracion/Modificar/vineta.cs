using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Configuracion.Modificar
{
    class vineta
    {
        public Label label { get; set; }
        public string nombre { get; set; }
        public bool usado { get; set; }
        public int posicionX { get; set; }
        public int posicionY { get; set; }
        public bool mover { get; set; }
        public vineta()
        {
            this.usado = false;
            label = new Label();
            mover = false;

        }
    }
}
