using System;
using System.Diagnostics;
using System.Threading;

namespace Pomo
{
    public class Sessions
    {
        public int _workTime { get; set; }
        public int _restTime { get; set; }

        public Sessions(int workTime, int restTime)
        {
            _workTime = workTime;
            _restTime = restTime;
        }

        public void Progression()
        {
            {
                Console.WriteLine("\nEnter how much time you would need to work in minute: ");
                var workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter how much time you would need to rest in minute: ");
                var restTime = Convert.ToInt32(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();
                
                if (workTime > 0)
                {
                    int timeInSec = workTime * 1000 * 60;
                    stopwatch.Start();
                    Console.WriteLine($"\nWork time count-down started...");
                    
                    Thread.Sleep(timeInSec);
                    stopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("The work time you entered is invalid");
                }
                
                TimeSpan timeSpan = stopwatch.Elapsed;
                Console.WriteLine($"Your work time has completed it's cycle.");
                Stopwatch stopwatch2 = new Stopwatch();
                
                if (restTime > 0)
                {
                    int workTimeInMin = restTime * 1000 * 60;
                    stopwatch2.Start();
                    Console.WriteLine($"\nRest time count-down started...");
                    
                    Thread.Sleep(workTimeInMin);
                    stopwatch2.Stop();
                }
                else
                {
                    Console.WriteLine("The rest time you entered is invalid");
                }

               
                TimeSpan endTimeSpan = stopwatch.Elapsed;
                Console.WriteLine($"Rest time count-down completed!");
                Console.WriteLine($"\nYour work session lasted for {workTime} min");
                Console.WriteLine($"Your rest session lasted for {restTime} min");
                Console.ReadLine();
            }
        }
    }
}
