using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulaiton
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "'This'";
            string str2 = "is now uppercase!";
            string str3 = " And all this text is joined with a string builder!";

            str1 = str1.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append(str1 + str2 + str3);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
