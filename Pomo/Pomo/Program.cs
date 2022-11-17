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
                // Task Start
                Console.WriteLine("\nEnter how much time you would need to work in minute: ");
                var workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter how much time you would need to rest in minute: ");
                var restTime = Convert.ToInt32(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();
                
                if (workTime > 0)
                {
                    int workTimeInMin = workTime * 1000 * 60;
                    stopwatch.Start();
                    Thread.Sleep(workTimeInMin);
                    stopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("The work time you entered is invalid");
                }
                
                // Task Completion
                TimeSpan timeSpan = stopwatch.Elapsed;
                Console.WriteLine($"Your work time has completed it's cycle.");
                Stopwatch stopwatch2 = new Stopwatch();
                
                if (restTime > 0)
                {
                    int workTimeInMin = restTime * 1000 * 60;
                    stopwatch2.Start();
                    Thread.Sleep(workTimeInMin);
                    stopwatch2.Stop();
                }
                else
                {
                    Console.WriteLine("The rest time you entered is invalid");
                }
                
                TimeSpan endTimeSpan = stopwatch.Elapsed;
                Console.WriteLine("Your Session Time is {0:00}:{1:00}:{2:00}",
                    timeSpan.Hours+endTimeSpan.Hours, timeSpan.Minutes+endTimeSpan.Minutes, timeSpan.Seconds + endTimeSpan.Seconds);
                Console.ReadLine();
            }
        }
    }
}
