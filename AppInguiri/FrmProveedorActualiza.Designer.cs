namespace AppInguiri
{
    partial class FrmProveedorActualiza
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
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkValidaExterna = new System.Windows.Forms.CheckBox();
            this.btnConsultaSunat = new System.Windows.Forms.Button();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.PanSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanSuperior
            // 
            this.PanSuperior.AutoSize = true;
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.btnLimpiar);
            this.PanSuperior.Controls.Add(this.chkValidaExterna);
            this.PanSuperior.Controls.Add(this.btnConsultaSunat);
            this.PanSuperior.Controls.Add(this.cbxTipoDocumento);
            this.PanSuperior.Controls.Add(this.Label3);
            this.PanSuperior.Controls.Add(this.txtNumeroDoc);
            this.PanSuperior.Controls.Add(this.LblCodigo);
            this.PanSuperior.Controls.Add(this.Label6);
            this.PanSuperior.Controls.Add(this.txtRazonSocial);
            this.PanSuperior.Controls.Add(this.txtDireccion);
            this.PanSuperior.Controls.Add(this.Label10);
            this.PanSuperior.Controls.Add(this.Label2);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(661, 153);
            this.PanSuperior.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::AppInguiri.Properties.Resources.limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(521, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 28);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkValidaExterna
            // 
            this.chkValidaExterna.AutoSize = true;
            this.chkValidaExterna.Checked = true;
            this.chkValidaExterna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkValidaExterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValidaExterna.Location = new System.Drawing.Point(303, 11);
            this.chkValidaExterna.Margin = new System.Windows.Forms.Padding(4);
            this.chkValidaExterna.Name = "chkValidaExterna";
            this.chkValidaExterna.Size = new System.Drawing.Size(152, 21);
            this.chkValidaExterna.TabIndex = 51;
            this.chkValidaExterna.Text = "Validación Sunat";
            this.chkValidaExterna.UseVisualStyleBackColor = true;
            this.chkValidaExterna.Click += new System.EventHandler(this.chkValidaExterna_Click);
            // 
            // btnConsultaSunat
            // 
            this.btnConsultaSunat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaSunat.Image = global::AppInguiri.Properties.Resources.buscar;
            this.btnConsultaSunat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSunat.Location = new System.Drawing.Point(387, 40);
            this.btnConsultaSunat.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaSunat.Name = "btnConsultaSunat";
            this.btnConsultaSunat.Size = new System.Drawing.Size(120, 28);
            this.btnConsultaSunat.TabIndex = 42;
            this.btnConsultaSunat.Text = "Consulta";
            this.btnConsultaSunat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaSunat.UseVisualStyleBackColor = true;
            this.btnConsultaSunat.Click += new System.EventHandler(this.btnConsultaSunat_Click);
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Items.AddRange(new object[] {
            "RUC"});
            this.cbxTipoDocumento.Location = new System.Drawing.Point(131, 41);
            this.cbxTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(71, 25);
            this.cbxTipoDocumento.TabIndex = 41;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(15, 46);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 17);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Tipo de Doc.";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDoc.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroDoc.Location = new System.Drawing.Point(211, 42);
            this.txtNumeroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDoc.MaxLength = 11;
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(158, 22);
            this.txtNumeroDoc.TabIndex = 0;
            this.txtNumeroDoc.Tag = "2";
            this.txtNumeroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoc_KeyPress);
            // 
            // LblCodigo
            // 
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Green;
            this.LblCodigo.Location = new System.Drawing.Point(132, 9);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(162, 24);
            this.LblCodigo.TabIndex = 34;
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 14);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 17);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "Código";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.Location = new System.Drawing.Point(131, 74);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.MaxLength = 35000;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(495, 22);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.Tag = "2";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(131, 102);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(495, 45);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.Tag = "2";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(13, 78);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(103, 17);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "Razón Social";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(13, 110);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 17);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Direccion";
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = global::AppInguiri.Properties.Resources.guardar;
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(395, 161);
            this.CmdGuardar.Margin = new System.Windows.Forms.Padding(4);
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
            this.CmdCancelar.Image = global::AppInguiri.Properties.Resources.cancelar;
            this.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancelar.Location = new System.Drawing.Point(515, 161);
            this.CmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(112, 32);
            this.CmdCancelar.TabIndex = 5;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // FrmProveedorActualiza
            // 
            this.AcceptButton = this.CmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCancelar;
            this.ClientSize = new System.Drawing.Size(661, 201);
            this.ControlBox = false;
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProveedorActualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProveedorActualiza_FormClosing);
            this.Load += new System.EventHandler(this.FrmProveedorActualiza_Load);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNumeroDoc;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtRazonSocial;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Button btnConsultaSunat;
        private System.Windows.Forms.CheckBox chkValidaExterna;
        private System.Windows.Forms.Button btnLimpiar;
    }
}