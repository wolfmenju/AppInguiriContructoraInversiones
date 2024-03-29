﻿using Entidad;
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
    public class DocumentoData
    {
        //Listar Varios
        public static List<Documento> ListarDocumento(Documento objDoc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<Documento> listDocumento = new List<Documento>();
            SqlConnection cnx = null;
            try
            {
                Conexion cn = new Conexion();
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Documento", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objDoc.nTipo);
                cmd.Parameters.AddWithValue("@IdDocumento", "");
                cmd.Parameters.AddWithValue("@Descripcion", "");
                cmd.Parameters.AddWithValue("@Abreviatura", "");

                cmd.Parameters.AddWithValue("@Venta", "");
                cmd.Parameters.AddWithValue("@Compra", "");
                cmd.Parameters.AddWithValue("@DocumentoInterno", "");

                cmd.Parameters.AddWithValue("@Usuario", "");
                cmd.Parameters.AddWithValue("@Estado", objDoc.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Documento objDocument = new Documento();

                    if (objDoc.nTipo == 5)
                    {
                        objDocument.sIdDocumento = dr[0].ToString();
                        objDocument.sDescripcion = dr[1].ToString();
                    }
                    else
                    {
                        objDocument.sIdDocumento = dr[0].ToString();
                        objDocument.sDescripcion = dr[1].ToString();
                        objDocument.sAbreviatura = dr[2].ToString();

                        objDocument.Venta =Convert.ToBoolean(dr[3]);
                        objDocument.Compra =Convert.ToBoolean(dr[4]);
                        objDocument.DoumentoInterno =Convert.ToBoolean(dr[5]);

                    }
                    listDocumento.Add(objDocument);

                }
                return listDocumento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        
        //Actualizar
        public static int ActualizarDocumento(Documento objDocumt)
        {
            int respuesta = 0, tipo = 3 ;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Documento", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdDocumento",objDocumt.sIdDocumento);
                cmd.Parameters.AddWithValue("@Descripcion", objDocumt.sDescripcion);
                cmd.Parameters.AddWithValue("@Abreviatura", objDocumt.sAbreviatura);
                cmd.Parameters.AddWithValue("@Venta", objDocumt.Venta);
                cmd.Parameters.AddWithValue("@Compra", objDocumt.Compra);
                cmd.Parameters.AddWithValue("@DocumentoInterno", objDocumt.DoumentoInterno);
                cmd.Parameters.AddWithValue("@Usuario", objDocumt.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objDocumt.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta= cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message,"InguiriSoft",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }

            return respuesta;
        }

        //Registrar
        public static int RegistrarDocumento(Documento objDocumt)
        {
            int respuesta = 0, tipo = 2;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;

            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Documento", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdDocumento", objDocumt.sIdDocumento);
                cmd.Parameters.AddWithValue("@Descripcion", objDocumt.sDescripcion);
                cmd.Parameters.AddWithValue("@Abreviatura", objDocumt.sAbreviatura);
                cmd.Parameters.AddWithValue("@Venta", objDocumt.Venta);
                cmd.Parameters.AddWithValue("@Compra", objDocumt.Compra);
                cmd.Parameters.AddWithValue("@DocumentoInterno", objDocumt.DoumentoInterno);
                cmd.Parameters.AddWithValue("@Usuario", objDocumt.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objDocumt.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message, "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
            }

            return respuesta;
        }

        //Eliminar
        public static int EliminarActivarDocumento(Documento objDocumt)
        {
            int respuesta = 0, tipo=4;
            SqlCommand cmd = null;
            Conexion cn = new Conexion();
            SqlConnection cnx = null;
            try
            {
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_Documento", cnx);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@IdDocumento", objDocumt.sIdDocumento);
                cmd.Parameters.AddWithValue("@Descripcion", objDocumt.sDescripcion);
                cmd.Parameters.AddWithValue("@Abreviatura", objDocumt.sAbreviatura);
                cmd.Parameters.AddWithValue("@Venta", objDocumt.Venta);
                cmd.Parameters.AddWithValue("@Compra", objDocumt.Compra);
                cmd.Parameters.AddWithValue("@DocumentoInterno", objDocumt.DoumentoInterno);
                cmd.Parameters.AddWithValue("@Usuario", objDocumt.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objDocumt.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();

                respuesta = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                respuesta = 2;
                MessageBox.Show(ex.Message, "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
