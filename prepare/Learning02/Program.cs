using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobCompany = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._jobStartYear = 2023;
        job1._jobEndYear = 2024;

        Job job2 = new Job();
        job2._jobCompany = "Microsoft";
        job2._jobTitle = "Manager";
        job2._jobStartYear = 2023;
        job2._jobEndYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Marlon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}