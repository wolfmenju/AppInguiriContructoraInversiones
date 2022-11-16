using Comun;
using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInguiri
{
    public partial class FrmDocumentoActualiza : Form
    {
        DocumentoNegocio objDocumentNeg = new DocumentoNegocio();
        public int tipo=0;
        private bool cerrarFormulario = true;
        public FrmDocumento frmDocumento;
        private Documento doc;
        public FrmDocumentoActualiza()
        {
            InitializeComponent();
        }

        public FrmDocumentoActualiza(Documento _doc)
        {
            InitializeComponent();
            doc = _doc;
        }

        private bool Validar()
        {
            bool resp = true;
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("El campo Descripción se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            else if (txtAbreviatura.Text.Equals(""))
            {
                MessageBox.Show("El campo Abreviatura se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            else if (tipo == 2)
            {
                if (txtCodigo.Text.Equals(""))
                {
                    MessageBox.Show("El campo Codigo se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resp = false;
                }
            }

            cerrarFormulario = resp;
            return resp;
        }
        

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            int respuesta = 0;

            if (tipo == 2)
            {
                if (!Funciones.Duplicados(txtDescripcion.Text, frmDocumento.DgvDocumento))
                {
                    txtDescripcion.Clear();
                    txtDescripcion.Focus();
                    cerrarFormulario = false;
                    return;
                }
                
                Documento objPre = new Documento()
                {
                    sIdDocumento =txtCodigo.Text,
                    sDescripcion = txtDescripcion.Text,
                    sAbreviatura=txtAbreviatura.Text,
                    Venta=chkVenta.Checked,
                    Compra=chkCompra.Checked,
                    DoumentoInterno=chkDocumentoInterno.Checked,
                    sUsuario = Funciones.UsuarioActual()
                };

                respuesta = objDocumentNeg.RegistrarDocumento(objPre);

                if (respuesta == 1)
                {
                    MessageBox.Show("Se Registro Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrarFormulario = true;
                }
                else
                {
                    MessageBox.Show("No se Registro Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cerrarFormulario = false;
                }
            }
            else
            {
                Documento objDoc = new Documento()
                {
                    sIdDocumento= txtCodigo.Text,
                    sDescripcion = txtDescripcion.Text,
                    sAbreviatura= txtAbreviatura.Text,
                    Venta = chkVenta.Checked,
                    Compra = chkCompra.Checked,
                    DoumentoInterno = chkDocumentoInterno.Checked,
                    sUsuario = Funciones.UsuarioActual()
                };

                respuesta = objDocumentNeg.ActualizarDocumento(objDoc);

                if (respuesta == 1)
                {
                    MessageBox.Show("Se Actualizó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrarFormulario = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se Actualizó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cerrarFormulario = false;
                }

            }
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormulario = true;
            this.Close();
        }
        
        private void FrmDocumentoActualiza_Load(object sender, EventArgs e)
        {
            if (tipo == 2)
            {
                txtCodigo.Enabled = true;
            }
            else
            {
                //Actualizar
                txtCodigo.Text = doc.sIdDocumento;
                txtDescripcion.Text = doc.sDescripcion;
                txtAbreviatura.Text = doc.sAbreviatura;
                chkVenta.Checked = doc.Venta;
                chkCompra.Checked = doc.Compra;
                chkDocumentoInterno.Checked = doc.DoumentoInterno;
            }
        }

        private void FrmDocumentoActualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarFormulario) e.Cancel = false;
            else e.Cancel = true;
        }
        
    }
}
