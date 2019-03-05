using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Test
{
    class SquareAndTriangle
    {
        public void square_Area(double s)
        {
            double area = (2 * s);
            Console.WriteLine("Area of Square = " + area);
            Console.ReadKey();
        }

        public void triangle_Area(double b, double h)
        {
            double Area = (b * h * 1 / 2);
            Console.WriteLine("Area of Triangle = " + Area);
            Console.ReadKey();
        }
    }
}
