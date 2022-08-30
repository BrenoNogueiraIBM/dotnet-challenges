using System.Collections.Generic;

namespace Desafio17
{
    class HandBattlefield
    {
        private Dictionary<string, int> _power;
        public HandBattlefield()
        {
            _power = new Dictionary<string, int>
            {
                { "papel", 1 },
                { "pedra", 100 },
                { "ataque", int.MaxValue } // 2147483647 (Maior numero que um int aguenta armazenar)
            };
        }

        private string DecideTie(string move)
        {
            switch (move)
            {
                case "ataque":
                    return "Aniquilacao Mutua";

                case "pedra":
                    return "Sem Ganhador";

                case "papel":
                    return "Ambos Venceram";

                default:
                    return "Nada Aconteceu. Nao existe essas opcoes, engracadinho.";
            }
        }

        public string Battle(string j1, string j2)
        {
            if (j1 == j2)
                return DecideTie(j1);

            if(_power.ContainsKey(j1) && _power.ContainsKey(j2))
            {
                return _power[j1] > _power[j2] ? "Jogador 1 Venceu!" : "Jogador 2 Venceu!";
            }

            return "Entrada Invalida!";
        }
    }
}