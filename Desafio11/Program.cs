using System;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto elementos haverao no array?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite abaixo o array, cada item separado por espaço: ");
            string[] values = Console.ReadLine().Trim().Split(" ");

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(values[i]);
            }

            ArrayOperations ao = new ArrayOperations(array);

            Console.WriteLine();
            Console.WriteLine("Menor valor: " + ao.MinValue());
            Console.WriteLine("Posicao: " + ao.MinValueIndex());

        }
    }
}
