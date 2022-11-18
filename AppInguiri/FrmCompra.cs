using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entidad;
using Negocio;
using Microsoft.VisualBasic;
using Comun;

namespace AppInguiri
{
    public partial class FrmCompra : DevExpress.XtraEditors.XtraForm
    {
        private static FrmCompra frmInstance = null;
        private ProveedorNegocio objProveeNeg = new ProveedorNegocio();
        private DocumentoNegocio objDocumentNeg = new DocumentoNegocio();
        private ParametroNegocio objParamNeg = new ParametroNegocio();
        private CompraNegocio objCompNeg = new CompraNegocio();
        private TipoOperacionNegocio objTipoOpeNeg = new TipoOperacionNegocio();
        private List<Parametro> listadoParametro = new List<Parametro>();
        private decimal fTotal = 0M, fIgv=0M, fIgvResto = 0M,fSubTotal2=0M;
        private string sTipoOperacionSunat="";
        
        //Singleton
        public static FrmCompra Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmCompra();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        public FrmCompra()
        {
            InitializeComponent();
            CargarMaestros();
        }


        private void LimpiarValores()
        {
            txtDescripcion.Clear();
            txtRuc.Clear();
            DgProducto.Rows.Clear();
            lblSubtotal.Text = "S/. 0.00";
            lblIgv.Text = "S/. 0.00";
            lblTotal.Text = "S/. 0.00";
            lblNombreProveedor.Text = "";
            LblCodigoProveedor.Text = "";
            cboDocumento.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;
            txtDia.Enabled = false;
            txtDescripcion.Focus();
            txtNumero.Clear();
            txtSerie.Clear();
            txtDia.Clear();
            fTotal = 0M;
            fIgvResto = 0M;
            fSubTotal2 = 0M;
        }

        private void CargarMaestros()
        {
            Documento objDoc = new Documento() {nTipo=1,bEstado=true };
            List<Documento> lis = objDocumentNeg.ListarDocumento(objDoc);
            List<Documento> lis2 = new List<Documento>();

            foreach (var item in lis)
            {
                if (item.Compra)
                {
                    lis2.Add(item);
                }
            }

            cboDocumento.ValueMember = "sIdDocumento";
            cboDocumento.DisplayMember = "sDescripcion";
            cboDocumento.DataSource = lis2;
            //Tipo de Pgo
            cboTipo.SelectedIndex = 0;

            //Igv
            fIgv=Convert.ToDecimal(objParamNeg.LeerUnParametro("ID_IGV"));

            dtFecha.Value = Funciones.CodFechaActual();
            dtFecha.Enabled = false;

            List<TipoOperacion> lisOpe = new List<TipoOperacion>();
            lisOpe = objTipoOpeNeg.ListarTipoOperacion(true);

            if (lisOpe.Count > 0)
            {
                foreach (var item in lisOpe)
                {
                    if (item.sDescripcion == "COMPRAS")
                    {
                        sTipoOperacionSunat = item.sCodigoSunat;
                        break;
                    }
                }
            }
        }

        #region Principal Load

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            if (Globales.FechaActual().Date != Funciones.CodFechaActual().Date)
            {
                BtnGuardar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnBuscar.Enabled = false;
                MessageBox.Show("No puede realizar Ventas con Fechas Anterior. Verifique si se Cerro Caja.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CalcularTotal();
        }

        #endregion

        private void FrmCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (Globales.FechaActual().Date != Funciones.CodFechaActual().Date && e.KeyCode != Keys.Escape)
            {
                MessageBox.Show("No puede realizar Ventas con Fechas Anterior. Verifique si se Cerro Caja.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.F1:
                    ListarProducto();
                    break;
                case Keys.F2:
                    ListarProveedor();
                    break;
                case Keys.F3:
                    BtnGuardar_Click(sender, e);
                    break;
                case Keys.F4:
                    break;
            }
        }

        private void ListarProveedor()
        {
            FrmProveedorListar frmProveedor = new FrmProveedorListar();
            frmProveedor.ShowDialog();

            if (frmProveedor._proveedor != null)
            {
                txtRuc.Text = frmProveedor._proveedor.sNumeroDoc.ToUpper();
                lblNombreProveedor.Text = frmProveedor._proveedor.sRazonSocial.ToUpper();
                LblCodigoProveedor.Text = frmProveedor._proveedor.nIdProveedor.ToString();
                cboDocumento.Focus();
                cboDocumento.DroppedDown = true;
            }
        }

        private void ListarProducto()
        {
            FrmProductoListar frmProductoListar = new FrmProductoListar();
            frmProductoListar.frmCompra = frmInstance;
            frmProductoListar.ShowDialog();

            DgProducto.DataSource= frmProductoListar.frmCompra.DgProducto.DataSource;
            
            if (DgProducto.RowCount > 0)
            {
                fTotal = 0;

                foreach (DataGridViewRow item in DgProducto.Rows)
                {
                    fTotal += Convert.ToDecimal(item.Cells["fSubTotal"].Value);
                }
            }
            
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            lblTotal.Text = fTotal.ToString("C");
            fTotal = decimal.Round(fTotal, 2);

            fSubTotal2 = decimal.Round((fTotal / (1 + (fIgv / 100))), 2);
            fIgvResto = decimal.Round(((fIgv / 100) * fSubTotal2), 2);

            lblIgv.Text = (fIgvResto).ToString("C");
            lblSubtotal.Text = (fSubTotal2).ToString("C");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void EliminarProducto()
        {
            if (DgProducto.RowCount > 0)
            {
                if (DgProducto.CurrentCell != null || DgProducto.CurrentCell.RowIndex != 0)
                {
                    if (MessageBox.Show("¿Desea Eliminar El Producto Seleccionado?", "InguiriSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Int32 filaselecionada = DgProducto.CurrentCell.RowIndex;
                        DataGridViewRow row2 = DgProducto.Rows[filaselecionada];
                        DgProducto.Rows.Remove(row2);

                        fTotal = 0;

                        if (DgProducto.RowCount > 0)
                        {
                            foreach (DataGridViewRow item in DgProducto.Rows)
                            {
                                fTotal += Convert.ToDecimal(item.Cells["fSubTotal"].Value);
                            }
                        }

                        CalcularTotal();
                    }
                }
            }
        }

        private void cboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 1)
            {
                txtDia.Enabled = true;
                txtDia.Focus();
            }
            else
            {
                txtDia.Enabled = false;
                txtDia.Clear();
                txtDescripcion.Focus();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.ValidarNumeroEntero(e, txtNumero);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            FrmCompraListar frmCompraListar = new FrmCompraListar();
            frmCompraListar.ShowDialog();
            txtDescripcion.Focus();
        }

        private void dtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtRuc.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCompra();
        }

        private void GuardarCompra()
        {
            if (DgProducto.Rows.Count < 1)
            {
                MessageBox.Show("Debe Agregar Productos.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Desea Generar La Compra?", "InguiriSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resp = 0;
                if (!VerificacionDatos()) return;

                List<CompraDetalle> listComDeta = new List<CompraDetalle>();
                CompraDetalle objComDeta = null;

                Compra objCompra = new Compra()
                {
                    nTipo=1,
                    nIdProveedor = Convert.ToInt32(LblCodigoProveedor.Text),
                    nIdAlmacen = Funciones.CodAlmacenActual(),
                    dFecha =dtFecha.Value,
                    dFechaAdquisicion=Convert.ToDateTime(mtxFechaAd.Text),
                    sIdDocumento = cboDocumento.SelectedValue.ToString(),
                    sSerie = txtSerie.Text,
                    nNumero = Convert.ToInt32(txtNumero.Text),
                    bCredito = cboTipo.SelectedIndex == 1 ? true : false,
                    nPorcentaje = (int)fIgv,
                    fSubTotal = fSubTotal2,
                    fIgv = fIgvResto,
                    fTotal = fTotal,
                    sUsuario = Funciones.UsuarioActual(),
                    sTipoOperacion= sTipoOperacionSunat
                };

                objCompra.nDias = objCompra.bCredito == true ? Convert.ToInt32(txtDia.Text) : 0;

                foreach (DataGridViewRow item in DgProducto.Rows)
                {
                    objComDeta = new CompraDetalle();
                    objComDeta.nIdMovimiento = Convert.ToInt32(item.Cells["nIdMovimiento"].Value);
                    objComDeta.nIdProducto = Convert.ToInt32(item.Cells["nIdProducto"].Value);
                    objComDeta.dFechaVencimiento = Convert.ToDateTime(item.Cells["dFechaVencimiento"].Value);
                    objComDeta.nCantidad = Convert.ToInt32(item.Cells["nCantidad"].Value);
                    objComDeta.fPrecioCompra = Convert.ToDecimal(item.Cells["fPrecioCompra"].Value);
                    objComDeta.sLote = item.Cells["sLote"].Value.ToString();
                    objComDeta.fGanancia = Convert.ToDecimal(item.Cells["fGanancia"].Value);
                    objComDeta.fPrecioVenta = Convert.ToDecimal(item.Cells["fPrecioVenta"].Value);
                    objComDeta.fSubTotal = Convert.ToDecimal(item.Cells["fSubTotal"].Value);
                    listComDeta.Add(objComDeta);

                }

                objCompra.listCompraDetalle = listComDeta;

                resp = objCompNeg.RegistrarCompra(objCompra);

                if (resp > 0)
                {
                    MessageBox.Show("La Compra Se Realizó Con Éxito", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarValores();
                }
                else
                {
                    MessageBox.Show("La Compra No Se Pudo Realizar", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool VerificacionDatos()
        {
            bool resp = true;

            if (lblNombreProveedor.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un Proveedor.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (cboDocumento.Text.Equals(""))
            {
                MessageBox.Show("Seleccione el Tipo de Documento.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (txtSerie.Text.Equals(""))
            {
                MessageBox.Show("El campo Serie se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("El campo Numero de CP se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }
            else if (cboTipo.SelectedIndex==1)
            {
                if (txtDia.Text.Equals(""))
                {
                    MessageBox.Show("El campo Dias se encuentra vacía, por favor ingrese un valor", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resp = false;
                }
            }
            else if (DgProducto.RowCount == 0)
            {
                MessageBox.Show("No agrego ningun Producto., por favor agregue un Producto.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            else if (sTipoOperacionSunat=="")
            {
                MessageBox.Show("Debea agregar el codigo de la operación de la compra", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            else if (mtxFechaAd.Text == "  /  /")
            {
                MessageBox.Show("Debea agregar la fecha de adquisición del producto.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resp = false;
            }

            return resp;
        }
    }
}