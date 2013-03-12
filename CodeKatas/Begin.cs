using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    class Begin
    {
        private static void Main(string[] args)
        {
            //FizzBuzz.CalculateSimple(Convert.ToInt16(number));
            //FizzBuzz.CalculateFunctional(Convert.ToInt16(number));
            //FizzBuzz.CalculateJavaScript(Convert.ToInt16(number));
            //FizzBuzz.CalculateFSharp(Convert.ToInt16(number));
            //FizzBuzz.CalculateLINQ(Convert.ToInt16(number));

            Console.WriteLine("Which program would you like to run? \n Your options are:  BowlingGame, BerlinClock, FizzBuzz, PrimeFactors or RomanNumerals");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "BowlingGame":
                case "BerlinClock":
                case "PrimeFactors":
                    {
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

        private static void RunFizzBuzz()
        {
            Console.WriteLine("Which version would you like to run? \n Options are:  Simple, Functional, JavaScript, FSharp or LINQ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Simple":
                    {
                        Console.WriteLine("Enter a number");
                        string readIn = Console.ReadLine();
                        RunFBSimple(readIn);
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
            Console.WriteLine("Which version would you like to run? \n Options are:  Simple, Functional, JavaScript, FSharp or LINQ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Simple":
                    {
                        Console.WriteLine("Enter a number");
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

        private static void RunFBSimple(string readIn)
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

