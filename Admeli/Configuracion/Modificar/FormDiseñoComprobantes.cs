using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad.Configuracion;
using Newtonsoft.Json;
using Entidad.Configuracion;
using System.Globalization;
using Bunifu.Framework.UI;
namespace Admeli.Configuracion.Modificar
{
    public partial class FormDiseñoComprobantes : Form
    {
        DiseñoDocumento diseño;
        List<FormatoDocumento>  formato;
        String json;

        Image imagen;
        Label documentoCliente, nombre, fechaEmision, direccionCliente;
        Label serieCorrelativo, nombreEmpresa, direccionEmpresa, nombreDocumento;
        Label impuesto, subTotal, textoTotal, total;

        List<vineta> vinetas = new List<vineta>();
        List<Label> listLabel = new List<Label>();
        DataGridView detalle=new DataGridView();
        string codigoProducto, nombreCombinacion, cantidad, nombrePresentacion,
                descripcion, nombreMarca, PrecioUnitario, descuento;
        
        
        public FormDiseñoComprobantes()
        {
            InitializeComponent();
            detalle.ColumnCount = 8;
        }
        public FormDiseñoComprobantes(DiseñoDocumento diseño)
        {
            InitializeComponent();
            this.diseño = diseño;
            detalle.ColumnCount = 8;
            crearLabels();
            formato =JsonConvert.DeserializeObject<List<FormatoDocumento>>(this.diseño.formatoDocumento);
            if(formato!=null)
                agregarElementos();
            cargarNoSeleccionados();
        }

        private void  crearLabels()
        {
            
            // verde

            vineta aux = new vineta();
            aux.label.Text = "Descripción Empresa";
            aux.nombre= "Descripción Empresa";
            vinetas.Add(aux);

            aux = new vineta();
            aux.label.Text = "Nombre/Razón Cliente";
            aux.nombre = "Nombre/Razón Cliente";
            vinetas.Add(aux);

            aux = new vineta();
            aux.label.Text = "Fecha Emision";
            aux.nombre = "Fecha Emision";
            vinetas.Add(aux);

            aux = new vineta();
            aux.label.Text = "Dirección Cliente";
            aux.nombre = "Dirección Cliente";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Documento Cliente";
            aux.nombre = "Documento Cliente";
            vinetas.Add(aux);

            /*
            nombre = new Label();
            nombre.Text = "Nombre/Razón Cliente";


            fechaEmision = new Label();
            fechaEmision.Text = "Fecha Emision";

            direccionCliente = new Label();
            direccionCliente.Text = "Direccion Cliente";*/


            // anaranjado

            aux = new vineta();
            aux.label.Text = "Serie-Correlativo";
            aux.nombre = "Serie-Correlativo";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Nombre Empresa";
            aux.nombre = "Nombre Empresa";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Dirección Empresa";
            aux.nombre = "Dirección Empresa";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Nombre Empresa";
            aux.nombre = "Nombre Empresa";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Documento Empresa";
            aux.nombre = "Documento Empresa";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Nombre Documento";
            aux.nombre = "Nombre Documento";
            vinetas.Add(aux);



            /*
            serieCorrelativo = new Label();
            serieCorrelativo.Text = "Serie Correlativo";
            nombreEmpresa = new Label();
            nombreEmpresa.Text = "nombre Empresa";
            direccionEmpresa = new Label();
            direccionEmpresa.Text = "Direccion Empresa";
            nombreDocumento = new Label();
            nombreEmpresa.Text = "Nombre Empresa";
            */

            //celeste
            aux = new vineta();
            aux.label.Text = "Impuesto";

            //aux.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseDown);
            aux.nombre = "Impuesto";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Sub Total";
            aux.nombre = "Sub Total";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Texto Total";
            aux.nombre = "Texto Total";
            vinetas.Add(aux);
            aux = new vineta();
            aux.label.Text = "Total";
            aux.nombre = "Total";
            vinetas.Add(aux);
            /*
            impuesto = new Label();
            impuesto.Text = "Impuesto";
            subTotal = new Label();
            subTotal.Text = "Sub Total";
            textoTotal = new Label();
            textoTotal.Text = "Texto Total";
            total = new Label();
            total.Text = "Total";

            */

        }
        private void agregarElementos()
        {
            //dataGridView2.Columns.Add(“Nombre_columna”, “Texto_a_mostrar_en_el_Grid”);
            foreach ( FormatoDocumento doc in formato)
            {
                string tipo = doc.tipo;
               switch (tipo)
                {
                    case "Label":
                        vineta aux=buscarVineta(doc.value);
                        aux.label.Text = doc.value;
                        aux.usado = true;
                        aux.nombre = doc.value;
                        aux.label.AutoSize = true;
                        // string colorcode = form.color;
                        //int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                        aux.label.BackColor = System.Drawing.Color.Fuchsia;
                        aux.label.Location = new System.Drawing.Point(doc.x, doc.y);
                        aux.label.Size = new System.Drawing.Size((int)doc.w, (int)doc.h);
                        aux.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseDown);
                        aux.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseMove);
                        aux.label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseUp);




                        aux.label.TabIndex = 5;
                        aux.label.AutoSize = true;
                        this.panel4.Controls.Add(aux.label);

                        
                     break;
                    case "ListGridField":
                        break;
                    case "":
                        break;

                }
                
            }
        }

        private void cargarNoSeleccionados()
        {
            int Y = 300;
            foreach(vineta v in vinetas)
            {
                if (!v.usado)
                {
                    Button bunifuThinButton21 = new Button();
                   
                    bunifuThinButton21.BackColor = System.Drawing.Color.LightGray;
                    bunifuThinButton21.Text =v.nombre;
                    bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
                    bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue;
                    bunifuThinButton21.FlatAppearance.BorderColor = Color.SlateGray;
                    bunifuThinButton21.FlatStyle= System.Windows.Forms.FlatStyle.Flat;
                    bunifuThinButton21.Location = new System.Drawing.Point(20, Y);
                    bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);           
                    bunifuThinButton21.Size = new System.Drawing.Size(150,30);
                    bunifuThinButton21.TabIndex = 0;
                    bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Y += 33;
                    this.panel1.Controls.Add(bunifuThinButton21);

                }

            } 
            
        }

        private vineta buscarVineta(string buscar)
        {

            foreach(vineta v in vinetas)
            {
                if (buscar == v.nombre)
                {
                    return v;
                }

            }
            return null;
        }
        private void FormDiseñoComprobantes_Load(object sender,EventArgs e)
        {
            
        }

        private void vineta_MouseDown(object sender, MouseEventArgs e)
        {

            Label label = sender as Label;
            vineta aux=buscarVineta(label.Text);
            aux.posicionX = e.X;
            aux.posicionY = e.Y;
            aux.mover = true;


            
    
        }
        private void vineta_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            vineta aux = buscarVineta(label.Text);
            if (aux.mover)
            {
                aux.label.Location = new Point(aux.label.Location.X + e.X - aux.posicionX, aux.label.Location.Y + e.Y - aux.posicionY);

                this.Refresh();

            }
        }

    

        private void vineta_MouseUp(object sender, EventArgs e)
        {
            Label label = sender as Label;
            vineta aux = buscarVineta(label.Text);

            aux.mover = false;
        }


    }
}
