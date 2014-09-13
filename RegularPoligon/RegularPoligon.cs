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
        private int circumscribedСircleRadius;

        /// <summary>
        /// Gets the radius of circumscribed circle.
        /// </summary>
        public override int CircumscribedСircleRadius
        {
            get { return circumscribedСircleRadius; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "Shape can't have nagative height");
                circumscribedСircleRadius = value;
                Points = GetRegularPoligonPoints();
            }
        }
        /// <summary>
        /// Gets the count of poligon's side.
        /// </summary>
        public int SidesCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Poligon class whith black color, (0;0) position and zero side size.
        /// </summary>
        public RegularPoligon()
            : base()
        {
            circumscribedСircleRadius = 0;
            Points = GetRegularPoligonPoints();
        }

        /// <summary>
        /// Initializes a new instance of the Poligon class with the specified color and position and zero side size.
        /// </summary>
        public RegularPoligon(Color color, Point position)
            : base(color, position)
        {
            circumscribedСircleRadius = 0;
            SidesCount = 6;
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
            return result;
        }

        /// <summary>
        /// Initializes a new instance of the Poligon class with the specified color, position, side size.
        /// </summary>
        public RegularPoligon(Color color, Point position, int circumscribedСircleRadius, int sidesCount)
            : base(color, position)
        {
            this.circumscribedСircleRadius = circumscribedСircleRadius;
            SidesCount = sidesCount;
            Points = GetRegularPoligonPoints();
        }

    }
}
