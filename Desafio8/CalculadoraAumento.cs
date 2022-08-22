using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio8
{
    class CalculadoraAumento
    {
        public double Salario { get; set; }

        public CalculadoraAumento(double salario)
        {
            Salario = salario;
        }

        public double SalarioAumentado
        {
            get { return Salario + (Salario * PorcentagemAumento()); }
        }

        private double PorcentagemAumento()
        {
            if (Salario < 0)
                return 0;

            if (Salario > 0 && Salario <= 400.0)
                return 0.15;
            else if (Salario >= 400.01 && Salario <= 800.0)
                return 0.12;
            else if (Salario >= 800.01 && Salario <= 1200.0)
                return 0.10;
            else if (Salario >= 1200.01 && Salario <= 2000.0)
                return 0.07;
            else
                return 0.04;
        }

        public double PercentualAumento()
        {
            return PorcentagemAumento() * 100;
        }

        public double Reajuste()
        {
            return SalarioAumentado - Salario;
        }
    }
}
