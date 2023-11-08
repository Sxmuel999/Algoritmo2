﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void escolhaOperador (int numero, string operadorEscolhido)
        {
            lbTemp.Text = numero.ToString();
            lbOperador.Text = operadorEscolhido;
            txbNumero1.Text = "";
        }

        public int calculos(int num1, int num2, string operador)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            }else if (operador == "-")
            {
                resultado = num1 - num2;
            }else if (operador == "*")
            {
                resultado = num1 * num2;
            }else if (operador == "/")
            {
                resultado = num1 / num2;
            }

            return resultado;
        }
        private void txbNumero1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnMais_Click(object sender, EventArgs e)
        {

            if (txbNumero1.Text != "" && txbNumero1.Text != "Error!")
            {


                    int numero1 = int.Parse(txbNumero1.Text);
                    int numero2 = 0;

                    Button botao = (Button)sender;
                    string operadorSelecionado = botao.Text;


                    int total;

                    // total = resultadoSoma(numero1, numero2);

                    // total = calculos(numero1, numero2, operadorSelecionado);
                    // lbResultado.Text = total.ToString();

                    escolhaOperador(numero1, operadorSelecionado);

            }else
            {
                txbNumero1.Text = "Error!";
            }
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            // total = resultadoVezes(numero1, numero2);

            total = calculos(numero1, numero2, "*");

            lbResultado.Text = total.ToString();
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            // total = resultadoMenos(numero1, numero2);

            total = calculos(numero1, numero2, "-");

            lbResultado.Text = total.ToString();
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            //  total = resultadoDivisao(numero1, numero2);

            total = calculos(numero1, numero2, "/");

            lbResultado.Text = total.ToString();
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button valorBotao = (Button)sender;
            //MessageBox.Show(valorBotao.Text);

            // txbNumero1.Text = txbNumero1.Text + valorBotao.Text;

            txbNumero1.Text += valorBotao.Text;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            txbNumero1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void lbOperador_Click(object sender, EventArgs e)
        {

        }
    }
}
