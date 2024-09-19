using System.Linq;

public class StringCalculator
{
    public int Add(string input)
    {
        if (checkNullString(input))
            return 0;
        var numberlist = input;
        return numberlist;
    }

  private static bool checkNullString(string input)
    { return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input); }

  private static List<int> inputDecoder(string numbers)
    {
        string[] delimiters = new string[] { ",", "\n" };
        if (numbers.StartsWith("//"))
        {
            int delimiterIndex = numbers.IndexOf('\n');
            string customDelimiter = numbers.Substring(2, delimiterIndex - 2);
            delimiters = new string[] { customDelimiter };
            numbers = numbers.Substring(delimiterIndex + 1);
        }
        string[] numberStrings = numbers.Split(delimiters, StringSplitOptions.None);
        return getNumberList(numberStrings);
    }

}
