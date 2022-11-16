namespace AppInguiri
{
    partial class FrmUsuarioActualiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioActualiza));
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.PanSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancelar.Image")));
            this.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancelar.Location = new System.Drawing.Point(516, 176);
            this.CmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(112, 32);
            this.CmdCancelar.TabIndex = 5;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.Image")));
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(396, 176);
            this.CmdGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(112, 32);
            this.CmdGuardar.TabIndex = 4;
            this.CmdGuardar.Text = "&Guardar";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // PanSuperior
            // 
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.Label3);
            this.PanSuperior.Controls.Add(this.txtDni);
            this.PanSuperior.Controls.Add(this.Label1);
            this.PanSuperior.Controls.Add(this.txtCelular);
            this.PanSuperior.Controls.Add(this.Label2);
            this.PanSuperior.Controls.Add(this.txtDireccion);
            this.PanSuperior.Controls.Add(this.LblCodigo);
            this.PanSuperior.Controls.Add(this.Label6);
            this.PanSuperior.Controls.Add(this.txtNombres);
            this.PanSuperior.Controls.Add(this.Label8);
            this.PanSuperior.Controls.Add(this.txtClave);
            this.PanSuperior.Controls.Add(this.Label9);
            this.PanSuperior.Controls.Add(this.Label10);
            this.PanSuperior.Controls.Add(this.txtLogin);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(650, 165);
            this.PanSuperior.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(452, 12);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 17);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.Location = new System.Drawing.Point(495, 9);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(133, 22);
            this.txtDni.TabIndex = 0;
            this.txtDni.Tag = "2";
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 107);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 17);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(100, 105);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 22);
            this.txtCelular.TabIndex = 3;
            this.txtCelular.Tag = "2";
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 76);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 17);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(100, 73);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(527, 22);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.Tag = "2";
            // 
            // LblCodigo
            // 
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Green;
            this.LblCodigo.Location = new System.Drawing.Point(100, 9);
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
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.Location = new System.Drawing.Point(100, 41);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.MaxLength = 35000;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(527, 22);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Tag = "2";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(347, 140);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 17);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(403, 137);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.MaxLength = 380;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(225, 22);
            this.txtClave.TabIndex = 5;
            this.txtClave.Tag = "2";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(15, 140);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 17);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "Login";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(15, 44);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 17);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "Nombres";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(100, 137);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(225, 22);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Tag = "2";
            // 
            // FrmUsuarioActualiza
            // 
            this.AcceptButton = this.CmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCancelar;
            this.ClientSize = new System.Drawing.Size(650, 214);
            this.ControlBox = false;
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioActualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuarioActualiza_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuarioActualiza_Load);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCelular;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtLogin;
    }
}