using System;

namespace TransformString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var length = input.Length;
            var result = new String('#', length - 4) + input.Substring(length - 4);
            
            Console.WriteLine(result);
        }
    }
}
