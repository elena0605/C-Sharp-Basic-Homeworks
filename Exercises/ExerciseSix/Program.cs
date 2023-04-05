//Create a class Human
//Add properties: FirstName, LastName, Age
//Create a method called GetPersonDetails that returns the full name of the human as well as their age
//Create an object human by asking the user to fill the required information (take first name, last name and age from user input)
//Call the GetPersonDetails method and print the result in the console after the object is created

using ExerciseSix;

Console.WriteLine("Enter your First Name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter yor Last Name: ");
string lastName = Console.ReadLine();
Console.WriteLine("Enter your age: ");
string age  = Console.ReadLine();

 Human inputPerson = new Human()
{
    FirstName = firstName,
    LastName = lastName,
    Age = age
};
inputPerson.GetPersonDetails();
