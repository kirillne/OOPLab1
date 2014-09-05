using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Defines an geometric shape.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Initializes a new instance of the Shape class whith black color and (0;0) position.
        /// </summary>
        protected Shape()
        {
            Color = Color.Black;
            Position = new Point(0,0);
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified color and position.
        /// </summary>
        protected Shape(Color color, Point position)
        {
            Color = color;
            Position = position;
        }

        /// <summary>
        /// With of pen.
        /// </summary>
        protected  const float PEN_WIDTH = 5.0f;

        /// <summary>
        /// Gets or sets the color of this Shape.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the position of this Shape.
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        /// Draw this Shape on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public abstract void Draw(Graphics graphics);

   }
}
