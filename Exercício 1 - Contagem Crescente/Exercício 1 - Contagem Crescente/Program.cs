using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1___Contagem_Crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Contagem Crescente");
            int menu = int.Parse(Console.ReadLine());

            if (menu ==1)
            {
                int contador = 1;

                Console.Write("Digite um número: ");
                int escolha_usuario = int.Parse(Console.ReadLine());


                while(contador <= 10)
                {
                    Console.WriteLine(contador);
                    contador = contador + 1;
                }
            }

            Console.ReadKey();
        }
    }
}
