using System;
using System.Globalization;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture) +"\n");
        }
    }
}
