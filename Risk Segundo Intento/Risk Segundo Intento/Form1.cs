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


        public Form1()
        {
            InitializeComponent();
            IngresarBotones();

            Coloear();

            lblTurno.Text = "1";

            

        }

        private void btnTurnoSiguiente_Click(object sender, EventArgs e)
        {

            //Turnos Turno = new Turnos();

            //Turno.TurnosMovimientos(lblTurno, MatrizBotones);


            PasarTurno();
            

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

            if (lblTurno.Text =="1")
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

        }

        private void btnP1FirstCountry_Click(object sender, EventArgs e)
        {
            AgregarSoldadosP(MatrizBotones[0, 0]);
        }

        private void btnP1SecondCountry_Click(object sender, EventArgs e)
        {
            AgregarSoldadosP(MatrizBotones[0, 1]);
        }

        private void btnP1ThirdCountry_Click(object sender, EventArgs e)
        {
            AgregarSoldadosP(MatrizBotones[0, 2]);
        }

        private void btnP1FourthCountry_Click(object sender, EventArgs e)
        {
            AgregarSoldadosP(MatrizBotones[0, 3]);
        }

        private void btnIaP1_Click(object sender, EventArgs e)
        {
            AgregarSoldadosIA(MatrizBotones[4,0]);
        }

        private void btnIaP2_Click(object sender, EventArgs e)
        {
            AgregarSoldadosIA(MatrizBotones[4, 1]);
        }

        private void btnIaP3_Click(object sender, EventArgs e)
        {
            AgregarSoldadosIA(MatrizBotones[4, 2]);
        }

        private void btnIaP4_Click(object sender, EventArgs e)
        {
            AgregarSoldadosIA(MatrizBotones[4, 3]);
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
            TemporalPosicionXPrimero = 1;
            TemporalPosicionYPrimero = 0;
            

            
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            TemporalPosicionXSegundo = 2;
            TemporalPosicionYSegundo = 0;

            MovimientoDeTropas();

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
