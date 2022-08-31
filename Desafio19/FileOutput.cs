using Desafio19.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Desafio19
{
    class FileOutput : IOutput
    {
        public string FilePath { get; set; }
        public FileOutput(string filePath)
        {
            FilePath = filePath + @"output.txt";
        }

        public void OutputResult(List<string> values)
        {
            using StreamWriter writer = new StreamWriter(FilePath);
            foreach (var item in values)
                writer.WriteLine(item);
        }
    }
}
