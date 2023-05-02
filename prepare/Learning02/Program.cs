using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");


        Job job1 = new Job();

        job1._company = "HostGator";
        job1._jobTitle = "Web Advisor";
        job1._startYear = 2017;
        job1._endYear = 2018;

        //job1.Display();

        Job job2 = new Job();
        job2._company = "Verizon Wireless";
        job2._jobTitle = "Tech Support";
        job2._startYear = 2022;
        job2._endYear = 2025;

        //job2.Display();

        Resume resumeOne = new Resume();
        resumeOne._name = "Joshua Smith";

        resumeOne._jobs.Add(job1);
        resumeOne._jobs.Add(job2);

        resumeOne.DisplayJobs();
    }
}