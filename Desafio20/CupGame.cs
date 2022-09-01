using System;
using System.Collections.Generic;

namespace Desafio20
{
    internal class CupGame
    {   
        private List<int> Moves;
        private char CurrentCup;    

        public CupGame(List<int> moves, char currentCup)
        {
            Moves = moves;
            CurrentCup = char.ToLower(currentCup);
        }

        public char Play()
        {
            foreach (var move in Moves)
                TrackCup(move);

            return char.ToUpper(CurrentCup);
        }

        private void TrackCup(int move)
        {
            switch (move)
            {
                case 1:
                    GoodOlSwitcheroo('a', 'b');
                    break;

                case 2:
                    GoodOlSwitcheroo('b', 'c');
                    break;

                case 3:
                    GoodOlSwitcheroo('a', 'c');
                    break;

                default:
                    Console.WriteLine($"Movimento '{move}' nao existe, pulando instrução.");
                    break;
            }
        }

        private void GoodOlSwitcheroo(char start, char dest)
        {
            if (CurrentCup == start)
                CurrentCup = dest;
            else if (CurrentCup == dest)
                CurrentCup = start;
        }
    }
}