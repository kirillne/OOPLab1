using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Shapes
{
    /// <summary>
    /// Defines an ellipse.
    /// </summary>
    public class Ellipse : RectlangeBaseShape
    {
        /// <summary>
        /// Initializes a new instance of the Ellipse class whith black color, (0;0) position and zero size.
        /// </summary>
        public Ellipse() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ellipse class with the specified color and position and zero size.
        /// </summary>
        [MainShapeConstracter]
        public Ellipse(Color color, Point position) : base(color, position)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ellipse class with the specified color, position, size.
        /// </summary>
        public Ellipse(Color color, Point position, int height, int width)
            : base(color, position, height, width)
        {
        }

        /// <summary>
        /// Draw this Ellipse on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color, penWidth), Position.X, Position.Y, Width, Height);
        }
    }
}
