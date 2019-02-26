using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int i;
            
            for ( i = 2; i <= 20; i++)

            {
                for (int j = 2; j <= 20; j++)

                {
                    if (i != 0 && i % j == 0)
                    { 
                        prime = false;
                        break;
                    }
                }
            }
            if (prime) ;
            {
                Console.WriteLine("prime number is" + i);
            }
            
        }
    } // End of class
} // End of namespace

