using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Water", "Fire", "Earth", "Air" };
            int[] intArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41 };
            List<string> stringList = new List<string> ();
            stringList.Add("It’s the job that’s never started as takes longest to finish. - Sam Gamgee");
            stringList.Add("Even the smallest person can change the course of history. Lady Galadriel");
            stringList.Add("He that breaks a thing to find out what it is, has left the path of wisdom. Gandalf");
            stringList.Add("It is not our part to master all the tides of the world, but to do what is in us for the succor of those years wherein we are set, uprooting the evil in the fields that we know, " +
                "so that those who live after may have clean earth to till. Gandalf");
            stringList.Add("Memory is not what the heart desires. That is only a mirror. - Gimli ");


            Console.WriteLine("Select an index from our string array!");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i <= stringArray.Length) {
                Console.WriteLine(stringArray[i]);
            }
            else
            {
                Console.WriteLine("That is not a vailid index, please select between 0 and " + (stringArray.Length - 1)+".");
                Console.WriteLine("Select an index from our string array!");
                i = Convert.ToInt32(Console.ReadLine());

                if (i <= stringArray.Length)
                {
                    Console.WriteLine(stringArray[i]);
                }
                else
                {
                    Console.WriteLine("Uh Oh! Index " + i + "not found!");
                }
            }
            Console.ReadLine();


            Console.WriteLine("Select an index from our interger array!");
            int i2 = Convert.ToInt32(Console.ReadLine());
            if (i2 <= intArray.Length)
            {
                Console.WriteLine(intArray[i2]);
            }
            else
            {
                Console.WriteLine("That is not a vailid index, please select between 0 and " + (intArray.Length - 1) + ".");
                i2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();


            Console.WriteLine("Select an index from our list of quotes!!");
            int i3 = Convert.ToInt32(Console.ReadLine());
            if (i3 <= stringList.Count && i3 != null)
            {
                Console.WriteLine(stringList[i3]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is not a vailid index, please select between 0 and " + (stringList.Count - 1) + ".");
                Console.WriteLine("Select an index from our list of quotes!!");
                i3 = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
