using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {

    }
    public WritingAssignment(string studentName, string topic, string )
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
        }
    }