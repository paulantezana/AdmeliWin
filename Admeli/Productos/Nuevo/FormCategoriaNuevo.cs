using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admeli.Productos.Nuevo
{
    public partial class FormCategoriaNuevo : Form
    {
        private CategoriaModel categoriaModel = new CategoriaModel();
        private Categoria categoria = new Categoria();

        public FormCategoriaNuevo()
        {
            InitializeComponent();
        }

        private void FormCategoriaNuevo_Load(object sender, EventArgs e)
        {
            cargarComponentes1();
            chkActivoCat.Checked = true;
        }

        private async void cargarComponentes1()
        {
            cbxCatPadre.DataSource = await categoriaModel.categorias21();
            cbxCatPadre.DisplayMember = "nombreCategoria";
            cbxCatPadre.ValueMember = "idCategoria";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarObjeto();
            guardar();
        }

        private async void guardar()
        {
            await categoriaModel.guardar(categoria);
            this.Close();
        }

        private void cargarObjeto()
        {
            categoria.nombreCategoria = textNombreCat.Text;
            categoria.idPadreCategoria = Convert.ToInt32(cbxCatPadre.SelectedValue);
            categoria.padre = cbxCatPadre.SelectedText;
            categoria.ordenVisualizacionProductos = Convert.ToInt32(cbxOrdenVisual.SelectedValue);
            categoria.mostrarProductosEn = Convert.ToInt32(cbxMostrarEn.SelectedValue);
            categoria.numeroColumnas = (textNumeroColumna.Text != "") ? Convert.ToInt32(textNumeroColumna.Text) : 1;
            categoria.tituloCategoriaSeo = textTituloCat.Text;
            categoria.urlCategoriaSeo = textUrlCat.Text;
            categoria.metaTagsSeo = textTagCat.Text;
            categoria.cabeceraPagina = textCabeceraTag.Text;
            categoria.piePagina = textPieCat.Text;
            categoria.orden = (textOrden.Text != "") ? Convert.ToInt32(textOrden.Text) : 0;
            categoria.estado = Convert.ToInt32(chkActivoCat.Checked);
            categoria.mostrarWeb = Convert.ToInt32(chkMostrarWeb.Checked);
        }
    }
}
