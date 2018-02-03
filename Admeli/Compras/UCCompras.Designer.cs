namespace Admeli.Compras
{
    partial class UCCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCompras));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new ADGV.AdvancedDataGridView();
            this.idCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroOrdenCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rucDniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripLabel();
            this.textBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCrud = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.cbxPersonales = new System.Windows.Forms.ToolStripComboBox();
            this.cbxEstados = new System.Windows.Forms.ToolStripComboBox();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.panelHeaderItem1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.toolStripNavigation.SuspendLayout();
            this.toolStripTools.SuspendLayout();
            this.toolStripCrud.SuspendLayout();
            this.panelHeaderItem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.toolStripNavigation);
            this.panelContainer.Controls.Add(this.toolStripTools);
            this.panelContainer.Controls.Add(this.toolStripCrud);
            this.panelContainer.Controls.Add(this.panelHeaderItem1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(882, 556);
            this.panelContainer.TabIndex = 7;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 132);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(880, 393);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoGenerateContextFilters = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
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
            this.idCompraDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.nroOrdenCompraDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.rucDniDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.formaPagoDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn,
            this.fechaFacturacionDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.tipoCompraDataGridViewTextBoxColumn,
            this.tipoCambioDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.idPagoDataGridViewTextBoxColumn,
            this.idPersonalDataGridViewTextBoxColumn,
            this.idTipoDocumentoDataGridViewTextBoxColumn,
            this.nombreLabelDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.compraBindingSource;
            this.dataGridView.DateWithTime = false;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(10, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(860, 373);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TimeFilter = false;
            // 
            // idCompraDataGridViewTextBoxColumn
            // 
            this.idCompraDataGridViewTextBoxColumn.DataPropertyName = "idCompra";
            this.idCompraDataGridViewTextBoxColumn.HeaderText = "idCompra";
            this.idCompraDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idCompraDataGridViewTextBoxColumn.Name = "idCompraDataGridViewTextBoxColumn";
            this.idCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idCompraDataGridViewTextBoxColumn.Visible = false;
            this.idCompraDataGridViewTextBoxColumn.Width = 76;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "numeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Numero Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 116;
            // 
            // nroOrdenCompraDataGridViewTextBoxColumn
            // 
            this.nroOrdenCompraDataGridViewTextBoxColumn.DataPropertyName = "nroOrdenCompra";
            this.nroOrdenCompraDataGridViewTextBoxColumn.HeaderText = "Nº Orden De Compra";
            this.nroOrdenCompraDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nroOrdenCompraDataGridViewTextBoxColumn.Name = "nroOrdenCompraDataGridViewTextBoxColumn";
            this.nroOrdenCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroOrdenCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nroOrdenCompraDataGridViewTextBoxColumn.Width = 88;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreProveedorDataGridViewTextBoxColumn.Width = 111;
            // 
            // rucDniDataGridViewTextBoxColumn
            // 
            this.rucDniDataGridViewTextBoxColumn.DataPropertyName = "rucDni";
            this.rucDniDataGridViewTextBoxColumn.HeaderText = "RUC DNI";
            this.rucDniDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rucDniDataGridViewTextBoxColumn.Name = "rucDniDataGridViewTextBoxColumn";
            this.rucDniDataGridViewTextBoxColumn.ReadOnly = true;
            this.rucDniDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rucDniDataGridViewTextBoxColumn.Width = 71;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.direccionDataGridViewTextBoxColumn.Width = 77;
            // 
            // formaPagoDataGridViewTextBoxColumn
            // 
            this.formaPagoDataGridViewTextBoxColumn.DataPropertyName = "formaPago";
            this.formaPagoDataGridViewTextBoxColumn.HeaderText = "Forma Pago";
            this.formaPagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.formaPagoDataGridViewTextBoxColumn.Name = "formaPagoDataGridViewTextBoxColumn";
            this.formaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.formaPagoDataGridViewTextBoxColumn.Width = 82;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            this.monedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.monedaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.monedaDataGridViewTextBoxColumn.Width = 71;
            // 
            // fechaFacturacionDataGridViewTextBoxColumn
            // 
            this.fechaFacturacionDataGridViewTextBoxColumn.DataPropertyName = "fechaFacturacion";
            this.fechaFacturacionDataGridViewTextBoxColumn.HeaderText = "Fecha Facturacion";
            this.fechaFacturacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaFacturacionDataGridViewTextBoxColumn.Name = "fechaFacturacionDataGridViewTextBoxColumn";
            this.fechaFacturacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFacturacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaFacturacionDataGridViewTextBoxColumn.Width = 111;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago";
            this.fechaPagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaPagoDataGridViewTextBoxColumn.Width = 83;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descuentoDataGridViewTextBoxColumn.Width = 84;
            // 
            // tipoCompraDataGridViewTextBoxColumn
            // 
            this.tipoCompraDataGridViewTextBoxColumn.DataPropertyName = "tipoCompra";
            this.tipoCompraDataGridViewTextBoxColumn.HeaderText = "Tipo Compra";
            this.tipoCompraDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoCompraDataGridViewTextBoxColumn.Name = "tipoCompraDataGridViewTextBoxColumn";
            this.tipoCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tipoCompraDataGridViewTextBoxColumn.Width = 85;
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            this.tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "tipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.HeaderText = "Tipo Cambio";
            this.tipoCambioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            this.tipoCambioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoCambioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tipoCambioDataGridViewTextBoxColumn.Width = 84;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.subTotalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.subTotalDataGridViewTextBoxColumn.Width = 72;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.totalDataGridViewTextBoxColumn.Width = 56;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.observacionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.observacionDataGridViewTextBoxColumn.Width = 92;
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
            this.estadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idProveedorDataGridViewTextBoxColumn.Visible = false;
            this.idProveedorDataGridViewTextBoxColumn.Width = 89;
            // 
            // idPagoDataGridViewTextBoxColumn
            // 
            this.idPagoDataGridViewTextBoxColumn.DataPropertyName = "idPago";
            this.idPagoDataGridViewTextBoxColumn.HeaderText = "idPago";
            this.idPagoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idPagoDataGridViewTextBoxColumn.Name = "idPagoDataGridViewTextBoxColumn";
            this.idPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idPagoDataGridViewTextBoxColumn.Visible = false;
            this.idPagoDataGridViewTextBoxColumn.Width = 65;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idPersonalDataGridViewTextBoxColumn.Visible = false;
            this.idPersonalDataGridViewTextBoxColumn.Width = 81;
            // 
            // idTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.idTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "idTipoDocumento";
            this.idTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "idTipoDocumento";
            this.idTipoDocumentoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idTipoDocumentoDataGridViewTextBoxColumn.Name = "idTipoDocumentoDataGridViewTextBoxColumn";
            this.idTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoDocumentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idTipoDocumentoDataGridViewTextBoxColumn.Visible = false;
            this.idTipoDocumentoDataGridViewTextBoxColumn.Width = 116;
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
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idSucursalDataGridViewTextBoxColumn.Visible = false;
            this.idSucursalDataGridViewTextBoxColumn.Width = 81;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.vendedorDataGridViewTextBoxColumn.Width = 78;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(Entidad.Compra);
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
            this.toolStripNavigation.Location = new System.Drawing.Point(1, 525);
            this.toolStripNavigation.Name = "toolStripNavigation";
            this.toolStripNavigation.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripNavigation.Size = new System.Drawing.Size(880, 30);
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
            // toolStripTools
            // 
            this.toolStripTools.AutoSize = false;
            this.toolStripTools.BackColor = System.Drawing.Color.White;
            this.toolStripTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.textBuscar,
            this.btnBuscar});
            this.toolStripTools.Location = new System.Drawing.Point(1, 87);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.toolStripTools.Size = new System.Drawing.Size(880, 45);
            this.toolStripTools.TabIndex = 14;
            this.toolStripTools.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 26);
            this.toolStripButton6.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.AutoSize = false;
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(300, 22);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 26);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.ToolTipText = "Buscar (Enter)";
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
            this.cbxPersonales,
            this.cbxEstados,
            this.btnConsultar});
            this.toolStripCrud.Location = new System.Drawing.Point(1, 42);
            this.toolStripCrud.Name = "toolStripCrud";
            this.toolStripCrud.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.toolStripCrud.Size = new System.Drawing.Size(880, 45);
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
            // cbxPersonales
            // 
            this.cbxPersonales.AutoSize = false;
            this.cbxPersonales.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxPersonales.Name = "cbxPersonales";
            this.cbxPersonales.Size = new System.Drawing.Size(151, 23);
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
            this.panelHeaderItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeaderItem1.Name = "panelHeaderItem1";
            this.panelHeaderItem1.Size = new System.Drawing.Size(880, 41);
            this.panelHeaderItem1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRAS";
            // 
            // UCCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCCompras";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(898, 572);
            this.Load += new System.EventHandler(this.UCCompras_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.toolStripNavigation.ResumeLayout(false);
            this.toolStripNavigation.PerformLayout();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStripTools;
        private System.Windows.Forms.ToolStripLabel toolStripButton6;
        private System.Windows.Forms.ToolStripTextBox textBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStrip toolStripCrud;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.ToolStripComboBox cbxPersonales;
        private System.Windows.Forms.ToolStripComboBox cbxEstados;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroOrdenCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucDniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
    }
}
