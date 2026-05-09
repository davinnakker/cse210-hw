using System.Security.Authentication.ExtendedProtection;

public class Word
{
    private string _word;
    private string _blank;
    private bool _isBlank = false;

    public Word(string word)
    {
        int len = word.Length;
        _word = word;
        _blank = "_";
        for (int i = 0; i < len; i++)
        {
            _blank = _blank + "_";
        }
    }

    public void MakeBlank()
    {
        _isBlank = true;
    }

    public void DisplayWord()
    {
        if (_isBlank == true)
        {
            Console.Write($"{_blank }");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }
}