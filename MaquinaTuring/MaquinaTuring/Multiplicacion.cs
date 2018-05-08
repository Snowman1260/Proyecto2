using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MaquinaTuring
{
    class Multiplicacion
    {
        public static string Cadena, Cadena2, temp;
        public static int longitud;
        public string resultado = "";
        //public string arreglo[];
        public int apuntador = 6;
        public static char[] Digitos;
        static DataGridView DGV;

        public String Multiplicador(String cadena, DataGridView DGVForm)
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

                temp = "x";
                mod();
                Right();
                q1();
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
            else if (temp == "*")
            {
                temp = "*";
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
                temp = "y";
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
                temp = "y";
                mod();
                Right();
                q3();
            }
            else if (temp == "=")
            {
                temp = "=";
                mod();
                Left();
                q4();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q4()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Right();
                q4();
            }
            else if (temp == "=")
            {
                temp = "=";
                mod();
                Right();
                q4();
            }
            else if (temp == "y")
            {
                temp = "1";
                mod();
                Right();
                q4();
            }
            else if (temp == "#")
            {
                temp = "1";
                mod();
                Left();
                q5();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q5()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Left();
                q5();
            }
            else if (temp == "*")
            {
                temp = "*";
                mod();
                Left();
                q5();
            }
            else if (temp == "=")
            {
                temp = "=";
                mod();
                Left();
                q5();
            }
            else if (temp == "x")
            {
                temp = "#";
                mod();
                Right();
                q6();
            }
            else if (temp == "y")
            {
                temp = "1";
                mod();
                Right();
                q4();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q6()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "x";
                mod();
                Right();
                q7();
            }
            else if (temp == "*")
            {
                temp = "*";
                mod();
                Right();
                q8();
            }
            else if (temp == "x")
            {
                temp = "#";
                mod();
                Right();
                q7();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q7()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "1";
                mod();
                Right();
                q7();
            }
            else if (temp == "*")
            {
                temp = "*";
                mod();
                Right();
                q2();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q8()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "1")
            {
                temp = "#";
                mod();
                Right();
                q8();
            }
            else if (temp == "=")
            {
                temp = "#";
                mod();
                Right();
                q9();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q9()
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
            DGV.Rows[apuntador - 1].Cells[0].Style.BackColor = Color.White;
            DGV.Rows[apuntador].Cells[0].Style.BackColor = Color.LightBlue;
            DGV.Rows[apuntador + 1].Cells[0].Style.BackColor = Color.White;
            //DGV.RowsDefaultCellStyle.ForeColor = Color.LightBlue;
            DGV.Refresh();
        }

    }
}
