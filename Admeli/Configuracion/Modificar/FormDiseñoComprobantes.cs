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

        Label aux;
        PictureBox cuadro;
        List<vineta> vinetas = new List<vineta>();
        List<Label> listLabel = new List<Label>();
        List<vineta> listGridField = new List<vineta>();

        DataGridView detalle; 
        bool moverCuadro = false;
        int posicionX, posicionY;
        public FormDiseñoComprobantes()
        {
            InitializeComponent();
            detalle.ColumnCount = 8;
        }
        public FormDiseñoComprobantes(DiseñoDocumento diseño)
        {

            InitializeComponent();
            detalle = new DataGridView();
            this.diseño = diseño;
            cuadro = new PictureBox();
            crearLabels();
            crearListGrid();

            
            formato =JsonConvert.DeserializeObject<List<FormatoDocumento>>(this.diseño.formatoDocumento);
            if(formato!=null)
                agregarElementos();
            cargarNoSeleccionados();
            designarEventos();
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

        private void crearListGrid()
        {
            vineta aux = new vineta();
            aux.label.Text = "codigoProducto";
            aux.nombre = "codigoProducto";
            listGridField.Add(aux);

            aux = new vineta();
            aux.label.Text = "nombreCombinacion";
            aux.nombre = "nombreCombinacion";
            listGridField.Add(aux);
            aux = new vineta();
            aux.label.Text = "cantidad";
            aux.nombre = "cantidad";
            listGridField.Add(aux);
            aux = new vineta();
            aux.label.Text = "nombrePresentacion";
            aux.nombre = "nombrePresentacion";
            listGridField.Add(aux);
            aux = new vineta();
            aux.label.Text = "descripcion";
            aux.nombre = "descripcion";
            listGridField.Add(aux);
            aux = new vineta();
            aux.label.Text = "nombreMarca";
            aux.nombre = "nombreMarca";
            listGridField.Add(aux);

            aux = new vineta();
            aux.label.Text = "precioUnitario";
            aux.nombre = "precioUnitario";
            listGridField.Add(aux);

            aux = new vineta();
            aux.label.Text = "descuento";
            aux.nombre = "descuento";
            listGridField.Add(aux);
            aux = new vineta();
            aux.label.Text = "total";
            aux.nombre = "total";
            listGridField.Add(aux);



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
                        vineta aux=buscarVineta(doc.value,vinetas);
                        aux.label.Text = doc.value;
                        aux.usado = 3;
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
                    case "ListGrid":


                        detalle.Location = new Point(doc.x, doc.y);
                        detalle.Size = new Size((int)doc.w, (int)doc.h);
                        detalle.Name = doc.formato;
                        this.panel4.Controls.Add(detalle);
                        break;
                    case "ListGridField":
                        vineta aux1 = buscarVineta(doc.formato, listGridField);
                        aux1.usado =3;
                        detalle.Columns.Add(doc.formato,doc.value);
                        break;
                    case "Img":

                        // \Recursos\Darck

                        string imagen = "E:\\code\\AdmeliWin\\Recursos\\Darck\\box_gray_icon.png";
                        cuadro.Image = Image.FromFile(imagen);
                        cuadro.Location = new Point(doc.x, doc.y);
                        cuadro.BackColor = Color.Green;

                       
                        cuadro.Size = new Size((int)doc.w, (int)doc.h);
                        cuadro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseDown);
                        cuadro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseMove);
                        cuadro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadro_MouseUp);
                        this.panel4.Controls.Add(cuadro);
                      
                        break;


                }
                
            }
        }

        private void cargarNoSeleccionados()
        {
            int Y = 10;
            foreach (vineta v1 in listGridField)
            {
                
                    Button bunifuThinButton21 = new Button();

                    bunifuThinButton21.BackColor = v1.usado == 3 ?System.Drawing.Color.LightGray: System.Drawing.Color.LightSlateGray;
                    v1.usado = 1;
                    bunifuThinButton21.Text = v1.nombre;
                    bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
                    bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 7.5f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue;
                    bunifuThinButton21.FlatAppearance.BorderColor = Color.SlateGray;
                    bunifuThinButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    bunifuThinButton21.Location = new System.Drawing.Point(20, Y);
                    bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
                    bunifuThinButton21.Size = new System.Drawing.Size(160, 30);
                    bunifuThinButton21.TabIndex = 5;
                    bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Y += 33;
                    this.panel1.Controls.Add(bunifuThinButton21);
            }

            Y += 10;
            foreach(vineta v in vinetas)
            {
                if (v.usado!=3)
                {
                    Button bunifuThinButton21 = new Button();
                    v.usado = -1;
                    bunifuThinButton21.BackColor = System.Drawing.Color.LightGray;
                    bunifuThinButton21.Text =v.nombre;
                    bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
                    bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 7.5f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue;
                    bunifuThinButton21.FlatAppearance.BorderColor = Color.SlateGray;
                    bunifuThinButton21.FlatStyle= System.Windows.Forms.FlatStyle.Flat;
                    bunifuThinButton21.Location = new System.Drawing.Point(20, Y);
                    bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);           
                    bunifuThinButton21.Size = new System.Drawing.Size(160,30);
                    bunifuThinButton21.TabIndex = 5;
                    bunifuThinButton21.BringToFront();
                    bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Y += 33;
                    this.panel1.Controls.Add(bunifuThinButton21);

                }

            }
            
        }

        private vineta buscarVineta(string buscar,List<vineta> listVineta)
        {

            foreach(vineta v in listVineta)
            {
                if (buscar == v.nombre)
                {
                    return v;
                }

            }
            return null;
        }


        private void designarEventos()
        {
            foreach(Control c in this.panel1.Controls)
            {
                Button c1 = c as Button;
                vineta aux=buscarVineta(c1.Text, vinetas);
                if (aux == null)
                {
                    aux=buscarVineta(c1.Text, listGridField);
                }
                if (aux.usado == 1)
                {
                    c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.field_MouseDown);
                    c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.field_MouseMove);
                    c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.field_MouseUp);
                }
                else
                    if (aux.usado == -1)
                        {
                            c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labels_MouseDown);
                            c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labels_MouseMove);
                            c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labels_MouseUp);
                        }
                    

                //listGripfield
                
            }
        }


        private void FormDiseñoComprobantes_Load(object sender,EventArgs e)
        {
            
        }

        private void vineta_MouseDown(object sender, MouseEventArgs e)
        {

            Label label = sender as Label;
            vineta aux=buscarVineta(label.Text,vinetas);
            aux.posicionX = e.X;
            aux.posicionY = e.Y;
            aux.mover = true;


            
    
        }
        private void vineta_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            vineta aux = buscarVineta(label.Text, vinetas);
            if (aux.mover)
            {
                aux.label.Location = new Point(aux.label.Location.X + e.X - aux.posicionX, aux.label.Location.Y + e.Y - aux.posicionY);

                this.Refresh();

            }
        }

    

        private void vineta_MouseUp(object sender, EventArgs e)
        {
            Label label = sender as Label;
            vineta aux = buscarVineta(label.Text, vinetas);

            aux.mover = false;
        }

        private void cuadro_MouseDown(object sender , MouseEventArgs e)
        {
            moverCuadro = true;
            posicionX = e.X;
            posicionY = e.Y;

        }
   
        private void cuadro_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverCuadro)
            {
                cuadro.Location = new Point(cuadro.Location.X+e.X-posicionX,cuadro.Location.Y+e.Y-posicionY);
                Refresh();

            }

        }
        private void cuadro_MouseUp(object sender, EventArgs e)
        {
            moverCuadro = false;

        }



        private void labels_MouseDown(object sender, MouseEventArgs e)
        {
            moverCuadro = true;
            posicionX = e.X;
            posicionY = e.Y;

        }

        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            if (moverCuadro)
            {
                cuadro.Location = new Point(cuadro.Location.X + e.X - posicionX, cuadro.Location.Y + e.Y - posicionY);
                Refresh();

            }

        }
        private void labels_MouseUp(object sender, EventArgs e)
        {
            moverCuadro = false;

        }

        private void field_MouseDown(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);
            this.aux = new Label();
            this.aux.Location = new Point(c1.Location.X, c1.Location.Y);
            this.aux.Text = aux.nombre;
            aux.mover= true;
            aux.posicionX = e.X;
            aux.posicionY = e.Y;
            c1.Cursor = Cursors.Hand;

        }

        private void field_MouseMove(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);
            if (aux.mover)
            {
                this.aux.Location = new Point(this.aux.Location.X + e.X - posicionX, this.aux.Location.Y + e.Y - posicionY);
                Refresh();

            }
           

        }
        private void field_MouseUp(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);


           // cuadro.Location = new Point(cuadro.Location.X + e.X - posicionX, cuadro.Location.Y + e.Y - posicionY);



            if (esta(panel4.Location.X, panel4.Location.Y, e.X, e.Y))
            {
                
                
                this.aux.BackColor = Color.Black;
                panel4.Controls.Add(this.aux);
            }
            

            aux.mover = false;

        }
        private bool esta(int x1 , int y1 ,int posicionX, int posicionY)
        {
           
            if (posicionX>= x1 ||posicionY >= y1)
                return true;
            return false;
        }

    }
}
