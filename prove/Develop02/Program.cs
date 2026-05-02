using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App!");

        string main_menu = """
        -----------------------------------------------
        Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5.Quit
        -----------------------------------------------

        """;
        
        Journal journal = new Journal();
        int selection = 0;

        while (selection != 5)
        {
            Console.WriteLine(main_menu);
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                journal.WriteEntry();
            }
            else if (selection == 2)
            {
                journal.DisplayEntries();       
            }
            else if (selection == 3)
            {
                journal.LoadEntries();
            }
            else if (selection == 4)
            {
                journal.SaveEntries();
            }
            else if (selection == 5)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
        Console.WriteLine("Thanks for using our app!");
    }
}