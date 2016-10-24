using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(79, 25);
            Console.SetBufferSize(80, 25);

            //рисуем рамку
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // рисуем точки
            Point p1 = new Point(1, 3, '*');
            Snake Snake = new Snake(p1, 4, Direction.UP);
            Snake.Draw();


            Console.ReadLine();
        
        }
       
    }
}
