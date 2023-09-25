using System;
using System.Data.SqlTypes;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        // (int/string/void(nothing)) TheTitle ((int/string) parameters, parameters)
        //{
        //body 
        //return
        //}

        //C#
        //void DisplayMessage()
        //{
        //   Console.WriteLine("Hello world!");
        //}
        //Python
        //def display_message():
        //print("Hello World")


        //Use  STATIC for all of your functions until we start writing classes.



        DisplayWelcome();
        string getName = PromptUserName();
        int getNumber = PromptUserNumber();
        int getSquaredNumber = SquareNumber(getNumber);
        DisplayResult(getName, getSquaredNumber);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string capitalizedName = textInfo.ToTitleCase(name);
        return capitalizedName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string FavNumber = Console.ReadLine();
        int number = int.Parse(FavNumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string capitalizedName, int getSquaredNumber)
    {
        Console.WriteLine($"{capitalizedName}, the square of your number is: {getSquaredNumber}.");
    }

}