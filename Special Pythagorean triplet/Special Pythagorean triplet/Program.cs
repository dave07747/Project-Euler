using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int c = 1; c <= 500; ++c)
            {
                for (int b = 1; b <= 500; ++b)
                {
                    for (int a = 1; a <= 500; ++a)
                    {
                        if(Convert.ToInt32(Math.Pow(a,2) + Math.Pow(b,2)) == Convert.ToInt32(Math.Pow(c,2)))
                        {
                            Console.WriteLine(Convert.ToInt32(Math.Pow(a, 2)) + " + " + Convert.ToInt32(Math.Pow(b, 2)) + " = " + Convert.ToInt32(Math.Pow(c, 2)));
                            if (a + b + c == 1000)
                            {
                                Console.WriteLine(a*b*c);
                                Console.Read();
                            }
                        }
                    }
                }
            }
        }
    }
}
