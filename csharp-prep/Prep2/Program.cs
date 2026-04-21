using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradeAsString = Console.ReadLine();
        int grade = int.Parse(gradeAsString);

        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is an {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you failed.");
        }
    }
}