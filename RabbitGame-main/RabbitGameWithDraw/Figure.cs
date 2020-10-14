using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Figure: Drawable
    {
        private Matrix matrix = null;
        public static Matrix offsets = new Matrix(1, 3);
        protected List<Point> points = new List<Point>();
        public Figure(List<Point> points)
        {
            this.Points = points;
        }
        public static void SetOffsets(double x, double y)
        {
            offsets[0, 0] = x;
            offsets[0, 1] = -y;
        }
        public List<Point> Points
        {
            set
            {
                matrix = new Matrix(value.Count, 3);
                for (int i = 0; i < value.Count; i++)
                {
                    matrix[i, 0] = value[i].X;
                    matrix[i, 1] = value[i].Y;
                    matrix[i, 2] = 1;
                }
            }
        }

        public void Draw(Graphics g, Pen pn, Transform tr)
        {
            Matrix drawMatrix = matrix.Clone();
            Matrix rotate = new Matrix(3, 3);
            rotate[0, 0] = Math.Cos(tr.angel);
            rotate[0, 1] = Math.Sin(tr.angel);
            rotate[0, 2] = 0;
            rotate[1, 0] = -Math.Sin(tr.angel);
            rotate[1, 1] = Math.Cos(tr.angel);
            rotate[1, 2] = 0;
            rotate[2, 0] = 0;
            rotate[2, 1] = 0;
            rotate[2, 2] = 1;

            Matrix move = new Matrix(3, 3);
            move[0, 0] = 1;
            move[0, 1] = 0;
            move[0, 2] = 0;
            move[1, 0] = 0;
            move[1, 1] = 1;
            move[1, 2] = 0;
            move[2, 0] = tr.x;
            move[2, 1] = tr.y;
            move[2, 2] = 1;
       


            drawMatrix *= tr.scale;
            drawMatrix = drawMatrix.AddRow(offsets);

            drawMatrix *= rotate;
            drawMatrix *= move;

            for (int i = 0; i < drawMatrix.M; i++)
            {
                drawMatrix[i, 1] *= -1;
            }
            for (int i = 1; i < drawMatrix.M; i++)
            {
                g.DrawLine(pn, (float)drawMatrix[i - 1, 0], (float)drawMatrix[i - 1, 1], (float)drawMatrix[i, 0], (float)drawMatrix[i, 1]);
            }
            g.DrawLine(pn, (float)drawMatrix[0, 0], (float)drawMatrix[0, 1], (float)drawMatrix[matrix.M - 1, 0], (float)drawMatrix[matrix.M - 1, 1]);

        }
    }
}
