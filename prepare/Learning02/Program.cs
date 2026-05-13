using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Mircosoft";
        job1._startYear = 2024;
        job1._endYear = 2026;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Market Analyst";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2025;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Michael";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResumeDetails();
    }
}