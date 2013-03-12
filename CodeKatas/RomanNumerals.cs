using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    class RomanNumerals
    {
        /// <summary>
        /// Take any arabic number and output its roman numeral equivilent
        /// </summary>
        /// <param name="number"></param>
        public static void CalculateSimple(int number)
        {
            StringBuilder output = new StringBuilder();
            int[] arabics = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            for (int y = 0; y < arabics.Length; y++)
            {
                while (number >= arabics[y])
                {
                    number -= arabics[y];
                    output.Append(romans[y]);
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
