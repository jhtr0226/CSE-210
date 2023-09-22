using System;

class Program
{
    static void Main(string[] args)
    {
        // string(variable) while
        // string(variable) do {} while;

        // for (The standard for loop in C# is more like a "for x in 
        //range" loop in Python.) for (int i = 0 <10; i++)

        // foreach (similar for loop in python) 
        //(foreach (string color in colors))

        // Random randomGenerator = new Random(); 
        //int number = randomGenerator.Next(1,11);

        string play = "yes";

        while (play != "no")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 100);

            Console.Write("What is the magic number? ");
            string guess = Console.ReadLine();
            int guessed = int.Parse(guess);


            int counter = 1;

            while (guessed != number)
            {
                if (guessed > number)
                {
                    Console.WriteLine("Lower");
                    counter += 1;
                }
                else if (guessed < number)
                {
                    Console.WriteLine("Higher");
                    counter += 1;
                }

                Console.Write("Try again!\nWhat is the magic number: ");
                guess = Console.ReadLine();
                guessed = int.Parse(guess);
            }

            if (guessed == number)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"It took you {counter} attempt to guess the secret number");
                }
                else
                {
                    Console.WriteLine($"It took you {counter} attempts to guess the secret number");
                }
            }

            Console.Write("Would you like to play again? (yes/no) ");
            string question = Console.ReadLine();

            if (question == "yes")
            {
                play = "yes";
            }
            else if (question == "no")
            {
                Console.WriteLine("Until the next time!");
                play = "no";
            }

        }












    }

}

































