using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCAdicionalPD : UserControl
    {
        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCAdicionalPD()
        {
            InitializeComponent();
        }

        public UCAdicionalPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        internal void reLoad()
        {
            //throw new NotImplementedException();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.topLine(panelHeader);
        }

        private void UCAdicionalPD_Paint(object sender, PaintEventArgs e)
        {
            int containerWidth = this.Size.Width;
            int itemWidth = containerWidth / 2;
            panelItem1.Size = new Size(itemWidth, 100);
        }

        #region ================================== CRUD ALL DATAGRD VIEW ==================================
        private void btnNuevoPrecentacion_Click(object sender, EventArgs e)
        {
            this.executeNuevoPrecentacion();
        }

        private void btnModificarPrecentacion_Click(object sender, EventArgs e)
        {
            this.executeModificarPrecentacion();
        }

        private void btnAnularPrecentacion_Click(object sender, EventArgs e)
        {
            this.executeAnularPrecentacion();
        }

        private void btnActualizarPrcentacion_Click(object sender, EventArgs e)
        {
            this.executeActualizarPrecentacion();
        }

        private void btnNuevoVariante_Click(object sender, EventArgs e)
        {
            this.executeNuevoVariante();
        }

        private void btnModificarVariante_Click(object sender, EventArgs e)
        {
            this.executeModificarVariante();
        }

        private void btnAnularVariante_Click(object sender, EventArgs e)
        {
            this.executeAnularVariante();
        }

        private void btnActualizarVariante_Click(object sender, EventArgs e)
        {
            this.executeActualizarVariante();
        }

        private void btnNuevoAlternativa_Click(object sender, EventArgs e)
        {
            this.executeNuevoAlternativa();
        }

        private void btnModificarAlternativa_Click(object sender, EventArgs e)
        {
            this.executeModificarAlternativa();
        }

        private void btnAnularAlternativa_Click(object sender, EventArgs e)
        {
            this.executeAnularAlternativa();
        }

        private void btnActualizarAlternativa_Click(object sender, EventArgs e)
        {
            this.executeActualizarAlternativa();
        }

        private void executeNuevoPrecentacion()
        {
            throw new NotImplementedException();
        }

        private void executeModificarPrecentacion()
        {
            throw new NotImplementedException();
        }

        private void executeAnularPrecentacion()
        {
            throw new NotImplementedException();
        }

        private void executeActualizarPrecentacion()
        {
            throw new NotImplementedException();
        }

        private void executeNuevoVariante()
        {
            throw new NotImplementedException();
        }

        private void executeModificarVariante()
        {
            throw new NotImplementedException();
        }

        private void executeAnularVariante()
        {
            throw new NotImplementedException();
        }

        private void executeActualizarVariante()
        {
            throw new NotImplementedException();
        }

        private void executeNuevoAlternativa()
        {
            throw new NotImplementedException();
        }

        private void executeModificarAlternativa()
        {
            throw new NotImplementedException();
        }

        private void executeAnularAlternativa()
        {
            throw new NotImplementedException();
        }

        private void executeActualizarAlternativa()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
