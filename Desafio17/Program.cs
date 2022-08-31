using System;

namespace Desafio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer jogar quantas vezes?");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();
            HandBattlefield hb = new HandBattlefield();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escolha Jogador 1: ");
                string j1 = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("Escolha Jogador 2: ");
                string j2 = Console.ReadLine().Trim().ToLower();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(hb.Battle(j1, j2));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

        }
    }
}
