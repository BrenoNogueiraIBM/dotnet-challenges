using System;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeConverter tc = new TimeConverter();

            while (true)
            {
                Console.WriteLine("Valor em segundos para conversao: ");
                long seconds = long.Parse(Console.ReadLine());

                string date = tc.ToTimeString(seconds);
                Console.WriteLine(date);
            }
        }
    }
}
