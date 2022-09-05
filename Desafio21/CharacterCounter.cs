using System;
using System.Collections.Generic;

namespace Desafio21
{
    class CharacterCounter
    {
        public string BiggestWord { get; set; }
        public CharacterCounter()
        {
            BiggestWord = "-";
        }

        private string SplitCheck(string target)
        {
            string[] values = target.Split(" ");
            string lenghts = "";
            foreach (string go in values)
            {
                if (go.Length >= BiggestWord.Length)
                    BiggestWord = go;

                lenghts += go.Length + "-";
            }

            return lenghts.Remove(lenghts.LastIndexOf("-"), 1);
        }

        public IEnumerable<string> CountCharacters(List<string> list)
        {
            List<string> lenghts = new List<string>();
            foreach (var item in list)
            {
                lenghts.Add(SplitCheck(item));
            }

            return lenghts;
        }
    }
}