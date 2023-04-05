
//Create an ATM application. A customer should be able to authenticate with card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:
//Balance checking - This should print out the current balance of money on their account
//Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal
//Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.
//In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.
//Example
//Welcome to the ATM app
//Please enter your card numer:
//> 1234 - 1234 - 1234 - 1234
//Enter Pin:
//> 4325
//Welcome Bob Bobsky!
//What would you like to do:
//Check Balance
//Cash Withdrawal
//Cash Deposit
//> 2
//You withdrew 250$. You have 400$ left on your account.
//Thank you for using the ATM app.
//Bonus: The balance and pin should not be public
//Bonus: The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.
//Bonus: When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action. If not it should print a goodbye message and show up the login menu again.
//Bonus: Add an option to register a new card in the system that store the customer in the system if the card number is not used for any other customer

using Exercise_Five;

bool ChooseOption(Customer customer)
{
    Console.WriteLine("Please choose one of the following:");
    Console.WriteLine("1) Check Balance");
    Console.WriteLine("2) Cash Withdrawal");
    Console.WriteLine("3) Cash Deposit");
    Console.WriteLine("4) Exit");

    bool isChoiceNumber = int.TryParse(Console.ReadLine(), out int choice);
    if (!isChoiceNumber || choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid input!");
        return false;
    }

    switch (choice)
    {
        case 1:
            customer.Card.CheckBalance();
            break;
        case 2:

            Console.WriteLine("How much would you like to withdraw?");
            bool isAmmountWNumber = int.TryParse(Console.ReadLine(), out int ammountW);

            if (!isAmmountWNumber)
            {
                Console.WriteLine("Input was not correct. The ballance was not changed.");
                break;
            }

            customer.Card.Withdraw(ammountW);
            break;
        case 3:
            Console.WriteLine("Enter ammount of deposit:");
            bool isAmmountDNumber = int.TryParse(Console.ReadLine(), out int ammountD);

            if (!isAmmountDNumber)
            {
                Console.WriteLine("Input was not correct. The ballance was not changed.");
                break;
            }

            customer.Card.Deposit(ammountD);
            break;
        case 4:

            return true;
        default:
            Console.WriteLine("The number should be one of the options. Please try again.");
            return false;
    }

    Console.WriteLine("Enter anything for another action or X to exit... ");

    if (Console.ReadLine().ToUpper() != "X") return false;
    return true;
}


Customer FindCustomer(Customer[] customers, long cardNumber)
{
    foreach (Customer customer in customers)
    {
        if (customer.Card.CardNumber == cardNumber) return customer;
    }

    return null;
}


long FormatCardNumber(string stringNumber)
{
    string[] numbers = stringNumber.Split('-');
    if (numbers.Length != 4) return -1;

    bool isNumber = long.TryParse(numbers[0] + numbers[1] + numbers[2] + numbers[3], out long number);
    if (!isNumber) return -1;
    
    return number;
}


bool InitATM(Customer[] customers)
{
    Console.WriteLine("Welcome to the ATM App");
    Console.WriteLine("Please enter your card number (xxxx-xxxx-xxxx-xxxx)");
    long cardNumber = FormatCardNumber(Console.ReadLine());

    if (cardNumber == -1)
    {
        Console.WriteLine("Your card number is incorrect. Enter anything to try again.");
        Console.ReadLine();
        return false;
    }

    Customer customer = FindCustomer(customers, cardNumber);

    if (customer == null)
    {
        Console.WriteLine("That customer does not exist. Enter anything to try again.");
        Console.ReadLine();
        return false;
    }

    Console.WriteLine("Please enter your PIN:");
    short pin = 0;
    bool isPinNumber = short.TryParse(Console.ReadLine(), out pin);

    if (!isPinNumber)
    {
        Console.WriteLine("Pin must be a number. Enter anything to try again.");
        Console.ReadLine();
        return false;
    }

    if (!customer.Card.CheckPin(pin))
    {
        Console.WriteLine("The pin was not correct. Enter anything to try again.");
        Console.ReadLine();
        return false;
    }

    Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");
    while (!ChooseOption(customer)) Console.Clear();
    Console.WriteLine("Enter X to exit the application or anything to login as another user.");

    if (Console.ReadLine().ToUpper() == "X")
    {
        return true;
    }
    return false;
}


Customer[] customers = new Customer[]
{
    new Customer("Bob","Bobsky", 750),
    new Customer("Jill","Wayne", 1200),
    new Customer("Rayan","Dawn", 500),
    new Customer("Anne","May", 400)
};

foreach (Customer customer in customers)
{
    customer.GetInfo();
}

while (!InitATM(customers)) Console.Clear();

Console.WriteLine("Have a nice day!");