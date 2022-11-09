using System;

namespace Date
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(currentDate);
        }
    }
}
