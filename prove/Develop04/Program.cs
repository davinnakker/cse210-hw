using System;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {   
        string response = "0";
        while (response != "4")
        {
            string menuMain = """
            Menu Options:
                1. Start breathing activity
                2. Start reflecting activity
                3. Start listing activity
                4. Quit
            Select a choice from the menu: 
            """;
            Console.WriteLine(menuMain);
            response = Console.ReadLine();

            if (response == "1")
            {
                BreathingActivity act1 = new BreathingActivity();
                act1.StartActivity();
                act1.Breathing();
                act1.EndActivity();
            }
            else if (response == "2")
            {
                ReflectionActivity act2 = new ReflectionActivity();
                act2.StartActivity();
                act2.Reflecting();
                act2.EndActivity();
            }
            else if (response == "3")
            {
                ListingActivity act3 = new ListingActivity();
                act3.StartActivity();
                act3.Listing();
                act3.EndActivity();
            }
            else if (response == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Give a valid option");
            }
        }
    }
}