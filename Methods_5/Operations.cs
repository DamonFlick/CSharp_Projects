using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_5
{
    static class Operations
    {
        public static void divide(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }

        
        public static void divide(int x, int y, out int z)
        {
             z = x / y;
        }
    }
}
