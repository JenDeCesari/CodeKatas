using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeKatas
{
    class FizzBuzz
    {
        //Complete simply, functionally, with Javascript, F# and with LINQ/lambdas
        
        //Any number divisible by three is replaced by the word fizz and any 
        //divisible by five by the word buzz. Numbers divisible by both become fizzbuzz. 

        public static void CalculateSimple(int number)
        {
            string output = string.Empty;

            if ((number%3) == 0)
            {
                output = "fizz";
            }

            if ((number%5) == 0)
            {
                output = "buzz";
            }
            
            if ((number%3) == 0 && (number%5) == 0)
            {
                output = "fizzbuzz";
            }

            Console.Write(output);
            Console.ReadKey();
        }

        public static void CalculateFunctional(int number)
        {
            string output = string.Empty;

            Console.WriteLine(output);
            Console.ReadKey();
        }

        public static void CalculateJavaScript(int number)
        {
            string output = string.Empty;

            Console.WriteLine(output);
            Console.ReadKey();
        }

        public static void CalculateFSharp(int number)
        {
            string output = string.Empty;

            Console.WriteLine(output);
            Console.ReadKey();   
        }

        public static void CalculateLINQ(int number)
        {
            string output = string.Empty;

            Console.WriteLine(output);
            Console.ReadKey();
        }        
    }
}
