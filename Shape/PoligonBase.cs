using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Defines an Shape which contains from connected points.
    /// </summary>
    public abstract class PoligonBase: Shape
    {
       
        /// <summary>
        /// Get or set points for Poligon.
        /// </summary>
        protected List<Point> Points { get; set; } 
        
        /// <summary>
        /// Initializes a new instance of the Shape class whith black color, (0;0) position and zero points.
        /// </summary>
        protected PoligonBase():base()
        {
            Points = new List<Point>();
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified color and position and zero point.
        /// </summary>
        protected PoligonBase(Color color, Point position) : base(color, position)
        {
            Points = new List<Point>();
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified color, position, points.
        /// </summary>
        protected PoligonBase(Color color, Point position, IEnumerable<Point> points )
            : base(color, position)
        {
            Points = new List<Point>(points);
        }

        ///<summary>
        /// Draw this Shape on graphics.
        /// </summary>
        /// <param name="graphics">Surfase for drawing.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(new Pen(Color),
                Points.Select(x => new Point(Position.X + x.X, Position.Y + x.Y)).ToArray());
        }
    }
}
