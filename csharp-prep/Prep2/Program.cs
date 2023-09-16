using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        // ///////////////////////IF block/////////////////////////
        string letter = "";

        if (number >= 90)
        {
            if (number >= 93)
                letter = "A";
            else
            {
                letter = "A-";
            }
        }


        else if (number >= 80)
        {
            if (number >= 87 && number <= 89)
            {
                letter = "B+";
            }
            else if (number >= 83 && number <= 86)
            {
                letter = "B";
            }
            else if (number >= 80 && number <= 82)
            {
                letter = "B-";
            }

        }


        else if (number >= 70)
        {
            if (number >= 77 && number <= 79)
            {
                letter = "C+";
            }
            else if (number >= 73 && number <= 76)
            {
                letter = "C";
            }
            else if (number >= 70 && number <= 72)
            {
                letter = "C-";
            }

        }
        else if (number >= 60)
        {
            if (number >= 67 && number <= 69)
            {
                letter = "D+";
            }
            else if (number >= 65 && number <= 66)
            {
                letter = "D";
            }
            else if (number >= 60 && number <= 64)
            {
                letter = "D-";
            }
        }
        else if (number < 60)
        {
            letter = "F";
        }
        // //////////////////////Adding an "n"///////////////////////////

        if (letter == "A" || letter == "A-")
        {
            Console.WriteLine($"Awesome!\nYour final grade is an {letter}");
        }
        else
        {
            Console.WriteLine($"Your final grade is a {letter}");
        }
        // ////////////////////////////Final message////////////////////////

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed!\nRemember always to give your best!");
        }
        else
        {
            Console.WriteLine("Sorry! You better study next time!\nAnd remember to believe in yourself!");
        }
















    }
}