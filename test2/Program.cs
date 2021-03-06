using System;
using System.Threading;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Beep();
                Console.WriteLine("IIT");
                Thread.Sleep(2000);
            }
        }
    }
}
