namespace TestSolution;

// Base method
public class PigLatin
{
    public static void Main()
    {
        var pigLatin = ToPigLatin("The quick brown fox");
        Console.WriteLine(pigLatin);
        Console.WriteLine(ToEnglish(pigLatin));
    }

    private static string ToPigLatin(string sentence)
    {
        var words = sentence.ToLower().Split(" ");
        var result = new List<string>();
        foreach (var word in words)
        {
            var newWord = word.Substring(1, word.Length - 1) + word[0] + "ay";
            result.Add(newWord);
        }

        return string.Join(" ", result);
    }

    private static string ToEnglish(string sentence)
    {
        var words = sentence.ToLower().Split(" ");
        var result = new List<string>();
        foreach (var word in words)
        {
            var newWord = word[word.Length - 3] + word.Substring(0, word.Length - 3);
            result.Add(newWord);
        }

        return string.Join(" ", result);
    }
}
