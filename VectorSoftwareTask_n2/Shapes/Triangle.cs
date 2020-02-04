using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n2.Shapes
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double Area
        {
            get
            {
                return Base * Height / 2;
            }
        }
        public Triangle(double _base, double height)
        {
            Base = _base;
            Height = height;
        }
    }
}
