using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>()
            {
                firstName = "Sample", lastName = "Student", ID = 1
            };
            Employee<int> employee2 = new Employee<int>()
            {
                firstName = "Sample", lastName = "Student", ID = 2
            };
            employee1.Things = new List<string> { "Hammer", "Nail" };
            employee2.Things = new List<int> { 3, 85 };
            employee1.Things.ForEach(i => Console.WriteLine(i));
            employee2.Things.ForEach(i => Console.WriteLine(i));


            ////Begin Assignment pg. 247

            //employee.Quit();
            //Console.ReadLine();

            //IQuittable quit = new Employee() { firstName = "Martha", lastName = "Marsh" };
            //quit.Quit();
            //Console.ReadLine();

            /* Console.WriteLine(Convert.ToString(employee1==employee2));  */      // Assignment pg. 252
            Console.ReadLine();
            
        }
    }
}
