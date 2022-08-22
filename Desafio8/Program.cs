using System;
using System.Globalization;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalculadoraAumento calc = new CalculadoraAumento(salario);

            Console.WriteLine("Novo salario: " + calc.SalarioAumentado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calc.Reajuste().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + calc.PercentualAumento().ToString("F0") + " %");    
        }
    }
}
