//In exercise 1 from the presentation add two more methods, Divide and Multiply. In the main method check for signs * and /. Make the calculator with switch. Additional: Check divide by zero

 int Sum (int num1, int num2 )
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num1 - num2;
}

int Multiply (int num1, int num2)
{
    return num1 * num2; 
}

int Divide (int num1, int num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("Division by zero is not possible!! Enter another number");


        return 0;
       
    }
    else
    {
        return num1 / num2;

    }
}
    int Calculator(char operations, int num1, int num2)
{ 
    int result = 0;
       
    switch(operations) { 

        case '+': 
            result = Sum(num1, num2); 
            break;
        case '-':
             result = Subtract(num1, num2);
            break;
            case '*':
            result = Multiply(num1, num2);
            break;
            case '/':
             result = Divide(num1, num2);
            break;
        default:
            Console.WriteLine("Please enter the correct operation!");
            break;
  
    }

    return result;  
       
  }

Console.WriteLine("Enter operations");
char op = char.Parse(Console.ReadLine());

Console.WriteLine("Enter num 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num 2");
int number2 = Convert.ToInt32(Console.ReadLine());


int Res = Calculator(op, number1, number2);
Console.WriteLine($"The result is: {Res}");