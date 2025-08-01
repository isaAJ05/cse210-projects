using System;

public class Assignment
{
    prot string _studentName;
    private string _topic;

    public Assignment()
    {
        
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}