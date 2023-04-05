//You are given the following string "The whole group of G2 loves C#.They find learning this language fun and easy!". Print the text after the ".", using string methods.
string sentance = "The whole group of G2 loves C#.They find learning this language fun and easy!";
string[] splited = sentance.Split('.');
Console.WriteLine(splited[1]);


