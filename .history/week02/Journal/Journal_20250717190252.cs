using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
        {
                outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
                outputFile.WriteLine($"{e._entryText}");
        }
        }

    }
    public void LoadFromFile(string file)
    {
        List <Entrystring[] lines = System.IO.File.ReadAllLines(file);
    }
}