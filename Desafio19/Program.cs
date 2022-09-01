using Desafio19.Interfaces;
using System;
using System.Globalization;
using System.IO;

namespace Desafio19
{
    // Desafio extra: 
    // Fazer uma interface que retorne o resultado tanto em um arquivo quanto imprimir na tela.
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite a Data: ");
            //DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yy", CultureInfo.InvariantCulture);

            string input = File.ReadAllText(@"C:\input.txt");
            DateTime date = DateTime.ParseExact(input.Trim(), "dd/MM/yy", CultureInfo.InvariantCulture);


            IOutput outProvider;
            Console.Write("Mostrar resultado como (arquivo/console): ");
            if(Console.ReadLine().Trim().ToLower() == "arquivo")
                outProvider = new FileOutput(@"C:\");
            else
                outProvider = new ConsoleOutput();
            
            DateParser dp = new DateParser(outProvider);
            dp.ParseDate(date);
            dp.Output();
        }
    }
}
