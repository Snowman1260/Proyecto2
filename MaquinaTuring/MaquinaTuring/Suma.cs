using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace MaquinaTuring
{
    public class Suma
    {
        public static string Cadena, Cadena2, temp;
        public static int longitud;
        public string resultado = "";
        //public string arreglo[];
        public int apuntador = 6;
        public static char[] Digitos;
        static DataGridView DGV;

        public String Sumador(String cadena, DataGridView DGVForm)
        {
            
            Cadena = cadena;
            DGV = DGVForm;
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
                mod();
                Right();     
                q1();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Right();
                q0();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }

        public void q1()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Right();
                q1();
            }
            else if (temp == "+")
            {
                temp = "1";
                mod();
                Right();
                q2();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q2()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Right();
                q3();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q3()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Right();
                q3();
            }
            else if (temp == "=")
            {
                temp = "#";
                mod();
                Right();
                q4();
            }
            else
            {
                Cadena = "Error en" + temp;
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


        
        public void mod()
        {
            //DGV[0, apuntador].Value.ToString().Replace(" ",temp
            Digitos[apuntador] = Convert.ToChar(temp);
            DGV[0, apuntador].Value = temp;
            DGV.Rows[apuntador-1].Cells[0].Style.BackColor = Color.White;
            DGV.Rows[apuntador].Cells[0].Style.BackColor = Color.LightBlue;
            DGV.Rows[apuntador+1].Cells[0].Style.BackColor = Color.White;
            //DGV.RowsDefaultCellStyle.ForeColor = Color.LightBlue;
            DGV.Refresh();
            Thread.Sleep(1000);
        }

    }

    
}
