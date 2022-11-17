using System;
using System.Diagnostics;
using System.Threading;

namespace Pomo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a WorkTime duration in minutes: ");
                var work_duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a RestTime duration in minutes: ");
                var rest_duration = Convert.ToInt32(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();
                
                if (work_duration > 0)
                {
                    int work_time_in_min = work_duration * 1000 * 60;
                    stopwatch.Start ();
                    Thread.Sleep(work_time_in_min);
                    stopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("Worktime you entered is invalid");
                }
                TimeSpan ts = stopwatch.Elapsed;
                Console.WriteLine("Your WorkTime has completed");
                Stopwatch stopwatch2 = new Stopwatch();
                if (rest_duration > 0)
                {
                    int work_time_in_min = rest_duration * 1000 * 60;
                    stopwatch2.Start();
                    Thread.Sleep(work_time_in_min);
                    stopwatch2.Stop();
                }
                else
                {
                    Console.WriteLine("The RestTime you entered is invalid");
                }
                TimeSpan rts = stopwatch.Elapsed;
                Console.WriteLine("Your Session Time is {0:00}:{1:00}:{2:00}",
                    ts.Hours+rts.Hours, ts.Minutes+rts.Minutes, ts.Seconds + rts.Seconds);
                Console.ReadLine();
            }
        }
    }
}
