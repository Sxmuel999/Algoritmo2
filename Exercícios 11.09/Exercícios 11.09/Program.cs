using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_11._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1: Números Pares no Intervalo\n Exercício 2: Sequência de Fibonacci\nExercício 3: Números Primos no Intervalo");
            int menu = int.Parse(Console.ReadLine());


            switch(menu)
            {
                case 1:
                    Console.WriteLine("Você escolheu \" Números Pares no Intervalo \"");
                    int numero1, numero2;

                    Console.Write("Escolha o primeiro número: ");
                    numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Escolha o segundo número: ");
                    numero2 = int.Parse(Console.ReadLine());

                    for (int contador = numero1 ; contador < numero2; contador++)
                    {
                        if (contador % 2 == 0)
                        {

                            Console.WriteLine("Número atual: " + contador);

                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Você escolheu \"Sequência de Fibonacci\"");

                    Console.WriteLine("Digite a posição escolhida: ");
                    int posicao = int.Parse(Console.ReadLine());

                    int anterior = 0;
                    int atual = 1;
                    int temporario = 0;

                    //A recebe o valor de B, B recebe de C e C recebe de A + B

                    //Console.Write("O valor de C: " + (a + b));
                    
                    for (int contador = 0; contador < posicao; contador++)
                    {
                        Console.WriteLine("Fibonacci posição " + (contador + 1) + ": " + (atual));

                        temporario = anterior;

                        anterior = atual;

                        atual = temporario + atual;
                    }
                        break;
                case 3:
                    Console.WriteLine("Você escolheu \"Números Primos no Intervalo\"");

                    Console.Write("Digite um número: ");
                    int valor = int.Parse(Console.ReadLine());

                    for (int contador =2; contador <= valor; contador++)
                    {
                        bool primo = true;
                        for (int j = 2; j < contador; j++)
                        {
                            if (contador % j == 0)
                            {
                                primo = false;
                            }
                        }
                        if (primo)
                        {
                            Console.WriteLine("O número: " + contador + " é PRIMO");
                        }
                        
                    }
            








                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida!!!");
                    break;

            }
            Console.WriteLine("Pressione <enter> para continuar...");
            Console.ReadKey();
        }
    }
}
