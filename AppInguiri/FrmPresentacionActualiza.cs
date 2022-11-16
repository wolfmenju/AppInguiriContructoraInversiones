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
    public partial class FrmPresentacionActualiza : Form
    {
        PresentacionNegocio objPresenNeg = new PresentacionNegocio();
        public int tipo = 0;
        public int idPresentacion = 0;
        public string descripcion = "";
        private bool cerrarFormulario = true;
        public FrmPresentacion frmPresentacion = null;
        public Presentacion prese;

        public FrmPresentacionActualiza(Presentacion _prese)
        {
            InitializeComponent();
            prese = _prese;
        }

        public FrmPresentacionActualiza()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool resp = true;

            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("El campo Descripción se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            if (txtCodSunat.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo de Sunat se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            cerrarFormulario = resp;
            return resp;
        }
        
        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            int respuesta = 0; 
                
            if (!Validar()) return;
            
            if (tipo == 2)
            {
                if (!Funciones.Duplicados(txtDescripcion.Text, frmPresentacion.DgvPresentacion))
                {
                    txtDescripcion.Clear();
                    txtDescripcion.Focus();
                    cerrarFormulario = false;
                    return;
                }
                
                Presentacion objPre = new Presentacion()
                {
                    sDescripcion = txtDescripcion.Text,
                    sCodigoSunat=txtCodSunat.Text.Trim(),
                    sUsuario = Funciones.UsuarioActual()
                };

                respuesta = objPresenNeg.RegistrarPresentacion(objPre);

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
                Presentacion objPre = new Presentacion()
                {
                    nIdPresentacion = Convert.ToInt32(LblCodigo.Text),
                    sDescripcion = txtDescripcion.Text,
                    sCodigoSunat=txtCodSunat.Text.Trim(),
                    sUsuario = Funciones.UsuarioActual()
                };

                respuesta = objPresenNeg.ActualizarPresentacion(objPre);

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

        private void FrmPresentacionNuevo_Load(object sender, EventArgs e)
        {
            if (tipo == 2)
            {
                LblCodigo.Text = "AUTOGENERADO";
            }
            else
            {
                //Actualizar
                LblCodigo.Text = prese.nIdPresentacion.ToString();
                txtDescripcion.Text = prese.sDescripcion;
                txtCodSunat.Text = prese.sCodigoSunat;
            }
        }

        private void FrmPresentacionActualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarFormulario) e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
