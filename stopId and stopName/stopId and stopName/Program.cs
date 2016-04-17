using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopId_and_stopName
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr =
                new StreamReader(@"C:\Users\David\Desktop\C# Stuff\Project Euler\stopId and stopName\stops.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\David\Desktop\DrizzleDrop\DrizzleDrop\stops.txt"))
                {

                    for (int x = 0; x < 69; ++x)
                    {
                        var input = sr.ReadLine();
                        int counter = 0;
                        while (input[counter] != ',')
                        {
                            sw.Write(input[counter]);
                            counter++;
                        }
                        sw.Write(",");
                        var temp = "";
                        var count2 = 0;
                        var store = 0;
                        for (int i = 0; i < input.Length; ++i)
                        {
                            if (input[i] == ',')
                            {
                                count2++;
                            }
                            if (count2 == 3)
                            {
                                store = i;
                                break;
                            }
                        }
                        for (int i = store + 1; i < input.Length; ++i)
                        {
                            if (input[i] == ',')
                                break;
                            sw.Write(input[i]);
                        }
                        sw.WriteLine();
                    }
                }
            }
        }
    }
}
