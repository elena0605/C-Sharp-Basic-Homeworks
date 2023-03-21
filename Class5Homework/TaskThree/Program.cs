//Create a function that takes a number as input. This method should return the sum of the digits in the number.

int SumOfDigits(int number)
{
    int sum = 0;
    string convertedNumberToString = number.ToString();
    if (convertedNumberToString.Length == 1)
    {
        int parsedStringToNumber = int.Parse(convertedNumberToString);
        sum = parsedStringToNumber;
        return sum;

    }
    else
    {
        char[] charsArrayOfStringDigits = convertedNumberToString.ToCharArray();
        foreach (char c in charsArrayOfStringDigits)
        {
            int parsedCharToNumberDigit = int.Parse(c.ToString());
            sum += parsedCharToNumberDigit;
        }
        return sum;
    }

}
Console.WriteLine("Enter a number: ");
int inputNumber = int.Parse(Console.ReadLine());
int result = SumOfDigits(inputNumber);
Console.WriteLine($"The sum of the digits in the input number is: {result}");

