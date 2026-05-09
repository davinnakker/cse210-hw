using System.ComponentModel;

public class Verse
{
    private string _citation;
    private string _textFull;
    private List<Word> _words;

    public Verse(string citation, string text)
    {
        _citation = citation;
        _textFull = text;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void BlankWords()
    {
        int verseLength = _words.Count;
        Random numGen = new Random();
        for (int i = 0; i <= 6; i++)
        {
            int id = numGen.Next(0, verseLength);
            _words[id].MakeBlank();
        }
    }

    public void DisplayVerse()
    {
        Console.Write($"{_citation}: ");

        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
        Console.WriteLine();
    }
}