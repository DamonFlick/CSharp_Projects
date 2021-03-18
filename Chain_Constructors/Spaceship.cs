using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors
{
    public class Spaceship
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Location { get; set; }
        public void BlastOff()
        {
            Console.WriteLine("You spaceship weighs {0} Lbs.", Weight);
            Console.WriteLine("3... 2... 1...");
            Console.ReadLine();
            Console.WriteLine("Blast Off!!!");
        }

        public Spaceship(string name, string location, int weight)
        {
            Name = name;
            Weight = weight;
            Location = location;
        }
        public Spaceship(string name, string location) : this(name, location,  100)
        {

        }
        
    }    
}
