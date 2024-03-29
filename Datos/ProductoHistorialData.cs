﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class ProductoHistorialData
    {
        //Listar Varios
        public static List<ProductoHistorial> ListarProductoHistorial(ProductoHistorial objProductoHist)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            SqlConnection cnx = null;
            List<ProductoHistorial> listProductoHist = new List<ProductoHistorial>();
            try
            {
                Conexion cn = new Conexion();
                cnx = new SqlConnection();
                cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_HistorialProducto", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProductoHist.nTipo);
                cmd.Parameters.AddWithValue("@IdHistorial", objProductoHist.nIdProductoHistorial);
                cmd.Parameters.AddWithValue("@IdProducto", objProductoHist.nIdProducto);
                cmd.Parameters.AddWithValue("@IdAlmacen", objProductoHist.nIdAlmacen);
                cmd.Parameters.AddWithValue("@Lote", objProductoHist.sLote);
                if(objProductoHist.nTipo==8 || objProductoHist.nTipo == 7 || objProductoHist.nTipo == 19) cmd.Parameters.AddWithValue("@IdLote", objProductoHist.sIdLote);
                else cmd.Parameters.AddWithValue("@IdLote", objProductoHist.nIdLote);
                cmd.Parameters.AddWithValue("@PrecioCompra", objProductoHist.fPrecioCompra);
                cmd.Parameters.AddWithValue("@Ganancia", objProductoHist.fGanancia);
                cmd.Parameters.AddWithValue("@PrecioVenta", objProductoHist.fPrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", objProductoHist.nStock);
                cmd.Parameters.AddWithValue("@Vencimiento", objProductoHist.dFechaVencimiento);
                cmd.Parameters.AddWithValue("@Usuario", objProductoHist.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProductoHist.bEstado);
                cmd.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProductoHistorial objProdHis = new ProductoHistorial();

                    if (objProductoHist.nTipo == 13 || objProductoHist.nTipo == 14)
                    {
                        objProdHis.nIdProducto = Convert.ToInt32(dr[0]);
                        objProdHis.nIdAlmacen = Convert.ToInt32(dr[1]);
                        objProdHis.sAlmacen = dr[2].ToString();
                        objProdHis.sCodigoInterno = dr[3].ToString();
                        objProdHis.sNombreProducto = dr[4].ToString();
                        objProdHis.bSeleccionar =Convert.ToBoolean(dr[5]);
                        objProdHis.sLaboratorio = dr[6].ToString();
                        objProdHis.sLote = dr[7].ToString();
                        objProdHis.dFechaVencimiento =Convert.ToDateTime(dr[8]);
                        objProdHis.nStock = Convert.ToInt32(dr[9]); 
                    }
                    else if (objProductoHist.nTipo == 12 || objProductoHist.nTipo == 11)
                    {
                        objProdHis.nIdProducto = Convert.ToInt32(dr[0]);
                        objProdHis.nIdAlmacen = Convert.ToInt32(dr[1]);
                        objProdHis.sAlmacen = dr[2].ToString();
                        objProdHis.sCodigoInterno = dr[3].ToString();
                        objProdHis.sNombreProducto = dr[4].ToString();
                        objProdHis.sPresentacion = Convert.ToString(dr[5]);
                        objProdHis.sLaboratorio = dr[6].ToString();
                        //Stock Minimo nIdProductoHistorial
                        objProdHis.nIdProductoHistorial = Convert.ToInt32(dr[7]);
                        objProdHis.nStock = Convert.ToInt32(dr[8]);
                    }
                    else if (objProductoHist.nTipo == 9 || objProductoHist.nTipo == 10)
                    {
                        objProdHis.nIdProducto = Convert.ToInt32(dr[0]);
                        objProdHis.sAlmacen = dr[1].ToString();
                        objProdHis.sCodigoInterno = dr[2].ToString();
                        objProdHis.sNombreProducto = dr[3].ToString();
                        objProdHis.bSeleccionar = Convert.ToBoolean(dr[4]);
                        objProdHis.sLaboratorio = dr[5].ToString();
                        objProdHis.sLote = dr[6].ToString();
                        if (dr[7] == DBNull.Value) objProdHis.dFechaVencimiento = null;
                        else objProdHis.dFechaVencimiento = Convert.ToDateTime(dr[7].ToString());
                        objProdHis.nStock = Convert.ToInt32(dr[8]);
                    }
                    else if (objProductoHist.nTipo == 8)
                    {
                        //Fecha
                        objProdHis.dFechaVencimiento = Convert.ToDateTime(dr[0]);
                        //Documento
                        objProdHis.sAlmacen = dr[1].ToString();
                        //Serie
                        objProdHis.sIdLote = dr[2].ToString();
                        //Numeracion
                        objProdHis.sLaboratorio = dr[3].ToString();

                        objProdHis.sTipoOperacion = dr[4].ToString();

                        objProdHis.sLote = Convert.ToString(dr[5]);
                        objProdHis.sMedSunat = dr[6].ToString();
                        objProdHis.sPresentacion = dr[7].ToString();

                        //Entrada
                        objProdHis.nIdLote = Convert.ToInt32(dr[8].ToString());

                        //Salida
                        objProdHis.nIdProductoHistorial = Convert.ToInt32(dr[9].ToString());
                        //Total
                        objProdHis.nStock = Convert.ToInt32(dr[10].ToString());

                    }
                    else if (objProductoHist.nTipo == 18 || objProductoHist.nTipo == 19)
                    {
                        //Fecha   
                        objProdHis.sCodigoInterno= dr[0].ToString();
                        objProdHis.sNombreProducto = dr[1].ToString();
                    
                        objProdHis.dFechaVencimiento = Convert.ToDateTime(dr[2]);
                        //Documento
                        objProdHis.sAlmacen = dr[3].ToString();
                        //Serie
                        objProdHis.sIdLote = dr[4].ToString();
                        //Numeracion
                        objProdHis.sLaboratorio = dr[5].ToString();

                        objProdHis.sTipoOperacion = dr[6].ToString();

                        objProdHis.sLote = Convert.ToString(dr[7]);
                        objProdHis.sMedSunat = dr[8].ToString();
                        objProdHis.sPresentacion = dr[9].ToString();

                        //Entrada
                        objProdHis.nIdLote = Convert.ToInt32(dr[10].ToString());

                        //Salida
                        objProdHis.nIdProductoHistorial = Convert.ToInt32(dr[11].ToString());
                        //Total
                        objProdHis.nStock = Convert.ToInt32(dr[12].ToString());
                        //TotalGeneral
                        objProdHis.nIdAlmacen= Convert.ToInt32(dr[13].ToString());

                    }
                    else if (objProductoHist.nTipo == 7)
                    {
                        //Fecha
                        objProdHis.dFechaVencimiento = Convert.ToDateTime(dr[0]);
                        //Documento
                        objProdHis.sAlmacen = dr[1].ToString();
                        //Serie
                        objProdHis.sIdLote = dr[2].ToString();
                        //Numeracion
                        objProdHis.sLaboratorio = dr[3].ToString();

                        objProdHis.sTipoOperacion = dr[4].ToString();
                        
                        objProdHis.sLote = Convert.ToString(dr[5]);
                        objProdHis.sMedSunat = dr[6].ToString();
                        objProdHis.sPresentacion = dr[7].ToString();
                        //Entrada
                        objProdHis.nIdLote = Convert.ToInt32(dr[8].ToString());

                        //Salida
                        objProdHis.nIdProductoHistorial = Convert.ToInt32(dr[9].ToString());
                        //Total
                        objProdHis.nStock = Convert.ToInt32(dr[10].ToString());

                    }
                    else
                    {
                        objProdHis.nIdProductoHistorial = Convert.ToInt32(dr[0]);
                        objProdHis.sLote = dr[1].ToString();
                        objProdHis.dFechaVencimiento = Convert.ToDateTime(dr[2]);
                        objProdHis.fPrecioCompra = Convert.ToDecimal(dr[3]);
                        objProdHis.fPrecioVenta = Convert.ToDecimal(dr[4]);
                        objProdHis.nStock = Convert.ToInt32(dr[5]);
                        objProdHis.bSeleccionar = Convert.ToBoolean(dr[6]); 
                    }

                    listProductoHist.Add(objProdHis);
                }

                return listProductoHist;
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
        public static int ActualizarProductoHistorial(ProductoHistorial objProductoHist)
        {
            int respuesta = 0;

            SqlCommand cmd = null;
            Conexion cn = new Conexion();

            try
            {
                SqlConnection cnx = cn.getConecta();
                cmd = new SqlCommand("IAE_HistorialProducto", cnx);
                cmd.Parameters.AddWithValue("@Tipo", objProductoHist.nTipo);
                cmd.Parameters.AddWithValue("@IdHistorial", objProductoHist.nIdProductoHistorial);
                cmd.Parameters.AddWithValue("@IdProducto", objProductoHist.nIdProducto);
                cmd.Parameters.AddWithValue("@IdAlmacen", objProductoHist.nIdAlmacen);
                cmd.Parameters.AddWithValue("@Lote", objProductoHist.sLote);
                cmd.Parameters.AddWithValue("@IdLote", objProductoHist.nIdLote);
                cmd.Parameters.AddWithValue("@PrecioCompra", objProductoHist.fPrecioCompra);
                cmd.Parameters.AddWithValue("@Ganancia", objProductoHist.fGanancia);
                cmd.Parameters.AddWithValue("@PrecioVenta", objProductoHist.fPrecioVenta);
                cmd.Parameters.AddWithValue("@Stock", objProductoHist.nStock);
                cmd.Parameters.AddWithValue("@Vencimiento", objProductoHist.dFechaVencimiento);
                cmd.Parameters.AddWithValue("@Usuario", objProductoHist.sUsuario);
                cmd.Parameters.AddWithValue("@Estado", objProductoHist.bEstado);
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
                cmd = null;
                cn = null;
            }

            return respuesta;
        }
    }
}
