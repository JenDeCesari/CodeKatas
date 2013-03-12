using System;

namespace CodeKatas
{
    class Begin
    {
        private static void Main()
        {
            Console.WriteLine("Which program would you like to run? \n Your options are: \nBowlingGame, BerlinClock, FizzBuzz, PrimeFactors or RomanNumerals");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "BowlingGame":
                case "BerlinClock":
                    {
                        break;
                    }
                case "PrimeFactors":
                    {
                        RunPrimeFactors();
                        break;
                    }
                case "FizzBuzz":
                    {
                        RunFizzBuzz();
                        break;
                    }
                case "RomanNumerals":
                    {
                        RunRomanNumerals();
                        break;
                    }
            }
        }

        private static void RunPrimeFactors()
        {
            Console.WriteLine("Which version would you like to run? \n Options are: \nSimple, Functional, JavaScript, FSharp or LINQ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Simple":
                    {
                        Console.WriteLine("Enter a number from 1 - 600:");
                        string readIn = Console.ReadLine();
                        RunPrimeSimple(readIn);
                        break;
                    }
                case "Functional":
                case "JavaScript":
                case "FSharp":
                case "LINQ":
                    {
                        break;
                    }
            }
        }
        private static void RunFizzBuzz()
        {
            Console.WriteLine("Which version would you like to run? \n Options are: \nSimple, Functional, JavaScript, FSharp or LINQ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Simple":
                    {
                        Console.WriteLine("Enter a number:");
                        string readIn = Console.ReadLine();
                        RunFbSimple(readIn);
                        break;
                    }
                case "Functional":
                case "JavaScript":
                case "FSharp":
                case "LINQ":
                    {
                        break;
                    }
            }
        }

        private static void RunRomanNumerals()
        {
            Console.WriteLine("Which version would you like to run? \n Options are: \nSimple, Functional, JavaScript, FSharp or LINQ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Simple":
                    {
                        Console.WriteLine("Enter a number:");
                        string readIn = Console.ReadLine();
                        RomanNumeralsSimple(readIn);
                        break;
                    }
                case "Functional":
                case "JavaScript":
                case "FSharp":
                case "LINQ":
                    {
                        break;
                    }
            }
        }

        private static void RunPrimeSimple(string readIn)
        {
            if (IsNumber(readIn))
            {
                int number = Convert.ToInt32(readIn);
                if (number > 600)
                {
                    Console.WriteLine("Only number less than 600 please");
                }
                else
                {
                    if (number < 0)
                    {
                        Console.Write("Only numbers greater than 0 please");
                    }

                    PrimeFactors.CalculateSimple(number);
                }
                
            }
        }
        private static void RunFbSimple(string readIn)
        {
            if (IsNumber(readIn))
            {
                int number = Convert.ToInt32(readIn);
                FizzBuzz.CalculateSimple(number);
            }
            
        }
        private static void RomanNumeralsSimple(string readIn)
        {
            if (IsNumber(readIn))
            {
                int number = Convert.ToInt32(readIn);
                RomanNumerals.CalculateSimple(number);
            }
        }

        private static bool IsNumber(string readIn)
        {
            if (readIn != string.Empty)
            {
                double x;
                bool isNumeric = double.TryParse(readIn, out x);

                if (isNumeric)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

