using System;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira Dica: ");
            string hint1 = Console.ReadLine();

            Console.Write("Digite a segunda Dica: ");
            string hint2 = Console.ReadLine();

            Console.Write("Digite a terceira Dica: ");
            string hint3 = Console.ReadLine();

            AnimalGuesser ag = new AnimalGuesser(hint1, hint2, hint3);
            Console.WriteLine(ag.Guess());
            Console.WriteLine();
        }
    }
}
