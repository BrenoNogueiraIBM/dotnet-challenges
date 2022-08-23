using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio13
{
    class QuadrantFinder
    {
        public QuadrantFinder()
        {
        }

        public string FindQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                return "primeiro";
            else if (x < 0 && y < 0)
                return "terceiro";
            else if (x < 0 && y > 0)
                return "segundo";
            else
                return "quarto";
        }

    }
}
