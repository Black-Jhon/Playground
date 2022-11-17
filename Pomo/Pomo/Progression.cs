using System;

namespace Pomo
{
    public class Progression
    {
        public string _start;

        public Progression(string start)
        {
            this._start = start;
        }

        public void GetSession(int duration)
        {
            Console.WriteLine("Enter how much time you need to work: ");
            var workTime = Console.ReadLine();
            
            Console.Write("Enter how much time you need to rest: ");
            var restTime = Console.ReadLine();

            
        }
        
        public void DisplayProgress()
        {
            Console.WriteLine($"The time started at: {_start}");
        }
    }
}
