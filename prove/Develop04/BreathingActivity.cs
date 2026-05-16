using System.Net;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        string name = "Breathing Activity";
        string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        SetName(name, description);
    }

    public void Breathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breath In...");
            CountDown(4);
            Console.WriteLine();
            Console.Write("Breath Out...");
            CountDown(7);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}