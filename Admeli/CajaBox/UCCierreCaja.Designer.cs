﻿namespace Admeli.CajaBox
{
    partial class UCCierreCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCierreCaja));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idCierreCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCajaSesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cierreCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpeedPages = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPageCount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCurrentPage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageAllItems = new System.Windows.Forms.Label();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbxPersonales = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl20 = new System.Windows.Forms.Label();
            this.panelCrud = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCajaEstado = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaBindingSource)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.panelCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelNavigation);
            this.panelContainer.Controls.Add(this.panelTools);
            this.panelContainer.Controls.Add(this.panelCrud);
            this.panelContainer.Controls.Add(this.lblCajaEstado);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(11, 10);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(1225, 571);
            this.panelContainer.TabIndex = 8;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(1223, 310);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCierreCajaDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaCierreDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.idCajaSesionDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.idPersonalDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cierreCajaBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(13, 12);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1197, 286);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // idCierreCajaDataGridViewTextBoxColumn
            // 
            this.idCierreCajaDataGridViewTextBoxColumn.DataPropertyName = "idCierreCaja";
            this.idCierreCajaDataGridViewTextBoxColumn.HeaderText = "idCierreCaja";
            this.idCierreCajaDataGridViewTextBoxColumn.Name = "idCierreCajaDataGridViewTextBoxColumn";
            this.idCierreCajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCierreCajaDataGridViewTextBoxColumn.Width = 134;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 121;
            // 
            // fechaCierreDataGridViewTextBoxColumn
            // 
            this.fechaCierreDataGridViewTextBoxColumn.DataPropertyName = "fechaCierre";
            this.fechaCierreDataGridViewTextBoxColumn.HeaderText = "fechaCierre";
            this.fechaCierreDataGridViewTextBoxColumn.Name = "fechaCierreDataGridViewTextBoxColumn";
            this.fechaCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCierreDataGridViewTextBoxColumn.Width = 128;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionDataGridViewTextBoxColumn.Width = 134;
            // 
            // idCajaSesionDataGridViewTextBoxColumn
            // 
            this.idCajaSesionDataGridViewTextBoxColumn.DataPropertyName = "idCajaSesion";
            this.idCajaSesionDataGridViewTextBoxColumn.HeaderText = "idCajaSesion";
            this.idCajaSesionDataGridViewTextBoxColumn.Name = "idCajaSesionDataGridViewTextBoxColumn";
            this.idCajaSesionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCajaSesionDataGridViewTextBoxColumn.Width = 139;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn.Width = 107;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonalDataGridViewTextBoxColumn.Width = 121;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "idSucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.Width = 121;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 98;
            // 
            // cierreCajaBindingSource
            // 
            this.cierreCajaBindingSource.DataSource = typeof(Entidad.CierreCaja);
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.label2);
            this.panelNavigation.Controls.Add(this.lblSpeedPages);
            this.panelNavigation.Controls.Add(this.panel5);
            this.panelNavigation.Controls.Add(this.lblPageAllItems);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(1, 496);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1223, 74);
            this.panelNavigation.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(1071, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mostrar cada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpeedPages
            // 
            this.lblSpeedPages.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpeedPages.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblSpeedPages.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lblSpeedPages.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
            this.lblSpeedPages.BorderThickness = 1;
            this.lblSpeedPages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSpeedPages.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblSpeedPages.isPassword = false;
            this.lblSpeedPages.Location = new System.Drawing.Point(1149, 16);
            this.lblSpeedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSpeedPages.Name = "lblSpeedPages";
            this.lblSpeedPages.Size = new System.Drawing.Size(60, 43);
            this.lblSpeedPages.TabIndex = 10;
            this.lblSpeedPages.Text = "10";
            this.lblSpeedPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblSpeedPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblSpeedPages_KeyPress);
            this.lblSpeedPages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lblSpeedPages_KeyUp);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblPageCount);
            this.panel5.Controls.Add(this.lblCurrentPage);
            this.panel5.Controls.Add(this.btnFirst);
            this.panel5.Controls.Add(this.btnLast);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnPrevious);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Location = new System.Drawing.Point(381, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 68);
            this.panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(195, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Página";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPageCount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPageCount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lblPageCount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
            this.lblPageCount.BorderThickness = 1;
            this.lblPageCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPageCount.Enabled = false;
            this.lblPageCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblPageCount.isPassword = false;
            this.lblPageCount.Location = new System.Drawing.Point(248, 18);
            this.lblPageCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(60, 43);
            this.lblPageCount.TabIndex = 1;
            this.lblPageCount.Text = "1";
            this.lblPageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrentPage.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCurrentPage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.lblCurrentPage.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
            this.lblCurrentPage.BorderThickness = 1;
            this.lblCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCurrentPage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblCurrentPage.isPassword = false;
            this.lblCurrentPage.Location = new System.Drawing.Point(152, 18);
            this.lblCurrentPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(60, 43);
            this.lblCurrentPage.TabIndex = 0;
            this.lblCurrentPage.Text = "1";
            this.lblCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblCurrentPage_KeyPress);
            this.lblCurrentPage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lblCurrentPage_KeyUp);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFirst.Location = new System.Drawing.Point(11, 18);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 43);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLast.Location = new System.Drawing.Point(389, 18);
            this.btnLast.Margin = new System.Windows.Forms.Padding(0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 43);
            this.btnLast.TabIndex = 10;
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(216, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "DE";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.Location = new System.Drawing.Point(81, 18);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 43);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(319, 18);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 43);
            this.btnNext.TabIndex = 6;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageAllItems
            // 
            this.lblPageAllItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPageAllItems.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageAllItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblPageAllItems.Location = new System.Drawing.Point(9, 16);
            this.lblPageAllItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageAllItems.Name = "lblPageAllItems";
            this.lblPageAllItems.Size = new System.Drawing.Size(93, 43);
            this.lblPageAllItems.TabIndex = 1;
            this.lblPageAllItems.Text = "10 Registros";
            this.lblPageAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.btnConsultar);
            this.panelTools.Controls.Add(this.panel13);
            this.panelTools.Controls.Add(this.panel10);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(1, 122);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1223, 64);
            this.panelTools.TabIndex = 27;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(472, 9);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(144, 49);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "  Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbxPersonales);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(241, 9);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(220, 49);
            this.panel13.TabIndex = 15;
            // 
            // cbxPersonales
            // 
            this.cbxPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPersonales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxPersonales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPersonales.DataSource = this.personalBindingSource;
            this.cbxPersonales.DisplayMember = "nombres";
            this.cbxPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPersonales.FormattingEnabled = true;
            this.cbxPersonales.Location = new System.Drawing.Point(4, 17);
            this.cbxPersonales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPersonales.Name = "cbxPersonales";
            this.cbxPersonales.Size = new System.Drawing.Size(209, 28);
            this.cbxPersonales.TabIndex = 1;
            this.cbxPersonales.ValueMember = "idPersonal";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(Entidad.Personal);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personales";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbxSucursales);
            this.panel10.Controls.Add(this.lbl20);
            this.panel10.Location = new System.Drawing.Point(13, 9);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(220, 49);
            this.panel10.TabIndex = 13;
            // 
            // cbxSucursales
            // 
            this.cbxSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSucursales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxSucursales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSucursales.DataSource = this.sucursalBindingSource;
            this.cbxSucursales.DisplayMember = "nombre";
            this.cbxSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(4, 17);
            this.cbxSucursales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(209, 28);
            this.cbxSucursales.TabIndex = 1;
            this.cbxSucursales.ValueMember = "idSucursal";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Entidad.Sucursal);
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.Color.DimGray;
            this.lbl20.Location = new System.Drawing.Point(4, 4);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(78, 16);
            this.lbl20.TabIndex = 0;
            this.lbl20.Text = "Sucursales";
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.btnNuevo);
            this.panelCrud.Controls.Add(this.btnModificar);
            this.panelCrud.Controls.Add(this.btnActualizar);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrud.Location = new System.Drawing.Point(1, 48);
            this.panelCrud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Padding = new System.Windows.Forms.Padding(13, 18, 0, 0);
            this.panelCrud.Size = new System.Drawing.Size(1223, 74);
            this.panelCrud.TabIndex = 23;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(209)))), ((int)(((byte)(96)))));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(13, 18);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(193, 49);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "  Arquear Caja (F3)";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(219, 18);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(173, 49);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "  Detalle (F4)";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(405, 18);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(189, 49);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "  Actualizar (F5)";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCajaEstado
            // 
            this.lblCajaEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.lblCajaEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCajaEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblCajaEstado.Location = new System.Drawing.Point(1, 1);
            this.lblCajaEstado.Name = "lblCajaEstado";
            this.lblCajaEstado.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lblCajaEstado.Size = new System.Drawing.Size(1223, 47);
            this.lblCajaEstado.TabIndex = 19;
            this.lblCajaEstado.Text = "alert message";
            this.lblCajaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCierreCaja";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(1247, 591);
            this.Load += new System.EventHandler(this.UCCierreCaja_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cierreCajaBindingSource)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.panelCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource cierreCajaBindingSource;
        private System.Windows.Forms.Label lblCajaEstado;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblSpeedPages;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblPageCount;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblCurrentPage;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageAllItems;
        private System.Windows.Forms.FlowLayoutPanel panelCrud;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbxPersonales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbxSucursales;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCierreCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCajaSesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}
