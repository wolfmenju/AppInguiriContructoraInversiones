using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Proveedor
    {
        public Proveedor()
        {
            this.nIdProveedor = 0;
            this.sNumeroDoc = "";
            this.sRazonSocial = "";
            this.sDireccion = "";
            this.sCelular = "";
            this.sDistrito = "";
            this.sProvincia = "";
            this.sDepartamento = "";
            this.sUbigeo = "";
            this.sContacto = "";
            this.sUsuario = "";
            this.bEstado = true;
            this.bValidadoSunat = false;
            this.dFechaValidaSunat = null;
        }
        
        public int nTipo { get; set; }
        public int nIdProveedor { get; set; }
        public string sNumeroDoc { get; set; }
        public string sRazonSocial { get; set; }
        public string sDireccion { get; set; }
        public string sDistrito { get; set; }
        public string sProvincia { get; set; }
        public string sDepartamento { get; set; }
        public string sUbigeo { get; set; }
        public string sCelular { get; set; }
        public string sContacto { get; set; }
        public string sUsuario { get; set; }
        public bool bEstado { get; set; }
        public bool bValidadoSunat { get; set; }
        public DateTime? dFechaValidaSunat { get; set; }

    }
}
