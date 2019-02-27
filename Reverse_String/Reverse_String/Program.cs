using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    
class Program
{
    static void Main(string[] args)
    {
        string reversed_String = " ";
        Console.WriteLine("Please write a string");
        string name = Console.ReadLine();

        for (int i = (name.Length - 1); i >= 0; i--)
        {
            reversed_String += name[i].ToString();
        }
        Console.Write("The reversed string is" + reversed_String);

        Console.ReadKey();

        

     } // End of Main
} // End of class
    } // End of namespace