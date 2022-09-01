using Desafio19.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio19
{
    class ConsoleOutput : IOutput
    {
        public void OutputResult(List<string> values)
        {
            foreach (var item in values)
                Console.WriteLine(item);
        }
    }
}
