using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {char.ToUpper(lastName[0])}{lastName.Substring(1)}, {char.ToUpper(name[0])}{name.Substring(1)} {char.ToUpper(lastName[0])}{lastName.Substring(1)}.");
    }
}


//goal
// bond james bond

//How i understood it
// Console.Write/read = everything {add line to pass make it print}
// then name the variable
// "string "name" = console.read"
// input = console.write