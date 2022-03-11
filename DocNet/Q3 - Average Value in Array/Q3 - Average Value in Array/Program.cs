//WAP to Print Number whose value is less than that of average value of all the number in the array. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3___Average_Value_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numberList = {10.23 , 102 , 56 , 23.10 , 26.35 , 99 , 64.50 , 26 , 96 , 21 };
            double sum = numberList.Sum();
            double avg = sum/ numberList.Length;

            var query=from num in numberList
                      where num<avg
                      select num;

            Console.WriteLine("Below is the number in the list:\n");
            foreach (double i in numberList)
            {
                Console.WriteLine(" - "+i);
            }
            Console.WriteLine("\nThe average of Array List are:" + avg);
            Console.WriteLine("\n\nBelow are the number less that avg of all the numbers in array:\n");
            foreach (double i in query)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
