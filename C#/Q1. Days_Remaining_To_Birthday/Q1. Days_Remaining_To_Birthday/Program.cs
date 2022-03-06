//WAP – Write a Program in C# to Calculate No of Days Remaining in your upcoming birthdays 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Days_Remaining_To_Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create d objects to find Current Date and Time
            DateTime d = DateTime.Now;
            Console.WriteLine("Today is : " +d.ToString("dd/MMMM/yyyy"));

            //Define current year,month, and date to each variables
            int thisyear = Convert.ToInt16(d.ToString("yyyy"));
            int thismonth= Convert.ToInt16(d.ToString("MM"));
            int thisday= Convert.ToInt16(d.ToString("dd"));

            //If the birthdays already passed this year, the year will +1, else not
            if (thismonth==08 && thisday > 18)
            {
                thisyear = thisyear + 1;
            }

            //Define the next birthday date
            var mynextbirthday = new DateTime(Convert.ToInt16(thisyear), 8, 18);
            Console.WriteLine("Your upcoming birthday date is: "+ mynextbirthday);

            //Calculate Remaining days until my next birthday
            int remainings = 0;
            while (d < mynextbirthday) //Comparer is just a target datetime
            {
                d = d.AddDays(1);
                remainings++;
            }
            Console.WriteLine("Remaining Days: " + remainings);


            Console.ReadKey();
        }
    }
}
