using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexões
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;


            int total = int.Parse(numero1) + int.Parse(numero2);

            lbResultado.Text = total.ToString(); 
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {
            lbResultado.Text = txbNumero1.Text + txbNumero2.Text;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;


            int total = int.Parse(numero1) - int.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;


            int total = int.Parse(numero1) * int.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;


            float total = float.Parse(numero1) / float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbNumero3.Text);

            if (numero3 < 0)
            {
                lbResultado.Text = "O número digitado é MENOR que 0";
            } else
            {
                lbResultado.Text = "O número digitado é MAIOR que 0";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ParImPar = int.Parse(txbNumero3.Text);

            if (ParImPar %2 == 0)
            {
                lbResultado.Text = "O número digitado é PAR";
            } else
            {
                lbResultado.Text = "o número digitado é ÍMPAR";
            }
        }
    }
}
