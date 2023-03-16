//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
double thirdNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the fourth number: ");
double fourthNumber = double.Parse(Console.ReadLine());
int numberOfInputCounts = 4;
double averageResult = (firstNumber + secondNumber + thirdNumber + fourthNumber)/numberOfInputCounts;
Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {averageResult}");