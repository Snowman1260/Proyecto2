using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Risk_Segundo_Intento
{
    class Turnos
    {
        public void TurnosMovimientos(Label Turno, Button[,] MatrizBotones)
        {
            int NumeroDentroDeLaMatriz;

            if (Turno.Text == "1")
            {
                MatrizBotones[0, 0].BackColor = Color.FromArgb(128, 0, 0);
                MatrizBotones[0, 1].BackColor = Color.FromArgb(128, 0, 0);
                MatrizBotones[0, 2].BackColor = Color.FromArgb(128, 0, 0);
                MatrizBotones[0, 3].BackColor = Color.FromArgb(128, 0, 0);

                //if (MatrizBotones[0,0].Click+= true)               
                //{
                //    NumeroDentroDeLaMatriz = Convert.ToInt32(MatrizBotones[0,0].Text);
                //    NumeroDentroDeLaMatriz++;
                //    MatrizBotones[0, 0].Text = Convert.ToString(NumeroDentroDeLaMatriz);
                //}


                
            }

       


        }

    }
}
