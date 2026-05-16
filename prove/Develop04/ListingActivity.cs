using System.Net;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        string name = "Listing Activity";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        SetName(name, description);
    }

    public void Listing()
    {
        string prompt = PromptGenerator.GetListPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"---  {prompt}  ---");
        Console.Write("You may begin in: ");
        CountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}