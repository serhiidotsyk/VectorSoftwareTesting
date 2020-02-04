using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorSoftwareTask_n2.Shapes;

namespace VectorSoftwareTask_n2
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var _base = 5D;
            var height = 2D;
            var width = 10D;
            var shapes = new List<Shape>
            {   
                new Triangle(_base, height),
                new Square(side),
                new Rectangle(width,height),
                new Circle(radius), 
            };
            foreach(var item in shapes)
                Console.WriteLine(item.Area);
            shapes.Sort();
            Console.WriteLine("sorted ------------------");
            foreach (var item in shapes)
                Console.WriteLine(item.Area); 
        }
    }
}
