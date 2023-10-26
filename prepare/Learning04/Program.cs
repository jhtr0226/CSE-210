using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel", "Multiplication");
        mathAssignment mathAssignment1 = new mathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        writingAssignment writingAssignment1 = new writingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(assignment1.getSummary());
        Console.WriteLine(mathAssignment1.getSummary());
        Console.WriteLine(mathAssignment1.getHomeWork());
        Console.WriteLine(writingAssignment1.getSummary());
        Console.WriteLine(writingAssignment1.getWritingInfo());
    }
}