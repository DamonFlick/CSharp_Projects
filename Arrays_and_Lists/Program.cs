using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> intList = new List<int>();       //Use Lists for unknown or changing size
            //intList.Add(4);
            //intList.Add(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


            //int[] numarray = new int[5];  //c# needs the array length specified    // Use for very large or specific 
            //numarray[0] = 5;
            //numarray[1] = 10;
            //numarray[2] = 456;
            //numarray[3] = 200;
            //numarray[4] = 5000;

            //int[] numarray1 = new int[] { 5, 2, 10, 200, 5000, 1234 }; //instantize at declaration. 

            //int[] numarray2 = { 5, 2, 10, 200, 5000, 1234 }; //add some sugar. 

            //numarray2[5] = 655;
            //Console.WriteLine(numarray2[5]);

            string[] stringarray = new string[5];  //c# needs the array length specified
            stringarray[0] = 5;
            stringarray[1] = 10;
            stringarray[2] = 456;
            stringarray[3] = 200;
            stringarray[4] = 5000;

            int[] numarray1 = new int[] { 5, 2, 10, 200, 5000, 1234 }; //instantize at declaration. 

            int[] numarray2 = { 5, 2, 10, 200, 5000, 1234 }; //add some sugar. 

            numarray2[5] = 655;
            Console.WriteLine(numarray2[5]);


        }
    }
}
