
//Create a method called NumberStats that accepts a number. This method should:
//Find out if the number is negative or positive
//Find out if the number is odd or even
//Find out if the number is decimal or integer
//After finding all the stats it should print them like this:
//Stats for number: 25
//Positive
//Integer
//Odd
//The number should be entered in the console by the user.
//Bonus: Validate if the user is entering a number
//Bonus: Ask the user to press Y to try again or X to exit



void NumberStats  (double number) {
    Console.WriteLine($"Stats for number: {number}");

    if (number > 0 )
    {
        Console.WriteLine("Positive");
    }  
    else Console.WriteLine("Negative");

    if(number % 1 != 0) 
    {
        Console.WriteLine("Decimal");
    }
    else
    {
        Console.WriteLine("Integer");
    }

    if (number % 2 == 0) 
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }

}

Console.WriteLine("Enter a number: ");
bool isNumber = double.TryParse(Console.ReadLine(), out double number);

if (!isNumber)
{
    Console.WriteLine("Please enter a valid number:");
}

NumberStats(number);
Console.WriteLine("Press Y to try again or X to exit:");
while ((Console.ReadLine().ToUpper() == "Y"))
{
    Console.WriteLine("Enter another number: ");
    bool anotherNumber = double.TryParse(Console.ReadLine(), out double num);
    if (!anotherNumber)
    {
        Console.WriteLine("Please enter a valid number:");
    }
    NumberStats(num);
    Console.WriteLine("Press Y to try again or X to exit:");
}



//bool UserInterface()
//{
//    Console.Write("Enter a number:");
//    double number;
//    bool isNumber = double.TryParse(Console.ReadLine(), out number);
//    if (!isNumber)
//    {
//        Console.WriteLine("That was not a number! Please try again!");
//        return false;
//    }
//    NumberStats(number);
//    Console.Write("Press any key to try again or X to exit.");
//    if (Console.ReadLine().ToUpper() == "X") return true;
//    return false;
//}


//while (!UserInterface());
//Console.ReadLine();






