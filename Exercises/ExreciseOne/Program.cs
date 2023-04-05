//Create a class Student that has properties: Name, Academy
//and Group
//● Create an array with 5 new Students(objects)
//● The user should enter a name and the user information
//should be displayed in the console if a user by that name
//exists
//● If there is no such user it should show an error message

using Exercises;



Student [] students = new Student[5];

for (int i = 0; i < students.Length; i++)
{
    students[i] = new Student();
}

foreach (Student student in students)
{
    Console.WriteLine("Enter student Name: ");
    student.Name = Console.ReadLine();
}



foreach (Student student in students)
{
    Console.WriteLine("Enter student Academy: ");
    student.Academy = Console.ReadLine();
}

foreach (Student student in students)
{
    Console.WriteLine("Enter student Group");
    student.Group = Console.ReadLine();


}
Console.WriteLine("Enter a student name: ");
string  inputName  = Console.ReadLine();

 foreach (Student student in students) {
    if (student.Name != inputName )
    {
        Console.WriteLine("you have entered wrong name, please try again");
        return;
    }else
    {
        Console.WriteLine($"There is a student with a name {student.Name} who is listening classes at a {student.Academy} in a {student.Group} group");
    }
    
}