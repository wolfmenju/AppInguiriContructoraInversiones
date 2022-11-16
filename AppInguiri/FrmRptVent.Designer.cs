namespace AppInguiri
{
    partial class FrmRptVent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptVent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanOpciones = new System.Windows.Forms.Panel();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.cbxOpcionDetalle = new System.Windows.Forms.ComboBox();
            this.cbxOpcionPrincipal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.PanInferior = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.PanTodo = new System.Windows.Forms.Panel();
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.nIdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCredito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanOpciones.SuspendLayout();
            this.PanSuperior.SuspendLayout();
            this.PanInferior.SuspendLayout();
            this.PanTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanOpciones
            // 
            this.PanOpciones.BackColor = System.Drawing.Color.White;
            this.PanOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanOpciones.Controls.Add(this.btnDescargar);
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
            // btnDescargar
            // 
            this.btnDescargar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.Black;
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.Location = new System.Drawing.Point(5, 79);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(110, 78);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.TabStop = false;
            this.btnDescargar.Text = "&Descargar [F6]";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = global::AppInguiri.Properties.Resources.xImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(5, 162);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 64);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "&Imprimir [F5]";
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
            this.btnBuscar.Text = "&Buscar    [F4]";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PanSuperior
            // 
            this.PanSuperior.BackColor = System.Drawing.Color.White;
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.chkTodos);
            this.PanSuperior.Controls.Add(this.cbxOpcionDetalle);
            this.PanSuperior.Controls.Add(this.cbxOpcionPrincipal);
            this.PanSuperior.Controls.Add(this.label3);
            this.PanSuperior.Controls.Add(this.Label2);
            this.PanSuperior.Controls.Add(this.Label1);
            this.PanSuperior.Controls.Add(this.dtFechaFin);
            this.PanSuperior.Controls.Add(this.dtFechaInicio);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(1070, 81);
            this.PanSuperior.TabIndex = 4;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Checked = true;
            this.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTodos.Location = new System.Drawing.Point(632, 49);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(68, 21);
            this.chkTodos.TabIndex = 67;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Visible = false;
            this.chkTodos.Click += new System.EventHandler(this.chkTodos_Click);
            // 
            // cbxOpcionDetalle
            // 
            this.cbxOpcionDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpcionDetalle.FormattingEnabled = true;
            this.cbxOpcionDetalle.Location = new System.Drawing.Point(439, 46);
            this.cbxOpcionDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxOpcionDetalle.Name = "cbxOpcionDetalle";
            this.cbxOpcionDetalle.Size = new System.Drawing.Size(179, 24);
            this.cbxOpcionDetalle.TabIndex = 66;
            this.cbxOpcionDetalle.Visible = false;
            this.cbxOpcionDetalle.SelectionChangeCommitted += new System.EventHandler(this.cbxOpcionDetalle_SelectionChangeCommitted);
            // 
            // cbxOpcionPrincipal
            // 
            this.cbxOpcionPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpcionPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxOpcionPrincipal.FormattingEnabled = true;
            this.cbxOpcionPrincipal.Items.AddRange(new object[] {
            "RESUMEN GENERAL POR MEDIO DE PAGO",
            "DETALLADO POR MEDIO DE PAGO"});
            this.cbxOpcionPrincipal.Location = new System.Drawing.Point(131, 46);
            this.cbxOpcionPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxOpcionPrincipal.Name = "cbxOpcionPrincipal";
            this.cbxOpcionPrincipal.Size = new System.Drawing.Size(300, 24);
            this.cbxOpcionPrincipal.TabIndex = 65;
            this.cbxOpcionPrincipal.SelectionChangeCommitted += new System.EventHandler(this.cbxOpcionPrincipal_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tipo de Reporte";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(215, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 17);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "---";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 17);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Fechas";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(245, 10);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(112, 23);
            this.dtFechaFin.TabIndex = 1;
            this.dtFechaFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFechaFin_KeyDown);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(90, 10);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(114, 23);
            this.dtFechaInicio.TabIndex = 0;
            this.dtFechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFechaInicio_KeyDown);
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
            // PanTodo
            // 
            this.PanTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanTodo.Controls.Add(this.dgvReporteVentas);
            this.PanTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTodo.Location = new System.Drawing.Point(0, 81);
            this.PanTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanTodo.Name = "PanTodo";
            this.PanTodo.Size = new System.Drawing.Size(1070, 466);
            this.PanTodo.TabIndex = 6;
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.AllowUserToAddRows = false;
            this.dgvReporteVentas.AllowUserToDeleteRows = false;
            this.dgvReporteVentas.AllowUserToResizeColumns = false;
            this.dgvReporteVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReporteVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReporteVentas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReporteVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIdCompra,
            this.nIdAlmacen,
            this.sIdDocumento,
            this.nIdProveedor,
            this.sRazonSocial,
            this.sRuc,
            this.bCredito,
            this.dFecha,
            this.fTotal,
            this.bEstado});
            this.dgvReporteVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvReporteVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReporteVentas.MultiSelect = false;
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReporteVentas.RowHeadersVisible = false;
            this.dgvReporteVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteVentas.Size = new System.Drawing.Size(1068, 464);
            this.dgvReporteVentas.TabIndex = 1;
            // 
            // nIdCompra
            // 
            this.nIdCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdCompra.DataPropertyName = "nIdCompra";
            this.nIdCompra.HeaderText = "IdCompra";
            this.nIdCompra.Name = "nIdCompra";
            this.nIdCompra.ReadOnly = true;
            this.nIdCompra.Visible = false;
            // 
            // nIdAlmacen
            // 
            this.nIdAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdAlmacen.DataPropertyName = "nIdAlmacen";
            this.nIdAlmacen.HeaderText = "IdAlmacen";
            this.nIdAlmacen.Name = "nIdAlmacen";
            this.nIdAlmacen.ReadOnly = true;
            this.nIdAlmacen.Visible = false;
            // 
            // sIdDocumento
            // 
            this.sIdDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sIdDocumento.DataPropertyName = "sIdDocumento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sIdDocumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.sIdDocumento.HeaderText = "Documento";
            this.sIdDocumento.Name = "sIdDocumento";
            this.sIdDocumento.ReadOnly = true;
            this.sIdDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sIdDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sIdDocumento.Width = 87;
            // 
            // nIdProveedor
            // 
            this.nIdProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdProveedor.DataPropertyName = "nIdProveedor";
            this.nIdProveedor.HeaderText = "IdProveedor";
            this.nIdProveedor.Name = "nIdProveedor";
            this.nIdProveedor.ReadOnly = true;
            this.nIdProveedor.Visible = false;
            // 
            // sRazonSocial
            // 
            this.sRazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sRazonSocial.DataPropertyName = "sRazonSocial";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sRazonSocial.DefaultCellStyle = dataGridViewCellStyle4;
            this.sRazonSocial.HeaderText = "Razón Social";
            this.sRazonSocial.Name = "sRazonSocial";
            this.sRazonSocial.ReadOnly = true;
            this.sRazonSocial.Width = 113;
            // 
            // sRuc
            // 
            this.sRuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sRuc.DataPropertyName = "sRuc";
            this.sRuc.HeaderText = "Ruc";
            this.sRuc.Name = "sRuc";
            this.sRuc.ReadOnly = true;
            this.sRuc.Width = 61;
            // 
            // bCredito
            // 
            this.bCredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bCredito.DataPropertyName = "bCredito";
            this.bCredito.HeaderText = "Crédito";
            this.bCredito.Name = "bCredito";
            this.bCredito.ReadOnly = true;
            this.bCredito.Width = 58;
            // 
            // dFecha
            // 
            this.dFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dFecha.DataPropertyName = "dFecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dFecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.dFecha.HeaderText = "Fecha";
            this.dFecha.Name = "dFecha";
            this.dFecha.ReadOnly = true;
            this.dFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dFecha.Width = 50;
            // 
            // fTotal
            // 
            this.fTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fTotal.DataPropertyName = "fTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.fTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.fTotal.HeaderText = "Total";
            this.fTotal.Name = "fTotal";
            this.fTotal.ReadOnly = true;
            this.fTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fTotal.Width = 44;
            // 
            // bEstado
            // 
            this.bEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bEstado.DataPropertyName = "bEstado";
            this.bEstado.HeaderText = "Estado";
            this.bEstado.Name = "bEstado";
            this.bEstado.ReadOnly = true;
            this.bEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bEstado.Width = 79;
            // 
            // FrmRptVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 567);
            this.ControlBox = false;
            this.Controls.Add(this.PanTodo);
            this.Controls.Add(this.PanInferior);
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.PanOpciones);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRptVent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FrmRptVent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRptCompras_KeyDown);
            this.PanOpciones.ResumeLayout(false);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.PanInferior.ResumeLayout(false);
            this.PanInferior.PerformLayout();
            this.PanTodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanOpciones;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtFechaFin;
        internal System.Windows.Forms.DateTimePicker dtFechaInicio;
        internal System.Windows.Forms.Panel PanInferior;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Panel PanTodo;
        internal System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bEstado;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.ComboBox cbxOpcionDetalle;
        private System.Windows.Forms.ComboBox cbxOpcionPrincipal;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnDescargar;
    }
}