using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaTuring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string Cadena = txtCadena.Text;
            string Resultado = "";

            for (int i = 0; i < Cadena.Length; i++)
            {

            }

            if (rdbPalindromas.Checked)
            {
                MessageBox.Show("Palindromos escogido");
                Palindromos Palindro = new Palindromos();
                Resultado = Palindro.Palicroquet(Cadena);
                MessageBox.Show(Resultado);
            }

            if (rdbCopia.Checked)
            {
                MessageBox.Show("Copia escogido");
            }

            if (rdbSuma.Checked)
            {
                MessageBox.Show("Suma escogido");
            }

            if (rdbResta.Checked)
            {
                MessageBox.Show("Resta escogido");
            }

            if (rdbMultiplicacion.Checked)
            {
                MessageBox.Show("Multiplicacion escogido");
            }
        }

        
    }
}
