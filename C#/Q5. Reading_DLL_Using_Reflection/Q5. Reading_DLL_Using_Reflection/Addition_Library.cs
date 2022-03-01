using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5.Reading_DLL_Using_Reflection
{
    internal class Addition_Library
    {
        public void Display()
        {
            Console.WriteLine("This is Display");
        }
    }

    class Student
    {
        public string name { set; get; }
        public int Age { set; get; }
    }
}
