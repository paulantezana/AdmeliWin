﻿namespace Admeli.Ventas
{
    partial class UCCuentaCobrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCuentaCobrar));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbxPersonales = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbxAlmacenes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbxSucursales = new System.Windows.Forms.ComboBox();
            this.lbl20 = new System.Windows.Forms.Label();
            this.panelCrud = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelNavigation);
            this.panelContainer.Controls.Add(this.panelTools);
            this.panelContainer.Controls.Add(this.panelCrud);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(11, 10);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(1134, 554);
            this.panelContainer.TabIndex = 5;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(1132, 340);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.Location = new System.Drawing.Point(13, 12);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1106, 316);
            this.dataGridView.TabIndex = 2;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.label2);
            this.panelNavigation.Controls.Add(this.lblSpeedPages);
            this.panelNavigation.Controls.Add(this.panel5);
            this.panelNavigation.Controls.Add(this.lblPageAllItems);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(1, 479);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1132, 74);
            this.panelNavigation.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(980, 16);
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
            this.lblSpeedPages.Location = new System.Drawing.Point(1059, 16);
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
            this.panel5.Location = new System.Drawing.Point(336, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelTools.Controls.Add(this.panel11);
            this.panelTools.Controls.Add(this.panel13);
            this.panelTools.Controls.Add(this.panel12);
            this.panelTools.Controls.Add(this.panel10);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(1, 75);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1132, 64);
            this.panelTools.TabIndex = 26;
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
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(928, 9);
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
            // panel11
            // 
            this.panel11.Controls.Add(this.cbxEstados);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(697, 10);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(220, 49);
            this.panel11.TabIndex = 16;
            // 
            // cbxEstados
            // 
            this.cbxEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxEstados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(4, 17);
            this.cbxEstados.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(209, 28);
            this.cbxEstados.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estados";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbxPersonales);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(469, 10);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbxPersonales.DisplayMember = "nombres";
            this.cbxPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPersonales.FormattingEnabled = true;
            this.cbxPersonales.Location = new System.Drawing.Point(4, 17);
            this.cbxPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPersonales.Name = "cbxPersonales";
            this.cbxPersonales.Size = new System.Drawing.Size(209, 28);
            this.cbxPersonales.TabIndex = 1;
            this.cbxPersonales.ValueMember = "idPersonal";
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
            // panel12
            // 
            this.panel12.Controls.Add(this.cbxAlmacenes);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Location = new System.Drawing.Point(241, 9);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(220, 49);
            this.panel12.TabIndex = 14;
            // 
            // cbxAlmacenes
            // 
            this.cbxAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAlmacenes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxAlmacenes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAlmacenes.DisplayMember = "nombre";
            this.cbxAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlmacenes.FormattingEnabled = true;
            this.cbxAlmacenes.Location = new System.Drawing.Point(4, 17);
            this.cbxAlmacenes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAlmacenes.Name = "cbxAlmacenes";
            this.cbxAlmacenes.Size = new System.Drawing.Size(209, 28);
            this.cbxAlmacenes.TabIndex = 1;
            this.cbxAlmacenes.ValueMember = "idAlmacen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacenes";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbxSucursales);
            this.panel10.Controls.Add(this.lbl20);
            this.panel10.Location = new System.Drawing.Point(13, 9);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbxSucursales.DisplayMember = "nombre";
            this.cbxSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucursales.FormattingEnabled = true;
            this.cbxSucursales.Location = new System.Drawing.Point(4, 17);
            this.cbxSucursales.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSucursales.Name = "cbxSucursales";
            this.cbxSucursales.Size = new System.Drawing.Size(209, 28);
            this.cbxSucursales.TabIndex = 1;
            this.cbxSucursales.ValueMember = "idSucursal";
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
            this.panelCrud.Controls.Add(this.btnAnular);
            this.panelCrud.Controls.Add(this.btnEliminar);
            this.panelCrud.Controls.Add(this.btnActualizar);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrud.Location = new System.Drawing.Point(1, 1);
            this.panelCrud.Margin = new System.Windows.Forms.Padding(4);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Padding = new System.Windows.Forms.Padding(13, 18, 0, 0);
            this.panelCrud.Size = new System.Drawing.Size(1132, 74);
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
            this.btnNuevo.Size = new System.Drawing.Size(168, 49);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "  Nuevo (F3)";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
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
            this.btnModificar.Location = new System.Drawing.Point(194, 18);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(187, 49);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "  Modificar (F4)";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnAnular.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(394, 18);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAnular.Size = new System.Drawing.Size(168, 49);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Text = "  Anular (F7)";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(575, 18);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(184, 49);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "  Eliminar (F6)";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.btnActualizar.Location = new System.Drawing.Point(772, 18);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(189, 49);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "  Actualizar (F5)";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(Entidad.Personal);
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataSource = typeof(Entidad.Almacen);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(Entidad.Sucursal);
            // 
            // UCCuentaCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCuentaCobrar";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(1156, 574);
            this.Load += new System.EventHandler(this.UCCuentaCobrar_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelCrud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbxPersonales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbxAlmacenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbxSucursales;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
