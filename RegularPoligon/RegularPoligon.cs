using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Shapes
{

    /// <summary>
    /// Defines a regular poligon.
    /// </summary>
    public class RegularPoligon : PoligonBase
    {
        /// <summary>
        /// Gets the radius of circumscribed circle.
        /// </summary>
        public int CircumscribedСircleRadius { get; private set; }

        /// <summary>
        /// Gets the count of poligon's side.
        /// </summary>
        public int SidesCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Poligon class whith black color, (0;0) position and zero side size.
        /// </summary>
        protected RegularPoligon() : base()
        {
            CircumscribedСircleRadius = 0;
            Points = GetTriangePointsBySideSize();
        }

        /// <summary>
        /// Initializes a new instance of the Poligon class with the specified color and position and zero side size.
        /// </summary>
        protected RegularPoligon(Color color, Point position) : base(color, position)
        {
            CircumscribedСircleRadius = 0;
            Points = GetRegularPoligonPoints();
        }

        private List<Point> GetRegularPoligonPoints()
        {
            double angleStep = 2*Math.PI/SidesCount;
            var result = new List<Point>();

            for (int i = 0; i < SidesCount; i++)
            {
                var coordinatesByCircleCenter = new Point((int) (CircumscribedСircleRadius*Math.Cos(i*angleStep)),
                    (int) (CircumscribedСircleRadius*Math.Sin(i*angleStep)));
                result.Add(new Point(CircumscribedСircleRadius + coordinatesByCircleCenter.X,
                    CircumscribedСircleRadius + coordinatesByCircleCenter.Y));
            }
        }

        /// <summary>
        /// Initializes a new instance of the Poligon class with the specified color, position, side size.
        /// </summary>
        protected RegularPoligon(Color color, Point position, int circumscribedСircleRadius, int sidesCount)
            : base(color, position)
        {
            this.CircumscribedСircleRadius = circumscribedСircleRadius;
            SidesCount = sidesCount;
            Points = Points = GetRegularPoligonPoints();
        }

    }
}
