using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuring
{
    public class Suma
    {
        public static string Cadena, Cadena2, temp;
        public static int longitud;
        public string resultado = "";
        //public string arreglo[];
        public int apuntador = 0;
        public static char[] Digitos;

        public String Sumador(String cadena)
        {
            
            Cadena = cadena;
            
            decodificar(Cadena);
            return Cadena;
        }

        public void decodificar(String dec)
        {
            Digitos = new char[dec.Length];
            for (int i = 0; i < dec.Length; i++)
            {
                Digitos[i] = Convert.ToChar(dec.Substring(i, 1));
            }

            q0();
        }

        public void q0()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "0";
                apuntador++;
                q1();
            }
        }

        public void q1()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                apuntador++;
                q1();
            }
            if (temp == "+")
            {
                temp = "1";
                apuntador++;
                q2();
            }
        }
        public void q2()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                apuntador++;
                q3();
            }
        }
        public void q3()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                apuntador++;
                q3();
            }
            if (temp == "=")
            {
                temp = "#";
                apuntador++;
                q4();
            }
        }
        public void q4()
        {
            Cadena = "Bien";
        }

        public void Right()
        {
            apuntador++;
        }
        public void Left()
        {
            apuntador--;
        }
        

    }

    
}
