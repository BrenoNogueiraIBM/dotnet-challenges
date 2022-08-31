using Desafio19.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio19
{
    class DateParser
    {
        public List<string> ParsedDates { get; set; }

        private IOutput _outputter;

        public DateParser(IOutput outputter)
        {
            ParsedDates = new List<string>();
            _outputter = outputter;
        }

        public void ParseDate(DateTime date)
        {
            string[] formats = new string[] { "MM/dd/yy", "yy/MM/dd", "dd-MM-yy" };

            for (int i = 0; i < formats.Length; i++)
                ParsedDates.Add(date.ToString(formats[i]));
        }

        public void Output()
        {
            _outputter.OutputResult(ParsedDates);
        }
    }
}
