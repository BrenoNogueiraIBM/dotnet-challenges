using System;

namespace Desafio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dia 1: ");
            int dia1 = int.Parse(Console.ReadLine().Trim());

            Console.Write("Hora 1: ");
            int [] data1 = ToIntArray(Console.ReadLine().Split(":"));

            Console.Write("Dia 2: ");
            int dia2 = int.Parse(Console.ReadLine().Trim());

            Console.Write("Data 2: ");
            int [] data2 = ToIntArray(Console.ReadLine().Split(":"));

            DateTime d1 = new DateTime(2032, 12, dia1, data1[0], data1[1], data1[2]);
            DateTime d2 = new DateTime(2032, 12, dia2, data2[0], data2[1], data2[2]);

            TimeSpan ts = d2 - d1;

            Console.WriteLine();
            Console.WriteLine(ts.Days + " dias(s)");
            Console.WriteLine(ts.Hours + " hora(s)");
            Console.WriteLine(ts.Minutes + " minuto(s)");
            Console.WriteLine(ts.Seconds + " segundo(s)");
        }

        public static int [] ToIntArray(string[] values)
        {
            int [] integers = new int [values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                integers[i] = int.Parse(values[i]);
            }
            return integers;
        }
    }
}
