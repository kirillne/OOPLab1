﻿using System;
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
    public class Line: RectlangeBaseShape
    {

        /// <summary>
        /// Initializes a new instance of the Line class whith black color, (0;0) position and zero size.
        /// </summary>
        public Line() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color and position and zero size.
        /// </summary>
        public Line(Color color, Point position) : base(color, position)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color, position, size.
        /// </summary>
        public Line(Color color, Point position, int height, int width)
            : base(color, position, height, width)
        {
        }

        /// <summary>
        /// Draw this Line on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color, penWidth), Position, Position + new Size(Width, Height));
        }
    }
}
