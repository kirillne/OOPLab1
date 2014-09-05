using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ShapeList : List<Shape>
    {
        public void DrawAll(Graphics graphics)
        {
            foreach (var shape in this)
            {
                shape.Draw(graphics);
            }
        }
    }
}
