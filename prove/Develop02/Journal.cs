using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = [];

    public void WriteEntry()
    {
        Entry newEntry = new Entry();
        newEntry.WriteEntry();
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveEntries()
    {
        FileManager manager = new FileManager();
        manager.SaveEntries(_entries);
    }

    public void LoadEntries()
    {
        FileManager manager = new FileManager();
        _entries = manager.LoadEntries();
    }
}