using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Desafio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mande suas mensagens!");
            List<string> list = new List<string>();
            while (true)
            {
                string value = Console.ReadLine().Trim();

                if (value == "0")
                    break;

                list.Add(value);
            }

            CharacterCounter cc = new CharacterCounter();
            Console.WriteLine("\n-----------------------------------------------\n");
            foreach (var item in cc.CountCharacters(list))
                Console.WriteLine(item);
            
            Console.WriteLine("Maior palavra: " + cc.BiggestWord);
        }
    }
}
