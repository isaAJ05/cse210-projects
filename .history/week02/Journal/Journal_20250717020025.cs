using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile()
    {

    }
    public void LoadFromFile()
    {

    }
}