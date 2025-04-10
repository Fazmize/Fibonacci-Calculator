using System.Diagnostics;

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
