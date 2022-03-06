//Create a Class Emp- Employee with Following details  
//Name, Age, Email, Salary
//Two Functions to calculate  last day of employment (max 60Years) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4.Create_Class_Employees
{
    class Employee
    {
        public string name;
        public int age;
        public string email;
        private double Msalary;
        private int yearEmployment;

        //Function 1 (Calculate last day of employment)
        public void Cal_Employment()
        {
            int lastyear = yearEmployment + 60;
            Console.WriteLine("\nThe last year of employment is:"+ lastyear);
        }

        //Function 2 (Display the information of employees)
        public void Display()
        {
            Console.WriteLine("\nEmployee Name: " + name+ "\nEmployee Age: " + age + "\nEmployee Email: " + email + "\nMonthly Salary: " + Msalary + "\nEmployment Year:" + yearEmployment) ;
        }


        //Setter and Getter
        public double MSalary
        {
            get { return Msalary; }
            set { this.Msalary = value; }
        }

        public int YearEmployment
        {
            get { return yearEmployment; }
            set { this.yearEmployment = value; }
        }

    }
    internal class Program:Employee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.name="Goh Chun Pin";
            e1.age = 22;
            e1.email = "example@outlook.com";
            e1.MSalary = 3000.00;
            e1.YearEmployment = 2020;

            e1.Display();
            e1.Cal_Employment();
            Console.ReadKey();
        }
    }
}
