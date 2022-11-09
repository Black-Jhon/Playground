using System;

namespace Library
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose between c, o, d, e, as your entry values: ");
            var user = Console.ReadLine();
            if (user == "c")
            {
                Console.WriteLine("C# Books");
            }else if (user == "o")
            {
                Console.WriteLine(".NET Core Books");
            }else if (user == "d")
            {
                Console.WriteLine("Clean Coding Books");
            }else if (user == "e")
            {
                Console.WriteLine("EFCore Books");
            }
            else
            {
                Console.WriteLine("Sorry! This is an Invalid Entry. Check and try again!");
            }
        }
    }
}
