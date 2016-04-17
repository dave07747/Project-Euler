using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13_Large_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr =
                new StreamReader(@"C:\Users\David\Desktop\C# Stuff\Project Euler\Problem 13 Large Sum\nums.txt");
            int[,] nums = new int[60, 100];
            int[] total = new int[60];
                for (int x = 0; x < 100; ++x)
                {
                    var temp = sr.ReadLine();
                    for (int i = 9; i < temp.Length; ++i)
                    {
                        nums[i, x] = Convert.ToInt32(temp[i]);
                    }
                }
        
            for (int x = 9; x <= 60; ++x)
            {
                for (int i = 0; i < 100; ++i)
                {
                    //total[x] += nums[x, i]; 
                }
            }
            int carry = 0;
            for (int i = 60; i > 0; --i)
            {
                carry = 0;
                while (total[i] >= 10)
                {
                    total[i]--;
                    carry++;
                }
                total[i - 1] += carry;
            }
            for (int i = 0; i < 15; ++i)
                Console.Write(total[i]);
            Console.Read();
        }
    }
}
