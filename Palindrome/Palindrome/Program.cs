using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
       class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write a string to check");
        string palindrome_String = Console.ReadLine();

        String reversed_String = " ";


        for (int i = (palindrome_String.Length - 1); i >= 0; i--)
        {
            reversed_String += palindrome_String[i].ToString();
        }
        Console.Write("The reversed string is = " + reversed_String);

        // Boolean str_Matched = true;
        int e = 0;

        for (int j = 0; j <= (palindrome_String.Length - 1); j++)
        {
            if (palindrome_String[j] != reversed_String[j])
            {
                Console.WriteLine("\n" + j);
                e = e++;
                // str_Matched = false;
            }

        }
        if (e == 0)
        {
            Console.WriteLine("\n" + "The string is Palindrome");
        }

        else
        {
            Console.WriteLine("\n" + "The string is not Palindrome");
        }        

        Console.ReadKey();

    } // End of Main
} // End of class
    } // End of namespace

