using System;
using System.Collections.Generic;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            do
            {
                List<string> times = new List<string>();
                while (true)
                {
                    Console.Write("Digite o horário que Bino acordou (0 para parar): ");
                    string value = Console.ReadLine().Trim();

                    if (value == "0")
                        break;

                    times.Add(value);
                }
                Console.WriteLine();

                BinoLatenessCalculator blc = new BinoLatenessCalculator();
                foreach (var item in times)
                {
                    int hours = int.Parse(item.Split(":")[0]);
                    int minutes = int.Parse(item.Split(":")[1]);
                    Console.WriteLine("Atraso Maximo = " + blc.BinoLateness(hours, minutes));
                }
            } while (debug);
        }
    }
}
