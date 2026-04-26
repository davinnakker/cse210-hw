using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static void PromptUserBirthYear(out int x)
        {
            Console.Write("What year were you born?: ");
            string ans = Console.ReadLine();
            x = int.Parse(ans);
        }

        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }

        static void DisplayResult(string userName, int numSquared, int birthYear)
        {   
            PromptUserBirthYear(out birthYear);
            Console.WriteLine($"{userName}, the square of our number is {numSquared}");
            Console.WriteLine($"{userName}, you will turn {2026 - birthYear} this year.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numSquared = SquareNumber(num);
        int x = 0;
        DisplayResult(name, numSquared, x);


    }
}