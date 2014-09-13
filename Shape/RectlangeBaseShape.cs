using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Defines an shape? wich can drawing in rectlange.
    /// </summary>
    public abstract class RectlangeBaseShape : Shape
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
                // if(value < 0) throw  new ArgumentOutOfRangeException("value", "Shape can't have nagative height");
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
                // if (value < 0) throw new ArgumentOutOfRangeException("value", "Shape can't have nagative width");
                width = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Shape class whith black color, (0;0) position and zero size.
        /// </summary>
        protected RectlangeBaseShape():base()
        {
            height = 0;
            width = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified color and position and zero size.
        /// </summary>
        protected RectlangeBaseShape(Color color, Point position) : base(color, position)
        {
            height = 0;
            width = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color, position, size.
        /// </summary>
        protected RectlangeBaseShape(Color color, Point position, int height, int width)
            : base(color, position)
        {
            this.height = height;
            this.width = width;
        }

    }
}
