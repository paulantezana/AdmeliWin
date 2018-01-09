using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Entidad;

namespace Admeli.Configuracion
{
    public partial class UCPersonal : UserControl
    {
        PersonalModel personalModel = new PersonalModel();

        public UCPersonal()
        {
            InitializeComponent();
        }

        private void UCPersonal_Load(object sender, EventArgs e)
        {
            Task<List<Personal>> list = Task.Run(()=> ) personalModel.listar();
            this.personalModel.guardar();
        }
    }
}
