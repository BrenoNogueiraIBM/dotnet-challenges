using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio15
{
    class FroggyGame
    {
        public int Jump { get; set; }
        public List<int> Pipes { get; set; }

        public FroggyGame(int jump, List<int> pipes)
        {
            Jump = jump;
            Pipes = pipes;
        }

        public string Play()
        {
            int currentHeight = Pipes.First();
            foreach (var pipeHeight in Pipes)
            {
                if (!ValidateJump(currentHeight, pipeHeight))
                    return "Game Over!";

                currentHeight = pipeHeight;
            }

            return "You Win!";
        }

        private bool ValidateJump(int current, int pipe)
        {
            int delta = Math.Abs(pipe - current);
            return delta >= 0 && delta <= Jump;
        }
    }
}