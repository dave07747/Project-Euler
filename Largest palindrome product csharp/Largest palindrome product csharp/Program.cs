using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_palindrome_product_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest= 0;
            for (var i = 999; i > 99; --i)
            {
                for (var x = 999; x > 99; --x)
                {
                    var temp = (i*x).ToString();
                    var comp = "";
                    for (var a = temp.Length-1; a >= 0; a--)
                    {
                        comp += temp[a];
                    }
                    if (temp == comp)
                    {
                        if(largest < Convert.ToInt32(temp))
                             largest = Convert.ToInt32(temp);
                    }
                }
            }
            Console.WriteLine(largest);
            Console.Read();
        }
    }
}
