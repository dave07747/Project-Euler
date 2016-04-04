using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10_Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 0; i < 2000000; i++)
            {
                bool prime = IsPrime(i);
                if (prime)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
