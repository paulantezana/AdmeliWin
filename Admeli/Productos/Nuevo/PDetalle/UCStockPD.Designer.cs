namespace Admeli.Productos.Nuevo.PDetalle
{
    partial class UCStockPD
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStockPD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrecios = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPrecios = new ADGV.AdvancedDataGridView();
            this.idPrecioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripCrud = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnDesactivar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabStockAlmacen = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewStocks = new ADGV.AdvancedDataGridView();
            this.idProductoStockAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIdealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertaStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevoStock = new System.Windows.Forms.ToolStripButton();
            this.btnEditarStock = new System.Windows.Forms.ToolStripButton();
            this.btnActualizarStock = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPrecios.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioBindingSource)).BeginInit();
            this.toolStripCrud.SuspendLayout();
            this.panelHeaderItem1.SuspendLayout();
            this.tabStockAlmacen.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelHeader.Size = new System.Drawing.Size(708, 49);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio-Stock";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 630);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelFooter.Size = new System.Drawing.Size(708, 49);
            this.panelFooter.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 49);
            this.panel1.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(58, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 36);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.Location = new System.Drawing.Point(230, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrecios);
            this.tabControl1.Controls.Add(this.tabStockAlmacen);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 581);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPrecios
            // 
            this.tabPrecios.BackColor = System.Drawing.Color.White;
            this.tabPrecios.Controls.Add(this.panel2);
            this.tabPrecios.Controls.Add(this.toolStripCrud);
            this.tabPrecios.Controls.Add(this.panelHeaderItem1);
            this.tabPrecios.Location = new System.Drawing.Point(4, 39);
            this.tabPrecios.Name = "tabPrecios";
            this.tabPrecios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrecios.Size = new System.Drawing.Size(700, 538);
            this.tabPrecios.TabIndex = 0;
            this.tabPrecios.Text = "Precios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPrecios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 89);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(694, 446);
            this.panel2.TabIndex = 23;
            // 
            // dataGridViewPrecios
            // 
            this.dataGridViewPrecios.AllowUserToAddRows = false;
            this.dataGridViewPrecios.AllowUserToDeleteRows = false;
            this.dataGridViewPrecios.AllowUserToOrderColumns = true;
            this.dataGridViewPrecios.AutoGenerateColumns = false;
            this.dataGridViewPrecios.AutoGenerateContextFilters = true;
            this.dataGridViewPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrecios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrecios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrecios.ColumnHeadersHeight = 40;
            this.dataGridViewPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrecioProductoDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.precioCompetenciaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.utilidadDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.idMonedaDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.nombreSucursalDataGridViewTextBoxColumn});
            this.dataGridViewPrecios.DataSource = this.precioBindingSource;
            this.dataGridViewPrecios.DateWithTime = false;
            this.dataGridViewPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrecios.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPrecios.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewPrecios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPrecios.Name = "dataGridViewPrecios";
            this.dataGridViewPrecios.ReadOnly = true;
            this.dataGridViewPrecios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPrecios.RowTemplate.Height = 27;
            this.dataGridViewPrecios.Size = new System.Drawing.Size(674, 426);
            this.dataGridViewPrecios.TabIndex = 0;
            this.dataGridViewPrecios.TimeFilter = false;
            this.dataGridViewPrecios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrecios_CellDoubleClick);
            // 
            // idPrecioProductoDataGridViewTextBoxColumn
            // 
            this.idPrecioProductoDataGridViewTextBoxColumn.DataPropertyName = "idPrecioProducto";
            this.idPrecioProductoDataGridViewTextBoxColumn.HeaderText = "idPrecioProducto";
            this.idPrecioProductoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idPrecioProductoDataGridViewTextBoxColumn.Name = "idPrecioProductoDataGridViewTextBoxColumn";
            this.idPrecioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPrecioProductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idPrecioProductoDataGridViewTextBoxColumn.Width = 113;
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "precioVenta";
            this.precioVentaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            this.precioVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioVentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precioVentaDataGridViewTextBoxColumn.Width = 89;
            // 
            // precioCompetenciaDataGridViewTextBoxColumn
            // 
            this.precioCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "precioCompetencia";
            this.precioCompetenciaDataGridViewTextBoxColumn.HeaderText = "precioCompetencia";
            this.precioCompetenciaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.precioCompetenciaDataGridViewTextBoxColumn.Name = "precioCompetenciaDataGridViewTextBoxColumn";
            this.precioCompetenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioCompetenciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precioCompetenciaDataGridViewTextBoxColumn.Width = 123;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.estadoDataGridViewTextBoxColumn.Width = 64;
            // 
            // utilidadDataGridViewTextBoxColumn
            // 
            this.utilidadDataGridViewTextBoxColumn.DataPropertyName = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.HeaderText = "utilidad";
            this.utilidadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.utilidadDataGridViewTextBoxColumn.Name = "utilidadDataGridViewTextBoxColumn";
            this.utilidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.utilidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.utilidadDataGridViewTextBoxColumn.Width = 65;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "moneda";
            this.monedaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            this.monedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.monedaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.monedaDataGridViewTextBoxColumn.Width = 70;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idProductoDataGridViewTextBoxColumn.Width = 83;
            // 
            // idMonedaDataGridViewTextBoxColumn
            // 
            this.idMonedaDataGridViewTextBoxColumn.DataPropertyName = "idMoneda";
            this.idMonedaDataGridViewTextBoxColumn.HeaderText = "idMoneda";
            this.idMonedaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idMonedaDataGridViewTextBoxColumn.Name = "idMonedaDataGridViewTextBoxColumn";
            this.idMonedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMonedaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idMonedaDataGridViewTextBoxColumn.Width = 79;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idSucursalDataGridViewTextBoxColumn.Width = 81;
            // 
            // nombreSucursalDataGridViewTextBoxColumn
            // 
            this.nombreSucursalDataGridViewTextBoxColumn.DataPropertyName = "nombreSucursal";
            this.nombreSucursalDataGridViewTextBoxColumn.HeaderText = "nombreSucursal";
            this.nombreSucursalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreSucursalDataGridViewTextBoxColumn.Name = "nombreSucursalDataGridViewTextBoxColumn";
            this.nombreSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreSucursalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreSucursalDataGridViewTextBoxColumn.Width = 108;
            // 
            // precioBindingSource
            // 
            this.precioBindingSource.DataSource = typeof(Entidad.Precio);
            // 
            // toolStripCrud
            // 
            this.toolStripCrud.AutoSize = false;
            this.toolStripCrud.BackColor = System.Drawing.Color.White;
            this.toolStripCrud.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripCrud.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCrud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.btnDesactivar,
            this.btnActualizar});
            this.toolStripCrud.Location = new System.Drawing.Point(3, 44);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStripCrud.Size = new System.Drawing.Size(694, 45);
            this.toolStripCrud.TabIndex = 22;
            this.toolStripCrud.Text = "toolStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 37);
            this.btnModificar.Text = "Detalle";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Modificar registro actual (F4)";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.AutoSize = false;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesactivar.Image")));
            this.btnDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(73, 37);
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesactivar.ToolTipText = "Anular(F7)";
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 37);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.ToolTipText = "Actualizar registros (F5)\r\n";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelHeaderItem1
            // 
            this.panelHeaderItem1.Controls.Add(this.label2);
            this.panelHeaderItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderItem1.Location = new System.Drawing.Point(3, 3);
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(694, 41);
            this.panelHeaderItem1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MANTENIMIENTO PRECIO PRODUCTO";
            // 
            // tabStockAlmacen
            // 
            this.tabStockAlmacen.BackColor = System.Drawing.Color.White;
            this.tabStockAlmacen.Controls.Add(this.panel3);
            this.tabStockAlmacen.Controls.Add(this.toolStrip1);
            this.tabStockAlmacen.Controls.Add(this.panel4);
            this.tabStockAlmacen.Location = new System.Drawing.Point(4, 39);
            this.tabStockAlmacen.Name = "tabStockAlmacen";
            this.tabStockAlmacen.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockAlmacen.Size = new System.Drawing.Size(700, 538);
            this.tabStockAlmacen.TabIndex = 1;
            this.tabStockAlmacen.Text = "Stock Almacen";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewStocks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 89);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(694, 446);
            this.panel3.TabIndex = 23;
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.AllowUserToAddRows = false;
            this.dataGridViewStocks.AllowUserToDeleteRows = false;
            this.dataGridViewStocks.AllowUserToOrderColumns = true;
            this.dataGridViewStocks.AutoGenerateColumns = false;
            this.dataGridViewStocks.AutoGenerateContextFilters = true;
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStocks.ColumnHeadersHeight = 40;
            this.dataGridViewStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoStockAlmacenDataGridViewTextBoxColumn,
            this.idAlmacenDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.stockIdealDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn,
            this.alertaStockDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn1,
            this.nombreAlmacenDataGridViewTextBoxColumn});
            this.dataGridViewStocks.DataSource = this.stockBindingSource;
            this.dataGridViewStocks.DateWithTime = false;
            this.dataGridViewStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStocks.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStocks.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewStocks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.ReadOnly = true;
            this.dataGridViewStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStocks.RowTemplate.Height = 27;
            this.dataGridViewStocks.Size = new System.Drawing.Size(674, 426);
            this.dataGridViewStocks.TabIndex = 0;
            this.dataGridViewStocks.TimeFilter = false;
            // 
            // idProductoStockAlmacenDataGridViewTextBoxColumn
            // 
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.DataPropertyName = "idProductoStockAlmacen";
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.HeaderText = "idProductoStockAlmacen";
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.Name = "idProductoStockAlmacenDataGridViewTextBoxColumn";
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idProductoStockAlmacenDataGridViewTextBoxColumn.Width = 152;
            // 
            // idAlmacenDataGridViewTextBoxColumn
            // 
            this.idAlmacenDataGridViewTextBoxColumn.DataPropertyName = "idAlmacen";
            this.idAlmacenDataGridViewTextBoxColumn.HeaderText = "idAlmacen";
            this.idAlmacenDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idAlmacenDataGridViewTextBoxColumn.Name = "idAlmacenDataGridViewTextBoxColumn";
            this.idAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlmacenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idAlmacenDataGridViewTextBoxColumn.Width = 81;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stockDataGridViewTextBoxColumn.Width = 58;
            // 
            // stockIdealDataGridViewTextBoxColumn
            // 
            this.stockIdealDataGridViewTextBoxColumn.DataPropertyName = "stockIdeal";
            this.stockIdealDataGridViewTextBoxColumn.HeaderText = "stockIdeal";
            this.stockIdealDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.stockIdealDataGridViewTextBoxColumn.Name = "stockIdealDataGridViewTextBoxColumn";
            this.stockIdealDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIdealDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stockIdealDataGridViewTextBoxColumn.Width = 81;
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            this.stockMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockMinimoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stockMinimoDataGridViewTextBoxColumn.Width = 91;
            // 
            // alertaStockDataGridViewTextBoxColumn
            // 
            this.alertaStockDataGridViewTextBoxColumn.DataPropertyName = "alertaStock";
            this.alertaStockDataGridViewTextBoxColumn.HeaderText = "alertaStock";
            this.alertaStockDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.alertaStockDataGridViewTextBoxColumn.Name = "alertaStockDataGridViewTextBoxColumn";
            this.alertaStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.alertaStockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.alertaStockDataGridViewTextBoxColumn.Width = 86;
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            this.estadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.estadoDataGridViewTextBoxColumn1.Width = 64;
            // 
            // nombreAlmacenDataGridViewTextBoxColumn
            // 
            this.nombreAlmacenDataGridViewTextBoxColumn.DataPropertyName = "nombreAlmacen";
            this.nombreAlmacenDataGridViewTextBoxColumn.HeaderText = "nombreAlmacen";
            this.nombreAlmacenDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreAlmacenDataGridViewTextBoxColumn.Name = "nombreAlmacenDataGridViewTextBoxColumn";
            this.nombreAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreAlmacenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreAlmacenDataGridViewTextBoxColumn.Width = 108;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(Entidad.Stock);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoStock,
            this.btnEditarStock,
            this.btnEliminar,
            this.btnActualizarStock});
            this.toolStrip1.Location = new System.Drawing.Point(3, 44);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStrip1.Size = new System.Drawing.Size(694, 45);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevoStock
            // 
            this.btnNuevoStock.AutoSize = false;
            this.btnNuevoStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoStock.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoStock.Image")));
            this.btnNuevoStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoStock.Name = "btnNuevoStock";
            this.btnNuevoStock.Size = new System.Drawing.Size(62, 37);
            this.btnNuevoStock.Text = "Nuevo ";
            this.btnNuevoStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoStock.ToolTipText = "Agregar un nuevo registro (F3)";
            this.btnNuevoStock.Click += new System.EventHandler(this.btnNuevoStock_Click);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.AutoSize = false;
            this.btnEditarStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarStock.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarStock.Image")));
            this.btnEditarStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(78, 37);
            this.btnEditarStock.Text = "Detalle";
            this.btnEditarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarStock.ToolTipText = "Modificar registro actual (F4)";
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.AutoSize = false;
            this.btnActualizarStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarStock.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarStock.Image")));
            this.btnActualizarStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(79, 37);
            this.btnActualizarStock.Text = "Actualizar";
            this.btnActualizarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizarStock.ToolTipText = "Actualizar registros (F5)\r\n";
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 41);
            this.panel4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "MANTENIMIENTO STOCK PRODUCTO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 37);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.ToolTipText = "Eliminar registro actual (F6)";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // UCStockPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "UCStockPD";
            this.Size = new System.Drawing.Size(708, 679);
            this.Load += new System.EventHandler(this.UCStockPD_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPrecios.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioBindingSource)).EndInit();
            this.toolStripCrud.ResumeLayout(false);
            this.toolStripCrud.PerformLayout();
            this.panelHeaderItem1.ResumeLayout(false);
            this.panelHeaderItem1.PerformLayout();
            this.tabStockAlmacen.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrecios;
        private System.Windows.Forms.TabPage tabStockAlmacen;
        private System.Windows.Forms.Panel panel2;
        private ADGV.AdvancedDataGridView dataGridViewPrecios;
        private System.Windows.Forms.ToolStrip toolStripCrud;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnDesactivar;
        private System.Windows.Forms.Panel panelHeaderItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private ADGV.AdvancedDataGridView dataGridViewStocks;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevoStock;
        private System.Windows.Forms.ToolStripButton btnEditarStock;
        private System.Windows.Forms.ToolStripButton btnActualizarStock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrecioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource precioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoStockAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIdealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertaStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.ToolStripButton btnEliminar;
    }
}
