//Take a sentence as input and print its words.

Console.WriteLine("Write a sentance: ");
string inputSentence = Console.ReadLine();
string[] splittedString = inputSentence.Split(" ");
foreach (string s in splittedString)
{
    Console.WriteLine(s);
}

