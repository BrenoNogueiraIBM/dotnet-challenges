using System;
using System.Globalization;

namespace Desafio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CoinsAndBills cab = new CoinsAndBills();
            Console.WriteLine(cab.HowMany(value ));
        }
    }
}
