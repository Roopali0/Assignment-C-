using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_Test
{
    [TestFixture]
    public class Shape
    {
        [Test]
        public void pass_Rectangle ()
            {
            Rectangle R = new Rectangle();
            R.calc_Area(50, 60);
            }
        [Test]
        public void pass_Square()
        {
            SquareAndTriangle ST = new SquareAndTriangle();
            ST.square_Area(20.8);
        }

        [Test]
        public void pass_Triangle()
        {
            SquareAndTriangle ST = new SquareAndTriangle();
            ST.triangle_Area(20,40);
        }

        [Test]
        public void pass_Trapezoid()
        {
            Trapezoid T = new Trapezoid();
            T.trap_Area(20, 20,8);
        }




    }
}
