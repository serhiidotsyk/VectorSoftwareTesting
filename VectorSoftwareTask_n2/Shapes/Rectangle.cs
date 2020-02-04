using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSoftwareTask_n2.Shapes
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area
        {
            get 
            { 
                return Width * Height; 
            }
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
