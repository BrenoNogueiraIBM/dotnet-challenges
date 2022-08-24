namespace Desafio14
{
    public class ConsecutiveOddCalculator
    {
        public ConsecutiveOddCalculator()
        {
        }

        public int RangeSum(int upperLimit, int lowerLimit)
        {
            int sum = 0;
            for (int i = lowerLimit + 1; i < upperLimit; i++)
                sum += i % 2 != 0 ? i : 0; 

            return sum;
        }
    }
}