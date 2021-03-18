using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_While_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a do-while loop. \n Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
         
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }  
            }
            while (!isGuessed);
            
            
            
            Console.ReadLine();  //Loop 2

            Console.WriteLine("Here's a while loop.\n Do you have an awesome favorite color? \n\n What is your favorite color?");
            string color = Console.ReadLine();
            bool isGuessed2 = color == "blue";

            while(!isGuessed2)
            {
                switch(color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue! You have an awesome favorite color!");
                        Console.ReadLine();
                        isGuessed2 = true;
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple! You do not have an awesome favorite color.");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green! You do not have an awesome favorite color.");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange! You do not have an awesome favorite color.");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red! You do not have an awesome favorite color.");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You do not have an awesome favorite color.");
                        color = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine(); 
        }
    }
}
