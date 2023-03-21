//Take one string from the input and print its last 5 characters.

Console.WriteLine("Write a string: ");
string inputString = Console.ReadLine();
Console.WriteLine(inputString.Substring(inputString.Length - 5));