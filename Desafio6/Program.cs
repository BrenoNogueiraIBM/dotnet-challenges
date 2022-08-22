using System;
using System.Globalization;

namespace Desafio6
{
    class Program
    {
        static double ValorCodigo(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    return 4.0;

                case 2:
                    return 4.5;

                case 3:
                    return 5.0;

                case 4:
                    return 2.0;

                case 5:
                    return 1.5;

                default:
                    return 0.0;
            }
        }

        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());

            int qte = int.Parse(Console.ReadLine());

            double valor = ValorCodigo(codigo);

            double valorTotal = valor * qte;

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
