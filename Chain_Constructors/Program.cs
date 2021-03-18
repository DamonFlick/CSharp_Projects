using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PlanetName = "Earth";
            Console.WriteLine("Please name your Spaceship!");
            var Name = Console.ReadLine();
            Spaceship spaceship = new Spaceship(Name, PlanetName);

            Console.WriteLine("Are you ready to depart Planet {0}?! \n Please answer 'yes' or 'no'", spaceship.Location);
            if (Console.ReadLine() == "yes")
            {
                spaceship.BlastOff();
                Console.ReadLine();
            }
        }
    }
}
