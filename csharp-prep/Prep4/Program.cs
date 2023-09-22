using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //.append (Python) == .add (C#)
        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)
        {
            Console.Write("Add a number to the list (0 to stop adding): ");
            string numero = Console.ReadLine();
            number = int.Parse(numero);
            //converting and verifying that is not 0, and if it is not, we add it
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int adding = 0;

        foreach (int bunchofnumbers in numbers)
        {
            adding += bunchofnumbers;
        }
        Console.WriteLine($"The sum is: {adding}");
        float average = ((float)adding) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int maxNumber = numbers.Max();
        Console.WriteLine($"The maximun number was {maxNumber}");
        int minNumber = numbers.Min();
        Console.WriteLine($"The minimun number was {minNumber}");

        int minPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        if (minPositive != int.MaxValue)
        {
            Console.WriteLine($"The smalles positive number is: {minPositive}");
        }




        numbers.Sort();

        Console.WriteLine("Sorted list is:");

        foreach (int moreNumbers in numbers)
        {
            Console.WriteLine(moreNumbers);
        }





















































    }
}