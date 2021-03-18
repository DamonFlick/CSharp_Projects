using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Operations
    {
        public static int opr(int x)
        {
            return x - 2;
        }

        public static int opr(double x)
        {
            return Convert.ToInt32(x * 2);
        }

        public static int opr(string x)
        {
            try
            {
                int y = Convert.ToInt32(x);
                return Convert.ToInt32(y / 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return 0;
            }
        }
    }
}
