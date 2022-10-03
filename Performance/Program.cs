using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            for (int i = 0; i < 10; i++)
            {
                Test();
            }

            s.Stop();

            Console.WriteLine($"Took {(float)s.ElapsedMilliseconds / 1000} seconds");

            Console.ReadLine();
        }

        static void Test()
        {
            List<int> myList = new List<int>();

            for (int i = 0; i < 49000000; i++)
            {
                myList.Add(i);
            }
        }
    }
}
