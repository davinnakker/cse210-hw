using System;
using System.IO;

public class FileManager
{
    public string _name;

    public void GetName()
    {
        Console.WriteLine("Choose your file name: ");
        string name = Console.ReadLine();
        _name = name + ".txt";
    }

    public void SaveEntries(List<Entry> entries)
    {
        GetName();
        
        using (StreamWriter outputFile = new StreamWriter(_name))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._text}");
            }
        }
        Console.WriteLine($"{_name} has been successfully saved!");
    }

    public List<Entry> LoadEntries()
    {
        GetName();

        string[] lines = System.IO.File.ReadAllLines(_name);

        List<Entry> entries = [];
        foreach (string line in lines)
        {
            string[] items = line.Split("~~");
            Entry entry = new Entry();
            entry._date = items[0];
            entry._prompt = items[1];
            entry._text = items[2];

            entries.Add(entry);
        }
        Console.WriteLine($"{_name} has been successfully loaded!");

        return entries;
    }
}