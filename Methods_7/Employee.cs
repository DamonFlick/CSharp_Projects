using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_7
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set; }
        
        public int ID;
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I ," + firstName + " " + lastName + ", quit.");
        }


        //public static bool operator ==(Employee employee1, Employee employee2)   //==
        //{
        //    if (employee1.ID == employee2.ID)
        //    {

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator !=(Employee x, Employee y)  //!=
        //{
        //    if (x.ID == y.ID)
        //    {

        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
