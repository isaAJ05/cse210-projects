using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        
    }
}