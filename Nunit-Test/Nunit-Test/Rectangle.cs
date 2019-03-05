using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Test
{
    class Rectangle
    {
        public void calc_Area(double l, double w)
        {
            double Area = (l * w);
            Console.WriteLine("Area of Rectangle = " + Area);
            Console.ReadKey();
        }
    }
}
