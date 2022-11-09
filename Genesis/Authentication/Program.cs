using System;

namespace Authentication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Register
            Console.Write("Enter name to register: ");
            var name = Console.ReadLine();
            Console.Write("Enter password to register: ");
            var password = Console.ReadLine();
            
            // Login
            Console.Write("Enter name to login: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter password to login: ");
            var confirmPassword = Console.ReadLine();

            if (name == firstName && password == confirmPassword)
            {
                Console.WriteLine($"You're logged in.");
            }
            else
            {
                Console.WriteLine($"Wrong credentials.");
            }
        }
    }
}
