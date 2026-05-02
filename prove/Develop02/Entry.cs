public class Entry
{
    public string _text;
    public string _date;
    public string _prompt;

    public void WriteEntry()
    {
        List<string> prompts = ["Who was the most interesting person I interacted with today?",
                                "What was the best part of my day?",
                                "How did I see the hand of the Lord in my life today?",
                                "What was the strongest emotion I felt today?",
                                "If I had one thing I could do over today, what would it be?"];
        
        Random randomGenerator = new Random();
        int numRandom = randomGenerator.Next(1, 5);
        _prompt = prompts[numRandom];
        Console.WriteLine(prompts[numRandom]);       // generate prompt

        _text = Console.ReadLine();                  // writing space

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();  // add date
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_text}");
    }
}