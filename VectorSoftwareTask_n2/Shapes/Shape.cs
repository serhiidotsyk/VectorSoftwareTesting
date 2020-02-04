using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n2.Shapes
{
    abstract class Shape: IComparable<Shape>
    {
        public abstract double Area { get; }
        public int CompareTo(Shape shape)
        {
            return Area.CompareTo(shape.Area);
        }
    }
}
