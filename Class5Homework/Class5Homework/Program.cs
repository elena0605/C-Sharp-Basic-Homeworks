//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today




double AgeCalculator (string birthdayDate)
{
    DateTime currentDateTime = DateTime.Today;
    DateTime convertedBirthdayDate = DateTime.Parse(birthdayDate);
    var difference = currentDateTime - convertedBirthdayDate; 
    var diffInDays = difference.TotalDays;
    var age = diffInDays / 365;
    return age; 
}

string birthdayStringDate = "21-10-1909";
double age = AgeCalculator(birthdayStringDate);
Console.WriteLine($" You are {Math.Truncate(age)} years old");


