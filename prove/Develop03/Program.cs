using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the following for the verse(s) you would like to memorize.");
        Console.WriteLine("Citation: ");
        string citation = Console.ReadLine();
        Console.WriteLine("Text of verse or verses: ");
        string text = Console.ReadLine();

        Reference reference = new Reference(citation, text);
        reference.StartApp();
    }
}