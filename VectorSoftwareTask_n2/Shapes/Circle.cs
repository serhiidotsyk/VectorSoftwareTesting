using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n2.Shapes
{
    class Circle: Shape
    {
        public double Radius { get; set; }
        public override double Area 
        {
            get 
            { 
                return Math.PI * Radius * Radius; 
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
