namespace Desafio13
{
    class QuadrantFinder
    {
        public QuadrantFinder()
        {
        }

        public string FindQuadrant(Point p)
        {
            if (p.X > 0 && p.Y > 0)
                return "primeiro";
            else if (p.X < 0 && p.Y < 0)
                return "terceiro";
            else if (p.X < 0 && p.Y > 0)
                return "segundo";
            else
                return "quarto";
        }

    }
}
