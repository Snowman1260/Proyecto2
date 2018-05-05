using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaTuring
{
    public class Palindromos
    {
        string Cadenaeje = "";
        char[] Letras = new char[0];


        public String Palicroquet(String cadena)
        {
            Cadenaeje = cadena;
            char[] Letras = new char[Cadenaeje.Length];


            for (int i = 0; i < Cadenaeje.Length; i++)
            {
                Letras[i] = Convert.ToChar(Cadenaeje.Substring(i, 1));
            }

            return Cadenaeje;

        }
        public void qo() 
        {
            string temp = "";
            
        }
    }
}
