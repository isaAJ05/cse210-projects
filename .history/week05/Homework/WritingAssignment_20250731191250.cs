using System;

public class WritingAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public WritingAssignment() : base()
    {

    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
        }
    }