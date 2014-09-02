using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    /// <summary>
    /// Defines an geometric shape.
    /// </summary>
    public abstract class Shape
    {
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
