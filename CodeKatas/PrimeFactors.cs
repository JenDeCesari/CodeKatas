using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    class PrimeFactors
    {
        //Compute the prime factors of a given natural number

        public static void CalculateSimple(int number)
        {
            StringBuilder output = new StringBuilder();

            int[] primes =
                {
                    2, 3, 5, 7, 11, 23, 29, 41, 43, 47, 61, 67, 83, 89, 101, 113, 131, 137, 139, 151, 157, 173,
                    179, 191, 193, 197, 199, 223, 227, 229, 241, 263, 269, 281, 283, 311, 313, 317, 331, 337, 353, 359, 373,
                    379, 397, 401, 409, 421, 443, 449, 461, 463, 467, 487, 557, 571, 577, 593, 557, 577, 599
                };

            foreach (int a in primes)
            {
                int x;
                int answer = Math.DivRem(number, a, out x);

                if (x == 0)
                {
                    output.Append(Convert.ToString(a));
                    output.Append(" , ");
                }
            }
            
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
