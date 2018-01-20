namespace Admeli.Productos
{
    partial class UCCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnDesactivar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tieneRegistrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostrarWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piePaginaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabeceraPaginaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaTagsSeoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlCategoriaSeoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloCategoriaSeoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroColumnasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostrarProductosEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPadreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new ADGV.AdvancedDataGridView();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripNavigation.SuspendLayout();
            this.toolStripCrud.SuspendLayout();
            this.panelHeaderItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.toolStripNavigation);
            this.panelContainer.Controls.Add(this.toolStripCrud);
            this.panelContainer.Controls.Add(this.panelHeaderItem1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(870, 450);
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
            this.panel1.Size = new System.Drawing.Size(868, 332);
            this.panel1.TabIndex = 20;
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
            this.toolStripNavigation.Location = new System.Drawing.Point(1, 419);
            this.toolStripNavigation.Name = "toolStripNavigation";
            this.toolStripNavigation.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripNavigation.Size = new System.Drawing.Size(868, 30);
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
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnDesactivar,
            this.btnActualizar});
            this.toolStripCrud.Location = new System.Drawing.Point(1, 42);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStripCrud.Size = new System.Drawing.Size(868, 45);
            this.toolStripCrud.TabIndex = 17;
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
            this.btnModificar.Text = "Detalle";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.ToolTipText = "Modificar registro actual (F4)";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 37);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.ToolTipText = "Eliminar registro actual (F6)";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.panelHeaderItem1.Controls.Add(this.label1);
            this.panelHeaderItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderItem1.Location = new System.Drawing.Point(1, 1);
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(868, 41);
            this.panelHeaderItem1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO CATEGORIA";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Entidad.Categoria);
            // 
            // tieneRegistrosDataGridViewTextBoxColumn
            // 
            this.tieneRegistrosDataGridViewTextBoxColumn.DataPropertyName = "tieneRegistros";
            this.tieneRegistrosDataGridViewTextBoxColumn.HeaderText = "tieneRegistros";
            this.tieneRegistrosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tieneRegistrosDataGridViewTextBoxColumn.Name = "tieneRegistrosDataGridViewTextBoxColumn";
            this.tieneRegistrosDataGridViewTextBoxColumn.ReadOnly = true;
            this.tieneRegistrosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tieneRegistrosDataGridViewTextBoxColumn.Width = 99;
            // 
            // mostrarWebDataGridViewTextBoxColumn
            // 
            this.mostrarWebDataGridViewTextBoxColumn.DataPropertyName = "mostrarWeb";
            this.mostrarWebDataGridViewTextBoxColumn.HeaderText = "mostrarWeb";
            this.mostrarWebDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mostrarWebDataGridViewTextBoxColumn.Name = "mostrarWebDataGridViewTextBoxColumn";
            this.mostrarWebDataGridViewTextBoxColumn.ReadOnly = true;
            this.mostrarWebDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.mostrarWebDataGridViewTextBoxColumn.Width = 89;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.estadoDataGridViewTextBoxColumn.Width = 64;
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "orden";
            this.ordenDataGridViewTextBoxColumn.HeaderText = "orden";
            this.ordenDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            this.ordenDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ordenDataGridViewTextBoxColumn.Width = 59;
            // 
            // piePaginaDataGridViewTextBoxColumn
            // 
            this.piePaginaDataGridViewTextBoxColumn.DataPropertyName = "piePagina";
            this.piePaginaDataGridViewTextBoxColumn.HeaderText = "piePagina";
            this.piePaginaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.piePaginaDataGridViewTextBoxColumn.Name = "piePaginaDataGridViewTextBoxColumn";
            this.piePaginaDataGridViewTextBoxColumn.ReadOnly = true;
            this.piePaginaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.piePaginaDataGridViewTextBoxColumn.Width = 79;
            // 
            // cabeceraPaginaDataGridViewTextBoxColumn
            // 
            this.cabeceraPaginaDataGridViewTextBoxColumn.DataPropertyName = "cabeceraPagina";
            this.cabeceraPaginaDataGridViewTextBoxColumn.HeaderText = "cabeceraPagina";
            this.cabeceraPaginaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cabeceraPaginaDataGridViewTextBoxColumn.Name = "cabeceraPaginaDataGridViewTextBoxColumn";
            this.cabeceraPaginaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cabeceraPaginaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cabeceraPaginaDataGridViewTextBoxColumn.Width = 110;
            // 
            // metaTagsSeoDataGridViewTextBoxColumn
            // 
            this.metaTagsSeoDataGridViewTextBoxColumn.DataPropertyName = "metaTagsSeo";
            this.metaTagsSeoDataGridViewTextBoxColumn.HeaderText = "metaTagsSeo";
            this.metaTagsSeoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.metaTagsSeoDataGridViewTextBoxColumn.Name = "metaTagsSeoDataGridViewTextBoxColumn";
            this.metaTagsSeoDataGridViewTextBoxColumn.ReadOnly = true;
            this.metaTagsSeoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.metaTagsSeoDataGridViewTextBoxColumn.Width = 98;
            // 
            // urlCategoriaSeoDataGridViewTextBoxColumn
            // 
            this.urlCategoriaSeoDataGridViewTextBoxColumn.DataPropertyName = "urlCategoriaSeo";
            this.urlCategoriaSeoDataGridViewTextBoxColumn.HeaderText = "urlCategoriaSeo";
            this.urlCategoriaSeoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.urlCategoriaSeoDataGridViewTextBoxColumn.Name = "urlCategoriaSeoDataGridViewTextBoxColumn";
            this.urlCategoriaSeoDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlCategoriaSeoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.urlCategoriaSeoDataGridViewTextBoxColumn.Width = 107;
            // 
            // tituloCategoriaSeoDataGridViewTextBoxColumn
            // 
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.DataPropertyName = "tituloCategoriaSeo";
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.HeaderText = "tituloCategoriaSeo";
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.Name = "tituloCategoriaSeoDataGridViewTextBoxColumn";
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tituloCategoriaSeoDataGridViewTextBoxColumn.Width = 118;
            // 
            // numeroColumnasDataGridViewTextBoxColumn
            // 
            this.numeroColumnasDataGridViewTextBoxColumn.DataPropertyName = "numeroColumnas";
            this.numeroColumnasDataGridViewTextBoxColumn.HeaderText = "numeroColumnas";
            this.numeroColumnasDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.numeroColumnasDataGridViewTextBoxColumn.Name = "numeroColumnasDataGridViewTextBoxColumn";
            this.numeroColumnasDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroColumnasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.numeroColumnasDataGridViewTextBoxColumn.Width = 113;
            // 
            // mostrarProductosEnDataGridViewTextBoxColumn
            // 
            this.mostrarProductosEnDataGridViewTextBoxColumn.DataPropertyName = "mostrarProductosEn";
            this.mostrarProductosEnDataGridViewTextBoxColumn.HeaderText = "mostrarProductosEn";
            this.mostrarProductosEnDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.mostrarProductosEnDataGridViewTextBoxColumn.Name = "mostrarProductosEnDataGridViewTextBoxColumn";
            this.mostrarProductosEnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mostrarProductosEnDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.mostrarProductosEnDataGridViewTextBoxColumn.Width = 127;
            // 
            // ordenVisualizacionProductosDataGridViewTextBoxColumn
            // 
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.DataPropertyName = "ordenVisualizacionProductos";
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.HeaderText = "ordenVisualizacionProductos";
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.Name = "ordenVisualizacionProductosDataGridViewTextBoxColumn";
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn.Width = 168;
            // 
            // padreDataGridViewTextBoxColumn
            // 
            this.padreDataGridViewTextBoxColumn.DataPropertyName = "padre";
            this.padreDataGridViewTextBoxColumn.HeaderText = "padre";
            this.padreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.padreDataGridViewTextBoxColumn.Name = "padreDataGridViewTextBoxColumn";
            this.padreDataGridViewTextBoxColumn.ReadOnly = true;
            this.padreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.padreDataGridViewTextBoxColumn.Width = 59;
            // 
            // idPadreCategoriaDataGridViewTextBoxColumn
            // 
            this.idPadreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idPadreCategoria";
            this.idPadreCategoriaDataGridViewTextBoxColumn.HeaderText = "idPadreCategoria";
            this.idPadreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idPadreCategoriaDataGridViewTextBoxColumn.Name = "idPadreCategoriaDataGridViewTextBoxColumn";
            this.idPadreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPadreCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idPadreCategoriaDataGridViewTextBoxColumn.Width = 113;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 112;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 85;
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
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.idPadreCategoriaDataGridViewTextBoxColumn,
            this.padreDataGridViewTextBoxColumn,
            this.ordenVisualizacionProductosDataGridViewTextBoxColumn,
            this.mostrarProductosEnDataGridViewTextBoxColumn,
            this.numeroColumnasDataGridViewTextBoxColumn,
            this.tituloCategoriaSeoDataGridViewTextBoxColumn,
            this.urlCategoriaSeoDataGridViewTextBoxColumn,
            this.metaTagsSeoDataGridViewTextBoxColumn,
            this.cabeceraPaginaDataGridViewTextBoxColumn,
            this.piePaginaDataGridViewTextBoxColumn,
            this.ordenDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.mostrarWebDataGridViewTextBoxColumn,
            this.tieneRegistrosDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.categoriaBindingSource;
            this.dataGridView.DateWithTime = false;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(10, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(848, 312);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TimeFilter = false;
            // 
            // UCCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCCategorias";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(886, 466);
            this.Load += new System.EventHandler(this.UCCategorias_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStripNavigation.ResumeLayout(false);
            this.toolStripNavigation.PerformLayout();
            this.toolStripCrud.ResumeLayout(false);
            this.toolStripCrud.PerformLayout();
            this.panelHeaderItem1.ResumeLayout(false);
            this.panelHeaderItem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeaderItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.ToolStripButton btnDesactivar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private ADGV.AdvancedDataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPadreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenVisualizacionProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostrarProductosEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumnasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloCategoriaSeoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlCategoriaSeoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaTagsSeoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabeceraPaginaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piePaginaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostrarWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieneRegistrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}
