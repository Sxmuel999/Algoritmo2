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
   int menu;
            string loop = "S";
            string nomeProduto1 = "", nomeProduto2 = "", nomeProduto3 = "";
            float valor1 = 0, valor2 = 0, valor3 = 0;
            int quantidade1 = 0, quantidade2 = 0, quantidade3 = 0;
            while (loop.ToUpper() == "S")
            {
                Console.WriteLine(" __         ______      _____   ______         _______    ______          ______   ________  __    __           _____   ______    ______  \r\n/  |       /      \\    /     | /      \\       /       \\  /      \\        /      \\ /        |/  |  /  |         /     | /      \\  /      \\ \r\n$$ |      /$$$$$$  |   $$$$$ |/$$$$$$  |      $$$$$$$  |/$$$$$$  |      /$$$$$$  |$$$$$$$$/ $$ |  $$ |         $$$$$ |/$$$$$$  |/$$$$$$  |\r\n$$ |      $$ |  $$ |      $$ |$$ |__$$ |      $$ |  $$ |$$ |  $$ |      $$ \\__$$/ $$ |__    $$ |  $$ |            $$ |$$ |__$$ |$$ |  $$ |\r\n$$ |      $$ |  $$ | __   $$ |$$    $$ |      $$ |  $$ |$$ |  $$ |      $$      \\ $$    |   $$ |  $$ |       __   $$ |$$    $$ |$$ |  $$ |\r\n$$ |      $$ |  $$ |/  |  $$ |$$$$$$$$ |      $$ |  $$ |$$ |  $$ |       $$$$$$  |$$$$$/    $$ |  $$ |      /  |  $$ |$$$$$$$$ |$$ |  $$ |\r\n$$ |_____ $$ \\__$$ |$$ \\__$$ |$$ |  $$ |      $$ |__$$ |$$ \\__$$ |      /  \\__$$ |$$ |_____ $$ \\__$$ |      $$ \\__$$ |$$ |  $$ |$$ \\__$$ |\r\n$$       |$$    $$/ $$    $$/ $$ |  $$ |      $$    $$/ $$    $$/       $$    $$/ $$       |$$    $$/       $$    $$/ $$ |  $$ |$$    $$/ \r\n$$$$$$$$/  $$$$$$/   $$$$$$/  $$/   $$/       $$$$$$$/   $$$$$$/         $$$$$$/  $$$$$$$$/  $$$$$$/         $$$$$$/  $$/   $$/  $$$$$$/  \r\n                                                                                                                                          \r\n                                                                                                                                          \r\n                                                                                                                                          ");
                Console.WriteLine("1 - CADASTRAR novos produtos");
                Console.WriteLine("2 - Realizar VENDA de produtos");
                Console.WriteLine("3 - Gerar RELATORIO de produtos");
                Console.WriteLine("4 - Nossa area de testes ! ! !");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("  ______    ______   _______    ______    ______   ________  _______    ______  \r\n /      \\  /      \\ /       \\  /      \\  /      \\ /        |/       \\  /      \\ \r\n/$$$$$$  |/$$$$$$  |$$$$$$$  |/$$$$$$  |/$$$$$$  |$$$$$$$$/ $$$$$$$  |/$$$$$$  |\r\n$$ |  $$/ $$ |__$$ |$$ |  $$ |$$ |__$$ |$$ \\__$$/    $$ |   $$ |__$$ |$$ |  $$ |\r\n$$ |      $$    $$ |$$ |  $$ |$$    $$ |$$      \\    $$ |   $$    $$< $$ |  $$ |\r\n$$ |   __ $$$$$$$$ |$$ |  $$ |$$$$$$$$ | $$$$$$  |   $$ |   $$$$$$$  |$$ |  $$ |\r\n$$ \\__/  |$$ |  $$ |$$ |__$$ |$$ |  $$ |/  \\__$$ |   $$ |   $$ |  $$ |$$ \\__$$ |\r\n$$    $$/ $$ |  $$ |$$    $$/ $$ |  $$ |$$    $$/    $$ |   $$ |  $$ |$$    $$/ \r\n $$$$$$/  $$/   $$/ $$$$$$$/  $$/   $$/  $$$$$$/     $$/    $$/   $$/  $$$$$$/  \r\n                                                                                \r\n                                                                                \r\n                                                                                ");
                    Console.Write("Nome do 1° Produto: ");
                    nomeProduto1 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do " + nomeProduto1 + ":");
                    quantidade1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto1 + ": ");
                    valor1 = float.Parse(Console.ReadLine());
 
                    Console.Write("Nome do 2° Produto: ");
                    nomeProduto2 = Console.ReadLine();
 
                    Console.Write("Digite a quantidade em estoque do" + nomeProduto2 + ": ");
                    quantidade2 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto2 + ": ");
                    valor2 = float.Parse(Console.ReadLine());

                    Console.Write("Nome do 3° Produto: ");
                    nomeProduto3 = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque do" + nomeProduto3 + ": ");
                    quantidade3 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor do " + nomeProduto3 + ": ");
                    valor3 = float.Parse(Console.ReadLine());

                }
                else if (menu == 2)
                {

                    Console.Clear();
                    Console.WriteLine(" __     __  ________  __    __  _______    ______  \r\n/  |   /  |/        |/  \\  /  |/       \\  /      \\ \r\n$$ |   $$ |$$$$$$$$/ $$  \\ $$ |$$$$$$$  |/$$$$$$  |\r\n$$ |   $$ |$$ |__    $$$  \\$$ |$$ |  $$ |$$ |__$$ |\r\n$$  \\ /$$/ $$    |   $$$$  $$ |$$ |  $$ |$$    $$ |\r\n $$  /$$/  $$$$$/    $$ $$ $$ |$$ |  $$ |$$$$$$$$ |\r\n  $$ $$/   $$ |_____ $$ |$$$$ |$$ |__$$ |$$ |  $$ |\r\n   $$$/    $$       |$$ | $$$ |$$    $$/ $$ |  $$ |\r\n    $/     $$$$$$$$/ $$/   $$/ $$$$$$$/  $$/   $$/ \r\n                                                   \r\n                                                   \r\n                                                   ");
                    Console.WriteLine("Qual Produto Você Deseja?");
                    Console.WriteLine("Produto 1: " + nomeProduto1);
                    Console.WriteLine("Produto 2: " + nomeProduto2);
                    Console.WriteLine("Produto 3: " + nomeProduto3);
                    Console.ReadLine();
                    if (nomeProduto1)
                    {
                        Console.WriteLine("Você escolheu comprar: " + nomeProduto1);
                    }








                    Console.WriteLine("Você escolheu vender um PRODUTO");
                }
                else if (menu == 3)
                {
                    Console.WriteLine(" _______   ________  __         ______   ________   ______   _______   ______   ______  \r\n/       \\ /        |/  |       /      \\ /        | /      \\ /       \\ /      | /      \\ \r\n$$$$$$$  |$$$$$$$$/ $$ |      /$$$$$$  |$$$$$$$$/ /$$$$$$  |$$$$$$$  |$$$$$$/ /$$$$$$  |\r\n$$ |__$$ |$$ |__    $$ |      $$ |__$$ |   $$ |   $$ |  $$ |$$ |__$$ |  $$ |  $$ |  $$ |\r\n$$    $$< $$    |   $$ |      $$    $$ |   $$ |   $$ |  $$ |$$    $$<   $$ |  $$ |  $$ |\r\n$$$$$$$  |$$$$$/    $$ |      $$$$$$$$ |   $$ |   $$ |  $$ |$$$$$$$  |  $$ |  $$ |  $$ |\r\n$$ |  $$ |$$ |_____ $$ |_____ $$ |  $$ |   $$ |   $$ \\__$$ |$$ |  $$ | _$$ |_ $$ \\__$$ |\r\n$$ |  $$ |$$       |$$       |$$ |  $$ |   $$ |   $$    $$/ $$ |  $$ |/ $$   |$$    $$/ \r\n$$/   $$/ $$$$$$$$/ $$$$$$$$/ $$/   $$/    $$/     $$$$$$/  $$/   $$/ $$$$$$/  $$$$$$/  \r\n                                                                                        \r\n                                                                                        \r\n                                                                                        ");
                    Console.WriteLine("Bem vindo ao relatorio !!!");
                    Console.WriteLine("Produto 1: " + nomeProduto1 + " - Estoque: " + quantidade1 + " - Valor: " + valor1);
                    Console.WriteLine("Produto 2: " + nomeProduto2 + " - Estoque: " + quantidade2 + " - Valor: " + valor2);
                    Console.WriteLine("Produto 3: " + nomeProduto3 + " - Estoque: " + quantidade3 + " - Valor: " + valor3);



                    Console.Write("Pressione Enter Para Finalizar...");
                    Console.ReadKey();
                }
                Console.WriteLine("Deseja Continuar? ");
                loop = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

