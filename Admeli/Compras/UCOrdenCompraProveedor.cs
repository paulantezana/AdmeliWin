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
using Admeli.Compras.Nuevo;
using Modelo;
using Entidad;
using Newtonsoft.Json;

namespace Admeli.Compras
{
    public partial class UCOrdenCompraProveedor : UserControl
    {
        private OrdenCompraModel ordenCompraModel = new OrdenCompraModel();
        private Paginacion paginacion;

        public UCOrdenCompraProveedor()
        {
            InitializeComponent();
            paginacion = new Paginacion(Convert.ToInt32(lblCurrentPage.Text), Convert.ToInt32(lblSteepPages.Text));
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.lineBorder(panelContainer);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCompraProveedorNuevo compraProveedorNuevo = new FormCompraProveedorNuevo();
            compraProveedorNuevo.ShowDialog();
        }

        private void UCOrdenCompraProveedor_Load(object sender, EventArgs e)
        {
            cargarRegistros();
        }

        private void loadState(bool state)
        {
            toolStripNavigation.Enabled = !state;
            toolStripCrud.Enabled = !state;
            toolStripTools.Enabled = !state;
            dataGridView.Enabled = !state;
        }

        private void mostrarPaginado()
        {
            // Cargando el combobox
            lblCurrentPage.Items.Clear();
            for (int i = 1; i <= paginacion.pageCount; i++)
            {
                lblCurrentPage.Items.AddRange(new object[] { i.ToString(), i.ToString() });
            }
            lblCurrentPage.SelectedIndex = paginacion.currentPage - 1;

            // Paginados
            lblPageAllItems.Text = paginacion.itemsCount.ToString();
            lblPageCount.Text = paginacion.pageCount.ToString();
        }

        private async void cargarRegistros()
        {
            loadState(true);
            try
            {

                dynamic response = await ordenCompraModel.getData(paginacion.currentPage.ToString(), paginacion.speed.ToString());

                // Enviando la cantidad de registros al objeto paginacion
                paginacion.itemsCount = response.nro_registros;
                paginacion.reload();

                List<OrdenCompra> listOrdenCompra = new List<OrdenCompra>();
                //List<OrdenCompra> list =  JsonConvert.DeserializeObject<List<OrdenCompra>>(response.datos);
                
                foreach (var item in response.datos)
                {
                    OrdenCompra ordenCompra = new OrdenCompra();
                    ordenCompra.idOrdenCompra = item.idOrdenCompra;
                    ordenCompra.serie = item.serie;
                    ordenCompra.correlativo = item.correlativo;
                    ordenCompra.nombreProveedor = item.nombreProveedor;
                    ordenCompra.rucDni = item.rucDni;
                    ordenCompra.direccionProveedor = item.direccionProveedor;
                    ordenCompra.moneda = item.moneda;
                    //ordenCompra.fecha = item.idOrdenCompra;
                    //ordenCompra.plazoEntrega = item.idOrdenCompra;
                    ordenCompra.observacion = item.observacion;
                    ordenCompra.direccion = item.direccion;
                    ordenCompra.estado = item.estado;
                    ordenCompra.idUbicacionGeografica = item.idUbicacionGeografica;
                    ordenCompra.idTipoDocumento = item.idTipoDocumento;
                    ordenCompra.idCompra = item.idCompra;
                    ordenCompra.subTotal = item.subTotal;
                    ordenCompra.total = item.total;
                    ordenCompra.idPago = item.idPago;
                    ordenCompra.idProveedor = item.idProveedor;
                    ordenCompra.estadoCompra = item.estadoCompra;
                    ordenCompra.nombres = item.nombres;

                    listOrdenCompra.Add(ordenCompra);
                }
                //JsonConvert.DeserializeObject<List<Personal>>(response.datos);
                ordenCompraBindingSource.DataSource = listOrdenCompra;
                dataGridView.Refresh();
                mostrarPaginado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                loadState(false);
            }
        }

    }
}
