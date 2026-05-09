public class Reference
{
    private string _response;
    private Verse _verse;

    public Reference(string citation, string text)
    {
        _verse = new Verse(citation, text);
        Console.Clear();
    }

    public void StartApp()
    {
        

        while (_response != "quit")
        {
            Console.WriteLine("Welcome to the scripture App! Press Enter to hide words or type 'quit' to stop");
            Console.WriteLine();
            _verse.DisplayVerse();
            _response = Console.ReadLine();
            _verse.BlankWords();
            Console.Clear();
        }
        
    }
}