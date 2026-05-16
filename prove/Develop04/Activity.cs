using System.Runtime.CompilerServices;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public void SetName(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void Pause(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write("|");
            Thread.Sleep(170);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(170);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(170);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(170);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i > -1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Pause(5);
    }

    public void EndActivity()
    {
        Console.WriteLine("Well Done!!!");
        Pause(5);
        Console.WriteLine($"Congratulations! You have completed {_duration} seconds of the {_activityName}.");
        Pause(5);
        Console.Clear();
    }
}