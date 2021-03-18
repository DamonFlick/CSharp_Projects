using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures1
{   public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number x = new Number();
            x.Amount = 42.06m;
            Console.WriteLine(x.Amount);
            Console.ReadLine();
        }
    }
}
