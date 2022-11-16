using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Documento
    {
        public Documento()
        {
            this.nTipo = 0;
            this.sIdDocumento = "";
            this.sDescripcion = "";
            this.sAbreviatura = "";
            this.Venta = false;
            this.Compra = false;
            this.DoumentoInterno = false;
            this.sUsuario = "";
            this.bEstado = true;
        }

        public int nTipo { get; set; }
        public string sIdDocumento { get; set; }
        public string sDescripcion { get; set; }
        public string sAbreviatura { get; set; }
        public bool Venta { get; set; }
        public bool Compra { get; set; }
        public bool DoumentoInterno { get; set; }
        public string sUsuario { get; set; }
        public bool bEstado { get; set; }
    }
}
