using System;

namespace Desafio14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            do
            {
                Console.Write("Digite o maior numero: ");
                int upperLimit = int.Parse(Console.ReadLine());

                Console.Write("Digite o menor numero: ");
                int lowerLimit = int.Parse(Console.ReadLine());

                ConsecutiveOddCalculator coc = new ConsecutiveOddCalculator();
                Console.WriteLine("Soma = " + coc.RangeSum(upperLimit, lowerLimit));
            } while (debug);
        }
    }
}
