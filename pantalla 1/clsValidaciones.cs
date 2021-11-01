using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pantalla_1
{
    class clsValidaciones
    {
        //valida espacios en blanco
        public bool Espacio_Blanco(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Espacio_Blanco = true;

            foreach (char caracter in txt.Text)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    Espacio_Blanco = false;
                    ubicacionError.SetError(txt, "");
                    break;
                }
                else
                {
                    Espacio_Blanco = true;
                }
            }
            return Espacio_Blanco;
        }
        //valida solo letras con espacios en blacons
        public bool Solo_Letras(ErrorProvider ubicacionError, TextBox txt)
        {
            bool soloLetras = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsLetter(caracter))
                {
                    soloLetras = false;
                    ubicacionError.SetError(txt, "");
                }
                else if (char.IsWhiteSpace(caracter))
                {
                    soloLetras = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    soloLetras = true;
                    break;
                }
            }
            return soloLetras;
        }

        //valida solo numeros
        public bool Solo_Numeros(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Solo_Numeros = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsDigit(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    Solo_Numeros = true;
                    break;
                }
            }
            return Solo_Numeros;
        }

        //valida numero con signos de puntuacion
        public bool Solo_Numeros1(ErrorProvider ubicacionError, TextBox txt)
        {
            bool Solo_Numeros = true;
            foreach (char caracter in txt.Text)
            {
                if (Char.IsDigit(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else if (char.IsPunctuation(caracter))
                {
                    Solo_Numeros = false;
                    ubicacionError.SetError(txt, "");
                }
                else
                {
                    Solo_Numeros = true;
                    break;
                }
            }
            return Solo_Numeros;
        }
    }
}
