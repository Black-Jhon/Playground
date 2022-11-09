using System;
using System.Linq;

namespace OrderedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var text = "ConexantSmartAudio HD";
            var result = text.Select((value, index) 
                    => new UpperCaseItem(value, index, char.IsUpper(value)))
                .Where(x => x.IsUpper);
    
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Index, -5:D3}{item.Value}");
            }
    
            Console.ReadLine();
        }
    }
}

public class UpperCaseItem
{
    public char Value { get; }
    public int Index { get; }
    public bool IsUpper { get; }
    
    public UpperCaseItem(char value, int index, bool isUpper)
    {
        Value = value;
        Index = index;
        IsUpper = isUpper;
    }
}
