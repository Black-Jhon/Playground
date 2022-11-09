using System;

namespace Genesis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = "4111111111111111";
            var length = input.Length;
            var result = new String('#', length - 4) + input.Substring(length - 4);

            Console.WriteLine(result);
        }
    }
}
