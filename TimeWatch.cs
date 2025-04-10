using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class TimeWatch : IDisposable
    {
        Stopwatch sw = new();

        public TimeWatch()
        {
            this.sw.Start();
        }

        public void Dispose()
        {
            this.sw.Stop();
            Console.WriteLine($"Finished. Done in: {this.sw.Elapsed}");
        }
    }
}
