using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Shapes
{
    /// <summary>
    /// Defines an line.
    /// </summary>
    public class Line: Shape
    {
        private int height;

        /// <summary>
        /// Gets or sets the vertical difference between start and end points.
        /// </summary>
        public int Height
        {
            get { return height; }
            set
            {
                if(height < 0) throw  new ArgumentOutOfRangeException("value", "Line can't have nagative height");
                height = value;
            }
        }

        private int width;

        /// <summary>
        /// Gets or sets the horisontal difference between start and end points.
        /// </summary>
        public int Width
        {
            get { return width; }
            set
            {
                if (width < 0) throw new ArgumentOutOfRangeException("value", "Line can't have nagative width");
                width = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Line class whith black color, (0;0) position and zero size.
        /// </summary>
        public Line():base()
        {
            height = 0;
            width = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color and position and zero size.
        /// </summary>
        public Line(Color color, Point position) : base(color, position)
        {
            height = 0;
            width = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color, position, size.
        /// </summary>
        public Line(Color color, Point position, int height, int width)
            : base(color, position)
        {
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Draw this Line on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color),Position, Position + new Size(width, height) );
        }
    }
}
