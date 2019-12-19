using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsoleApp
{
    class Program
    {
        static IEnumerable<int> Populate(int max)
        {
            //List<int> list = new List<int>();

            for (int i = 0; i <= max; i++)
            {
                yield return i;
            }
            //return list;                 
        }
        static void Main(string[] args)
        {
            int n = 1000000000;
            long sum = 0;
            Stopwatch sw = new Stopwatch();
            int stopAt = 10000000;

            foreach (var value in Populate(n))
            {
                sum += value;
                if(value % stopAt == 0)
                {
                    Console.WriteLine("{0}M\tMem={1}Mbyte\tTime={2}mesc", 
                        value/1000000, GC.GetTotalMemory(false) / 1024/ 1024, sw.ElapsedMilliseconds);
                }
                    

            }
            long expectedSum = (long)n * ((long)n + 1) / 2;
            Console.WriteLine("Sum {{1.. {0:#,##0} = {1:#,##0}}} = {1:#,##0}; expected {2:#,##0}", n , sum, expectedSum);
            Console.ReadLine();
        }
    }
}
