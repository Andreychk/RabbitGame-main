using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Rectangle : Figure
    {
        public Rectangle(List<Point> points): base(points) {}

        public static Rectangle CreateRectangle(Point leftUp, Point rightDown)
        {
            List<Point> points = new List<Point>
            {
                leftUp,
                new Point(rightDown.X, leftUp.Y),
                rightDown,
                new Point(leftUp.X, rightDown.Y)
            };

            return new Rectangle(points); 
        }
    }
}
