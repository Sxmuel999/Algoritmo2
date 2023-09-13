using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
       /*  string aluno6 = "Renon";
            string aluno7 = "Pedro";
            string aluno8 = "Monique";
            string aluno9 = "Erick";
            string aluno10 = "Richard";
            string aluno11 = "Edilson";
            string aluno12 = "Lehner";
       */
            string prof1 = "Paulo";
            string prof2 = "Vagner";
            string prof3 = "Ricardo";

            string[] alunos = { "Samuel", "Gustavo", "Lucas", "Rafaela", "Reryel", "Renon", "Pedro", "Monique", "Erick", "Richard", "Edilson","Lehner" };
            string[] profs = { "Paulo", "Vagner", "Ricardo" };
                           
            
            //Console.WriteLine(aluno1);
            //Console.WriteLine(aluno2);
            //Console.WriteLine(aluno3);
            //Console.WriteLine(aluno4);
            //Console.WriteLine(aluno5);
            //Console.WriteLine(aluno6);
            //Console.WriteLine(aluno7);
            //Console.WriteLine(aluno8);
            //Console.WriteLine(aluno9);
            //Console.WriteLine(aluno10);
            //Console.WriteLine(aluno11);

            //    Console.WriteLine(prof1);
            //    Console.WriteLine(prof2);
            //    Console.WriteLine(prof3);

            //   Console.WriteLine(alunos[0]);
            //   Console.WriteLine(alunos[1]);
            //   Console.WriteLine(alunos[2]);
            //   Console.WriteLine(alunos[3]);
            //   Console.WriteLine(alunos[4]);
            //   Console.WriteLine(alunos[5]);
            //   Console.WriteLine(alunos[6]);
            //   Console.WriteLine(alunos[7]);
            //   Console.WriteLine(alunos[8]);
            //   Console.WriteLine(alunos[9]);
            //   Console.WriteLine(alunos[10]);
            //   Console.WriteLine(profs[0]);
            //   Console.WriteLine(profs[1]);
            //   Console.WriteLine(profs[]);]

            int[] idades = {17,17,18,18,19,19,23,25,27,29 }; // MÉDIA = 43,8%

            Console.WriteLine(alunos.Length);

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(alunos[i]);
            }

            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(profs[i]);
            }

            // Erick

            float media = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                media += (float)idades[i];
            }

            media = media / idades.Length;
            Console.WriteLine(media);

            // Pedrin

            float sum = 0;
            Array.ForEach(idades, contador => sum += contador);

            
            sum = sum / idades.Length;
            Console.WriteLine(sum);
























            Console.ReadKey();
        }
    }
}
