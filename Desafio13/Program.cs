using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listX = new List<int>();
            List<int> listY = new List<int>();
            while (true)
            {

                Console.WriteLine("Digite coordenadas (x,y): ");
                string[] values = Console.ReadLine().Trim().Split(" ");
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);

                if (x == 0 || y == 0)
                    break;

                listX.Add(x);
                listY.Add(y);
            }
            Console.WriteLine();
            QuadrantFinder qf = new QuadrantFinder();
            foreach (var item in listX.Zip(listY, Tuple.Create))
            {
                Console.WriteLine(qf.FindQuadrant(item.Item1, item.Item2));
            }

        }
    }
}
