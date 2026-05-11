using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("davin", "programming");
        a1.GetSummary();

        MathAssignment a2 = new MathAssignment("Davin", "calc", "3.7", "3-5");
        a2.GetSummary();
        a2.GetHomeworkList();

        WritingAssignment a3 = new WritingAssignment("Lidia", "english", "The Book of Mormon");
        a3.GetSummary();
        a3.GetWritingInformation();
    }

}