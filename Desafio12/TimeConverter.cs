using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio12
{
    class TimeConverter
    {
        public TimeConverter()
        { 
        }

        public int SecondsToHours(long seconds)
        {
            return (int) seconds / 3600;
        }
        public int SecondsToMinutes(long seconds)
        {
            return (int) (seconds / 60) % 60;
        }
        public int SecondsToClearSeconds(long seconds)
        {
            return (int)seconds % 60;
        }

        public string ToTimeString(long timeSeconds)
        {
            int hours = SecondsToHours(timeSeconds);
            int minutes = SecondsToMinutes(timeSeconds);
            int seconds = SecondsToClearSeconds(timeSeconds);

            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
