//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:
//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14

int[] arrayOfIntegers = new int[6];
int intNumber;
int sum = 0;

for (int i = 0; i<arrayOfIntegers.Length; i++)
{
    Console.WriteLine($"Enter integer No.{i}: ");
     intNumber = int.Parse(Console.ReadLine());
    arrayOfIntegers[i] = intNumber; 
}
  foreach (int number in arrayOfIntegers)
{
    if(number % 2 == 0)
    {
        sum+= number;
        
    }
    
}
Console.WriteLine($"The result is: {sum}");