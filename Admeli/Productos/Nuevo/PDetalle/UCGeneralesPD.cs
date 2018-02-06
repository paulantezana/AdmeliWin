﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admeli.Componentes;
using Modelo;
using Entidad;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class UCGeneralesPD : UserControl
    {
        public UnidadMedidaModel unidadMedidaModel = new UnidadMedidaModel();
        public MarcaModel marcaModel = new MarcaModel();
        public ProductoModel productoModel = new ProductoModel();

        private bool isFieldsValid { get; set; }
        public bool lisenerKeyEvents { get; internal set; }
        private FormProductoNuevo formProductoNuevo;

        public UCGeneralesPD()
        {
            InitializeComponent();
        }

        public UCGeneralesPD(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
        }

        #region ================================ Root Load ================================
        private void UCGeneralesPD_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        internal void reLoad()
        {
            cargarMarcas();
            cargarUnidadesMedida();
            cargarDatosModificar();
        }
        #endregion

        private void cargarDatosModificar()
        {
            if (formProductoNuevo.nuevo) return;

            textNombreProducto.Text = formProductoNuevo.currentProducto.nombreProducto;
            textCodigoProducto.Text = formProductoNuevo.currentProducto.codigoProducto;
            textPrecioCompra.Text = formProductoNuevo.currentProducto.precioCompra;
            textDescripcion.Text = formProductoNuevo.currentProducto.descripcionCorta;
            isFieldsValid = true;
        }


        #region ============================= Loads =============================
        internal async void cargarMarcas()
        {
            formProductoNuevo.appLoadState(true);
            marcaBindingSource.DataSource = await marcaModel.marcas();
            if (!formProductoNuevo.nuevo) cbxMarcas.SelectedValue = formProductoNuevo.currentProducto.idMarca;
            formProductoNuevo.appLoadState(false);
        }
        internal async void cargarUnidadesMedida()
        {
            formProductoNuevo.appLoadState(true);
            unidadMedidaBindingSource.DataSource = await unidadMedidaModel.unimedidas();
            if (!formProductoNuevo.nuevo) cbxUnidadMedida.SelectedValue = formProductoNuevo.currentProducto.idUnidadMedida;
            formProductoNuevo.appLoadState(false);
        }
        #endregion

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panelHeader);
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            FormMarcaNuevo formMarca = new FormMarcaNuevo();
            formMarca.ShowDialog();
            this.cargarMarcas();
        }

        private void btnAddUnidadMedida_Click(object sender, EventArgs e)
        {
            FormUnidadMedidaNuevo formUnidad = new FormUnidadMedidaNuevo();
            formUnidad.ShowDialog();
            this.cargarUnidadesMedida();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormElegirCategoria formElegir = new FormElegirCategoria();
            formElegir.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            // Validando los campos
            if (!isFieldsValid)
            {
                MessageBox.Show("Datos incorrectos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ejecutando el guardado
            cargarObjeto();

            // Ejecutando el gurdado
            formProductoNuevo.executeGuardar();
        }

        private void cargarObjeto()
        {
            if(formProductoNuevo.nuevo) formProductoNuevo.currentProducto = new Producto();
           // if (!formProductoNuevo.nuevo) formProductoNuevo.currentProducto.idProducto = 1; // Llenar el id categoria cuando este en esTAdo modificar
            if (formProductoNuevo.nuevo)
            {
                formProductoNuevo.currentProducto.cantidadFraccion = false;
                formProductoNuevo.currentProducto.codigoBarras = "";
                formProductoNuevo.currentProducto.controlSinStock = "sin_stock";

                formProductoNuevo.currentProducto.descripcionLarga = "";

                formProductoNuevo.currentProducto.enCategoriaEstrella = false;
                formProductoNuevo.currentProducto.enPortada = false;
                formProductoNuevo.currentProducto.enUso = false;

                formProductoNuevo.currentProducto.keywords = "";

                formProductoNuevo.currentProducto.limiteMaximo = "0";
                formProductoNuevo.currentProducto.limiteMinimo = "0";
                formProductoNuevo.currentProducto.mostrarPrecioWeb = true;
                formProductoNuevo.currentProducto.mostrarVideo = true;
                formProductoNuevo.currentProducto.mostrarWeb = true;

                formProductoNuevo.currentProducto.urlVideo = "";
                formProductoNuevo.currentProducto.ventaVarianteSinStock = false;
            }

            formProductoNuevo.currentProducto.codigoProducto = textCodigoProducto.Text;
            formProductoNuevo.currentProducto.descripcionCorta = textDescripcion.Text;

            formProductoNuevo.currentProducto.estado = chkActivoProducto.Checked;
            formProductoNuevo.currentProducto.idMarca = Convert.ToInt32(cbxMarcas.SelectedValue);
            formProductoNuevo.currentProducto.idUnidadMedida = Convert.ToInt32(cbxUnidadMedida.SelectedValue);

            formProductoNuevo.currentProducto.nombreMarca = cbxMarcas.Text;
            formProductoNuevo.currentProducto.nombreProducto = textNombreProducto.Text;
            formProductoNuevo.currentProducto.nombreUnidad = cbxUnidadMedida.Text;

            formProductoNuevo.currentProducto.precioCompra = Convert.ToDouble(textPrecioCompra.Text);
        }

        #region ================================ Validation ===============================
        /**
         * ======================================================================
         *  ---- Funciones de las validacion por cada campo
         * 
         * */

        private void validarPrecio()
        {
            if (textPrecioCompra.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textPrecioCompra, false);
                errorProvider1.SetError(textPrecioCompra, "Campo obligatorio");
                this.isFieldsValid = false;
                return;
            }
            Validator.textboxValidateColor(textPrecioCompra, true);
            errorProvider1.Clear();
            this.isFieldsValid = true;
        }

        private async void validarProductoNombreCodigo()
        {
            // Validando si el campo esta vacia
            if (textNombreProducto.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textNombreProducto, false);
                errorProvider1.SetError(textNombreProducto, "Campo obligatorio");
                this.isFieldsValid = false;
                return;
            }

            // Creando el objeto para enviar
            Producto np = new Producto();
            np.nombre = textNombreProducto.Text;
            np.idProducto = (formProductoNuevo.nuevo) ? 0 : formProductoNuevo.currentProducto.idProducto;

            // validando si el codigo del producto existe
            List<Producto> list = await productoModel.validarProducto(np);
            if (list.Count > 0)
            {
                errorProvider1.SetError(textNombreProducto, "Ya existe un producto con el mismo nombre.");
                Validator.textboxValidateColor(textNombreProducto, false);
                this.isFieldsValid = false;
                return;
            }

            // Dando el formato adecuado cuando paso toda las validaciones
            Validator.textboxValidateColor(textNombreProducto, true);
            errorProvider1.Clear();
            this.isFieldsValid = true;
        }

        private async void validarProductoNombre()
        {
            // Validando si el campo esta vacia
            if (textNombreProducto.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textNombreProducto, false);
                errorProvider1.SetError(textNombreProducto, "Campo obligatorio");
                this.isFieldsValid = false;
                return;
            }

            // Creando el objeto para enviar
            Producto np = new Producto();
            np.nombre = textNombreProducto.Text;
            np.idProducto = (formProductoNuevo.nuevo) ? 0 : formProductoNuevo.currentProducto.idProducto;

            // validando si el codigo del producto existe
            List<Producto> list = await productoModel.validarProducto(np);
            if (list.Count > 0)
            {
                errorProvider1.SetError(textNombreProducto, "Ya existe un producto con el mismo nombre.");
                Validator.textboxValidateColor(textNombreProducto, false);
                this.isFieldsValid = false;
                return;
            }

            // Dando el formato adecuado cuando paso toda las validaciones
            Validator.textboxValidateColor(textNombreProducto, true);
            errorProvider1.Clear();
            this.isFieldsValid = true;
        }

        private async void validarProductoCodigo()
        {

            // Validando si el campo esta vacia
            if (textCodigoProducto.Text.Trim() == "")
            {
                Validator.textboxValidateColor(textCodigoProducto, false);
                errorProvider1.SetError(textCodigoProducto, "Campo obligatorio");
                this.isFieldsValid = false;
                return;
            }

            // Creando el objeto para enviar
            Producto np = new Producto();
            np.codigo = textCodigoProducto.Text;
            np.idProducto = (formProductoNuevo.nuevo) ? 0 : formProductoNuevo.currentProducto.idProducto;

            // validando si el codigo del producto existe
            List<Producto> list = await productoModel.validarProducto(np);
            if (list.Count > 0)
            {
                errorProvider1.SetError(textCodigoProducto, "Ya existe un producto con el mismo código.");
                Validator.textboxValidateColor(textCodigoProducto, false);
                this.isFieldsValid = false;
                return;
            }

            // Dando el formato adecuado cuando paso toda las validaciones
            Validator.textboxValidateColor(textCodigoProducto, true);
            errorProvider1.Clear();
            this.isFieldsValid = true;
        }

        /**
         * ======================================================================
         *  ---- Eventos de las validaciones en timepo real
         * 
         * */
        private void textCodigoProducto_Validated(object sender, EventArgs e)
        {
            validarProductoCodigo();
        }

        private void textNombreProducto_Validated(object sender, EventArgs e)
        {
            validarProductoNombre();
        }

        private void textPrecioCompra_Validated(object sender, EventArgs e)
        {
            validarPrecio();
        }

        private void textPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }  
        #endregion
    }
}
