using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Shapes
{

    /// <summary>
    /// Defines a trapizoid.
    /// </summary>
    public class Trapizoid : PoligonBase
    {
        /// <summary>
        /// Gets the hight of trapizoid.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Gets the angle of trapizoi in radians.
        /// </summary>
        public double Angle { get; private set; }

        /// <summary>
        /// Gets the lagest width of trapizoids.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Trapizoid class whith black color, (0;0) position and zero size.
        /// </summary>
        protected Trapizoid():base()
        {
            Height = 0;
            Width = 0;
            Angle = Math.PI/4;
        }

        /// <summary>
        /// Initializes a new instance of the Trapizoid class with the specified color and position and zero size.
        /// </summary>
        protected Trapizoid(Color color, Point position) : base(color, position)
        {
           

            Height = 0;
            Width = 0;
            Angle = Angle = Math.PI / 4;
        }

        private List<Point> GetTrapizoidPoints()
        {
            int sideDifferent = Height/(int)Math.Tan(Angle);
            return new List<Point>
            {
                new Point(sideDifferent, 0),
                new Point(Width - sideDifferent,0),
                new Point(Width, Height),
                new Point(0, Height)
            };
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified color, position, size.
        /// </summary>
        /// <param name="angle">Angle in radians</param>
        protected Trapizoid(Color color, Point position, int height, int width, double angle)
            : base(color, position)
        {
            if (angle <= 0 || angle > Math.PI/4)
                throw new ArgumentException("Trapezoid cann't have angle less then 0 or more then pi/4 ");

            Height = height;
            Width = width;
            Angle = angle;
        }

    }
}
