using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pYList;
        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pYList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point pY = new Point(x, y, sym);
                pYList.Add(pY);
            }
        }
        public void Draw()
        {
            foreach (Point pY in pYList)
            {
                pY.Draw();
            }
        }
    }
}
