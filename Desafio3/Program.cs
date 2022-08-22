using System;
using System.Globalization;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double porHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * porHoras; 

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }   
    }
}
