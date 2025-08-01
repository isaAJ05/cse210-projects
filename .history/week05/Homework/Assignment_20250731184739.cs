using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        
    }
    public string GetSummary()
    {
        return $"{studentName} {topic}";
    }


}