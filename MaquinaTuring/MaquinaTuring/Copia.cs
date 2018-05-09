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
    public class Copia
    {
        public static string Cadena, Cadena2, temp;
        public static int longitud;
        public string resultado = "";
        //public string arreglo[];
        public int apuntador = 6;
        public static char[] Digitos;
        static DataGridView DGV;

        public String Copiador(String cadena, DataGridView DGVForm)
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
            if (temp == "a")
            {

                temp = "x";
                mod();
                Right();
                q1();
            }
            else if (temp == "b")
            {
                temp = "y";
                mod();
                Right();
                q3();
            }
            else if (temp == "c")
            {
                temp = "z";
                mod();
                Right();
                q4();
            }
            else if (temp == "x")
            {
                temp = "x";
                mod();
                Right();
                q0();
            }
            else if (temp == "y")
            {
                temp = "y";
                mod();
                Right();
                q0();
            }
            else if (temp == "z")
            {
                temp = "z";
                mod();
                Right();
                q0();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q5();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }

        public void q1()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {

                temp = "a";
                mod();
                Right();
                q1();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Right();
                q1();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Right();
                q1();
            }
            else if (temp == "x")
            {
                temp = "x";
                mod();
                Right();
                q1();
            }
            else if (temp == "y")
            {
                temp = "y";
                mod();
                Right();
                q1();
            }
            else if (temp == "z")
            {
                temp = "z";
                mod();
                Right();
                q1();
            }
            else if (temp == "#")
            {
                temp = "x";
                mod();
                Left();
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
            if (temp == "a")
            {

                temp = "a";
                mod();
                Left();
                q2();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Left();
                q2();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Left();
                q2();
            }
            else if (temp == "x")
            {
                temp = "x";
                mod();
                Left();
                q2();
            }
            else if (temp == "y")
            {
                temp = "y";
                mod();
                Left();
                q2();
            }
            else if (temp == "z")
            {
                temp = "z";
                mod();
                Left();
                q2();
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
        public void q3()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {

                temp = "a";
                mod();
                Right();
                q3();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Right();
                q3();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Right();
                q3();
            }
            else if (temp == "x")
            {
                temp = "x";
                mod();
                Right();
                q3();
            }
            else if (temp == "y")
            {
                temp = "y";
                mod();
                Right();
                q3();
            }
            else if (temp == "z")
            {
                temp = "z";
                mod();
                Right();
                q3();
            }
            else if (temp == "#")
            {
                temp = "y";
                mod();
                Left();
                q2();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q4()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {

                temp = "a";
                mod();
                Right();
                q4();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Right();
                q4();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Right();
                q4();
            }
            else if (temp == "x")
            {
                temp = "x";
                mod();
                Right();
                q4();
            }
            else if (temp == "y")
            {
                temp = "y";
                mod();
                Right();
                q4();
            }
            else if (temp == "z")
            {
                temp = "z";
                mod();
                Right();
                q4();
            }
            else if (temp == "#")
            {
                temp = "z";
                mod();
                Left();
                q2();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q5()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "x")
            {

                temp = "a";
                mod();
                Left();
                q5();
            }
            else if (temp == "y")
            {
                temp = "b";
                mod();
                Left();
                q5();
            }
            else if (temp == "z")
            {
                temp = "c";
                mod();
                Left();
                q5();
            }

            else if (temp == "#")
            {
                temp = "#";
                mod();
                Right();
                q6();
            }

            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q6()
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
            Thread.Sleep(1000);
        }

    }
}
