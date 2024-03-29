﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comun
{
    public static class Funciones
    {
        private static string User = "";
        private static int CodAlmacen = 0;
        private static string NombreAlmacen = "";
        private static string NombreUsuario = "";

        private static DateTime dtCodFecha = Globales.FechaActual();

        public static void UsuarioActualSet(string user)
        {
            User = user;
        }

        public static void UsuarioActualNombreSet(string user)
        {
            NombreUsuario = user;
        }

        public static string UsuarioNombreActual()
        {
            return NombreUsuario;
        }

        public static string UsuarioActual()
        {
            return User;
        }

        public static bool VerificarConexionInternet()
        {
            System.Uri Url = new System.Uri("https://www.google.com/");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objetoResp;

            try
            {
                //Se establecio conexión a internet corretamente.
                objetoResp = WebRequest.GetResponse();
                objetoResp.Close();
                return true;
            }
            catch (Exception ex)
            {
                //No se pudo conectar a Internet "
                return false;
            }            
        }
        
        public static int CodAlmacenActual()
        {
            return CodAlmacen;
        }

        public static string NombreAlmacenActual()
        {
            return NombreAlmacen;
        }

        public static DateTime CodFechaActual()
        {
            return dtCodFecha;
        }

        public static void CodFechaSet(DateTime dtCodAlmacen)
        {
            dtCodFecha = dtCodAlmacen;
        }

        public static void CodAlmacenSet(int codAlmacen)
        {
            CodAlmacen = codAlmacen;
        }

        public static void NombreAlmacenSet(string nombreAlmacen)
        {
            NombreAlmacen = nombreAlmacen;
        }
        
        public static bool DatosVacios( string valorDato)
        {
            if (valorDato == "" || valorDato == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DatosDuplicados(string valorDato)
        {
            return true;
        }

        public static decimal CalcularMonto(decimal num1,decimal num2)
        {
            return num1 * num2;
        }

        public static int ValidarNumeroEntero(KeyPressEventArgs e, TextBox text)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return 1;
        }

        public static void LimpiarCajas(System.Windows.Forms.Control.ControlCollection Controls)
        {
            foreach (Control item in Controls)
            {
                if (item.Controls != null && item.Controls.Count > 0)
                {
                    LimpiarCajas(item.Controls);
                }
                else if (item.GetType().Name == "TextBox")
                {
                   
                }
            }
        }
     
       
        public static int ValidarNumeroDecimal(KeyPressEventArgs e, TextBox text)
        {
            string Separador = ".";
            int d = e.KeyChar.ToString().Length;
            int f = text.Text.Length;
            int dig = Convert.ToString(text.Text.Trim() + e.KeyChar).Length;
            int a = 0, esDecimal = 0, NumDecimales = 0;
            bool esDec = false;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Separador))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return a;
            }
            else
            {
                e.Handled = true;
            }

            if (text.SelectedText != "")
            {
                if (e.KeyChar == Convert.ToChar(Separador))
                {
                    e.Handled = false;
                    return a;
                }
            }
            if (dig == 1 && e.KeyChar == Convert.ToChar(Separador))
            {
                e.Handled = true;
                return a;
            }

            if (text.SelectedText == "")
            {
                for (a = 0; a <= dig - 1; a++)
                {
                    string car = Convert.ToString(text.Text + e.KeyChar);

                    if (Convert.ToChar(car.Substring(a, 1)) == Convert.ToChar(Separador))
                    {
                        esDecimal = esDecimal + 1;
                        esDec = true;
                    }

                    if (esDec)
                    {
                        NumDecimales = NumDecimales + 1;
                    }

                    if (NumDecimales >= 4 || esDecimal >= 2)
                    {
                        e.Handled = true;
                    }

                }
            }

            return 1;
        }

        public static bool Duplicados(string texto, DataGridView datagriview)
        {
            foreach (DataGridViewRow item in datagriview.Rows)
            {
                if (item.Cells["sDescripcion"].Value.ToString() == texto)
                {
                    MessageBox.Show("La Descripción " + texto + " Ya Existe.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static bool DuplicadosDocumento(string texto, DataGridView datagriview)
        {
            foreach (DataGridViewRow item in datagriview.Rows)
            {
                if (item.Cells["sNumeroDoc"].Value.ToString() == texto)
                {
                    MessageBox.Show("El documento N° " + texto + " Ya Existe.", "InguiriSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public static string NumeroALetras(this decimal numberAsString)
        {
            string dec;

            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            if (decimales > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" Y {decimales:0,0} /100 SOLES";
            }
            //Código agregado por mí
            else
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" Y {decimales:0,0} /100 SOLES";
            }
            var res = NumerosLetras(Convert.ToDecimal(entero)) + dec;
            return res;
        }

        public static string NumerosLetras( decimal value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + NumerosLetras(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + NumerosLetras(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = NumerosLetras(Math.Truncate(value / 10) * 10) + " Y " + NumerosLetras(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + NumerosLetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumerosLetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = NumerosLetras(Math.Truncate(value / 100) * 100) + " " + NumerosLetras(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + NumerosLetras(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = NumerosLetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + NumerosLetras(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + NumerosLetras(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = NumerosLetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + NumerosLetras(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + NumerosLetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = NumerosLetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + NumerosLetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }

        public static string ExtrarNumeroTexto(string texto)
        {
            string sNum = string.Empty;
            Match m = Regex.Match(texto, "(\\d+)");

            if (m.Success) sNum = m.Value;

            return sNum;
        }
    }
}
