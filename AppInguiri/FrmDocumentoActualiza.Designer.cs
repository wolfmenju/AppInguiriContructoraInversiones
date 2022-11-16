namespace AppInguiri
{
    partial class FrmDocumentoActualiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentoActualiza));
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkVenta = new System.Windows.Forms.CheckBox();
            this.chkCompra = new System.Windows.Forms.CheckBox();
            this.chkDocumentoInterno = new System.Windows.Forms.CheckBox();
            this.PanSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanSuperior
            // 
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.groupBox1);
            this.PanSuperior.Controls.Add(this.txtCodigo);
            this.PanSuperior.Controls.Add(this.txtAbreviatura);
            this.PanSuperior.Controls.Add(this.Label1);
            this.PanSuperior.Controls.Add(this.Label8);
            this.PanSuperior.Controls.Add(this.Label6);
            this.PanSuperior.Controls.Add(this.txtDescripcion);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(603, 198);
            this.PanSuperior.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.Color.Green;
            this.txtCodigo.Location = new System.Drawing.Point(117, 9);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.Tag = "2";
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbreviatura.ForeColor = System.Drawing.Color.Black;
            this.txtAbreviatura.Location = new System.Drawing.Point(117, 69);
            this.txtAbreviatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAbreviatura.MaxLength = 10;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(163, 22);
            this.txtAbreviatura.TabIndex = 20;
            this.txtAbreviatura.Tag = "2";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 74);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 17);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Abreviatura";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(15, 43);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(93, 17);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Descripción";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 11);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 17);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Código";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(117, 38);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(471, 23);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Tag = "2";
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.Image")));
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(358, 218);
            this.CmdGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(112, 32);
            this.CmdGuardar.TabIndex = 4;
            this.CmdGuardar.Text = "&Guardar";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancelar.Image")));
            this.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancelar.Location = new System.Drawing.Point(478, 218);
            this.CmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(112, 32);
            this.CmdCancelar.TabIndex = 5;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDocumentoInterno);
            this.groupBox1.Controls.Add(this.chkCompra);
            this.groupBox1.Controls.Add(this.chkVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asociar a Proceso";
            // 
            // chkVenta
            // 
            this.chkVenta.AutoSize = true;
            this.chkVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVenta.Location = new System.Drawing.Point(122, 32);
            this.chkVenta.Name = "chkVenta";
            this.chkVenta.Size = new System.Drawing.Size(69, 21);
            this.chkVenta.TabIndex = 0;
            this.chkVenta.Text = "Salida";
            this.chkVenta.UseVisualStyleBackColor = true;
            // 
            // chkCompra
            // 
            this.chkCompra.AutoSize = true;
            this.chkCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompra.Location = new System.Drawing.Point(208, 32);
            this.chkCompra.Name = "chkCompra";
            this.chkCompra.Size = new System.Drawing.Size(77, 21);
            this.chkCompra.TabIndex = 1;
            this.chkCompra.Text = "Ingreso";
            this.chkCompra.UseVisualStyleBackColor = true;
            // 
            // chkDocumentoInterno
            // 
            this.chkDocumentoInterno.AutoSize = true;
            this.chkDocumentoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDocumentoInterno.Location = new System.Drawing.Point(304, 32);
            this.chkDocumentoInterno.Name = "chkDocumentoInterno";
            this.chkDocumentoInterno.Size = new System.Drawing.Size(150, 21);
            this.chkDocumentoInterno.TabIndex = 2;
            this.chkDocumentoInterno.Text = "Documento Interno";
            this.chkDocumentoInterno.UseVisualStyleBackColor = true;
            // 
            // FrmDocumentoActualiza
            // 
            this.AcceptButton = this.CmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCancelar;
            this.ClientSize = new System.Drawing.Size(603, 260);
            this.ControlBox = false;
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.PanSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDocumentoActualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar de Documento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocumentoActualiza_FormClosing);
            this.Load += new System.EventHandler(this.FrmDocumentoActualiza_Load);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.TextBox txtAbreviatura;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDocumentoInterno;
        private System.Windows.Forms.CheckBox chkCompra;
        private System.Windows.Forms.CheckBox chkVenta;
    }
}