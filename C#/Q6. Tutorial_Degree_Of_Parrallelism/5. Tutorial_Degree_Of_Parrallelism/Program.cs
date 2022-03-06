//WAP to implement MaxDegreeOfParallelism 
//Degree of Parallelism -> Specify how many numbers of Threads to be used to execute the program
//Useful when working with Multithreading
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Tutorial_Degree_Of_Parrallelism
{
    internal class Program
    {
        static void Main(string[] args) {
            var max = new ParallelOptions() {MaxDegreeOfParallelism = 2}; //Define Maximum Threads using ParallelOptions property
            int number = 100;
            Parallel.For(0, number,max, i =>
            {
                Console.WriteLine("Running {0} time, thread ID= {1}",i,Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });

        }
    }
}
