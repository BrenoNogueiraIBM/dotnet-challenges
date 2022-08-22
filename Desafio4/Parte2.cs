using System;
using System.Globalization;

namespace Desafio4
{
    class Parte2 
    {
        public static double IMC(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        public static void ImcClassificacao(double imc)
        {
            if(imc < 18.50)
                Console.WriteLine("Sua classificação é: Magreza");
            else if (imc >= 18.50 && imc <= 24.99)
                Console.WriteLine("Sua classificação é: Peso ideal");
            else if(imc > 24.99 && imc <= 29.9)
                Console.WriteLine("Sua classificação é: Sobrepeso");
            else
                Console.WriteLine("Sua classificação é: Obesidade");
        }

        public static double AreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }   

        public static double RegraDeTres(double a, double b, double c)
        {
            return (c * b) / a;
        }

        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("1 - Calculadora de IMC");
                Console.WriteLine("2 - Calculadora Area Circulo");
                Console.WriteLine("3 - Calculadora regra de 3");
                Console.WriteLine("4 - Sair");
                Console.Write("Sua escolha: ");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if(choice == 4)
                {
                    Console.WriteLine("FINALIZADO COM SUCESSO!");
                    break;
                }

                switch(choice)
                {
                    case 1:
                        Console.Write("Informe o peso: ");
                        double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Informe a altura: ");
                        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double imc = IMC(peso, altura);
                        
                        Console.WriteLine();
                        Console.WriteLine($"Seu IMC é de: {imc:F2}");

                        ImcClassificacao(imc);
                        
                        Console.WriteLine();
                        break;
                    
                    case 2:
                        Console.Write("Informe o raio do Círculo: ");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double area = AreaCirculo(raio);

                        Console.WriteLine($"\nA área do Círculo é de: {area:F2}\n"); 
                        break;

                    case 3:
                        Console.Write("Informe o A: ");
                        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Informe o B: ");
                        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Informe o C: ");
                        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        double d = RegraDeTres(a, b, c);

                        Console.WriteLine();
                        Console.WriteLine($"{a} -- {b}");
                        Console.WriteLine($"{c} -- D");
                        Console.WriteLine($"Com D = {d}");
                        Console.WriteLine();
                        break;

                    default: 
                        Console.WriteLine("Nenhuma opção com esse código, tente novamente.\n");
                        break;
                }

            }
        }
    }
}