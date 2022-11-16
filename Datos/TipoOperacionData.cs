using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class TipoOperacionData
    {
        //Listar Varios
        public static List<TipoOperacion> ListarTipoOperacion(bool estado)
        {
            int tipo = 1;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            SqlConnection cnx = null;

            List<TipoOperacion> listPresentacion = new List<TipoOperacion>();

            try
            {
                Conexion cn = new Conexion();
                cnx = new SqlConnection();
                cnx = cn.getConecta();

                cmd = new SqlCommand("IAE_TipoOperacion", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdTipoOperacion", "");
                cmd.Parameters.AddWithValue("@Descripcion", "");
                cmd.Parameters.AddWithValue("@CodigoSunat", "");
                cmd.Parameters.AddWithValue("@Usuario", "");
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TipoOperacion objPresent = new TipoOperacion();
                    objPresent.nIdTipoOperacion = int.Parse(dr[0].ToString());
                    objPresent.sDescripcion = dr[1].ToString();
                    objPresent.sCodigoSunat = dr[2].ToString();

                    listPresentacion.Add(objPresent);

                }

                return listPresentacion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }
        }
        
        //Actualizar
        public static int ActualizarTipoOperacion(TipoOperacion objPre)
        {
            int respuesta = 0, tipo = 3 ;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_TipoOperacion", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdTipoOperacion", objPre.nIdTipoOperacion);
                cmd.Parameters.AddWithValue("@Descripcion", objPre.sDescripcion);
                cmd.Parameters.AddWithValue("@CodigoSunat", objPre.sCodigoSunat);
                cmd.Parameters.AddWithValue("@Usuario", objPre.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objPre.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta= cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }

            return respuesta;
        }

        //Registrar
        public static int RegistrarTipoOperacion(TipoOperacion objPre)
        {
            int respuesta = 0, tipo = 2;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_TipoOperacion", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdTipoOperacion", objPre.nIdTipoOperacion);
                cmd.Parameters.AddWithValue("@Descripcion", objPre.sDescripcion);
                cmd.Parameters.AddWithValue("@CodigoSunat", objPre.sCodigoSunat);
                cmd.Parameters.AddWithValue("@Usuario", objPre.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objPre.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }

            return respuesta;
        }

        //Eliminar
        public static int EliminarActivarTipoOperacion(TipoOperacion objPre)
        {
            int respuesta = 0, tipo=4;
            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_TipoOperacion", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdTipoOperacion", objPre.nIdTipoOperacion);
                cmd.Parameters.AddWithValue("@Descripcion", objPre.sDescripcion);
                cmd.Parameters.AddWithValue("@CodigoSunat", objPre.sCodigoSunat);
                cmd.Parameters.AddWithValue("@Usuario", objPre.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objPre.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }

            return respuesta;
        }

    }
}
