using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            
            int n = DGVCadena.Rows.Count;

            string Cadena = "###"+txtCadena.Text+"###";
            string Resultado = "";
            char[] Caracteres = new char[Cadena.Length];
            for (int i = 0; i < Cadena.Length; i++)
            {
                DGVCadena.Rows.Add();
                Caracteres[i] = Convert.ToChar(Cadena.Substring(i,1));  
                DGVCadena[0, i].Value = Convert.ToString(Caracteres[i]);
            }
            
            if (rdbPalindromas.Checked)
            {
                MessageBox.Show("Palindromos escogido");
                Palindromos Palindro = new Palindromos();
                Resultado = Palindro.Palicroquet(Cadena, DGVCadena);
                MessageBox.Show(Resultado);
            }

            if (rdbCopia.Checked)
            {
                MessageBox.Show("Copia escogido");
            }

            if (rdbSuma.Checked)
            {

                MessageBox.Show("Suma escogido");
                Suma Suma = new Suma();
                Resultado = Suma.Sumador(Cadena, DGVCadena);
                MessageBox.Show(Resultado);
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
