namespace AppInguiri
{
    partial class FrmServicioActualiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicioActualiza));
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkPaquete = new System.Windows.Forms.CheckBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.PanSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanSuperior
            // 
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.lblCodigoInterno);
            this.PanSuperior.Controls.Add(this.label7);
            this.PanSuperior.Controls.Add(this.txtPrecio);
            this.PanSuperior.Controls.Add(this.label1);
            this.PanSuperior.Controls.Add(this.ChkPaquete);
            this.PanSuperior.Controls.Add(this.LblCodigo);
            this.PanSuperior.Controls.Add(this.Label6);
            this.PanSuperior.Controls.Add(this.txtDescripcion);
            this.PanSuperior.Controls.Add(this.Label10);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(483, 135);
            this.PanSuperior.TabIndex = 6;
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInterno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigoInterno.Location = new System.Drawing.Point(99, 7);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(122, 20);
            this.lblCodigoInterno.TabIndex = 48;
            this.lblCodigoInterno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Código \r\nInterno";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(99, 100);
            this.txtPrecio.MaxLength = 500;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrecio.Size = new System.Drawing.Size(122, 20);
            this.txtPrecio.TabIndex = 39;
            this.txtPrecio.Tag = "2";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Precio";
            // 
            // ChkPaquete
            // 
            this.ChkPaquete.AutoSize = true;
            this.ChkPaquete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPaquete.Location = new System.Drawing.Point(383, 7);
            this.ChkPaquete.Name = "ChkPaquete";
            this.ChkPaquete.Size = new System.Drawing.Size(73, 17);
            this.ChkPaquete.TabIndex = 38;
            this.ChkPaquete.TabStop = false;
            this.ChkPaquete.Text = "Paquete";
            this.ChkPaquete.UseVisualStyleBackColor = true;
            this.ChkPaquete.Visible = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Green;
            this.LblCodigo.Location = new System.Drawing.Point(99, 7);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(122, 20);
            this.LblCodigo.TabIndex = 34;
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCodigo.Visible = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(11, 11);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(20, 13);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "ID";
            this.Label6.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(99, 32);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 62);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Tag = "2";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(11, 36);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 13);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "Descripcion";
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.Image")));
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(298, 142);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(84, 26);
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
            this.CmdCancelar.Location = new System.Drawing.Point(388, 142);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(84, 26);
            this.CmdCancelar.TabIndex = 5;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // FrmServicioActualiza
            // 
            this.AcceptButton = this.CmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCancelar;
            this.ClientSize = new System.Drawing.Size(483, 175);
            this.ControlBox = false;
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicioActualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProveedorActualiza_FormClosing);
            this.Load += new System.EventHandler(this.FrmProveedorActualiza_Load);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox ChkPaquete;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblCodigoInterno;
        internal System.Windows.Forms.Label label7;
    }
}