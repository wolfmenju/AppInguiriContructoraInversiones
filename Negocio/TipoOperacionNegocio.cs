using Comun;
using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
     public class TipoOperacionNegocio
    {
        //Listar
        public List<TipoOperacion> ListarTipoOperacion(bool activo)
        {
            return TipoOperacionData.ListarTipoOperacion(activo);
        }
        
        //Actualizar
        public int ActualizarTipoOperacion(TipoOperacion objPre)
        {
            return TipoOperacionData.ActualizarTipoOperacion(objPre);
        }

        //Registrar
        public int RegistrarTipoOperacion(TipoOperacion objPre)
        {
            return TipoOperacionData.RegistrarTipoOperacion(objPre);
        }

        //Eliminar
        public int EliminarActivarPresentacion(TipoOperacion objPre)
        {
            return TipoOperacionData.EliminarActivarTipoOperacion(objPre);
        }

    }
}