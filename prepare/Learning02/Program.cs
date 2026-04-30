using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hey world");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._yearStart = 2019;
        job1._yearEnd = 2022;
        Console.WriteLine($"{job1._jobTitle}");

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._yearStart = 2012;
        job2._yearEnd = 2024;
        Console.WriteLine($"{job2._jobTitle}");

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Davin";
        resume1._jobs = [job1, job2];
        resume1.Display();

    }
}