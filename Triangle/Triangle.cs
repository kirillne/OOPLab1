using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace Lab1.Shapes
{

    /// <summary>
    /// Defines a triangle.
    /// </summary>
    public class Triangle : PoligonBase
    {
        private int circumscribedСircleRadius;
        private const double SIN60 = 0.86602540378443864676372317075294;
        private int sideSize;


        /// <summary>
        /// Gets  the size of triangel.
        /// </summary>
        public override int CircumscribedСircleRadius
        {
            get { return circumscribedСircleRadius; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "Shape can't have nagative height");
                circumscribedСircleRadius = value;
                sideSize =(int)(circumscribedСircleRadius*Math.Sqrt(3));
                Points = GetTriangePointsBySideSize();
            }
        }


        /// <summary>
        /// Initializes a new instance of the Triangle class whith black color, (0;0) position and zero side size.
        /// </summary>
        public Triangle()
            : base()
        {
            sideSize = 0;
            Points = GetTriangePointsBySideSize();
        }

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified color and position and zero side size.
        /// </summary>
        public Triangle(Color color, Point position)
            : base(color, position)
        {
            sideSize = 0;
            Points = GetTriangePointsBySideSize();
        }

        private List<Point> GetTriangePointsBySideSize()
        {
            var triangleHieght = (int)(sideSize*SIN60);
            return new List<Point> {new Point(0,triangleHieght), new Point(sideSize,triangleHieght ), new Point(sideSize/2, 0)};
        }

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified color, position, side size.
        /// </summary>
        public Triangle(Color color, Point position, int sideSize)
            : base(color, position)
        {
            this.sideSize = sideSize;
            Points = Points = GetTriangePointsBySideSize();
        }

    }
}
