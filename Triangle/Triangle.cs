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
        private const double SIN60 = 0.86602540378443864676372317075294;

        /// <summary>
        /// Gets  the size of triangel's side.
        /// </summary>
        public int SideSize { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Triangle class whith black color, (0;0) position and zero side size.
        /// </summary>
        public Triangle()
            : base()
        {
            SideSize = 0;
            Points = GetTriangePointsBySideSize();
        }

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified color and position and zero side size.
        /// </summary>
        [MainShapeConstracter]
        public Triangle(Color color, Point position)
            : base(color, position)
        {
            SideSize = 0;
            Points = GetTriangePointsBySideSize();
        }

        private List<Point> GetTriangePointsBySideSize()
        {
            var triangleHieght = (int)(SideSize*SIN60);
            return new List<Point> {new Point(0,triangleHieght), new Point(SideSize,triangleHieght ), new Point(SideSize/2, 0)};
        }

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified color, position, side size.
        /// </summary>
        public Triangle(Color color, Point position, int sideSize)
            : base(color, position)
        {
            this.SideSize = sideSize;
            Points = Points = GetTriangePointsBySideSize();
        }
    }
}
