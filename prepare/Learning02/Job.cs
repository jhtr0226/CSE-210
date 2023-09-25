using System;

public class Job //crearting the "structure of a job
{
    public string _jobTitle;
    public string _company;
    public int _startingYear;
    public int _endingYear;

    public void Display()
    {
        // we display how the jobs are going to look like
        Console.WriteLine($"{_jobTitle} ({_company}) {_startingYear}-{_endingYear}");
    }
}