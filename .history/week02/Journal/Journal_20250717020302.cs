using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _jobs)
        {
            j.DisplayJobDetails();
        }
    }
    public void SaveToFile()
    {

    }
    public void LoadFromFile()
    {

    }
}