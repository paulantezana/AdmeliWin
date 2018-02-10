namespace Admeli.Configuracion
{
    partial class UCAsignarCorrelativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAsignarCorrelativo));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new ADGV.AdvancedDataGridView();
            this.docCorrelativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCorrelativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCorrelativoBindingSource)).BeginInit();
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
            this.panelContainer.Size = new System.Drawing.Size(883, 546);
            this.panelContainer.TabIndex = 7;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(881, 428);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoGenerateContextFilters = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.idCorrelativoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nombreLabelDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.correlativoInicioDataGridViewTextBoxColumn,
            this.correlativoFinDataGridViewTextBoxColumn,
            this.correlativoActualDataGridViewTextBoxColumn,
            this.finDataGridViewCheckBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idDocumentoDataGridViewTextBoxColumn,
            this.operacionDataGridViewTextBoxColumn,
            this.idOperacionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.docCorrelativoBindingSource;
            this.dataGridView.DateWithTime = false;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(10, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(861, 408);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TimeFilter = false;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // docCorrelativoBindingSource
            // 
            this.docCorrelativoBindingSource.DataSource = typeof(Entidad.DocCorrelativo);
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
            this.toolStripNavigation.Location = new System.Drawing.Point(1, 515);
            this.toolStripNavigation.Name = "toolStripNavigation";
            this.toolStripNavigation.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripNavigation.Size = new System.Drawing.Size(881, 30);
            this.toolStripNavigation.TabIndex = 19;
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
            this.btnModificar,
            this.btnActualizar});
            this.toolStripCrud.Location = new System.Drawing.Point(1, 42);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStripCrud.Size = new System.Drawing.Size(881, 45);
            this.toolStripCrud.TabIndex = 17;
            this.toolStripCrud.Text = "toolStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 37);
            this.btnModificar.Text = "Modificar (F4)";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Modificar registro actual (F4)";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 37);
            this.btnActualizar.Text = "Actualizar (F5)";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.ToolTipText = "Actualizar registros (F5)\r\n";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelHeaderItem1
            // 
            this.panelHeaderItem1.Controls.Add(this.label1);
            this.panelHeaderItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderItem1.Location = new System.Drawing.Point(1, 1);
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(881, 41);
            this.panelHeaderItem1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO CORRELATIVO DOCUMENTOS COMERCIALES";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOperacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "idOperacion";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 114;
            // 
            // idCorrelativoDataGridViewTextBoxColumn
            // 
            this.idCorrelativoDataGridViewTextBoxColumn.DataPropertyName = "idCorrelativo";
            this.idCorrelativoDataGridViewTextBoxColumn.HeaderText = "idCorrelativo";
            this.idCorrelativoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idCorrelativoDataGridViewTextBoxColumn.Name = "idCorrelativoDataGridViewTextBoxColumn";
            this.idCorrelativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCorrelativoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idCorrelativoDataGridViewTextBoxColumn.Width = 90;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.areaDataGridViewTextBoxColumn.Width = 53;
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // nombreLabelDataGridViewTextBoxColumn
            // 
            this.nombreLabelDataGridViewTextBoxColumn.DataPropertyName = "nombreLabel";
            this.nombreLabelDataGridViewTextBoxColumn.HeaderText = "nombreLabel";
            this.nombreLabelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreLabelDataGridViewTextBoxColumn.Name = "nombreLabelDataGridViewTextBoxColumn";
            this.nombreLabelDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreLabelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreLabelDataGridViewTextBoxColumn.Width = 93;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.serieDataGridViewTextBoxColumn.Width = 54;
            // 
            // correlativoInicioDataGridViewTextBoxColumn
            // 
            this.correlativoInicioDataGridViewTextBoxColumn.DataPropertyName = "correlativoInicio";
            this.correlativoInicioDataGridViewTextBoxColumn.HeaderText = "correlativoInicio";
            this.correlativoInicioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.correlativoInicioDataGridViewTextBoxColumn.Name = "correlativoInicioDataGridViewTextBoxColumn";
            this.correlativoInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativoInicioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.correlativoInicioDataGridViewTextBoxColumn.Width = 106;
            // 
            // correlativoFinDataGridViewTextBoxColumn
            // 
            this.correlativoFinDataGridViewTextBoxColumn.DataPropertyName = "correlativoFin";
            this.correlativoFinDataGridViewTextBoxColumn.HeaderText = "correlativoFin";
            this.correlativoFinDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.correlativoFinDataGridViewTextBoxColumn.Name = "correlativoFinDataGridViewTextBoxColumn";
            this.correlativoFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativoFinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.correlativoFinDataGridViewTextBoxColumn.Width = 95;
            // 
            // correlativoActualDataGridViewTextBoxColumn
            // 
            this.correlativoActualDataGridViewTextBoxColumn.DataPropertyName = "correlativoActual";
            this.correlativoActualDataGridViewTextBoxColumn.HeaderText = "correlativoActual";
            this.correlativoActualDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.correlativoActualDataGridViewTextBoxColumn.Name = "correlativoActualDataGridViewTextBoxColumn";
            this.correlativoActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativoActualDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.correlativoActualDataGridViewTextBoxColumn.Width = 111;
            // 
            // finDataGridViewCheckBoxColumn
            // 
            this.finDataGridViewCheckBoxColumn.DataPropertyName = "fin";
            this.finDataGridViewCheckBoxColumn.HeaderText = "fin";
            this.finDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.finDataGridViewCheckBoxColumn.Name = "finDataGridViewCheckBoxColumn";
            this.finDataGridViewCheckBoxColumn.ReadOnly = true;
            this.finDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.finDataGridViewCheckBoxColumn.Width = 43;
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
            // idDocumentoDataGridViewTextBoxColumn
            // 
            this.idDocumentoDataGridViewTextBoxColumn.DataPropertyName = "idDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.HeaderText = "idDocumento";
            this.idDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDocumentoDataGridViewTextBoxColumn.Name = "idDocumentoDataGridViewTextBoxColumn";
            this.idDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDocumentoDataGridViewTextBoxColumn.Width = 95;
            // 
            // operacionDataGridViewTextBoxColumn
            // 
            this.operacionDataGridViewTextBoxColumn.DataPropertyName = "operacion";
            this.operacionDataGridViewTextBoxColumn.HeaderText = "operacion";
            this.operacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.operacionDataGridViewTextBoxColumn.Name = "operacionDataGridViewTextBoxColumn";
            this.operacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.operacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.operacionDataGridViewTextBoxColumn.Width = 79;
            // 
            // idOperacionDataGridViewTextBoxColumn
            // 
            this.idOperacionDataGridViewTextBoxColumn.DataPropertyName = "idOperacion";
            this.idOperacionDataGridViewTextBoxColumn.HeaderText = "idOperacion";
            this.idOperacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idOperacionDataGridViewTextBoxColumn.Name = "idOperacionDataGridViewTextBoxColumn";
            this.idOperacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idOperacionDataGridViewTextBoxColumn.Width = 89;
            // 
            // UCAsignarCorrelativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCAsignarCorrelativo";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(899, 562);
            this.Load += new System.EventHandler(this.UCAsignarCorrelativo_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCorrelativoBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panelHeaderItem1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.BindingSource docCorrelativoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCorrelativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperacionDataGridViewTextBoxColumn;
    }
}
