
//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.WriteLine("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the calculation operator:");
bool ifParsingSucceeded = char.TryParse(Console.ReadLine(), out char calcOperator);

if (ifParsingSucceeded)
{
    double result;
    switch (calcOperator) {

        case '+':
            result = firstNumber + secondNumber; 
            Console.WriteLine($"The result of the Sum operation is {result}");
            break;
        case '-':
            result = firstNumber - secondNumber;
            Console.WriteLine($"The result of the Subtraction operation is {result}");
            break;
        case '*':
            result = firstNumber * secondNumber;
            Console.WriteLine($"The result of the Multiplication operation is {result}");
            break;  
        case '/':
            result = firstNumber / secondNumber;
            Console.WriteLine($"The result of the Division operation is {result} ");
            break;
        default:
            Console.WriteLine("You have entered wrong operator");
            break;
             
    }

}


