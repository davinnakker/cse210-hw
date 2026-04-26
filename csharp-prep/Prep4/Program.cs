using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string response = "-4";
        List<int> numbers= new List<int>();

        while (response != "0")
        {
            Console.Write("Enter a number: ");
            response = Console.ReadLine();
            numbers.Add(int.Parse(response));
        }

        int sum = 0;
        int lowest = 1000000000;
        int highest = -100000000;

        foreach (int num in numbers)
        {
            if (num > highest)
            {
                highest = num;
            }
            if (num < lowest)
            {
                lowest = num;
            }
            sum = sum + num;
        }
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum * 1.0/ numbers.Count * 1.0}");
        Console.WriteLine($"The largest number is {highest}");

    }
    
}   