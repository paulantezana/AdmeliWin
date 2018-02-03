﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Modelo;

namespace Admeli.Productos.Nuevo.PDetalle
{
    public partial class FormPresentacionNuevo : Form
    {
        private int currentIDPresentacion { get; set; }
        private bool nuevo { get; set; }

        private Presentacion currentPresentacion { get; set; }
        private PresentacionModel presentacionModel = new PresentacionModel();
        private FormProductoNuevo formProductoNuevo;

        #region ============================== Constructor ==============================
        public FormPresentacionNuevo()
        {
            InitializeComponent();
        }

        public FormPresentacionNuevo(FormProductoNuevo formProductoNuevo)
        {
            InitializeComponent();
            this.formProductoNuevo = formProductoNuevo;
            this.nuevo = true;
        }

        public FormPresentacionNuevo(FormProductoNuevo formProductoNuevo, Presentacion currentPresentacion)
        {
            InitializeComponent();

            // Parametros
            this.formProductoNuevo = formProductoNuevo;
            this.currentPresentacion = currentPresentacion;
            this.currentIDPresentacion = currentPresentacion.idPresentacion;

            // Mostrando los datos modificar
            mostrarDatosModificar();

            // Cambiando el estado a modificar
            this.nuevo = false;
        } 
        #endregion


        private void mostrarDatosModificar()
        {
            textNombre.Text = currentPresentacion.nombrePresentacion;
            textSimbolo.Text = currentPresentacion.simboloPresentacion;
            textCantidad.Text = currentPresentacion.cantidadUnitaria;
            chkEstado.Checked = Convert.ToBoolean(currentPresentacion.estado);
        }

        #region ========================== SAVE AND UPDATE ===========================
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            executeGuardar();
        }

        private async void executeGuardar()
        {
            if (!validarCampos()) return;
            try
            {
                crearObjetoSucursal();
                if (nuevo)
                {
                    Response response = await presentacionModel.guardar(currentPresentacion);
                    MessageBox.Show(response.msj, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Response response = await presentacionModel.modificar(currentPresentacion);
                    MessageBox.Show(response.msj, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearObjetoSucursal()
        {
            currentPresentacion = new Presentacion();

            if (!nuevo) currentPresentacion.idPresentacion = currentIDPresentacion; // Llenar el id categoria cuando este en esdo modificar

            currentPresentacion.nombrePresentacion = textNombre.Text;
            currentPresentacion.simboloPresentacion = textSimbolo.Text;
            currentPresentacion.cantidadUnitaria = textCantidad.Text;
            currentPresentacion.estado = Convert.ToInt32(chkEstado.Checked);
            currentPresentacion.idProducto = formProductoNuevo.currentIDProducto;
        }

        private bool validarCampos()
        {
            if (textNombre.Text == "")
            {
                errorProvider1.SetError(textNombre, "Este campo esta bacía");
                textNombre.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (textSimbolo.Text == "")
            {
                errorProvider1.SetError(textSimbolo, "Este campo esta bacía");
                textSimbolo.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
