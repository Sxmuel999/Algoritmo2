using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício___Soma_dos_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha_soma_usuario;
            int contador_soma = 1;
            int soma_total = 0;

            Console.WriteLine("Escolha quantos números você quer somar: ");
            escolha_soma_usuario = int.Parse(Console.ReadLine());

            while(contador_soma <= escolha_soma_usuario)
            {
                Console.Write("Digite o " + contador_soma + "° numero: ");
                soma_total += int.Parse(Console.ReadLine());

                contador_soma++;
            }

            Console.WriteLine("A Soma Total dos Números é: " + soma_total);
            Console.ReadKey();

        }
    }
}
