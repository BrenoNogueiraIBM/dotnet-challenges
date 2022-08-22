using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio10
{
    class TaxCalculator
    {
        public TaxCalculator()
        {
        }

        private double CalculateTax(double salary)
        {
            if (salary < 0)
                return 0;

            double[] lowerLimits = new double[] { 0, 2000.01, 3000.01, 4500.01 };
            double[] upperLimits = new double[] { 2000.00, 3000.00, 4500.00, 4500.01 };
            double[] taxes =  new double[] { 0, 0.08, 0.18, 0.28 };
            double lastLimit = 4500.01;

            double tax = 0;
            for (int i = 0; i < upperLimits.Length; i++)
            {
                if (salary - lowerLimits[i] < 0 && salary - upperLimits[i] < 0)
                    break;

                if (upperLimits[i] == lastLimit)
                {
                    tax += (salary - lastLimit) * taxes[i];
                    break;
                }

                if (salary - upperLimits[i] < 0)
                    tax += (salary - lowerLimits[i]) * taxes[i];
                else
                    tax += (upperLimits[i] - lowerLimits[i]) * taxes[i];
            }

            return tax;
        }

        public string GetTaxes(double salary)
        {
            double imposto = CalculateTax(salary);
            return imposto > 0 ? "R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture) : "Isento";
        }
    }
}
