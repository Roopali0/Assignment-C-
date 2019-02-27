using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[8] { 2, 15, 3, 5, 6, 6, -1, 10 };
            int i, j, Smallest = 0;

            for (i = 0; i <= 7; i++)
            {
                for (j = 1; j <= 6; j++)
                {
                    if (num[j] <= num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    } // End of If
                } // End of For 
                Smallest = num[j];

            } // End of For

            Console.WriteLine("Smallest number is " + Smallest);
            Console.Read();

        } // End of Main
    } // End of class
} // End of namespace

