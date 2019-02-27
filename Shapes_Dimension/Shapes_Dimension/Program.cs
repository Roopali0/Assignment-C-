using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Dimension
{
    public enum shape_choice    
        { Circle = 1,
        Square = 2,
        Rectangle = 3,
        Triangle = 4 }    

    public class Shape
    {
         //int length, width, radius, height, side, base1;

        public Shape()
        {
            double Area = 0;
        }        
        
        int Circle = (int)shape_choice.Circle;
        int Square = (int)shape_choice.Square;
        int Rectangle = (int)shape_choice.Rectangle;
        int Triangle = (int)shape_choice.Triangle;

    }

    public class Circle : Shape
    {
        double radius;
        public Circle(double r)
        {
            this.radius = r;
            double area = (2 * 2.14 * r);
            Console.WriteLine("Area of Circle = " + area);
            Console.ReadKey();
        }
        
    }

    class Square : Shape
    {
        public Square(double s)
        {
            double area = (2 * s);
            Console.WriteLine("Area of Square = " + area);
            Console.ReadKey();
        }
    }

    class Rectangle : Shape
    {
       public Rectangle(double l, double w)
               {
            double Area= ( l * w);
            Console.WriteLine("Area of Rectangle = " + Area);
            Console.ReadKey();
        }
    }

    class Triangle : Shape
    {
        
        public Triangle(double b, double h)
        {            
           double Area = ( b*h*1/2);
            Console.WriteLine("Area of Triangle = " + Area);
            Console.ReadKey();
        }
    }

    class program
    {
        public static void Main()
        {
            
            int cc = 0;
            do
            {
                Console.WriteLine("For which shape you want to calculate the dimension" + Environment.NewLine + "Press 1. Circle" +
                Environment.NewLine + "2. Square" + Environment.NewLine + "3. Rectangle" + Environment.NewLine + "4. Triangle" + Environment.NewLine);

                string input = Console.ReadLine();
                int r = Convert.ToInt32(input);


                switch (r)

                {
                    case ((int)shape_choice.Circle):
                        Console.WriteLine("Enter the radius of the circle");
                        string radius = Console.ReadLine();
                        Convert.ToDouble(radius);
                        //C.Circle(radius);
                        Circle C = new Circle(Convert.ToDouble(radius));
                        break;

                    case ((int)shape_choice.Square):
                        Console.WriteLine("Enter the side of the Square");
                        string side = Console.ReadLine();

                        Square SQ = new Square(Convert.ToInt32(side));
                        break;

                    case
                         ((int)shape_choice.Rectangle):
                        Console.WriteLine("Enter the Length of the Rectangle");
                        string length = Console.ReadLine();
                        Console.WriteLine("Enter the Width of the Rectangle");
                        string width = Console.ReadLine();
                        Rectangle R = new Rectangle(Convert.ToDouble(length), Convert.ToDouble(width));

                        break;

                    case ((int)shape_choice.Triangle):


                        Console.WriteLine("Enter the base of the triangle");
                        string base1 = Console.ReadLine();

                        Console.WriteLine("Enter the height of the triangle");
                        string height1 = Console.ReadLine();
                        Triangle T = new Triangle(Convert.ToDouble(base1), Convert.ToDouble(height1));
                        break;

                    default:
                        Console.WriteLine(" You are in default case and this does not calulate any dimension");
                        break;

                } // end of switch

                Console.WriteLine("do you want to continue? Select 0 to continue and 1 to exit");
                string continue_Choice = Console.ReadLine();
                 cc = Convert.ToInt32(continue_Choice);                
            } while (cc == 0); // End of Do

        } // End of class

    } // end of main

} // end of namespace