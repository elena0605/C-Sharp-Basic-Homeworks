﻿using ExerciseFour;

//Create a class User with the following:
//Id - int
//Username - string
//Password - string
//Messages - Array of strings Create an array of users and add 3 users to it manually ( hard-coded ).
//Create a Console UI that will ask the user:

//Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message
//Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4**


User[] users = new User[]
{
    new User(){Id = 56734, Password = "paswword", UserName = "Bob", Messages = new string[] { "Hey Bob, thanks for being a great customer! ", "To say thanks, here's a coupon for 15% off your next order" } },
    new User() {Id = 6746734, Password = "689468946", UserName = "Elena", Messages = new string[] { "Happy birthday Elena!", "Elena, don’t forget, you’re registered for G2 today at 5pm." } },
    new User() {Id = 8467845, Password = "djhdghdj", UserName = "Mile", Messages = new string[]{ "Thank you Mile for scheduling a consultation", "Your Reservation at our place is Confirmed" } },
};


void LogIn(User[] users, string username, string password )
{

}

void Register(User[] users, string username, string password, int id)
{

}


Console.WriteLine("Choose one option: \n 1.Log In \n 2.Register");
bool isNumber = int.TryParse(Console.ReadLine(), out int option);    
if(!isNumber || (option != 1 && option != 2))
{
    Console.WriteLine("You didn't enter a valid number. Try again. ");
} 
else if(option == 1)
{
    Console.WriteLine("Please enter your username:");
    string username = Console.ReadLine();
    Console.WriteLine("Please enter your password:");
    string password = Console.ReadLine();
    LogIn(users, username, password);
} 
else if (option == 2)
{
    Console.WriteLine("Please enter your username:");
    string username = Console.ReadLine();
    Console.WriteLine("Please enter your password:");
    string password = Console.ReadLine();
    Console.WriteLine("Please enter your Id:");
    int id = int.Parse(Console.ReadLine()); 
    Register(users, username, password, id);
}   



