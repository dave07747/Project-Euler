using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace put_commas_between_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\David\Desktop\C# Stuff\Project Euler\put commas between nums\nums.txt");
            StreamWriter sw =
                new StreamWriter(@"C:\Users\David\Desktop\C# Stuff\Project Euler\put commas between nums\newnums.txt");
           while(!sr.EndOfStream)
            sw.Write((sr.Read()-48) + ",");
        }
    }
}
