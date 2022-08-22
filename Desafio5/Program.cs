using System;

namespace Desafio5
{
    class Program
    {

        public static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + Multiplicacao(i, n));
            }
        }
    }
}
