using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Registradora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cadastro, Venda, Relatorio, Preço, Peso, Tamanho, Quantidade, ID, Menu;
            string loop = "S";

            Console.WriteLine("VocÊ Quer Entrar no Menu?(S/N) ");
            loop = Console.ReadLine();

            while (loop == "S")
            {

                Console.WriteLine("Menu de Seleção:");
                Console.WriteLine("1- Cadastro");
                Console.WriteLine("2- Venda");
                Console.WriteLine("3- Relatorio");
                Menu = int.Parse(Console.ReadLine());



                //Estrutura de escolha do menu

                if (Menu == 1)
                {
                    Console.WriteLine("Você escolheu CADASTRAR UM PRODUTO");
                }
                else if (Menu == 2)
                {
                    Console.WriteLine("Você escolheu VENDER UM PRODUTO");
                }
                else if (Menu == 3)
                {
                    Console.WriteLine("Você escolheu gerar UM RELATÓRIO DOS PRODUTOS");
                }
                else
                {
                    Console.WriteLine("Selecione uma opção válida");
                }

                Console.WriteLine("Deseja Continuar no Sistema? (S/N)");

                loop = Console.ReadLine();
            }

            













            Console.Write("Pressione Enter Para Finalizar...");
            Console.ReadKey();
        }
    }
}
