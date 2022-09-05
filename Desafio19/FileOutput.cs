using Desafio19.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Desafio19
{
    class FileOutput : IOutput 
    {
        public string FilePath { get; set; }
        public FileOutput(string filePath)
        {
            FilePath = filePath;
        }

        public void OutputResult(List<string> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                using StreamWriter writer = new StreamWriter(Path.Combine(FilePath, $"output{i}.txt"));
                writer.WriteLine(values[i]);
            }
        }
    }
}
