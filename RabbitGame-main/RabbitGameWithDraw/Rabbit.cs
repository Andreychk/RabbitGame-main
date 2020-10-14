using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Rabbit : ComplexFigure
    {
        public Rabbit(List<Figure> figures): base(figures)
        {

        }
        public static Rabbit CreateRabbit()
        {
            List<Point> bodyPoints = new List<Point>
            {
                new Point(-30, 120),
                new Point(-10, 120),
                new Point(-10, 80),
                new Point(10, 80),
                new Point(10, 120),
                new Point(30, 120),
                new Point(30, 30),
                new Point(30, 10),
                new Point(25, 0),
                new Point(20, 10),
                new Point(15, 0),
                new Point(10, 10),
                new Point(5, 0),
                new Point(0, 10),
                new Point(-5, 0),
                new Point(-10, 10),
                new Point(-15, 0),
                new Point(-20, 10),
                new Point(-25, 0),
                new Point(-30, 10),
            };
            List<Figure> figures = new List<Figure> 
            {
                new Figure(bodyPoints),
                Rectangle.CreateRectangle(new Point(-20,70), new Point(-10,60)),
                Rectangle.CreateRectangle(new Point(10,70), new Point(20,60)),
                Rectangle.CreateRectangle(new Point(-10, 50), new Point(10,40))

            };
            return new Rabbit(figures);
        }
    }
}
