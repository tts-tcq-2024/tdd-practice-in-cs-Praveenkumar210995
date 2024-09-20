
using System.Linq;

public class StringCalculator
{
    public int Add(string input)
    {
        if (checkNullString(input))
            return 0;

        var numberList = inputDecoder(input);
        var negativeNumbers = checkNegativeNumber(numberList);

        if (negativeNumbers.Count > 0)
            throw new Exception($"Negatives not allowed: { string.Join(", ", negativeNumbers) }");

        return numberList.Sum();
    }

    private static bool checkNullString(string input)
    { return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input); }

    private static List<int> checkNegativeNumber(List<int> numberList) 
    {
        var negativeNumbers = new List<int>();

        foreach (var number in numberList)
        {
            if (number < 0)
            {
                negativeNumbers.Add(number);
            }
        }
        return negativeNumbers;
    }


    private static List<int> getNumberList(string[] numberStrings)
    {
        var numberList = new List<int>();
        foreach (var numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                if (number <= 1000)
                {
                    numberList.Add(number);
                }
            }
        }
        return numberList;
    }
}
