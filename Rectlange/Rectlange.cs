using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Shapes
{
    /// <summary>
    /// Defines an rectlange.
    /// </summary>
    public class Rectlange : RectlangeBaseShape
    {
         /// <summary>
        /// Initializes a new instance of the Rectlange class whith black color, (0;0) position and zero size.
        /// </summary>
        public Rectlange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectlange class with the specified color and position and zero size.
        /// </summary>
        public Rectlange(Color color, Point position) : base(color, position)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectlange class with the specified color, position, size.
        /// </summary>
        public Rectlange(Color color, Point position, int height, int width)
            : base(color, position, height, width)
        {
        }

        /// <summary>
        /// Draw this Rectlange on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color, PEN_WIDTH), Position.X, Position.Y, Width, Height);
        }
    }
}
