namespace AppInguiri
{
    partial class FrmRptSockMinimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptSockMinimo));
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
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.cboAlmacen = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PanTodo = new System.Windows.Forms.Panel();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.sCodigoInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMedSunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMedSunat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdProductoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanOpciones.SuspendLayout();
            this.PanInferior.SuspendLayout();
            this.PanSuperior.SuspendLayout();
            this.PanTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
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
            this.PanSuperior.Controls.Add(this.chkTodos);
            this.PanSuperior.Controls.Add(this.cboAlmacen);
            this.PanSuperior.Controls.Add(this.Label4);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(1070, 75);
            this.PanSuperior.TabIndex = 6;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Checked = true;
            this.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(581, 12);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(233, 21);
            this.chkTodos.TabIndex = 44;
            this.chkTodos.Text = "[F1] - Todos Los Almacenes";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Visible = false;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // cboAlmacen
            // 
            this.cboAlmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacen.Enabled = false;
            this.cboAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlmacen.FormattingEnabled = true;
            this.cboAlmacen.Location = new System.Drawing.Point(79, 10);
            this.cboAlmacen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboAlmacen.Name = "cboAlmacen";
            this.cboAlmacen.Size = new System.Drawing.Size(494, 25);
            this.cboAlmacen.TabIndex = 40;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 17);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Almacén";
            // 
            // PanTodo
            // 
            this.PanTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanTodo.Controls.Add(this.dgvProducto);
            this.PanTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTodo.Location = new System.Drawing.Point(0, 75);
            this.PanTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanTodo.Name = "PanTodo";
            this.PanTodo.Size = new System.Drawing.Size(1070, 472);
            this.PanTodo.TabIndex = 7;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AllowUserToResizeColumns = false;
            this.dgvProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCodigoInterno,
            this.sNombreProducto,
            this.dFechaVencimiento,
            this.sAlmacen,
            this.sIdLote,
            this.sLaboratorio,
            this.sTipoOperacion,
            this.sLote,
            this.sPresentacion,
            this.sMedSunat,
            this.nIdLote,
            this.sMedSunat2,
            this.nIdProductoHistorial,
            this.nStock,
            this.nIdAlmacen});
            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducto.Location = new System.Drawing.Point(0, 0);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(1068, 470);
            this.dgvProducto.TabIndex = 2;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFecha.Location = new System.Drawing.Point(22, 43);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(74, 21);
            this.chkFecha.TabIndex = 57;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.Click += new System.EventHandler(this.chkFecha_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(226, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 17);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "---";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Enabled = false;
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(255, 41);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(123, 23);
            this.dtFechaFinal.TabIndex = 55;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Enabled = false;
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(100, 41);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(123, 23);
            this.dtFechaInicio.TabIndex = 54;
            // 
            // sCodigoInterno
            // 
            this.sCodigoInterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sCodigoInterno.DataPropertyName = "sCodigoInterno";
            this.sCodigoInterno.HeaderText = " Codigo Interno";
            this.sCodigoInterno.Name = "sCodigoInterno";
            this.sCodigoInterno.ReadOnly = true;
            this.sCodigoInterno.Width = 122;
            // 
            // sNombreProducto
            // 
            this.sNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNombreProducto.DataPropertyName = "sNombreProducto";
            this.sNombreProducto.HeaderText = "Producto";
            this.sNombreProducto.Name = "sNombreProducto";
            this.sNombreProducto.ReadOnly = true;
            this.sNombreProducto.Width = 94;
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
            this.dFechaVencimiento.Width = 117;
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
            // sPresentacion
            // 
            this.sPresentacion.DataPropertyName = "sPresentacion";
            this.sPresentacion.HeaderText = "sPresentacion";
            this.sPresentacion.Name = "sPresentacion";
            this.sPresentacion.ReadOnly = true;
            this.sPresentacion.Visible = false;
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
            // nIdAlmacen
            // 
            this.nIdAlmacen.DataPropertyName = "nIdAlmacen";
            this.nIdAlmacen.HeaderText = "TotalGeneral";
            this.nIdAlmacen.Name = "nIdAlmacen";
            this.nIdAlmacen.ReadOnly = true;
            this.nIdAlmacen.Visible = false;
            // 
            // FrmRptSockMinimo
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
            this.Name = "FrmRptSockMinimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Stock de Productos";
            this.Load += new System.EventHandler(this.FrmRptLoteProductoPorVencer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptLoteProductoPorVencer_KeyDown);
            this.PanOpciones.ResumeLayout(false);
            this.PanInferior.ResumeLayout(false);
            this.PanInferior.PerformLayout();
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.PanTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
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
        internal System.Windows.Forms.CheckBox chkTodos;
        internal System.Windows.Forms.ComboBox cboAlmacen;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel PanTodo;
        internal System.Windows.Forms.DataGridView dgvProducto;
        internal System.Windows.Forms.CheckBox chkFecha;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtFechaFinal;
        internal System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCodigoInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTipoOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMedSunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMedSunat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdProductoHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdAlmacen;
    }
}