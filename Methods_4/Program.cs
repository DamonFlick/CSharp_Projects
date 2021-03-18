using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers, one after the other:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Operations.operate(x: x, y: y);
        }
    }
}
