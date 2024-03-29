﻿namespace AppInguiri
{
    partial class FrmRptKardex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptKardex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanOpciones = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PanInferior = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboAlmacen = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PanTodo = new System.Windows.Forms.Panel();
            this.dgvKardex = new System.Windows.Forms.DataGridView();
            this.dFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMedSunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMedSunat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdProductoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanOpciones.SuspendLayout();
            this.PanInferior.SuspendLayout();
            this.PanSuperior.SuspendLayout();
            this.PanTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // PanOpciones
            // 
            this.PanOpciones.BackColor = System.Drawing.Color.White;
            this.PanOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanOpciones.Controls.Add(this.btnImprimir);
            this.PanOpciones.Controls.Add(this.btnSalir);
            this.PanOpciones.Controls.Add(this.btnBuscar);
            this.PanOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanOpciones.Location = new System.Drawing.Point(1070, 0);
            this.PanOpciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanOpciones.Name = "PanOpciones";
            this.PanOpciones.Size = new System.Drawing.Size(122, 567);
            this.PanOpciones.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = global::AppInguiri.Properties.Resources.xImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(5, 81);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 64);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "&Imprimir [F2]";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::AppInguiri.Properties.Resources.xSalir;
            this.btnSalir.Location = new System.Drawing.Point(5, 487);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 64);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "&Salir      [Esc]";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(5, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 64);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "&Buscar    [F1]";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PanInferior
            // 
            this.PanInferior.BackColor = System.Drawing.Color.White;
            this.PanInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanInferior.Controls.Add(this.lblTotal);
            this.PanInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanInferior.Location = new System.Drawing.Point(0, 547);
            this.PanInferior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanInferior.Name = "PanInferior";
            this.PanInferior.Size = new System.Drawing.Size(1070, 20);
            this.PanInferior.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = " Se Encontraron 00 Registros";
            // 
            // PanSuperior
            // 
            this.PanSuperior.BackColor = System.Drawing.Color.White;
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.chkFecha);
            this.PanSuperior.Controls.Add(this.Label2);
            this.PanSuperior.Controls.Add(this.dtFechaFinal);
            this.PanSuperior.Controls.Add(this.dtFechaInicio);
            this.PanSuperior.Controls.Add(this.lblStock);
            this.PanSuperior.Controls.Add(this.lblCodigo);
            this.PanSuperior.Controls.Add(this.lblDescripcion);
            this.PanSuperior.Controls.Add(this.Label3);
            this.PanSuperior.Controls.Add(this.Label1);
            this.PanSuperior.Controls.Add(this.cboAlmacen);
            this.PanSuperior.Controls.Add(this.Label4);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(1070, 78);
            this.PanSuperior.TabIndex = 6;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFecha.Location = new System.Drawing.Point(5, 44);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(74, 21);
            this.chkFecha.TabIndex = 53;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.Click += new System.EventHandler(this.chkFecha_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(207, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 17);
            this.Label2.TabIndex = 52;
            this.Label2.Text = "---";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Enabled = false;
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(233, 41);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(123, 23);
            this.dtFechaFinal.TabIndex = 51;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Enabled = false;
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(80, 42);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(123, 23);
            this.dtFechaInicio.TabIndex = 50;
            // 
            // lblStock
            // 
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Blue;
            this.lblStock.Location = new System.Drawing.Point(785, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(137, 24);
            this.lblStock.TabIndex = 49;
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Blue;
            this.lblCodigo.Location = new System.Drawing.Point(79, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(123, 24);
            this.lblCodigo.TabIndex = 48;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Blue;
            this.lblDescripcion.Location = new System.Drawing.Point(244, 10);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(534, 24);
            this.lblDescripcion.TabIndex = 47;
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 14);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 17);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Producto";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(206, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 17);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "[F1]";
            // 
            // cboAlmacen
            // 
            this.cboAlmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlmacen.FormattingEnabled = true;
            this.cboAlmacen.Location = new System.Drawing.Point(427, 42);
            this.cboAlmacen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboAlmacen.Name = "cboAlmacen";
            this.cboAlmacen.Size = new System.Drawing.Size(494, 25);
            this.cboAlmacen.TabIndex = 40;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(359, 46);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 17);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Almacén";
            // 
            // PanTodo
            // 
            this.PanTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanTodo.Controls.Add(this.dgvKardex);
            this.PanTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTodo.Location = new System.Drawing.Point(0, 78);
            this.PanTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanTodo.Name = "PanTodo";
            this.PanTodo.Size = new System.Drawing.Size(1070, 469);
            this.PanTodo.TabIndex = 7;
            // 
            // dgvKardex
            // 
            this.dgvKardex.AllowUserToAddRows = false;
            this.dgvKardex.AllowUserToDeleteRows = false;
            this.dgvKardex.AllowUserToResizeColumns = false;
            this.dgvKardex.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKardex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKardex.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKardex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dFechaVencimiento,
            this.sPresentacion,
            this.sAlmacen,
            this.sIdLote,
            this.sLaboratorio,
            this.sTipoOperacion,
            this.sLote,
            this.sMedSunat,
            this.nIdLote,
            this.sMedSunat2,
            this.nIdProductoHistorial,
            this.nStock});
            this.dgvKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKardex.Location = new System.Drawing.Point(0, 0);
            this.dgvKardex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKardex.MultiSelect = false;
            this.dgvKardex.Name = "dgvKardex";
            this.dgvKardex.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKardex.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvKardex.RowHeadersVisible = false;
            this.dgvKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKardex.Size = new System.Drawing.Size(1068, 467);
            this.dgvKardex.TabIndex = 1;
            // 
            // dFechaVencimiento
            // 
            this.dFechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dFechaVencimiento.DataPropertyName = "dFechaVencimiento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dFechaVencimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dFechaVencimiento.HeaderText = "Fecha Registro";
            this.dFechaVencimiento.Name = "dFechaVencimiento";
            this.dFechaVencimiento.ReadOnly = true;
            this.dFechaVencimiento.Width = 127;
            // 
            // sPresentacion
            // 
            this.sPresentacion.DataPropertyName = "sPresentacion";
            this.sPresentacion.HeaderText = "sPresentacion";
            this.sPresentacion.Name = "sPresentacion";
            this.sPresentacion.ReadOnly = true;
            this.sPresentacion.Visible = false;
            // 
            // sAlmacen
            // 
            this.sAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sAlmacen.DataPropertyName = "sAlmacen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sAlmacen.DefaultCellStyle = dataGridViewCellStyle4;
            this.sAlmacen.HeaderText = "Documento";
            this.sAlmacen.Name = "sAlmacen";
            this.sAlmacen.ReadOnly = true;
            this.sAlmacen.Width = 110;
            // 
            // sIdLote
            // 
            this.sIdLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sIdLote.DataPropertyName = "sIdLote";
            this.sIdLote.HeaderText = "Serie";
            this.sIdLote.Name = "sIdLote";
            this.sIdLote.ReadOnly = true;
            this.sIdLote.Width = 66;
            // 
            // sLaboratorio
            // 
            this.sLaboratorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sLaboratorio.DataPropertyName = "sLaboratorio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sLaboratorio.DefaultCellStyle = dataGridViewCellStyle5;
            this.sLaboratorio.HeaderText = "Numeración";
            this.sLaboratorio.Name = "sLaboratorio";
            this.sLaboratorio.ReadOnly = true;
            this.sLaboratorio.Width = 110;
            // 
            // sTipoOperacion
            // 
            this.sTipoOperacion.DataPropertyName = "sTipoOperacion";
            this.sTipoOperacion.HeaderText = "Tipo de Operación";
            this.sTipoOperacion.Name = "sTipoOperacion";
            this.sTipoOperacion.ReadOnly = true;
            // 
            // sLote
            // 
            this.sLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sLote.DataPropertyName = "sLote";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sLote.DefaultCellStyle = dataGridViewCellStyle6;
            this.sLote.HeaderText = "Lote";
            this.sLote.Name = "sLote";
            this.sLote.ReadOnly = true;
            this.sLote.Visible = false;
            this.sLote.Width = 64;
            // 
            // sMedSunat
            // 
            this.sMedSunat.DataPropertyName = "sMedSunat";
            this.sMedSunat.HeaderText = "U.M";
            this.sMedSunat.Name = "sMedSunat";
            this.sMedSunat.ReadOnly = true;
            // 
            // nIdLote
            // 
            this.nIdLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdLote.DataPropertyName = "nIdLote";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nIdLote.DefaultCellStyle = dataGridViewCellStyle7;
            this.nIdLote.HeaderText = "Entrada";
            this.nIdLote.Name = "nIdLote";
            this.nIdLote.ReadOnly = true;
            this.nIdLote.Width = 85;
            // 
            // sMedSunat2
            // 
            this.sMedSunat2.DataPropertyName = "sMedSunat";
            this.sMedSunat2.HeaderText = "U.M";
            this.sMedSunat2.Name = "sMedSunat2";
            this.sMedSunat2.ReadOnly = true;
            // 
            // nIdProductoHistorial
            // 
            this.nIdProductoHistorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdProductoHistorial.DataPropertyName = "nIdProductoHistorial";
            this.nIdProductoHistorial.HeaderText = "Salida";
            this.nIdProductoHistorial.Name = "nIdProductoHistorial";
            this.nIdProductoHistorial.ReadOnly = true;
            this.nIdProductoHistorial.Width = 71;
            // 
            // nStock
            // 
            this.nStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nStock.DataPropertyName = "nStock";
            this.nStock.HeaderText = "Stock";
            this.nStock.Name = "nStock";
            this.nStock.ReadOnly = true;
            this.nStock.Width = 72;
            // 
            // FrmRptKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 567);
            this.ControlBox = false;
            this.Controls.Add(this.PanTodo);
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.PanInferior);
            this.Controls.Add(this.PanOpciones);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRptKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de Productos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptKardex_KeyDown);
            this.PanOpciones.ResumeLayout(false);
            this.PanInferior.ResumeLayout(false);
            this.PanInferior.PerformLayout();
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.PanTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanOpciones;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Panel PanInferior;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.ComboBox cboAlmacen;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel PanTodo;
        internal System.Windows.Forms.DataGridView dgvKardex;
        internal System.Windows.Forms.CheckBox chkFecha;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtFechaFinal;
        internal System.Windows.Forms.DateTimePicker dtFechaInicio;
        internal System.Windows.Forms.Label lblStock;
        internal System.Windows.Forms.Label lblCodigo;
        internal System.Windows.Forms.Label lblDescripcion;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMedSunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMedSunat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdProductoHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nStock;
    }
}