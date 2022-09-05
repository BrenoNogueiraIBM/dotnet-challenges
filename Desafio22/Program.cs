using System;

namespace Desafio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensão do tabuleiro: ");
            int n = int.Parse(Console.ReadLine());

            GameBoard gb = new GameBoard(n);
            Console.WriteLine(gb.PartDistribution());
        }
    }
}
