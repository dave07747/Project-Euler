using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_Highlydivisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            for (long i = 1; i < 100000000000000; ++i)
            {
                number += i;
                long divisible = 0;
                for (long x = 1; x <= number; ++x)
                {
                    if (number%x == 0)
                    {
                        divisible++;
                    }
                }
                if (divisible > 300)
                {
                    Console.WriteLine(divisible + " " + number);
                    if (divisible > 500)
                    {
                        break;
                    }
                }
               
            }
            Console.WriteLine(number);
            Console.Read();
        }
    }
}
