namespace AppInguiri
{
    partial class FrmPagoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagoDetalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxTipoMedioPago = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvMedioPagos = new System.Windows.Forms.DataGridView();
            this.IdMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdCancelar);
            this.panel1.Controls.Add(this.CmdGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 39);
            this.panel1.TabIndex = 4;
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancelar.Image")));
            this.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancelar.Location = new System.Drawing.Point(297, 5);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(84, 26);
            this.CmdCancelar.TabIndex = 7;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.Image")));
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(169, 6);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(120, 26);
            this.CmdGuardar.TabIndex = 6;
            this.CmdGuardar.Text = "&Generar Venta";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Controls.Add(this.txtPago);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.Label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 98);
            this.panel2.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(29, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(81, 31);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "Pago";
            // 
            // txtPago
            // 
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.Blue;
            this.txtPago.Location = new System.Drawing.Point(129, 49);
            this.txtPago.Multiline = true;
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(219, 37);
            this.txtPago.TabIndex = 55;
            this.txtPago.Text = "0.00";
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(129, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(219, 37);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(29, 12);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 31);
            this.Label8.TabIndex = 50;
            this.Label8.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 244);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbxTipoMedioPago);
            this.panel5.Controls.Add(this.txtMonto);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 42);
            this.panel5.TabIndex = 1;
            // 
            // cbxTipoMedioPago
            // 
            this.cbxTipoMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTipoMedioPago.FormattingEnabled = true;
            this.cbxTipoMedioPago.Location = new System.Drawing.Point(46, 12);
            this.cbxTipoMedioPago.Name = "cbxTipoMedioPago";
            this.cbxTipoMedioPago.Size = new System.Drawing.Size(169, 21);
            this.cbxTipoMedioPago.TabIndex = 2;
            this.cbxTipoMedioPago.SelectionChangeCommitted += new System.EventHandler(this.cbxTipoMedioPago_SelectionChangeCommitted);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(221, 13);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 0;
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pago";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(321, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(22, 22);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblVuelto);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 48);
            this.panel6.TabIndex = 2;
            // 
            // lblVuelto
            // 
            this.lblVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.Blue;
            this.lblVuelto.Location = new System.Drawing.Point(125, 6);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(219, 37);
            this.lblVuelto.TabIndex = 56;
            this.lblVuelto.Text = "0.00";
            this.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 55;
            this.label5.Text = "Vuelto";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvMedioPagos);
            this.panel4.Location = new System.Drawing.Point(3, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 149);
            this.panel4.TabIndex = 8;
            // 
            // dgvMedioPagos
            // 
            this.dgvMedioPagos.AllowUserToAddRows = false;
            this.dgvMedioPagos.AllowUserToDeleteRows = false;
            this.dgvMedioPagos.AllowUserToResizeColumns = false;
            this.dgvMedioPagos.AllowUserToResizeRows = false;
            this.dgvMedioPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedioPago,
            this.fPago,
            this.fMonto,
            this.Column4});
            this.dgvMedioPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedioPagos.Location = new System.Drawing.Point(0, 0);
            this.dgvMedioPagos.Name = "dgvMedioPagos";
            this.dgvMedioPagos.RowHeadersVisible = false;
            this.dgvMedioPagos.Size = new System.Drawing.Size(384, 145);
            this.dgvMedioPagos.TabIndex = 2;
            this.dgvMedioPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedioPagos_CellContentClick);
            // 
            // IdMedioPago
            // 
            this.IdMedioPago.DataPropertyName = "IdMedioPago";
            this.IdMedioPago.HeaderText = "IdMedioPago";
            this.IdMedioPago.Name = "IdMedioPago";
            this.IdMedioPago.Visible = false;
            // 
            // fPago
            // 
            this.fPago.DataPropertyName = "sPago";
            this.fPago.HeaderText = "Pago";
            this.fPago.Name = "fPago";
            this.fPago.Width = 200;
            // 
            // fMonto
            // 
            this.fMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fMonto.DataPropertyName = "fMonto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.fMonto.DefaultCellStyle = dataGridViewCellStyle2;
            this.fMonto.HeaderText = "Monto";
            this.fMonto.Name = "fMonto";
            this.fMonto.Width = 62;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "";
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.Column4.Name = "Column4";
            this.Column4.Width = 5;
            // 
            // FrmPagoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(394, 381);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPagoDetalle_FormClosing);
            this.Load += new System.EventHandler(this.FrmPagoDetalle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPago_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        private System.Windows.Forms.DataGridView dgvMedioPagos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMonto;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxTipoMedioPago;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Label lblVuelto;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMonto;
    }
}