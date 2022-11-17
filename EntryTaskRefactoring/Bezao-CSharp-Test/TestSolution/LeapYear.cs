namespace TestSolution;

public class LeapYear
{
    public static void Main()
    {
        var newLeapYear = GetNextLeapDate(DateTime.Now);
        Console.WriteLine(newLeapYear);

        DateTime GetNextLeapDate(DateTime baseDate)
        {
            var year = baseDate.Year;

            // Starts in the next year assuming we’re already in March
            if (baseDate.Month > 2)
                year++;

            // Find the next leap year
            while (!DateTime.IsLeapYear(year))
                year++;

            // Gets last of February
            return new DateTime(year, 2, 29);
        }
    }
}
