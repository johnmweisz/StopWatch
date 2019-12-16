using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new StopWatch();
            Console.WriteLine("Use command 'start' or 'stop' to use StopWatch or return to exit");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "start")
                {
                    timer.Start();
                }
                else if (input == "stop")
                {
                    timer.Stop();
                }
                else
                {
                    Console.WriteLine("Program ended");
                    break;
                }
            }
        }   
    }
}
