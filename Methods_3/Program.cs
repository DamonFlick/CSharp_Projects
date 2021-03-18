using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers, one after the other and witness some sweet addition. You can also omit the second number.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
            string optInput = Console.ReadLine();
            if ( String.IsNullOrEmpty(optInput))
            {

                Console.WriteLine("Result: " + operations.expression(x));
            }
            else
            {
                y = Convert.ToInt32(optInput
                    );
                Console.WriteLine("Result: " + operations.expression(x, y));
            }
            
            Console.ReadLine();
        }
    }
}