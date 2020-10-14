using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RabbitGameWithDraw
{
    interface Drawable
    {
        void Draw(Graphics g, Pen pn, Transform tr);
    }
}
