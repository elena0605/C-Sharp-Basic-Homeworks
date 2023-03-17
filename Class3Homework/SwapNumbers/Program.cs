//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:
//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.WriteLine("Input the First Number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the Second Number: ");
int secondNumber = int.Parse(Console.ReadLine());
int helperVariable;
if (firstNumber == secondNumber)
{
    return;
} else
{
    helperVariable = firstNumber;
    firstNumber = secondNumber;
    secondNumber = helperVariable;
}
Console.WriteLine("After Swapping: ");
Console.WriteLine($"First Number: { firstNumber}");
Console.WriteLine($"Second Number: {secondNumber}");
