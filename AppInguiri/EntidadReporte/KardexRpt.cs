using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInguiri.EntidadReporte
{
    public class KardexRpt
    {
        public DateTime dFecha { get; set; }
        public string sCodigoInterno { get; set; }
        public string sProducto { get; set; }
        public string sDocumento { get; set; }
        public string sSerie { get; set; }
        public string sNumeracion { get; set; }
        public string sTipoOperacion { get; set; }
        public string sPresentacion { get; set; }
        public string sMedSunat { get; set; }
        public int nEntrada { get; set; }
        public int nSalida { get; set; }
        public int nExiste { get; set; }
        public int nTotalGeneral { get; set; }

    }
}
