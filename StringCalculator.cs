using System.Linq;

public class StringCalculator
{
    public int Add(string input)
    {
        if (checkNullString(input))
            return 0;
    }

  private static bool checkNullString(string input)
    { return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input); }
}
