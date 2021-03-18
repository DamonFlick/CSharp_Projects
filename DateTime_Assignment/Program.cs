using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current Date and Time is " + DateTime.Now);
            Console.WriteLine("Please enter an number of hours to see what time it will be after those hours elapse");
            double answer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}
