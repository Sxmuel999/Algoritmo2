using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares_no_intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 1 , valor2 = 2;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());

            for (int cont = valor1; cont <valor2; cont++)
            {
                Console.WriteLine("for " + cont);
            }












































            Console.ReadKey();
        }
    }
}
