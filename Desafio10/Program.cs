using System;
using System.Globalization;


namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tax = new TaxCalculator();

            while (true)
            {
                Console.Write("Caro cidadão Lisarbiano, digite seu salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(tax.GetTaxes(salary));
            }
        }
    }
}
