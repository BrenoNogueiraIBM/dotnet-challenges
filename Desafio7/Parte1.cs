using System;

namespace Desafio7
{
    public class Parte1
    {

        static int DataParaMinutos(int hora, int minutos)
        {
            return (hora * 60) + minutos;;
        }

        static int DiferencaDatas(int dataInicial, int dataFinal)
        {
            return dataFinal - dataInicial;
        }

        static int ExtrairHoras(int minutos)
        {
            return (int) Math.Floor((double) minutos/60);
        }

        static int ExtrairMinutos(int data, int horas)
        {
            return data - (horas * 60);
        }

        public static void Program()
        {
            string[] datas = Console.ReadLine().Split(" ");

            int horaInicial = int.Parse(datas[0]);
            int minutoInicial = int.Parse(datas[1]);
            int horaFinal = int.Parse(datas[2]);
            int minutoFinal = int.Parse(datas[3]);

            int dataInicial = DataParaMinutos(horaInicial, minutoInicial);
            int dataFinal = DataParaMinutos(horaFinal, minutoFinal);

            int diferenca = DiferencaDatas(dataInicial, dataFinal);

            if (diferenca <= 0)
            {
                diferenca = DiferencaDatas(dataInicial, dataFinal + (24 * 60)); // Adiciona 24h na data final, se o resultado der negativo ou zero
            }

            horaFinal = ExtrairHoras(diferenca);
            minutoFinal = ExtrairMinutos(diferenca, ExtrairHoras(diferenca));

            Console.WriteLine("O JOGO DUROU " + horaFinal + " HORA(S) E " + minutoFinal + " MINUTO(S)");
        }
    }
}