using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Janitor";
        job1._endYear = 2025;
        job1._startYear = 2020;
        Job job2 = new Job();
        job2._company = "Lockheed";
        job2._jobTitle = "Plane Designer";
        job2._endYear = 2030;
        job2._startYear = 2025;
        Resume res = new Resume();
        res._name = "Cooper Bench";
        res._jobs.Add(job1);
        res._jobs.Add(job2);
        res.DisplayResume();


        
    }
}