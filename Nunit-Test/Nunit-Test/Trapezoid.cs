using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Test
{
    class Trapezoid
    {
        public void trap_Area(double b1, double b2, double h)
        {
            double area = ((b1 * b2 /2)*h);
            Console.WriteLine("Area of Trapezoid = " + area);
            Console.ReadKey();
        }
    }
}
