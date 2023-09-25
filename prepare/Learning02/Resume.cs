using System;
using System.Collections.Generic;
public class Resume
{
    public string _personName;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}"); // outputs the name
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.Display(); //we are dislaying our layout coded in job.cs
        }
    }


}