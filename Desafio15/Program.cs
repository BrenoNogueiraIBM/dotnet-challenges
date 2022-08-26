using System;
using System.Collections.Generic;

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            do
            {
                Console.WriteLine("Altura do salto do Froggy: ");
                int jump = int.Parse(Console.ReadLine());

                Console.WriteLine("Numero de Canos: ");
                int nPipes = int.Parse(Console.ReadLine());

                Console.WriteLine("Altura dos Canos (separar por espaços): ");
                string[] values = Console.ReadLine().Trim().Split(" ");

                List<int> pipes = new List<int>();
                for (int i = 0; i < nPipes; i++)
                    pipes.Add(int.Parse(values[i]));

                FroggyGame fg = new FroggyGame(jump, pipes);
                Console.WriteLine();
                Console.WriteLine(fg.Play());
                Console.WriteLine();
            } while (debug);
        }
    }
}
