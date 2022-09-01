using Desafio19.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio19
{
    class DateParser
    {
        private List<string> _parsedDates { get; set; }

        private readonly IOutput _outputter;

        public DateParser(IOutput outputter)
        {
            _parsedDates = new List<string>();
            _outputter = outputter;
        }

        public void ParseDate(DateTime date)
        {
            string[] formats = new string[] { "MM/dd/yy", "yy/MM/dd", "dd-MM-yy" };

            for (int i = 0; i < formats.Length; i++)
                _parsedDates.Add(date.ToString(formats[i]));
        }

        public void Output()
        {
            _outputter.OutputResult(_parsedDates);
        }
    }
}
