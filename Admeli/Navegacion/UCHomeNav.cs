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
using Admeli.Componentes;
using Entidad.Configuracion;

namespace Admeli.Navegacion
{
    public partial class UCHomeNav : UserControl
    {
        private FormPrincipal formPrincipal;
        private ConfigModel confiModel = new ConfigModel();

        public UCHomeNav()
        {
            InitializeComponent();
        }

        public UCHomeNav(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void UCHomeNav_Load(object sender, EventArgs e)
        {
            /*lblApellidoPersonal.Text = PersonalModel.personal.apellidos;
            lblDniPersonal.Text = PersonalModel.personal.numeroDocumento;
            lblNombrePersonal.Text = PersonalModel.personal.nombres;
            lblUsuarioPersonal.Text = PersonalModel.personal.usuario;
            */

            // Configuracion
           /* int x = 20, y = 40;
            foreach (TipoCambioMoneda item in ConfigModel.tipoCambioMonedas)
            {
                y += 20;
                element(String.Format("{0} : {1:0.00}", item.moneda, item.cambio), x, y);
            }*/
        }

        private void element(string textContent, int x, int y)
        {
            /*Label label = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(x, y),
                Name = "lbl" + textContent,
                Size = new System.Drawing.Size(64, 91),
                TabIndex = 39,
                Text = textContent
            };*/
           // this.panelCambio.Controls.Add(label);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
           // drawShape.bottomLine(panel1);
        }

        private void btnVentaShorkout_Click(object sender, EventArgs e)
        {

        }
    }
}
