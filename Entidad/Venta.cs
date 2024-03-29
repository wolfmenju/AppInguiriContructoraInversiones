﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        public Venta()
        {
            this.nIdVenta = 0;
            this.nIdProducto = 0;
            this.nIdAlmacen = 0;
            this.nIdPedido = 0;
            this.sIdDocumento = "";
            this.sDescripDocumento = "";
            this.sLaboratorio = "";
            this.sProducto = "";
            this.sSerie = "";
            this.nNumero = 0;
            this.dFecha = DateTime.Now;
            this.fPorcentajeIgv = 0M;
            this.fDescuento = 0M;
            this.fSubTotal = 0M;
            this.fIgv = 0M;
            this.fPrecioVenta = 0M;
            this.fTotal = 0M;
            this.nIdCliente = 0;
            this.sNombre = "";
            this.sIdVendedor = "";
            this.sIdCajero = "";
            this.nCodigo = 0;
            this.sUsuario = "";
            this.bAlternativo = false;
            this.bEstado = true;
            this.sEstado = "";
            this.listVentaDetalle = new List<VentaDetalle>();
            this.listVentaMedioPago = new List<VentaMedioPago>();
            this.nIdHistorial = 0;
            this.nIdTarjeta = 0;
            this.bSunat = 0;
            this.sSunat = "";
            this.dFechaNotificacionSunat=null;
            this.FechaAnuladoSunat = null;
            this.sCdr = "";
            this.sHash = "";
            this.sCodigoResp = "";
            this.sMensajeResp = "";
            this.sCodigoSunat = "";
            this.sCodigoInterno = "";
            this.bIgvAplica = false;
            this.bServicio = false;
            this.sDocumentoAnulacion = "";
            this.sDocumentoAceptacion = "";
            this.sMedioPago = "";
            this.sTipoOperacion = "";
            this.sMedSunat = "";
    }
        
        public int nTipo { get; set; }
        public int nIdVenta { get; set; }
        public int nIdProducto { get; set; }
        public int nIdAlmacen { get; set; }
        public int nIdPedido { get; set; }
        public string sIdDocumento { get; set; }
        public string sDescripDocumento { get; set; }
        public string sLaboratorio { get; set; }
        public string sProducto { get; set; }
        public string sSerie { get; set; }
        public int? nNumero { get; set; }
        public DateTime dFecha { get; set; }
        public DateTime dFechaRegistrado { get; set; }
        public decimal fPorcentajeIgv { get; set; }
        public decimal fDescuento { get; set; }
        public decimal fSubTotal { get; set; }
        public decimal fIgv { get; set; }
        public decimal fPrecioVenta { get; set; }
        public decimal fTotal { get; set; }
        public int nIdCliente { get; set; }
        public string sNombre { get; set; }
        public string sIdVendedor { get; set; }
        public string sIdCajero { get; set; }
        public int nCodigo { get; set; }
        public String sUsuario { get; set; }
        public bool bAlternativo { get; set; }
        public bool bEstado { get; set; }
        public string sEstado { get; set; }
        public int nIdHistorial { get; set; }
        public int nIdTarjeta { get; set; }
        public decimal fIgvDetalle { get; set; }
        public string sCodigoInterno { get; set; } 
        public int bSunat  { get; set; }
        public string sSunat { get; set; }
        public DateTime? dFechaNotificacionSunat { get; set; }
        public DateTime? FechaAnuladoSunat { get; set; }
        public bool bIgvAplica { get; set; }
        public bool bServicio { get; set; }
        public string sMedioPago { get; set; }

        public List<VentaDetalle> listVentaDetalle { get; set; }
        public List<VentaMedioPago> listVentaMedioPago { get; set; }

        //Complemento
        public string sCdr { get; set; }
        public string sHash { get; set; }
        public string sCodigoResp { get; set; }
        public string sCodigoSunat { get; set; }
        public string sMensajeResp { get; set; }
        public string sDocumentoAnulacion { get; set; }
        public string sDocumentoAceptacion { get; set; }

        public string sTipoOperacion { get; set; }
        public string sMedSunat { get; set; }

    }
}
