using Comun;
using Entidad;
using Negocio;
using Newtonsoft.Json;
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
    public partial class FrmProveedorActualiza : Form
    {
        ProveedorNegocio objClienNeg = new ProveedorNegocio();
        WsRestServiceConsultaDocumentoNegocio objConsultaDocumento = new WsRestServiceConsultaDocumentoNegocio();
        public int tipo = 0;
        private bool cerrarFormulario = true;
        private Proveedor cliente = null;
        public FrmProveedor frmProveedor = null;
        public FrmProveedorListar frmProveedorListar = null;

        public FrmProveedorActualiza(Proveedor _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
        }

        public FrmProveedorActualiza()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool resp = true;

            if (txtRazonSocial.Text.Equals(""))
            {
                MessageBox.Show("El campo Razón Social se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (txtNumeroDoc.Text.Equals(""))
            {
                MessageBox.Show("El campo Ruc se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("El campo Dirección se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            /*
            else if (txtDistrito .Text.Equals(""))
            {
                MessageBox.Show("El campo Distrito se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (txtProvincia.Text.Equals(""))
            {
                MessageBox.Show("El campo Provincia se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if ( txtDeparamento.Text.Equals(""))
            {
                MessageBox.Show("El campo Deparamento se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            
            else if (txtUbigeo.Text.Equals(""))
            {
                MessageBox.Show("El campo Ubigeo se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            else if (txtCelular.Text.Equals(""))
            {
                MessageBox.Show("El campo Celular se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            
            else if (txtContacto.Text.Equals(""))
            {
                MessageBox.Show("El campo Contacto se encuentra vacía, por favor ingrese un valor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            */
            cerrarFormulario = resp;
            return resp;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            int respuesta = 0;

            if (!Validar()) return;

            Proveedor objClien = new Proveedor()
            {
                nTipo = 2,
                sRazonSocial = txtRazonSocial.Text.ToUpper().Trim(),
                sNumeroDoc = txtNumeroDoc.Text.ToUpper().Trim(),
                sDireccion = txtDireccion.Text.ToUpper().Trim(),
                sDistrito = "", //txtDistrito.Text,
                sProvincia = "",//txtProvincia.Text,
                sDepartamento = "", //txtDeparamento.Text,
                sCelular = "",//txtCelular.Text.ToUpper().Trim(),
                sUsuario = Funciones.UsuarioActual(),
                bEstado = true,
                sContacto = "",//txtContacto.Text,
                sUbigeo = "",//txtUbigeo.Text,
                bValidadoSunat = chkValidaExterna.Checked           
            };

            if (tipo ==0)
            {
                if (frmProveedor != null)
                {
                    if (!Funciones.Duplicados(txtRazonSocial.Text, frmProveedor.DgvProveedor))
                    {
                        txtRazonSocial.Clear();
                        txtRazonSocial.Focus();
                        cerrarFormulario = false;
                        return;
                    }
                }
                //frmProveedorListar
                else if (frmProveedorListar != null)
                {
                    if (!Funciones.DuplicadosDocumento(txtNumeroDoc.Text, frmProveedorListar.DgvProveedor))
                    {
                        txtRazonSocial.Clear();
                        txtRazonSocial.Focus();
                        cerrarFormulario = false;
                        return;
                    }
                }

                respuesta = objClienNeg.RegistrarProveedor(objClien);

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
                objClien.nIdProveedor = Convert.ToInt32(LblCodigo.Text);
                objClien.nTipo = 3;

                respuesta = objClienNeg.ActualizarProveedor(objClien);

                if (respuesta == 1)
                {
                    MessageBox.Show("Se Actualizó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrarFormulario = true;
                }
                else
                {
                    MessageBox.Show("No se Actualizó Correctamente", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cerrarFormulario = false;
                }

            }
        }

        private void FrmProveedorActualiza_Load(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                LblCodigo.Text = "AUTOGENERADO";
                cbxTipoDocumento.SelectedIndex = 0;
            }
            else
            {
                //Actualizar
                LblCodigo.Text = cliente.nIdProveedor.ToString();
                txtRazonSocial.Text = cliente.sRazonSocial.ToUpper();
                txtNumeroDoc.Text = cliente.sNumeroDoc.ToUpper();
                txtDireccion.Text = cliente.sDireccion.ToUpper();
                //txtDistrito.Text = cliente.sDistrito;
                //txtProvincia.Text = cliente.sProvincia;
                //txtDeparamento.Text = cliente.sDepartamento;
                //txtUbigeo.Text = cliente.sUbigeo;
                //txtCelular.Text = cliente.sCelular.ToUpper();
                chkValidaExterna.Checked = cliente.bValidadoSunat;
                cbxTipoDocumento.SelectedIndex = 0;
                //txtContacto.Text = cliente.sContacto;

                if (cliente.bValidadoSunat)
                {
                    chkValidaExterna.Enabled = false;
                    txtNumeroDoc.Enabled = false;
                    btnConsultaSunat.Enabled = false;
                    btnLimpiar.Enabled = false;
                    cbxTipoDocumento.Enabled = false;
                }
                else
                {
                    chkValidaExterna.Enabled = true;
                    txtNumeroDoc.Enabled = true;
                    btnConsultaSunat.Enabled = true;
                    btnLimpiar.Enabled = true;
                    cbxTipoDocumento.Enabled = true;
                    txtRazonSocial.Enabled = true;
                    txtNumeroDoc.Enabled = true;
                    txtDireccion.Enabled =true;
                    //txtDistrito.Enabled = true;
                    //txtProvincia.Enabled = true;
                    //txtDeparamento.Enabled = true;
                    //txtUbigeo.Enabled = true;
                    //txtContacto.Enabled = true;

                }
            }
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProveedorActualiza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarFormulario) e.Cancel = false;
            else e.Cancel = true;

            cerrarFormulario = true;
        }

        private void btnConsultaSunat_Click(object sender, EventArgs e)
        {
            ConsultaServiciosExternos();
        }

        private void ConsultaServiciosExternos()
        {
            if (txtNumeroDoc.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el número del " + cbxTipoDocumento.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (cbxTipoDocumento.Text.Equals("RUC"))
            {
                if (txtNumeroDoc.Text.Length != 11)
                {
                    MessageBox.Show("El número del " + cbxTipoDocumento.Text + " debe tener 11 digítos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            try
            {
                var WsConsultaDocResponse = objConsultaDocumento.ConsultaDocumentoServicioExterno(txtNumeroDoc.Text);

                if (WsConsultaDocResponse != null)
                {
                    if (!WsConsultaDocResponse.condicion.Equals("HABIDO") && !WsConsultaDocResponse.tipoDocumento.Equals("1"))
                    {
                        MessageBox.Show("El número ingresado del " + cbxTipoDocumento.Text + " No se Encuentra Habido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    txtNumeroDoc.Enabled = false;
                    txtRazonSocial.Text = WsConsultaDocResponse.nombre;

                    if (WsConsultaDocResponse.direccion.Equals("-") || WsConsultaDocResponse.direccion.Equals(""))
                    {
                        txtDireccion.Text = "";
                        txtDireccion.Enabled = true;
                    }
                    else
                    {
                        txtDireccion.Text = WsConsultaDocResponse.direccion;
                        txtDireccion.Enabled = false;
                    }

                    if (WsConsultaDocResponse.distrito.Equals("-") || WsConsultaDocResponse.distrito.Equals(""))
                    {
                        //txtDistrito.Text = "";
                        //txtDistrito.Enabled = true;
                    }
                    else
                    {
                        //txtDistrito.Text = WsConsultaDocResponse.distrito;
                        //txtDistrito.Enabled = false;
                    }

                    if (WsConsultaDocResponse.provincia.Equals("-") || WsConsultaDocResponse.provincia.Equals(""))
                    {
                        //txtProvincia.Text = "";
                        //txtProvincia.Enabled = true;
                    }
                    else
                    {
                        //txtProvincia.Text = WsConsultaDocResponse.provincia;
                        //txtProvincia.Enabled = false;
                    }

                    if (WsConsultaDocResponse.departamento.Equals("-") || WsConsultaDocResponse.departamento.Equals(""))
                    {
                        //txtDeparamento.Text = "";
                        //txtDeparamento.Enabled = true;
                    }
                    else
                    {
                        //txtDeparamento.Text = WsConsultaDocResponse.departamento;
                        //txtDeparamento.Enabled = false;
                    }

                    if (WsConsultaDocResponse.ubigeo.Equals("-") || WsConsultaDocResponse.ubigeo.Equals(""))
                    {
                        //txtUbigeo.Text = "";
                        //txtUbigeo.Enabled = true;
                    }
                    else
                    {
                        //txtUbigeo.Text = WsConsultaDocResponse.ubigeo;
                        //txtUbigeo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("El número ingresado del " + cbxTipoDocumento.Text + " No Existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show( "Error" +ex, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkValidaExterna_Click(object sender, EventArgs e)
        {
            DesactivarCampos();
        }

        private void DesactivarCampos()
        {
            if (chkValidaExterna.Checked)
            {
                txtRazonSocial.Enabled = false;
                txtDireccion.Enabled = false;
                //txtDistrito.Enabled = false;
                //txtProvincia.Enabled = false;
                //txtDeparamento.Enabled = false;
                //txtUbigeo.Enabled = false;
                //txtCelular.Enabled = false;
                btnConsultaSunat.Enabled = true;
            }
            else
            {
                txtRazonSocial.Enabled = true;
                txtDireccion.Enabled = true;
                //txtDistrito.Enabled = true;
                //txtProvincia.Enabled = true;
                //txtDeparamento.Enabled = true;
                //txtUbigeo.Enabled = true;
                //txtCelular.Enabled = true;
                btnConsultaSunat.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();   
        }

        private void LimpiarDatos()
        {
            foreach (Control c in PanSuperior.Controls)
            {
                if (c is TextBox & c.Text != String.Empty)
                {
                    c.Text = "";
                }
            }

            txtNumeroDoc.Enabled = true;
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.ValidarNumeroEntero(e, txtNumeroDoc);
        }
    }
}


