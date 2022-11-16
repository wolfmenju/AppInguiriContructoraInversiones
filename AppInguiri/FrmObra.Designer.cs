namespace AppInguiri
{
    partial class FrmObra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.PanOpciones = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PanInferior = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PanTodo = new System.Windows.Forms.Panel();
            this.nIdInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIdAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDecripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.PanOpciones.SuspendLayout();
            this.PanInferior.SuspendLayout();
            this.PanTodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIdInventario,
            this.nItem,
            this.nIdAlmacen,
            this.sDecripcion,
            this.dFechaInicio,
            this.dFechaFin,
            this.bEstado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.Location = new System.Drawing.Point(0, 0);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1184, 565);
            this.dgvInventario.TabIndex = 10;
            // 
            // PanOpciones
            // 
            this.PanOpciones.BackColor = System.Drawing.Color.White;
            this.PanOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanOpciones.Controls.Add(this.BtnEliminar);
            this.PanOpciones.Controls.Add(this.BtnSalir);
            this.PanOpciones.Controls.Add(this.BtnRefrescar);
            this.PanOpciones.Controls.Add(this.BtnBuscar);
            this.PanOpciones.Controls.Add(this.BtnAgregar);
            this.PanOpciones.Controls.Add(this.BtnModificar);
            this.PanOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanOpciones.Location = new System.Drawing.Point(1186, 0);
            this.PanOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.PanOpciones.Name = "PanOpciones";
            this.PanOpciones.Size = new System.Drawing.Size(145, 591);
            this.PanOpciones.TabIndex = 11;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = global::AppInguiri.Properties.Resources.X;
            this.BtnEliminar.Location = new System.Drawing.Point(4, 299);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(136, 64);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Text = "&Cerrar [F5]";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Image = global::AppInguiri.Properties.Resources.xSalir;
            this.BtnSalir.Location = new System.Drawing.Point(4, 512);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(136, 64);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Text = "&Salir      [Esc]";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRefrescar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescar.ForeColor = System.Drawing.Color.Black;
            this.BtnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefrescar.Image")));
            this.BtnRefrescar.Location = new System.Drawing.Point(4, 156);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(136, 64);
            this.BtnRefrescar.TabIndex = 2;
            this.BtnRefrescar.TabStop = false;
            this.BtnRefrescar.Text = "&Recargar [F3]";
            this.BtnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(4, 228);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(136, 64);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.Text = "  &Buscar  [F4]";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgregar.Location = new System.Drawing.Point(4, 14);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(136, 64);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.TabStop = false;
            this.BtnAgregar.Text = "  &Nuevo  [F1]";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(4, 85);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(136, 64);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.TabStop = false;
            this.BtnModificar.Text = "&Actualizar [F2]";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PanInferior
            // 
            this.PanInferior.BackColor = System.Drawing.Color.White;
            this.PanInferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanInferior.Controls.Add(this.LblTotal);
            this.PanInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanInferior.Location = new System.Drawing.Point(0, 567);
            this.PanInferior.Margin = new System.Windows.Forms.Padding(4);
            this.PanInferior.Name = "PanInferior";
            this.PanInferior.Size = new System.Drawing.Size(1186, 24);
            this.PanInferior.TabIndex = 12;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Blue;
            this.LblTotal.Location = new System.Drawing.Point(0, 0);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(223, 17);
            this.LblTotal.TabIndex = 17;
            this.LblTotal.Text = " Se Encontraron 00 Registros";
            // 
            // PanTodo
            // 
            this.PanTodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanTodo.Controls.Add(this.dgvInventario);
            this.PanTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanTodo.Location = new System.Drawing.Point(0, 0);
            this.PanTodo.Margin = new System.Windows.Forms.Padding(4);
            this.PanTodo.Name = "PanTodo";
            this.PanTodo.Size = new System.Drawing.Size(1186, 567);
            this.PanTodo.TabIndex = 17;
            // 
            // nIdInventario
            // 
            this.nIdInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nIdInventario.DataPropertyName = "nIdInventario";
            this.nIdInventario.HeaderText = "nIdInventario";
            this.nIdInventario.Name = "nIdInventario";
            this.nIdInventario.ReadOnly = true;
            this.nIdInventario.Visible = false;
            this.nIdInventario.Width = 109;
            // 
            // nItem
            // 
            this.nItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nItem.DataPropertyName = "nItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.nItem.HeaderText = "Item";
            this.nItem.Name = "nItem";
            this.nItem.ReadOnly = true;
            this.nItem.Width = 69;
            // 
            // nIdAlmacen
            // 
            this.nIdAlmacen.DataPropertyName = "nIdAlmacen";
            this.nIdAlmacen.HeaderText = "nIdAlmacen";
            this.nIdAlmacen.Name = "nIdAlmacen";
            this.nIdAlmacen.ReadOnly = true;
            this.nIdAlmacen.Visible = false;
            // 
            // sDecripcion
            // 
            this.sDecripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sDecripcion.DataPropertyName = "sDecripcion";
            this.sDecripcion.HeaderText = "Descripción de la Obra";
            this.sDecripcion.Name = "sDecripcion";
            this.sDecripcion.ReadOnly = true;
            this.sDecripcion.Width = 142;
            // 
            // dFechaInicio
            // 
            this.dFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dFechaInicio.DataPropertyName = "dFechaInicio";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dFechaInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dFechaInicio.HeaderText = "Fecha Inicio";
            this.dFechaInicio.Name = "dFechaInicio";
            this.dFechaInicio.ReadOnly = true;
            this.dFechaInicio.Width = 118;
            // 
            // dFechaFin
            // 
            this.dFechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dFechaFin.DataPropertyName = "dFechaFin";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dFechaFin.DefaultCellStyle = dataGridViewCellStyle5;
            this.dFechaFin.HeaderText = "Fecha Fin";
            this.dFechaFin.Name = "dFechaFin";
            this.dFechaFin.ReadOnly = true;
            this.dFechaFin.Width = 102;
            // 
            // bEstado
            // 
            this.bEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bEstado.DataPropertyName = "bEstado";
            this.bEstado.HeaderText = "Estado";
            this.bEstado.Name = "bEstado";
            this.bEstado.ReadOnly = true;
            this.bEstado.Width = 67;
            // 
            // FrmObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(1331, 591);
            this.ControlBox = false;
            this.Controls.Add(this.PanTodo);
            this.Controls.Add(this.PanInferior);
            this.Controls.Add(this.PanOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obras";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInventario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.PanOpciones.ResumeLayout(false);
            this.PanInferior.ResumeLayout(false);
            this.PanInferior.PerformLayout();
            this.PanTodo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgvInventario;
        internal System.Windows.Forms.Panel PanOpciones;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnRefrescar;
        internal System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.Button BtnAgregar;
        internal System.Windows.Forms.Button BtnModificar;
        internal System.Windows.Forms.Panel PanInferior;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.Panel PanTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIdAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDecripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bEstado;
    }
}