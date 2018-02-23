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
using Entidad;
using System.Globalization;
using Bunifu.Framework.UI;
using Modelo;
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
        vineta detalleBtn;
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
            detalle.ColumnHeadersHeightSizeMode =
        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            detalle.RowHeadersVisible = false;
            this.diseño = diseño;
            cuadro = new PictureBox();
            detalleBtn = new vineta();
            detalleBtn.nombre = "Detalle";
            crearLabels();
            crearListGrid();

            
            formato =JsonConvert.DeserializeObject<List<FormatoDocumento>>(this.diseño.formatoDocumento);
            
            if (formato!=null && exitePagina())
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
                        detalleBtn.usado = 3;
                        detalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
                        detalle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseMove);
                        detalle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);

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
        private bool exitePagina()
        {
            

            for(int i= formato.Count-1; i >= 0; i--)
            {
                if (formato[i].tipo == "Pagina")
                {
                    panel4.BackColor = Color.White;
                    panel4.Width = (int)formato[i].w;
                    panel4.Height = (int)formato[i].h;
                    panel4.Location = new Point(formato[i].x, formato[i].y);
                    panel4.Name = formato[i].value;
                    
                    return true;
                }
                
            }
                return false;
        }
        private void cargarNoSeleccionados()
        {
            
            int Y = 10;
            foreach (vineta v1 in listGridField)
            {
                
                    Button bunifuThinButton21 = new Button();

                    bunifuThinButton21.BackColor = v1.usado == 3 ?System.Drawing.Color.LightGray: System.Drawing.Color.LightSlateGray;
                    v1.usado = v1.usado == 3?3:1;
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
            Y += 10;
            if (detalleBtn.usado != 3)
            {
                Button bunifuThinButton21 = new Button();
                detalleBtn.usado = 2;
                bunifuThinButton21.BackColor = System.Drawing.Color.LightGray;
                bunifuThinButton21.Text = detalleBtn.nombre;
                bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
                bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 7.5f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue;
                bunifuThinButton21.FlatAppearance.BorderColor = Color.SlateGray;
                bunifuThinButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                bunifuThinButton21.Location = new System.Drawing.Point(20, Y);
                bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
                bunifuThinButton21.Size = new System.Drawing.Size(160, 30);
                bunifuThinButton21.TabIndex = 5;
                bunifuThinButton21.BringToFront();
                bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Y += 33;
                this.panel1.Controls.Add(bunifuThinButton21);

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
                    if (aux == null)
                    {
                        aux = detalleBtn;
                    }
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
                    else {
                            c.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseDown);
                            c.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseMove);
                            c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseUp);


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
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, vinetas);

            aux.posicionX = e.X;
            aux.posicionY = e.Y;

            aux.inicialX = c1.Location.X;
            aux.inicialY = c1.Location.Y;
            c1.Cursor = Cursors.Hand;
            aux.mover = true;

        }

        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, vinetas);
            if (aux.mover)
            {
                c1.Location = new Point(c1.Location.X + e.X - posicionX, c1.Location.Y + e.Y - posicionY);
                Refresh();

            }

        }
        private void labels_MouseUp(object sender, EventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, vinetas);
            
            aux.mover = true;
           
            aux.label.BackColor = Color.Black;
            aux.label.Location = new Point(c1.Location.X - (panel3.Location.X + panel4.Location.X), c1.Location.Y - panel4.Location.Y);

            aux.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseDown);
            aux.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseMove);
            aux.label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vineta_MouseUp);


            panel4.Controls.Add(aux.label);
            aux.usado = 3;// esta en el panel1 ahora
            panel1.Controls.Remove(c1); // el boton se elimina de panel1
            c1.Location = new Point(aux.inicialX, aux.inicialY);

            aux.mover = false;

        }

        private void field_MouseDown(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);
           
            aux.posicionX = e.X;
            aux.posicionY = e.Y;

            aux.inicialX = c1.Location.X;
            aux.inicialY = c1.Location.Y;
            c1.Cursor = Cursors.Hand;
            aux.mover = true;

        }

        private void field_MouseMove(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);
            if (aux.mover)
            {
                c1.Location = new Point(c1.Location.X + e.X - posicionX, c1.Location.Y + e.Y - posicionY);
                Refresh();

            }
           

        }
        private void field_MouseUp(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            vineta aux = buscarVineta(c1.Text, listGridField);
           
                if (esta(detalle.Location.X, detalle.Width, detalle.Location.Y, detalle.Height, c1.Location.X - (panel3.Location.X + panel4.Location.X), c1.Location.Y - panel4.Location.Y))
                { if (!buscarColumna(c1.Text))
                    {
                    detalle.Columns.Add(c1.Text, c1.Text);
                    aux.usado = 3;
                    }
                }
            c1.Location = new Point(aux.inicialX,aux.inicialY);
   
            aux.mover = false;

        }
        
        private void dataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            detalleBtn.mover = true;
            detalleBtn.posicionX = e.X;
            detalleBtn.posicionY = e.Y;
            detalleBtn.inicialX = c1.Location.X;
            detalleBtn.inicialY = c1.Location.Y;
            c1.Cursor = Cursors.Hand;
            
        }
        private void dataGrid_MouseMove(object sender, MouseEventArgs e)
        {

            Button c1 = sender as Button;
           
            if (detalleBtn.mover)
            {
                c1.Location = new Point(c1.Location.X + e.X - posicionX, c1.Location.Y + e.Y - posicionY);
                Refresh();

            }
        }
        private void dataGrid_MouseUp(object sender, MouseEventArgs e)
        {
            Button c1 = sender as Button;
            detalle.Location = new Point(c1.Location.X - (panel3.Location.X + panel4.Location.X), c1.Location.Y - panel4.Location.Y);

            detalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            detalle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseMove);
            detalle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);

            panel4.Controls.Add(detalle);
            detalleBtn.usado = 3;
            panel1.Controls.Remove(c1);
            //c1.Location = new Point(detalleBtn.inicialX, detalleBtn.inicialY);
            detalleBtn.mover = false;
            //actualizar estado de 

        }
        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            
            detalleBtn.mover = true;
            detalleBtn.posicionX = e.X;
            detalleBtn.posicionY = e.Y;
    
        }
        private void dataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            if (detalleBtn.mover)
            {
                detalle.Location = new Point(detalle.Location.X + e.X - posicionX, detalle.Location.Y + e.Y - posicionY);
                Refresh();

            }

        }
        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            detalleBtn.mover = false;

        }

        
        private bool buscarColumna(string column)
        {
            foreach (DataGridViewColumn c in detalle.Columns)
            {
                if (c.Name == column)
                    return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
           FormatoDoc nuevo = new FormatoDoc();
            
            nuevo.idTipoDocumento= diseño.idTipoDocumento;
           Redimensionar redi = new Redimensionar();
            redi.idTipoDocumento = diseño.idTipoDocumento;
            redi.redimensionarModelo = Convert.ToInt16( diseño.redimensionarModelo);
            redi.bordeDetalle = 0;
            
            
            List<FormatoDocumento> listFormato = new List<FormatoDocumento>();

            // las texto del documentos
            foreach(vineta v in vinetas)
            {
                if (v.usado == 3)
                {
                    FormatoDocumento nuevoFormato = new FormatoDocumento();
                    nuevoFormato.color = v.label.BackColor.ToString();
                    nuevoFormato.formato = "";
                    nuevoFormato.tipo = "Label";
                    nuevoFormato.h = v.label.Height;
                    nuevoFormato.w = v.label.Width;
                    nuevoFormato.x = v.label.Location.X;
                    nuevoFormato.y = v.label.Location.Y;
                    nuevoFormato.value = v.label.Text;
                    listFormato.Add(nuevoFormato);

                }
            }
            FormatoDocumento nuevo1 = new FormatoDocumento();

            nuevo1.color = detalle.BackColor.ToString();
            nuevo1.formato = "";
            nuevo1.tipo = "ListGrid";
            nuevo1.h = detalle.Height;
            nuevo1.w = detalle.Width;
            nuevo1.x = detalle.Location.X;
            nuevo1.y = detalle.Location.Y;
            
            listFormato.Add(nuevo1);

            foreach (vineta v1 in listGridField)
            {
                if (v1.usado == 3)
                {
                    FormatoDocumento nuevoFormato = new FormatoDocumento();
                    nuevoFormato.color = v1.label.BackColor.ToString();
                    nuevoFormato.formato = v1.label.Text;
                    nuevoFormato.tipo = "ListGridField";
                    nuevoFormato.h = v1.label.Height;
                    nuevoFormato.w = v1.label.Width;
                    nuevoFormato.x = v1.label.Location.X;
                    nuevoFormato.y = v1.label.Location.Y;
                    nuevoFormato.value = v1.nombre;
                    listFormato.Add(nuevoFormato);

                }
            }

            FormatoDocumento nuevo2 = new FormatoDocumento();

            /*
            panel3.Controls.Find()
            nuevo1.color = cuadro.BackColor.ToString();
            nuevo1.formato = "";
            nuevo1.tipo = "Img";
            nuevo1.h = cuadro.Height;
            nuevo1.w = cuadro.Width;
            nuevo1.x = cuadro.Location.X;
            nuevo1.y = cuadro.Location.Y;
            nuevo1.value = "Imagen";
            listFormato.Add(nuevo1);*/

            nuevo.formatoDocumento = JsonConvert.SerializeObject(listFormato);

            modificarformato(nuevo);
            redimensionar(redi);
        }
        public async void modificarformato( FormatoDoc nuevo)
        {
            TipoDocumentoModel aux=new TipoDocumentoModel();
             await aux.modificarFormato(nuevo);

        }
        public async void redimensionar(Redimensionar nuevo)
        {
            TipoDocumentoModel aux = new TipoDocumentoModel();
            await aux.redimensionar(nuevo);

        }
        private bool esta(int x1 , int x2 ,int y1,int y2,int posicionX, int posicionY)
        {
            int finalX = x1 + x2;
            int finalY = y1 + y2;


            if (posicionX>= x1 && posicionX<= finalX)
                if(posicionY>=y1 && posicionY<=finalY)
                return true;
            return false;
        }

    }
}
