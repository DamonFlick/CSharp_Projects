using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your Favorite Number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heaightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short tempOnMars = -341;

            string myName = "Jesse";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.Read();
        }
    }
}
