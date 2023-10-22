using System;
using System.IO;
using System.Data;
using System.Runtime.InteropServices.Marshalling; //i don't know what this is and I didn't put it there, maybe it was automatic from one of the deleted lines?

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        List<int> alreadyHidden = new List<int>();



        string[] lines = File.ReadAllLines("Books.txt");//reader
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string book = parts[0];
            string reference = parts[1];
            string text = parts[2];

            //getting chapter,verses from the reference
            string[] referenceParts = reference.Split(':');
            int chapter = int.Parse(referenceParts[0]);

            string[] verseParts = referenceParts[1].Split('-');
            int verseStart = int.Parse(verseParts[0]);
            int verseEnd = verseParts.Length > 1 ? int.Parse(verseParts[1]) : verseStart;

            //I learned that ? is like a condition (quick if) for a line, comes along with : for else lol

            List<string> verseWords = new List<string>(text.Split(' '));//separates the words
            List<Word> words = verseWords.Select(wordText => new Word(wordText)).ToList(); // Creates list of words
            Reference referenceObj = new Reference(book, chapter, verseStart, verseEnd);
            Scripture scripture = new Scripture(referenceObj, words);
            //new scripture object

            scriptures.Add(scripture); //adds scripture to the list of scriptures
        }

        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(0, scriptures.Count)];

        while (!currentScripture.AllWordsHidden()) //loops until words get to be all hidden
        {
            Console.Clear();
            Console.WriteLine(currentScripture.getRenderedText());
            Console.Write("\nPress enter to continue or type quit to finish:\n");
            string importantChoice = Console.ReadLine();

            if (importantChoice == "")
            {
                currentScripture.hiding(alreadyHidden); //calls to hide words form the selected scripture

                if (currentScripture.AllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(currentScripture.getRenderedText());
                    /*fun fact, the last 2 lines of code took me around 4 hours to put them here
                    I kept reaching the end without getting everything hidden, I thought the problems was in 
                    the hiding method but it was this break from below*/
                    break;
                }
            }
            else if (importantChoice.ToLower() == "quit")
            {
                break;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Until next time!");
    }
}
