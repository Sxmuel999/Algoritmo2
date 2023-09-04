using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4___Adivinhar_o_Número
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int numero_aleatorio = random.Next(1, 101);
            int tentativa_usuario = 0;

            while (tentativa_usuario != numero_aleatorio)
            {
                Console.Write("Digite a tentativa: ");
                tentativa_usuario = int.Parse(Console.ReadLine());
                if(tentativa_usuario > numero_aleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O numero digitado é MAIOR que o número sorteado! ");

                } else if (tentativa_usuario < numero_aleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O número digitado é MENOR que o número sorteado! ");

                } else
                {
                    Console.WriteLine("Parabéns Você GANHOU ! ! ! !");

                }
                Console.ReadKey();
            }
        }
    }
}
