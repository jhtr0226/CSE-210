using System;

class Program
{
    static void Main(string[] args)
    {
        // first job and we add its information
        Job job1 = new Job();
        /*Console.Write("company name? ");
        job1._jobTitle = Console.ReadLine();*/
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsfot";
        job1._startingYear = 2019;
        job1._endingYear = 2022;


        //second job

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startingYear = 2022;
        job2._endingYear = 2023;


        // we build the resume
        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); //our final "print" statement 

    }

}
