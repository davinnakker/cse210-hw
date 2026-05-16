using System.Security.Cryptography;

public class PromptGenerator
{
    public static string GetPrompt()
    {
        List<string> prompts = ["Think of a time when you stood up for someone else.",
                                "Think of a time when you did something really difficult.",
                                "Think of a time when you helped someone in need.",
                                "Think of a time when you did something truly selfless."];

        int len = prompts.Count;
        Random numGen = new Random();
        int ranNum = numGen.Next(1, len);

        return prompts[ranNum];
    }

    public static string GetQuestion()
    {
        List<string> questions = ["Why was this experience meaningful to you?",
                                    "Have you ever done anything like this before?",
                                    "How did you get started?",
                                    "How did you feel when it was complete?",
                                    "What made this time different than other times when you were not as successful?",
                                    "What is your favorite thing about this experience?",
                                    "What could you learn from this experience that applies to other situations?",
                                    "What did you learn about yourself through this experience?",
                                    "How can you keep this experience in mind in the future?"];
        int len = questions.Count;
        Random numGen = new Random();
        int ranNum = numGen.Next(1, len);
        return questions[ranNum];
    }

    public static string GetListPrompt()
    {
        List<string> prompts = ["Who are people that you appreciate?",
                                "What are personal strengths of yours?",
                                "Who are people that you have helped this week?",
                                "When have you felt the Holy Ghost this month?",
                                "Who are some of your personal heroes?"];

        int len = prompts.Count;
        Random numGen = new Random();
        int ranNum = numGen.Next(1, len);

        return prompts[ranNum];
    }
}

