using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Point
    {
        
        private Matrix matrix = new Matrix(1, 3);
        public double X
        {
            get
            {
                return matrix[0, 0];
            }
            set
            {
                matrix[0, 0] = value;
            }
        }
        public double Y
        {
            get
            {
                return matrix[0, 1];
            }
            set
            {
                matrix[0, 1] = value;
            }
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        private double convertCoords(double coord)
        {

            return 0;
        }
        public void Move(float x, float y)
        {

        }
    }
}
