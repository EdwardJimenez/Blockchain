using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WABlockchain.Class
{
    public class Helper
    {
        #region Validacion TextBox
        public bool validacionBarraBajaPuntoComaVacio(string texto)
        {
            bool res = false;
            string text = texto.Trim();
            if (text != "")
            {
                string[] validacionPuntoComa = text.Split(';');
                if (text[text.Length - 1].ToString() != "_" && validacionPuntoComa.Count() < 2)
                {
                    res = true;
                }
            }
            return res;
        }
        private string normalizarNombres(string nombresR)
        {
            string[] nombres = nombresR.Trim().ToLower().Split(' ');
            string res = string.Empty, primerNombre = nombres[0], segundoNombre = string.Empty, primerNombreConversion = string.Empty, segundoNombreConversion = string.Empty;
            char[] letras;
            letras = primerNombre.ToCharArray();
            letras[0] = char.ToUpper(letras[0]);
            for (int i = 0; i < letras.Length; i++)
            {
                primerNombreConversion = primerNombreConversion + letras[i];
            }
            if (nombres.Length >= 2)
            {
                segundoNombre = nombres[1];
                letras = segundoNombre.ToCharArray();
                letras[0] = char.ToUpper(letras[0]);
                for (int i = 0; i < letras.Length; i++)
                {
                    segundoNombreConversion = segundoNombreConversion + letras[i];
                }
            }
            res = primerNombreConversion + " " + segundoNombreConversion;
            return res;
        }
        private string[] normalizarApellidos(string apellidosR)
        {
            string[] apellidos = apellidosR.Trim().ToLower().Split(' '), res = new string[2];
            string primerApellidoConversion = string.Empty, segundoApellidoConversion = string.Empty, primerApellido = apellidos[0], segundoApellido = string.Empty;
            char[] letras;
            letras = primerApellido.ToCharArray();
            letras[0] = char.ToUpper(letras[0]);
            for (int i = 0; i < letras.Length; i++)
            {
                primerApellidoConversion = primerApellidoConversion + letras[i];
            }
            if (apellidos.Length >= 2)
            {
                segundoApellido = apellidos[1];
                letras = segundoApellido.ToCharArray();
                letras[0] = char.ToUpper(letras[0]);
                for (int i = 0; i < letras.Length; i++)
                {
                    segundoApellidoConversion = segundoApellidoConversion + letras[i];
                }
            }
            res[0] = primerApellidoConversion;
            res[1] = segundoApellidoConversion;
            return res;
        }
       
        #endregion
    }
}