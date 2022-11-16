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
using AppInguiri.EntidadReporte;
using AppInguiri.Reporte;
using AppInguiri.ReporteFormulario;

namespace AppInguiri
{
    public partial class FrmRptSockMinimo : DevExpress.XtraEditors.XtraForm
    {
        private static FrmRptSockMinimo frmInstance = null;
        VentaNegocio objVentaNeg = new VentaNegocio();
        ProductoHistorialNegocio objProHistNeg = new ProductoHistorialNegocio();
        ParametroNegocio objParaNeg = new ParametroNegocio();
        List<ProductoHistorial> listadoProductoHistorial = null;

        AlmacenNegocio objAlmNeg = new AlmacenNegocio();
        
        //Singleton
        public static FrmRptSockMinimo Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmRptSockMinimo();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }


        public FrmRptSockMinimo()
        {
            InitializeComponent();
            CargarAlmacen();
        }


        private void CargarAlmacen()
        {
            List<Almacen> listAlm = objAlmNeg.ListarAlmacen(true);
            cboAlmacen.DisplayMember = "sDescripcion";
            cboAlmacen.ValueMember = "nIdAlmacen";
            cboAlmacen.DataSource = listAlm;
            cboAlmacen.SelectedValue = Funciones.CodAlmacenActual();
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            if (dgvProducto.Rows.Count < 1) return;

            List<KardexRpt> listKardexRpt = new List<KardexRpt>();
            RptKardexGeneral rpt = new RptKardexGeneral();

            foreach (DataGridViewRow item in dgvProducto.Rows)
            {
                KardexRpt objKardexRpt = new KardexRpt();

                objKardexRpt.dFecha = Convert.ToDateTime(item.Cells["dFechaVencimiento"].Value);
                objKardexRpt.sProducto = item.Cells["sCodigoInterno"].Value.ToString()+"-"+ item.Cells["sNombreProducto"].Value.ToString();
                objKardexRpt.sDocumento = item.Cells["sAlmacen"].Value.ToString();
                objKardexRpt.sSerie = item.Cells["sIdLote"].Value.ToString();
                objKardexRpt.sNumeracion = item.Cells["sLaboratorio"].Value.ToString();
                objKardexRpt.sTipoOperacion = item.Cells["sTipoOperacion"].Value.ToString();
                objKardexRpt.sPresentacion =  item.Cells["sPresentacion"].Value.ToString();
                objKardexRpt.sMedSunat = item.Cells["sMedSunat"].Value.ToString();
                objKardexRpt.nEntrada = Convert.ToInt32(item.Cells["nIdLote"].Value.ToString());
                objKardexRpt.nSalida = Convert.ToInt32(item.Cells["nIdProductoHistorial"].Value.ToString());
                objKardexRpt.nExiste = Convert.ToInt32(item.Cells["nStock"].Value.ToString());
                objKardexRpt.nTotalGeneral = Convert.ToInt32(item.Cells["nIdAlmacen"].Value.ToString());

                listKardexRpt.Add(objKardexRpt);
            }

            rpt.SetDataSource(listKardexRpt);
            rpt.SetParameterValue("Usuario", Funciones.UsuarioActual());
            //rpt.SetParameterValue("Producto", lblCodigo.Text + "-" + lblDescripcion.Text.ToUpper());
            rpt.SetParameterValue("NombreEmpresa", objParaNeg.LeerUnParametro("ID_TITULO"));
            rpt.SetParameterValue("NombreObra", Funciones.NombreAlmacenActual());
            rpt.SetParameterValue("Nombres", Funciones.UsuarioActual());
            rpt.SetParameterValue("Ruc", objParaNeg.LeerUnParametro("ID_RUC"));

            RptMaestro Reporte = new RptMaestro();
            Reporte.Show();
            Reporte.Text = "";//cboOpcion.Text;
            Reporte.Focus();
            Reporte.cReporte.ReportSource = rpt;
            int exportFormatFlags = (int)(CrystalDecisions.Shared.ViewerExportFormats.PdfFormat);
            Reporte.cReporte.AllowedExportFormats = exportFormatFlags;

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboOpcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listadoProductoHistorial = null;
            dgvProducto.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consulta(); 
        }

        private void Consulta()
        {
            ProductoHistorial objProHis = new ProductoHistorial()
            {
                nTipo = chkFecha.CheckState == CheckState.Unchecked ? 18 : 19,
                nIdAlmacen =Convert.ToInt32(cboAlmacen.SelectedValue),
                sLote = dtFechaInicio.Value.ToString("yyyyMMdd"),
                sIdLote = dtFechaFinal.Value.ToString("yyyyMMdd"),
                bEstado = true
            };

            listadoProductoHistorial= objProHistNeg.ListarProductoHistorial(objProHis);

            if (listadoProductoHistorial.Count > 0)
            {
                dgvProducto.AutoGenerateColumns = false;
                dgvProducto.DataSource = listadoProductoHistorial;
                lblTotal.Text = "Se Encontraron " + dgvProducto.Rows.Count + " Registros";
            }
            else
            {
                dgvProducto.Rows.Clear();
            }

        }

        private void FrmRptLoteProductoPorVencer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnBuscar_Click(sender, e);
                    break;
                case Keys.F2:
                    btnImprimir_Click(sender, e);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void FrmRptLoteProductoPorVencer_Load(object sender, EventArgs e)
        {
           
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            Activar();
        }

        private void Activar()
        {
            if (cboAlmacen.Enabled)
            {
                cboAlmacen.Enabled = false;
                chkTodos.Checked = Convert.ToBoolean(CheckState.Checked);
            }
            else
            {
                if (cboAlmacen.Items.Count > 0)
                {
                    cboAlmacen.SelectedIndex = 0;
                    cboAlmacen.Enabled = true;
                    chkTodos.Checked = Convert.ToBoolean(CheckState.Unchecked);
                }
            }

            dgvProducto.DataSource = null;
        }

        private void chkFecha_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(chkFecha.CheckState) == true || Convert.ToInt32(chkFecha.CheckState) == 1)
            {
                dtFechaInicio.Value = DateTime.Now;
                dtFechaFinal.Value = DateTime.Now;
                dtFechaInicio.Enabled = true;
                dtFechaFinal.Enabled = true;
                dtFechaInicio.Focus();
            }
            else
            {
                dtFechaInicio.Value = DateTime.Now;
                dtFechaFinal.Value = DateTime.Now;
                dtFechaInicio.Enabled = false;
                dtFechaFinal.Enabled = false;
            }

            dgvProducto.DataSource = null;
        }
    }
}