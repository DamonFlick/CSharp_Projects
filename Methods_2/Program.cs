using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger to subtract two from it");
            Console.WriteLine( "Result: " + Operations.opr(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();

            Console.WriteLine("Enter a decimal number multiply by two");
            Console.WriteLine("Result: " + Operations.opr(Convert.ToDouble(Console.ReadLine())));
            Console.ReadLine();

            Console.WriteLine(" Enter a number to be converted to \'int\' by a custom method, then divided by two");
            Console.WriteLine("Result: " + Operations.opr(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
