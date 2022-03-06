//WAP to find the entered string is a palindrome 
//Palindrome= is the one that once reversed produces the same result as the original input string
//Ex. civic, radar, level, kayak, madam, refer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to input string
            Console.WriteLine("Please enter a string to check wheter it is a Palindrome:");
            string input = Console.ReadLine();

            //Create reverse string and save the value
            string reverse=string.Empty;
            if (input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i].ToString();
                }
                if (reverse == input)
                {
                    Console.WriteLine("\nInput = {0}\nOutput= {1}\nString is Palindrome ", input, reverse);
                }
                else
                {
                    Console.WriteLine("\nInput = {0}\nOutput= {1}\nString is NOT Palindrome ", input, reverse);
                }
            }
            Console.ReadKey();
        }
    }
}
