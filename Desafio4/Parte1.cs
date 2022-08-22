using System;
using System.Globalization;

namespace Desafio4
{
    class Parte1
    {
        static string DDD (int ddd)
        {
            switch(ddd)
            {
                case 61:
                    return "Brasilia";
                    
                case 71:
                    return "Salvador";
                    
                case 11:
                    return "Sao Paulo";
                    
                case 21:
                    return "Rio de Janeiro";
                    
                case 32:
                    return "Juiz de Fora";
                    
                case 19:
                    return "Campinas";
                    
                case 27:
                    return "Vitoria";
                    
                case 31:
                    return "Belo Horizonte";
                    
                default: 
                    return "DDD nao Registrado!";
            }
        }

        public static void Program()
        {
            int ddd = int.Parse(Console.ReadLine());

            Console.WriteLine(DDD(ddd));            
        }   
    }
}