using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {

    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
        }
    }