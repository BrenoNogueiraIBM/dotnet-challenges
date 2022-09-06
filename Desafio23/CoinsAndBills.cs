using System;
using System.Globalization;

namespace Desafio23
{
    class CoinsAndBills
    {
        public CoinsAndBills()
        {
        }

        public string HowMany(double value)
        {
            double [] bills = new double [] { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };
            double [] coins = new double [] { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

            string total = "NOTAS:\n";
            foreach (double bill in bills)
            {
                int howMany = (int) Math.Floor(value / bill);
                total += $"{howMany} nota(s) de R${bill.ToString("F2", CultureInfo.InvariantCulture)}\n";
                value -= howMany * bill;
            }

            total += "MOEDAS:\n";
            foreach (double coin in coins)
            {
                int howMany = (int)Math.Floor(value / coin);
                total += $"{howMany} moeda(s) de R${coin.ToString("F2", CultureInfo.InvariantCulture)}\n";
                value -= howMany * coin;
            }

            return total;
        }
    }
}