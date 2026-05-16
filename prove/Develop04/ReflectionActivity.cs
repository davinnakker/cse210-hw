using System.Net;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        string name = "Reflection Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        SetName(name, description);
    }

    public void Reflecting()
    {
        string prompt = PromptGenerator.GetPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"---  {prompt}  ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            string question = PromptGenerator.GetQuestion();
            Console.Write($"> {question} ");
            Pause(10);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}