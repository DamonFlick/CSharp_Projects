using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be divided by two: ");
           Operations.divide(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Now enter two numbers. The second number is the divisor: "); 
            Operations.divide(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),out int z);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
