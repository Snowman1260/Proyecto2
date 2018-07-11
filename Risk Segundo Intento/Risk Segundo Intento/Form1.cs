using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk_Segundo_Intento
{
    public partial class Form1 : Form
    {
        public Button[,] MatrizBotones = new Button[5, 4];

        public int Turnos;
        


        //Todo lo que tiene que ver con el primerturno y agregar tropas
        public int NumeroBoton;
        public int ContadorP;
        public int ContadorIA;

        public int TEMPORAL = 0;

        //Variable de boton para encontrar matriz

        //public Button[,] TemporalMatrizA = new Button[5,4];

        //Temporales de Matriz

        public int TemporalPosicionXPrimero;
        public int TemporalPosicionYPrimero;

        public int TemporalPosicionXSegundo;
        public int TemporalPosicionYSegundo;

        //Temporales Suma y Resta para movimiento de la matriz

        public int SumaA;
        public int SumaB;

        public int ResultadoMovimiento;

        public string enseñar;

        //Variable Flag para agregar mierdas de tropas

        public int AgregarTropasIdeaRoma1;
        public int AgregarTropasIdeaRoma2;
        public int NumeroTotal;
        public int AgregarTropasAlTurno = 0;

        

        public Form1()
        {
            InitializeComponent();
            IngresarBotones();

            Coloear();

            lblTurno.Text = "1";

            

        }
        Random botonIA = new Random();
        private void btnTurnoSiguiente_Click(object sender, EventArgs e)
        {
            clicks = 0;
            troopOffset = 0;

            ContadorP = 0;
            ContadorIA = 0;

            AgregarTropasAlTurno = 0;

            //Turnos Turno = new Turnos();

            //Turno.TurnosMovimientos(lblTurno, MatrizBotones);


            PasarTurno();

            NumeroDeTropasAAgregar();

            lblAgregarTropasTotales.Text = Convert.ToString(AgregarTropasAlTurno);

            if (Turnos % 2 == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    switch (botonIA.Next(1,5))
                    {
                        case 1:
                            btnIaP1_Click(sender, e);
                            break;
                        case 2:
                            btnIaP2_Click(sender, e);
                            break;
                        case 3:
                            btnIaP3_Click(sender, e);
                            break;
                        case 4:
                            btnIaP4_Click(sender, e);
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        public void IngresarBotones()
        {
            MatrizBotones[0, 0] = btnP1FirstCountry;
            MatrizBotones[0, 1] = btnP1SecondCountry;
            MatrizBotones[0, 2] = btnP1ThirdCountry;
            MatrizBotones[0, 3] = btnP1FourthCountry;

            MatrizBotones[4, 0] = btnIaP1;
            MatrizBotones[4, 1] = btnIaP2;
            MatrizBotones[4, 2] = btnIaP3;
            MatrizBotones[4, 3] = btnIaP4;

            MatrizBotones[1, 0] = btn01;
            MatrizBotones[2, 0] = btn02;
            MatrizBotones[3, 0] = btn03;

            MatrizBotones[1, 1] = btn11;
            MatrizBotones[2, 1] = btn12;
            MatrizBotones[3, 1] = btn13;

            MatrizBotones[1, 2] = btn21;
            MatrizBotones[2, 2] = btn22;
            MatrizBotones[3, 2] = btn23;

            MatrizBotones[1, 3] = btn31;
            MatrizBotones[2, 3] = btn32;
            MatrizBotones[3, 3] = btn33;

            AgregarSoldadosNeutral();

        }


        //Agrega los soldados donde debe ser el mapa

        public void AgregarSoldadosNeutral()
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MatrizBotones[i, j].Text = "2";
                }
            }
        }

        public void Coloear()
        {
            MatrizBotones[0, 0].BackColor = Color.FromArgb(0, 200, 0);
            MatrizBotones[0, 1].BackColor = Color.FromArgb(0, 200, 0);
            MatrizBotones[0, 2].BackColor = Color.FromArgb(0, 200, 0);
            MatrizBotones[0, 3].BackColor = Color.FromArgb(0, 200, 0);

            MatrizBotones[4, 0].BackColor = Color.FromArgb(200, 0, 0);
            MatrizBotones[4, 1].BackColor = Color.FromArgb(200, 0, 0);
            MatrizBotones[4, 2].BackColor = Color.FromArgb(200, 0, 0);
            MatrizBotones[4, 3].BackColor = Color.FromArgb(200, 0, 0);

        }

        public void PasarTurno()
        {
            Turnos = Convert.ToInt32(lblTurno.Text);
            Turnos++;
            lblTurno.Text = Convert.ToString(Turnos);
        }


        public void AgregarSoldadosP(Button Posicion)
        {


                if (ContadorP < 10)
                {
                    NumeroBoton = Convert.ToInt32(Posicion.Text);
                    NumeroBoton++;
                    Posicion.Text = Convert.ToString(NumeroBoton);
                    ContadorP++;
                }
                else
                {
                    MessageBox.Show("Se ha excedido de las tropas");
                }

                
            

        }
        int troopOffset = 0;
        int posx = -1;
        int posy = -1;
        int clicks = 0;
        private void btnP1FirstCountry_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                
                if (clicks == 0)
                {
                    posx = 0;
                    posy = 0;
                }
                pasarTropas(0, 0);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[0, 0]);
            }
            clicks++;
        }
        private int[,] moves(int x, int y)
        {
            int[,] moves = new int[2,8];
            moves[0, 0] = x + 1;
            moves[1, 0] = y - 1;
            moves[0, 1] = x + 1;
            moves[1, 1] = y;
            moves[0, 2] = x + 1;
            moves[1, 2] = y + 1;
            moves[0, 3] = x - 1;
            moves[1, 3] = y - 1;
            moves[0, 4] = x - 1;
            moves[1, 4] = y;
            moves[0, 5] = x - 1;
            moves[1, 5] = y + 1;
            moves[0, 6] = x;
            moves[1, 6] = y - 1;
            moves[0, 7] = x;
            moves[1, 7] = y + 1;
            return moves;
        }
        private bool checkMoves(int x, int y, int j, int k)
        {
            bool flag = false;
            int[,] posibleMoves = moves( j , k );
            for (int i = 0; i < 8; i++)
            {
                if (posibleMoves[0,i] == x && posibleMoves[1,i] == y)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private void pasarTropas(int x, int y)
        {
            
            if (posx != x || posy != y)
            {
                if (checkMoves(x, y, posx, posy) == true)
                {
                    if (MatrizBotones[x, y].BackColor == MatrizBotones[posx, posy].BackColor)
                    {
                        MatrizBotones[x, y].Text = (Convert.ToInt32(MatrizBotones[x, y].Text) + troopOffset).ToString();
                    }
                    else
                    {
                        if (troopOffset > Convert.ToInt32(MatrizBotones[x, y].Text))
                        {
                            MatrizBotones[x, y].BackColor = MatrizBotones[posx, posy].BackColor;
                        }
                        else
                        {

                        }
                        MatrizBotones[x, y].Text = (Math.Abs((Convert.ToInt32(MatrizBotones[x, y].Text) - troopOffset))).ToString();
                    }
                    troopOffset = 0;
                }
                else
                {
                    MessageBox.Show("Elija una opcion correcta");
                }
            }
            else
            {
                troopOffset++;
                MatrizBotones[posx, posy].Text = (Convert.ToInt32(MatrizBotones[posx, posy].Text) - 1).ToString();
            }
        }

        private void btnP1SecondCountry_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 0;
                    posy = 1;
                }
                pasarTropas(0, 1);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[0, 1]);
            }
            clicks++;
            //AgregarSoldadosP(MatrizBotones[0, 1]);
        }

        private void btnP1ThirdCountry_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 0;
                    posy = 2;
                }
                pasarTropas(0, 2);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[0, 2]);
            }
            clicks++;
            //AgregarSoldadosP(MatrizBotones[0, 2]);
        }

        private void btnP1FourthCountry_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 0;
                    posy = 3;
                }
                pasarTropas(0, 3);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[0, 3]);
            }
            clicks++;
            //AgregarSoldadosP(MatrizBotones[0, 3]);
        }

        private void btnIaP1_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 4;
                    posy = 0;
                }
                pasarTropas(4, 0);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[4, 0]);
            }
            clicks++;
            //AgregarSoldadosIA(MatrizBotones[4,0]);
        }

        private void btnIaP2_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 4;
                    posy = 1;
                }
                pasarTropas(4, 1);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[4, 1]);
            }
            clicks++;
            //AgregarSoldadosIA(MatrizBotones[4, 1]);
        }

        private void btnIaP3_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 4;
                    posy = 2;
                }
                pasarTropas(4, 2);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[4, 2]);
            }
            clicks++;
            //AgregarSoldadosIA(MatrizBotones[4, 2]);
        }

        private void btnIaP4_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 4;
                    posy = 3;
                }
                pasarTropas(4, 3);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[4, 3]);
            }
            clicks++;
            //AgregarSoldadosIA(MatrizBotones[4, 3]);
        }

        public void AgregarSoldadosIA(Button Posicion)
        {

            if (lblTurno.Text == "2")
            {
                if (ContadorIA < 10)
                {
                    NumeroBoton = Convert.ToInt32(Posicion.Text);
                    NumeroBoton++;
                    Posicion.Text = Convert.ToString(NumeroBoton);
                    ContadorIA++;
                }
                else
                {
                    MessageBox.Show("Se ha excedido de las tropas");
                }
            }
            
        }
        public void EncontrarMatrizA(int TemporalPosiX, int TemporalPosiY)
        {
            enseñar = MatrizBotones[TemporalPosiX, TemporalPosiY].Text;
            MessageBox.Show(enseñar);

           
        }

        public void EncontrarMatrizB(int TemporalPosiX, int TemporalPosiY)
        {
            enseñar = MatrizBotones[TemporalPosiX, TemporalPosiY].Text;
            MessageBox.Show(enseñar);

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 1;
                    posy = 0;
                }
                pasarTropas(1, 0);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[1, 0]);
            }
            clicks++;
            //TemporalPosicionXPrimero = 1;
            //TemporalPosicionYPrimero = 0;
            

            
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 2;
                    posy = 0;
                }
                pasarTropas(2, 0);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[2, 0]);
            }
            clicks++;
            //TemporalPosicionXSegundo = 2;
            //TemporalPosicionYSegundo = 0;

            //MovimientoDeTropas();

            //EncontrarMatrizB(TemporalPosicionXSegundo,TemporalPosicionYSegundo);

        }

        public void MovimientoDeTropas()
        {
            SumaA = Convert.ToInt32(MatrizBotones[TemporalPosicionXPrimero, TemporalPosicionYPrimero].Text);
            SumaB = Convert.ToInt32(MatrizBotones[TemporalPosicionXSegundo,TemporalPosicionYSegundo].Text);

            ResultadoMovimiento = SumaA - SumaB;

            MatrizBotones[TemporalPosicionXPrimero, TemporalPosicionYPrimero].Text = Convert.ToString(ResultadoMovimiento);
            MatrizBotones[TemporalPosicionXSegundo, TemporalPosicionYSegundo].Text = Convert.ToString(ResultadoMovimiento);


        }

        private void btn03_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 3;
                    posy = 0;
                }
                pasarTropas(3, 0);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[3, 0]);
            }
            clicks++;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 1;
                    posy = 1;
                }
                pasarTropas(1, 1);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[1, 1]);
            }
            clicks++;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 2;
                    posy = 1;
                }
                pasarTropas(2, 1);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[2, 1]);
            }
            clicks++;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 3;
                    posy = 1;
                }
                pasarTropas(3, 1);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[3, 1]);
            }
            clicks++;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 1;
                    posy = 2;
                }
                pasarTropas(1, 2);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[1, 2]);
            }
            clicks++;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 2;
                    posy = 2;
                }
                pasarTropas(2, 2);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[2, 2]);
            }
            clicks++;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 3;
                    posy = 2;
                }
                pasarTropas(3, 2);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[3, 2]);
            }
            clicks++;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 1;
                    posy = 3;
                }
                pasarTropas(1, 3);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[1, 3]);
            }
            clicks++;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 2;
                    posy = 3;
                }
                pasarTropas(2, 3);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[2, 3]);
            }
            clicks++;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (Turnos > 2)
            {
                if (clicks == 0)
                {
                    posx = 3;
                    posy = 3;
                }
                pasarTropas(3, 3);
            }
            else
            {
                AgregarSoldadosP(MatrizBotones[3, 3]);
            }
            clicks++;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTropas_Click(object sender, EventArgs e)
        {
            
            AgregarTropasIdeaRoma1 = Convert.ToInt32(txtMatriz1.Text);
            AgregarTropasIdeaRoma2 = Convert.ToInt32(txtMatriz2.Text);

            NumeroTotal = Convert.ToInt32(DUDNumerodeTropas.Text);

            if ((AgregarTropasIdeaRoma1 > -1) && (AgregarTropasIdeaRoma2 > -1) && (AgregarTropasAlTurno > 0))
            {


                if (MatrizBotones[AgregarTropasIdeaRoma1,AgregarTropasIdeaRoma2].BackColor == Color.FromArgb(0, 200, 0))
                {
                    NumeroBoton = Convert.ToInt32(MatrizBotones[AgregarTropasIdeaRoma1,AgregarTropasIdeaRoma2].Text);
                    NumeroBoton = NumeroBoton + NumeroTotal;
                    AgregarTropasAlTurno = AgregarTropasAlTurno - NumeroTotal;
                    MatrizBotones[AgregarTropasIdeaRoma1, AgregarTropasIdeaRoma2].Text = Convert.ToString(NumeroBoton);
                    lblAgregarTropasTotales.Text = Convert.ToString(AgregarTropasAlTurno);
                }
                else
                {
                    MessageBox.Show("Enseñar un color correcto");
                }
            }
            else
            {
                MessageBox.Show("Error en la posicion o se excedio de tropas");
            }

        }

        public void NumeroDeTropasAAgregar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (MatrizBotones[i, j].BackColor == Color.FromArgb(0, 200, 0))
                    {
                        AgregarTropasAlTurno = AgregarTropasAlTurno + 2;
                    }



                }
            }
        }





        //public void ValidarTurno(Button Primero, Button Segundo)
        //{
        //    if (lblTurno.Text == "1")
        //    {
        //        AgregarSoldadosP(Primero);
        //    }

        //    else if (lblTurno.Text == "2")
        //    {
        //        AgregarSoldadosIA(Primero);
        //    }

        //    else if (lblTurno.Text == "3")
        //    {

        //    }
        //}

    }
}
