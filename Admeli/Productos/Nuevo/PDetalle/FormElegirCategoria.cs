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

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class FormElegirCategoria : Form
    {
        private CategoriaModel categoriaModel = new CategoriaModel();
        internal CategoriaProducto catProducto { get; set; }

        public FormElegirCategoria()
        {
            InitializeComponent();
        }

        private async Task cargarRegistros()
        {
            catProducto = await categoriaModel.categoriaProducto(0);
        }

        private void cargarCategorias()
        {
            List<Categoria> categoriaList = catProducto.producto;
            foreach (Categoria categoria in categoriaList)
            {
                if (categoria.idPadreCategoria > 0)
                {
                    int nodeIndex = treeViewFrom.Nodes.IndexOfKey(categoria.idPadreCategoria.ToString());
                    treeViewFrom.Nodes[nodeIndex].Nodes.Add(categoria.idCategoria.ToString(), categoria.nombreCategoria);
                    treeViewFrom.Nodes[nodeIndex].ImageIndex = 1;
                }
                else
                {
                    treeViewFrom.Nodes.Add(categoria.idCategoria.ToString(), categoria.nombreCategoria);
                }
            }
            
        }

        private void cargarCategoriasElegidas()
        {

        }

        private void FormElegirCategoria_Load(object sender, EventArgs e)
        {
            this.reLoad();
        }

        private async void reLoad()
        {
            await cargarRegistros();
            cargarCategorias();
            cargarCategoriasElegidas();
        }
    }
}
