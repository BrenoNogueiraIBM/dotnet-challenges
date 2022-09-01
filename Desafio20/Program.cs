using System;
using System.Collections.Generic;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos movimentos serao feitos?: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Posicao inicial da moeda: ");
            char init = char.Parse(Console.ReadLine());

            Console.WriteLine($"Todos os movimentos: ");
            List<int> moves = new List<int>(n);
            for (int i = 0; i < n; i++)
                moves.Add(int.Parse(Console.ReadLine()));

            CupGame cg = new CupGame(moves, init);
            Console.WriteLine(cg.Play());
        }
    }
}
