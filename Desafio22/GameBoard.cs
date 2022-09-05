namespace Desafio22
{
    internal class GameBoard
    {
        private int Parts;

        public GameBoard(int dimension)
        {
            this.Parts = dimension * dimension; // Linearizando o tabuleiro
        }

        public string PartDistribution()
        {
            int blacks = 0;
            int whites = 0;
            for (int i = 0; i < Parts; i++)
            {
                if (i % 2 == 0)
                    whites++; // Pares -> Brancas
                else
                    blacks++; // Impares -> Pretas
            }

            return $"{whites} casas brancas e {blacks} casas pretas.";
        }
    }
}