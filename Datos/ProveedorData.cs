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
    public class ProveedorData
    {
        //Listar Varios
        public static List<Proveedor> ListarProveedor(Proveedor objProveedor)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            SqlConnection cnx = null;
            List<Proveedor> listProveedor = new List<Proveedor>();
            try
            {
                Conexion cn = new Conexion();
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Proveedor", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProveedor.nTipo);
                cmd.Parameters.AddWithValue("@IdProveedor", objProveedor.nIdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", objProveedor.sRazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", objProveedor.sNumeroDoc);
                cmd.Parameters.AddWithValue("@Direccion", objProveedor.sDireccion);
                cmd.Parameters.AddWithValue("@Distrito", objProveedor.sDistrito);
                cmd.Parameters.AddWithValue("@Provincia", objProveedor.sProvincia);
                cmd.Parameters.AddWithValue("@Departamento", objProveedor.sDepartamento);
                cmd.Parameters.AddWithValue("@Ubigeo", objProveedor.sUbigeo);
                cmd.Parameters.AddWithValue("@Celular", objProveedor.sCelular);
                cmd.Parameters.AddWithValue("@Contacto", objProveedor.sContacto);
                cmd.Parameters.AddWithValue("@Usuario", objProveedor.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProveedor.bEstado);
                cmd.Parameters.AddWithValue("@ValidadoSunat", objProveedor.bValidadoSunat);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Proveedor objUser = new Proveedor();
                    objUser.nIdProveedor = Convert.ToInt32(dr[0]);
                    objUser.sRazonSocial = dr[1].ToString();
                    objUser.sNumeroDoc = dr[2].ToString();
                    objUser.sDireccion = dr[3].ToString();
                    objUser.sCelular = dr[4].ToString();
                    objUser.sContacto = dr[5].ToString();
                    objUser.bValidadoSunat=Convert.ToBoolean(dr[6].ToString());

                    listProveedor.Add(objUser);

                }
                return listProveedor;
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

        //Registrar
        public static int RegistrarProveedor(Proveedor objProveedor)
        {
            int respuesta = 0;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;
            
            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Proveedor", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProveedor.nTipo);
                cmd.Parameters.AddWithValue("@IdProveedor", objProveedor.nIdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", objProveedor.sRazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", objProveedor.sNumeroDoc);
                cmd.Parameters.AddWithValue("@Direccion", objProveedor.sDireccion);
                cmd.Parameters.AddWithValue("@Distrito", objProveedor.sDistrito);
                cmd.Parameters.AddWithValue("@Provincia", objProveedor.sProvincia);
                cmd.Parameters.AddWithValue("@Departamento", objProveedor.sDepartamento);
                cmd.Parameters.AddWithValue("@Ubigeo", objProveedor.sUbigeo);
                cmd.Parameters.AddWithValue("@Celular", objProveedor.sCelular);
                cmd.Parameters.AddWithValue("@Contacto", objProveedor.sContacto);
                cmd.Parameters.AddWithValue("@Usuario", objProveedor.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProveedor.bEstado);
                cmd.Parameters.AddWithValue("@ValidadoSunat", objProveedor.bValidadoSunat);
                
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

        //Actualizar
        public static int ActualizarProveedor(Proveedor objProveedor)
        {
            int respuesta = 0;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Proveedor", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProveedor.nTipo);
                cmd.Parameters.AddWithValue("@IdProveedor", objProveedor.nIdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", objProveedor.sRazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", objProveedor.sNumeroDoc);
                cmd.Parameters.AddWithValue("@Direccion", objProveedor.sDireccion);
                cmd.Parameters.AddWithValue("@Distrito", objProveedor.sDistrito);
                cmd.Parameters.AddWithValue("@Provincia", objProveedor.sProvincia);
                cmd.Parameters.AddWithValue("@Departamento", objProveedor.sDepartamento);
                cmd.Parameters.AddWithValue("@Ubigeo", objProveedor.sUbigeo);
                cmd.Parameters.AddWithValue("@Celular", objProveedor.sCelular);
                cmd.Parameters.AddWithValue("@Contacto", objProveedor.sContacto);
                cmd.Parameters.AddWithValue("@Usuario", objProveedor.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProveedor.bEstado);
                cmd.Parameters.AddWithValue("@ValidadoSunat", objProveedor.bValidadoSunat);
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

        public static int EliminarActivarProveedor(Proveedor objProveedor)
        {
            int respuesta = 0;
            SqlCommand cmd = null;
            SqlConnection cnx = null;
            Conexion cn = new Conexion();

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Proveedor", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProveedor.nTipo);
                cmd.Parameters.AddWithValue("@IdProveedor", objProveedor.nIdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", objProveedor.sRazonSocial);
                cmd.Parameters.AddWithValue("@Ruc", objProveedor.sNumeroDoc);
                cmd.Parameters.AddWithValue("@Direccion", objProveedor.sDireccion);
                cmd.Parameters.AddWithValue("@Distrito", objProveedor.sDistrito);
                cmd.Parameters.AddWithValue("@Provincia", objProveedor.sProvincia);
                cmd.Parameters.AddWithValue("@Departamento", objProveedor.sDepartamento);
                cmd.Parameters.AddWithValue("@Ubigeo", objProveedor.sUbigeo);
                cmd.Parameters.AddWithValue("@Celular", objProveedor.sCelular);
                cmd.Parameters.AddWithValue("@Contacto", objProveedor.sContacto);
                cmd.Parameters.AddWithValue("@Usuario", objProveedor.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProveedor.bEstado);
                cmd.Parameters.AddWithValue("@ValidadoSunat", objProveedor.bValidadoSunat);
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
