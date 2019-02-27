using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program to find the prime numbers 

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int i, j;

            for (i = 2; i <= 100; i++)

            {
                for (j = 2; j <= 100; j++)

                {
                    if (i != j && i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.WriteLine("prime number is " + i);
                }

                prime = true;

            } // End of first loop
            Console.ReadKey();
        } // End of Main
    } // End of class
} // End of namespace
