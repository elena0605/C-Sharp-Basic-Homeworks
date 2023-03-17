//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko


using System.ComponentModel.Design;

string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] {"Mirko", "Slavko", "Denko","Marko", "Zivko"};

Console.WriteLine("Enter student group: (there are 1 and 2)");  
int numberOfGroup = int.Parse(Console.ReadLine());

if (numberOfGroup == 1)
{
    Console.WriteLine("The students in G1 are: ");

    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);


    }
}else if (numberOfGroup == 2)
{
    Console.WriteLine("The students in G2 are: ");

    foreach(string student in studentsG2)
    {
        Console.WriteLine(student); 
    }
}