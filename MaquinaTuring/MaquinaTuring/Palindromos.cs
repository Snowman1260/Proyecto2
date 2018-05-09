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
    public class Palindromos
    {
        public static string Cadena, temp, Estados;
        public static int longitud;
        public string resultado = "";
        //public string arreglo[];
        public int apuntador = 6;
        public static char[] Digitos;
        static DataGridView DGV;
        //static Label Cadena2;

        public String Palicroquet(String cadena, DataGridView DGVForm, String Cadena2)
        {
            Cadena2 = Estados;
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
            Estados = "q0";
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {
                
                temp = "#";
                mod();
                Right();
                q1();
            }
            else if (temp == "b")
            {
                temp = "#";
                mod();
                Right();
                q4();
            }
            else if (temp == "c")
            {
                temp = "#";
                mod();
                Right();
                q7();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q10();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }

        public void q1()
        {
            Estados = "q1";
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
            else if (temp == "#")
            {
                temp = "#";
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
                temp = "#";
                mod();
                Left();
                q3();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q10();
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
                Left();
                q3();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Left();
                q3();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Left();
                q3();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Right();
                q0();
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
        public void q5()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "b")
            {
                temp = "#";
                mod();
                Left();
                q3();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q10();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q6()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {
                temp = "a";
                mod();
                Left();
                q6();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Left();
                q6();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Left();
                q6();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Right();
                q0();
            }
        }
        public void q7()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {
                temp = "a";
                mod();
                Right();
                q7();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Right();
                q7();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Right();
                q7();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q8();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q8()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "c")
            {
                temp = "#";
                mod();
                Left();
                q9();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Left();
                q10();
            }
            else
            {
                Cadena = "Error en" + temp;
            }
        }
        public void q9()
        {
            temp = Convert.ToString(Digitos[apuntador]);
            if (temp == "a")
            {
                temp = "a";
                mod();
                Left();
                q9();
            }
            else if (temp == "b")
            {
                temp = "b";
                mod();
                Left();
                q9();
            }
            else if (temp == "c")
            {
                temp = "c";
                mod();
                Left();
                q9();
            }
            else if (temp == "#")
            {
                temp = "#";
                mod();
                Right();
                q0();
            }
        }
        public void q10()
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
