namespace Desafio16
{
    internal class BinoLatenessCalculator
    {
        public BinoLatenessCalculator()
        {
        }

        public int ToMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes;
        }

        public int BinoCommute(int minutes)
        {
            return minutes + 60;
        }

        public int BinoLateness(int hours, int minutes)
        {
            int meetTime = ToMinutes(8, 0);
            int lateness = BinoCommute(ToMinutes(hours, minutes)) - meetTime; 

            return lateness < 0 ? 0 : lateness;
        }
    }
}