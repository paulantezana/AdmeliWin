namespace Admeli.Configuracion
{
    partial class UCPuntoDeVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPuntoDeVenta));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new ADGV.AdvancedDataGridView();
            this.puntoDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripNavigation = new System.Windows.Forms.ToolStrip();
            this.lblPageAllItems = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripLabel();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentPage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.lblSpeedPages = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCrud = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.cbxSucursales = new System.Windows.Forms.ToolStripComboBox();
            this.cbxEstados = new System.Windows.Forms.ToolStripComboBox();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idPuntoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaWebDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaBindingSource)).BeginInit();
            this.toolStripNavigation.SuspendLayout();
            this.toolStripCrud.SuspendLayout();
            this.panelHeaderItem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.toolStripNavigation);
            this.panelContainer.Controls.Add(this.toolStripCrud);
            this.panelContainer.Controls.Add(this.panelHeaderItem1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(921, 481);
            this.panelContainer.TabIndex = 8;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(919, 363);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoGenerateContextFilters = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPuntoVentaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.ventaWebDataGridViewCheckBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.puntoDeVentaBindingSource;
            this.dataGridView.DateWithTime = false;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(10, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(899, 343);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TimeFilter = false;
            // 
            // puntoDeVentaBindingSource
            // 
            this.puntoDeVentaBindingSource.DataSource = typeof(Entidad.Configuracion.PuntoDeVenta);
            // 
            // toolStripNavigation
            // 
            this.toolStripNavigation.AutoSize = false;
            this.toolStripNavigation.BackColor = System.Drawing.Color.White;
            this.toolStripNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripNavigation.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripNavigation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPageAllItems,
            this.toolStripButton5,
            this.btnFirst,
            this.btnPrevious,
            this.lblCurrentPage,
            this.toolStripButton2,
            this.lblPageCount,
            this.btnNext,
            this.btnLast,
            this.toolStripButton1,
            this.lblSpeedPages,
            this.toolStripButton3});
            this.toolStripNavigation.Location = new System.Drawing.Point(1, 450);
            this.toolStripNavigation.Name = "toolStripNavigation";
            this.toolStripNavigation.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripNavigation.Size = new System.Drawing.Size(919, 30);
            this.toolStripNavigation.TabIndex = 15;
            this.toolStripNavigation.Text = "toolStrip3";
            // 
            // lblPageAllItems
            // 
            this.lblPageAllItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblPageAllItems.Image = ((System.Drawing.Image)(resources.GetObject("lblPageAllItems.Image")));
            this.lblPageAllItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblPageAllItems.Name = "lblPageAllItems";
            this.lblPageAllItems.Size = new System.Drawing.Size(13, 27);
            this.lblPageAllItems.Text = "0";
            this.lblPageAllItems.ToolTipText = "Total de registros en el sistema";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(55, 27);
            this.toolStripButton5.Text = "Registros";
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 27);
            this.btnFirst.Text = "Primera página";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 27);
            this.btnPrevious.Text = "Anterior página";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = false;
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(31, 23);
            this.lblCurrentPage.Text = "1";
            this.lblCurrentPage.ToolTipText = "Página actual (enter)";
            this.lblCurrentPage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lblCurrentPage_KeyUp);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(12, 27);
            this.toolStripButton2.Text = "/";
            // 
            // lblPageCount
            // 
            this.lblPageCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblPageCount.Image = ((System.Drawing.Image)(resources.GetObject("lblPageCount.Image")));
            this.lblPageCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(13, 27);
            this.lblPageCount.Text = "1";
            this.lblPageCount.ToolTipText = "Número total de páginas";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 27);
            this.btnNext.Text = "Siguiente página";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 27);
            this.btnLast.Text = "Ultimo página";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 27);
            this.toolStripButton1.Text = "Mostrar cada";
            // 
            // lblSpeedPages
            // 
            this.lblSpeedPages.AutoSize = false;
            this.lblSpeedPages.Name = "lblSpeedPages";
            this.lblSpeedPages.Size = new System.Drawing.Size(38, 23);
            this.lblSpeedPages.Text = "50";
            this.lblSpeedPages.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblSpeedPages.ToolTipText = "Cantidad de registros a mostrar (enter)";
            this.lblSpeedPages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lblSpeedPages_KeyUp);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 27);
            this.toolStripButton3.Text = "Registros";
            // 
            // toolStripCrud
            // 
            this.toolStripCrud.AutoSize = false;
            this.toolStripCrud.BackColor = System.Drawing.Color.White;
            this.toolStripCrud.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripCrud.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCrud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnAnular,
            this.btnActualizar,
            this.cbxSucursales,
            this.cbxEstados,
            this.btnConsultar});
            this.toolStripCrud.Location = new System.Drawing.Point(1, 42);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStripCrud.Size = new System.Drawing.Size(919, 45);
            this.toolStripCrud.TabIndex = 13;
            this.toolStripCrud.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 37);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Agregar un nuevo registro (F3)";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 37);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Modificar registro actual (F4)";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.AutoSize = false;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(73, 37);
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnular.ToolTipText = "Anular(F7)";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            // cbxSucursales
            // 
            this.cbxSucursales.AutoSize = false;
            this.cbxSucursales.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(151, 23);
            // 
            // cbxEstados
            // 
            this.cbxEstados.AutoSize = false;
            this.cbxEstados.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(151, 23);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = false;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 37);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.ToolTipText = "Actualizar registros (F5)\r\n";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelHeaderItem1
            // 
            this.panelHeaderItem1.Controls.Add(this.label1);
            this.panelHeaderItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderItem1.Location = new System.Drawing.Point(1, 1);
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(919, 41);
            this.panelHeaderItem1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO PUNTO DE VENTA";
            // 
            // idPuntoVentaDataGridViewTextBoxColumn
            // 
            this.idPuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "idPuntoVenta";
            this.idPuntoVentaDataGridViewTextBoxColumn.HeaderText = "idPuntoVenta";
            this.idPuntoVentaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idPuntoVentaDataGridViewTextBoxColumn.Name = "idPuntoVentaDataGridViewTextBoxColumn";
            this.idPuntoVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPuntoVentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idPuntoVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ventaWebDataGridViewCheckBoxColumn
            // 
            this.ventaWebDataGridViewCheckBoxColumn.DataPropertyName = "ventaWeb";
            this.ventaWebDataGridViewCheckBoxColumn.HeaderText = "Venta Web";
            this.ventaWebDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.ventaWebDataGridViewCheckBoxColumn.Name = "ventaWebDataGridViewCheckBoxColumn";
            this.ventaWebDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ventaWebDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.sucursalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idAsignarPuntoVentaDataGridViewTextBoxColumn
            // 
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "idAsignarPuntoVenta";
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.HeaderText = "idAsignarPuntoVenta";
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.Name = "idAsignarPuntoVentaDataGridViewTextBoxColumn";
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idAsignarPuntoVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // UCPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCPuntoDeVenta";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(937, 497);
            this.Load += new System.EventHandler(this.UCPuntoDeVenta_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaBindingSource)).EndInit();
            this.toolStripNavigation.ResumeLayout(false);
            this.toolStripNavigation.PerformLayout();
            this.toolStripCrud.ResumeLayout(false);
            this.toolStripCrud.PerformLayout();
            this.panelHeaderItem1.ResumeLayout(false);
            this.panelHeaderItem1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private ADGV.AdvancedDataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStripNavigation;
        private System.Windows.Forms.ToolStripLabel lblPageAllItems;
        private System.Windows.Forms.ToolStripLabel toolStripButton5;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripComboBox lblCurrentPage;
        private System.Windows.Forms.ToolStripLabel toolStripButton2;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox lblSpeedPages;
        private System.Windows.Forms.ToolStripLabel toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStripCrud;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripComboBox cbxSucursales;
        private System.Windows.Forms.ToolStripComboBox cbxEstados;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.Panel panelHeaderItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource puntoDeVentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuntoVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ventaWebDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignarPuntoVentaDataGridViewTextBoxColumn;
    }
}
