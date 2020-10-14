using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class ComplexFigure
    {
        List<Figure> figures = null;
        public ComplexFigure(List<Figure> figures) 
        {
            this.figures = figures;    
        }
        public void Draw(Graphics g, Pen pn, Transform tr)
        {
            foreach (Figure figure in figures)
            {
                figure.Draw(g, pn, tr);
            }
        }
     
    }
}
