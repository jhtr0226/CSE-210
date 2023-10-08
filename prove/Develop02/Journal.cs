using System;
using System.IO;
using System.Collections.Generic;



public class Journal
{
    public string _filename;
    public string _deletingNumber;

    List<string> days = new List<string>();

    public void addingEntries(string entry)
    {
        days.Add(entry);
    }

    public void displayingJournal()
    {
        for (int numbersToDisplay = 0; numbersToDisplay < days.Count; numbersToDisplay++)
        {
            string[] partes = days[numbersToDisplay].Split("|");

            string inputDate = partes[0].Trim();
            string inputPrompt = partes[1].Trim();
            string inputAnswer = partes[2].Trim();

            string displayer = $"Entry #{numbersToDisplay + 1}.\nDate: {inputDate} - Prompt: {inputPrompt}\n{inputAnswer}\n";
            Console.WriteLine(displayer);
        }
    }

    public void saving()
    {

        using (StreamWriter outputFile = new StreamWriter(_filename, true))
        {
            foreach (string newEntry in days)
            {
                outputFile.WriteLine(newEntry);
            }
        }
    }
    public void loading()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        days.Clear();

        foreach (string line in lines)
        {
            days.Add(line);
        }

    }

    public void deleting()
    {
        int ripEntry = int.Parse(_deletingNumber);

        if (ripEntry >= 1 && ripEntry <= days.Count)
        {
            days.RemoveAt(ripEntry - 1);
            Console.WriteLine($"\nDELETING entry #{ripEntry}.... 50%\nDELETING entry #{ripEntry}.... 99%\nEntry #{ripEntry} deleted successfully!");

        }
        else
        {
            Console.WriteLine("\nWow! It looks like this number does not exist yet! No memories were deleted!");
        }

    }
}