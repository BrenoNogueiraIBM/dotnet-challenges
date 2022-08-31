using System;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas músicas no show?: ");
            int n = int.Parse(Console.ReadLine());

            SoundBoard sb = new SoundBoard();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pressione a combinacao de dois numeros: ");
                string [] values= Console.ReadLine().Trim().Split(" ");

                int button1 = int.Parse(values[0]);
                int button2 = int.Parse(values[1]);

                Console.WriteLine("Tocando agora: " + sb.PlayMusic(button1, button2));
                Console.WriteLine();
            }
        }
    }
}       
