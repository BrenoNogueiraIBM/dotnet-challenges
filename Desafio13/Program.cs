using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> list = new List<Point>();
            while (true)
            {
                Console.WriteLine("Digite coordenadas (x,y): ");
                string[] values = Console.ReadLine().Trim().Split(" ");
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);

                if (x == 0 || y == 0)
                    break;

                list.Add(new Point(x, y));
            }

            Console.WriteLine();
            QuadrantFinder qf = new QuadrantFinder();
            foreach (var item in list)
                Console.WriteLine(qf.FindQuadrant(item));
        }
    }
}
