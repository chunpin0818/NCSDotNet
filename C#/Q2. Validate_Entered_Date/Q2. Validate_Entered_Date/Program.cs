//WAP to find out if entered date is a valid date or not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //contains classes that define culture-related information (language, country/region, calendars, format for dates & currency...)

namespace Q2.Validate_Entered_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask User to Input a complete date
            Console.WriteLine("Date Format (MM/dd/yyyy) -- Ex.12/25/2022\nPlease Enter a date:");
            string inputdate = Convert.ToString(Console.ReadLine());

            //'TryParse' = Convert the representation format, return a boolean method whether the conversion is succeeded
            //'CultureInfo.InvariantCulture' =returned by properties DateTimeFormat, and also reflect the string comparison 
            //'DateTimeStyles' = defines the formatting options that customize how the DateTime.Parse
            DateTime d;
            bool valid = DateTime.TryParseExact(inputdate, "MM/dd/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out d);
            if (valid!=true)
            {
                Console.WriteLine("It is NOT a valid Date :(");
            }
            else
            {
                Console.WriteLine("It is a valid Date :)");
            }

            Console.ReadKey();
        }
    }
}
