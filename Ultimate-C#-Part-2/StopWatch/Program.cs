using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Console.WriteLine(stopWatch.Start());
            Console.WriteLine(stopWatch.Stop());
        }
    }
}
