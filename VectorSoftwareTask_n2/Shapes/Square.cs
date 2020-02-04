using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n2.Shapes
{
    class Square: Shape
    {
        public double Side { get; set; }
        public override double Area 
        {
            get 
            { 
                return Side * Side; 
            } 
        }
        public Square(double side)
        {
            Side = side;
        }
    }
}
