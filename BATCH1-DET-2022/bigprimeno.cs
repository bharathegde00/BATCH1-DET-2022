using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class bigprimeno
    {
        static long MaxPrime(long num)
        {
            long CurrMaxPrime = -1;

            if (num % 2 == 0)
            {
                CurrMaxPrime = 2;
                while (num % 2 == 0)
                {
                    num = num / 2;
                }
            }

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    CurrMaxPrime = i;
                    num = num / i;
                }
            }

            if (num > 2)
                CurrMaxPrime = num;

            return CurrMaxPrime;
        }

        static void Main(string[] args)
        {
            long x, y, z;
            x = 65;
            y = 244;
            z = 98765;

            Console.WriteLine("Largest prime factor of " + x
                               + " is: " + MaxPrime(x));
            Console.WriteLine("Largest prime factor of " + y
                               + " is: " + MaxPrime(y));
            Console.WriteLine("Largest prime factor of " + z
                               + " is: " + MaxPrime(z));
        }
    }
}
