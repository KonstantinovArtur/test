using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Скоропечатание
{
    class Watch
    {
         internal void Main(string[] args)
         {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
         }

    }
}
